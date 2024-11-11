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
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();
            db.OpenConnection();

            string query = "INSERT INTO Usuarios (nombre, email, rol, contraseña) VALUES (@nombre, @correo, @rol, @contraseña)";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
            cmd.Parameters.AddWithValue("@rol", txtRol.Text);
            cmd.Parameters.AddWithValue("@contraseña", txtContraseña.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario agregado correctamente.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
            }

            db.CloseConnection();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();
            db.OpenConnection();

            string query = "UPDATE Usuarios SET nombre = @nombre, email = @correo, rol = @rol, contraseña = @contraseña WHERE id_usuario = @id";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
            cmd.Parameters.AddWithValue("@rol", txtRol.Text);
            cmd.Parameters.AddWithValue("@contraseña", txtContraseña.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado correctamente.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message);
            }

            db.CloseConnection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();
            db.OpenConnection();

            string query = "DELETE FROM Usuarios WHERE id_usuario = @id";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado correctamente.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }

            db.CloseConnection();

        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();
            db.OpenConnection();

            string query = "SELECT * FROM Usuarios";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            System.Data.DataTable table = new System.Data.DataTable();

            adapter.Fill(table);
            dgvUsuarios.DataSource = table;

            db.CloseConnection();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario actual y regresa al formulario principal
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
