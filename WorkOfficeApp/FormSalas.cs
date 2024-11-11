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
    public partial class FormSalas : Form
    {
        public FormSalas()
        {
            InitializeComponent();
        }

        private void CargarSalas()
        {
            DatabaseConnection conexion = new DatabaseConnection();
            using (var conn = conexion.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Salas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSalas.DataSource = dt;
            }
        }

        private void btnAgregarSala_Click(object sender, EventArgs e)
        {
            DatabaseConnection conexion = new DatabaseConnection();
            using (var conn = conexion.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Salas (disponibilidad, capacidad, ubicacion, distribucion, 
                         proyector, oasis, cafetera) VALUES (@disponibilidad, @capacidad, 
                         @ubicacion, @distribucion, @proyector, @oasis, @cafetera)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@disponibilidad", cmbDisponibilidad.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@capacidad", txtCapacidad.Text);
                cmd.Parameters.AddWithValue("@ubicacion", txtUbicacion.Text);
                cmd.Parameters.AddWithValue("@distribucion", txtDistribucion.Text);
                cmd.Parameters.AddWithValue("@proyector", chkProyector.Checked);
                cmd.Parameters.AddWithValue("@oasis", chkOasis.Checked);
                cmd.Parameters.AddWithValue("@cafetera", chkCafetera.Checked);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sala agregada correctamente.");
                CargarSalas();
            }
        }

        private void btnActualizarSala_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtIdSala.Text))
    {
                MessageBox.Show("Selecciona una sala para actualizar.");
                return;
            }

            DatabaseConnection conexion = new DatabaseConnection();
            using (var conn = conexion.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Salas SET disponibilidad = @disponibilidad, capacidad = @capacidad, 
                         ubicacion = @ubicacion, distribucion = @distribucion, proyector = @proyector, 
                         oasis = @oasis, cafetera = @cafetera WHERE id_sala = @id_sala";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_sala", txtIdSala.Text);
                cmd.Parameters.AddWithValue("@disponibilidad", cmbDisponibilidad.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@capacidad", txtCapacidad.Text);
                cmd.Parameters.AddWithValue("@ubicacion", txtUbicacion.Text);
                cmd.Parameters.AddWithValue("@distribucion", txtDistribucion.Text);
                cmd.Parameters.AddWithValue("@proyector", chkProyector.Checked);
                cmd.Parameters.AddWithValue("@oasis", chkOasis.Checked);
                cmd.Parameters.AddWithValue("@cafetera", chkCafetera.Checked);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sala actualizada correctamente.");
                CargarSalas();
            }
        }

        private void btnEliminarSala_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdSala.Text))
            {
                MessageBox.Show("Selecciona una sala para eliminar.");
                return;
            }

            DatabaseConnection conexion = new DatabaseConnection();
            using (var conn = conexion.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Salas WHERE id_sala = @id_sala";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_sala", txtIdSala.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sala eliminada correctamente.");
                CargarSalas();
            }
        }

        private void dgvSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSalas.Rows[e.RowIndex];
                txtIdSala.Text = row.Cells["id_sala"].Value.ToString();
                cmbDisponibilidad.SelectedItem = row.Cells["disponibilidad"].Value.ToString();
                txtCapacidad.Text = row.Cells["capacidad"].Value.ToString();
                txtUbicacion.Text = row.Cells["ubicacion"].Value.ToString();
                txtDistribucion.Text = row.Cells["distribucion"].Value.ToString();
                chkProyector.Checked = Convert.ToBoolean(row.Cells["proyector"].Value);
                chkOasis.Checked = Convert.ToBoolean(row.Cells["oasis"].Value);
                chkCafetera.Checked = Convert.ToBoolean(row.Cells["cafetera"].Value);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario actual y regresa al formulario principal
        }
    }
}
