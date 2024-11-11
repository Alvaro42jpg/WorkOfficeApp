using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace WorkOfficeApp
{
    class DatabaseConnection
    {
        private MySqlConnection connection;

        // Constructor: inicializa la conexión con la cadena de conexión
        public DatabaseConnection()
        {
            string connectionString = "Server=localhost;Database=workofficedb;Uid=root;Pwd=ElementorDio$;";
            connection = new MySqlConnection(connectionString);
        }

        // Método para abrir la conexión
        public void OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexión a MySQL abierta.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al conectar a MySQL: " + ex.Message);
            }
        }

        // Método para cerrar la conexión
        public void CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Conexión a MySQL cerrada.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cerrar la conexión a MySQL: " + ex.Message);
            }
        }

        // Método para obtener la conexión (útil para realizar consultas)
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
