using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WorkOfficeApp
{
    public partial class FormReservas : Form
    {
        public FormReservas()
        {
            InitializeComponent();
        }


        
        private void CargarSalas()
        {
            DatabaseConnection conexion = new DatabaseConnection();
            conexion = new DatabaseConnection();
            using (var conn = conexion.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_sala FROM Salas";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbIdSala.Items.Add(reader.GetInt32("id_sala"));
                }
            }
        }
        private const decimal precioMenu1 = 10.00m;
        private const decimal precioMenu2 = 12.00m;
        private const decimal precioMenu3 = 15.00m;
        private void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTotalMonto.Text))
            {
                MessageBox.Show("Por favor, calcule el total antes de guardar.");
                return;
            }

            int cantidadMenu1 = int.TryParse(txtCantidadMenu1.Text, out var result1) ? result1 : 0;
            int cantidadMenu2 = int.TryParse(txtCantidadMenu2.Text, out var result2) ? result2 : 0;
            int cantidadMenu3 = int.TryParse(txtCantidadMenu3.Text, out var result3) ? result3 : 0;

            decimal total = (cantidadMenu1 * precioMenu1) + (cantidadMenu2 * precioMenu2) + (cantidadMenu3 * precioMenu3);

            DatabaseConnection conexion = new DatabaseConnection();
            using (var conn = conexion.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Reservas (id_sala, horario, persona_reserva, menu1, menu2, menu3, total) 
                         VALUES (@idSala, @horario, @personaReserva, @menu1, @menu2, @menu3, @total)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idSala", cmbIdSala.SelectedValue);
                cmd.Parameters.AddWithValue("@horario", dtpHorario.Value);
                cmd.Parameters.AddWithValue("@personaReserva", txtNombreCliente.Text);
                cmd.Parameters.AddWithValue("@menu1", cantidadMenu1);
                cmd.Parameters.AddWithValue("@menu2", cantidadMenu2);
                cmd.Parameters.AddWithValue("@menu3", cantidadMenu3);
                cmd.Parameters.AddWithValue("@total", total);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Reserva guardada correctamente.");
            }
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            int cantidadMenu1 = int.TryParse(txtCantidadMenu1.Text, out var result1) ? result1 : 0;
            int cantidadMenu2 = int.TryParse(txtCantidadMenu2.Text, out var result2) ? result2 : 0;
            int cantidadMenu3 = int.TryParse(txtCantidadMenu3.Text, out var result3) ? result3 : 0;

            decimal total = (cantidadMenu1 * precioMenu1) + (cantidadMenu2 * precioMenu2) + (cantidadMenu3 * precioMenu3);

            lblTotalMonto.Text = $"${total:N2}";
        }

        private void btnMostrarReservas_Click(object sender, EventArgs e)
        {
            CargarReservas();  // Llama al método para cargar las reservas en el DataGridView
        }

        private void CargarReservas()
        {
            try
            {
                // Crear la conexión
                DatabaseConnection conexion = new DatabaseConnection();
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();

                    // Consulta para obtener los datos de las reservas
                    string query = "SELECT id_reserva, id_sala, horario, persona_reserva, menu1, menu2, menu3, total FROM Reservas";

                    // Ejecutar la consulta y llenar el DataGridView
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asignar el DataTable como fuente de datos del DataGridView
                    dgvReservas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las reservas: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario actual y regresa al formulario principal
        }
    }
}
