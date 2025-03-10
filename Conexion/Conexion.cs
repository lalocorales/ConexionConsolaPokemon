using System;
using Microsoft.Data.SqlClient; // Usa Microsoft.Data.SqlClient para .NET 8

namespace Conexion
{

    public class Conexion
    {
        private readonly string connectionString;

        // Constructor que inicializa la cadena de conexión
        public Conexion()
        {
            connectionString = "Server=CORRALES\\SQLEXPRESS;Database=Pokedex;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        }

        // Método para obtener la cadena de conexión
        public string GetConnectionString()
        {
            return connectionString;
        }

        // Método para probar la conexión a la base de datos
        public void ProbarConexion()
        {
            try
            {
                using var conexion = new SqlConnection(connectionString);
                conexion.Open();
                Console.WriteLine("✅ Conexión exitosa a SQL Server.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al conectar: {ex.Message}");
            }
        }
    }
}


