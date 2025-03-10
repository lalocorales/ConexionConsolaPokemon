using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{


    public class PokemonEntrenadorRepository : IPokemonEntrenadorRepository
    {
        private readonly string connectionString;

        public PokemonEntrenadorRepository(Conexion conexion)
        {
            connectionString = conexion.GetConnectionString();
        }

        public void Crear(PokemonEntrenador entrenador)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO PokemonEntrenadores (IdEntrenador, NombreEntrenador, Ciudad, Pokemon, Tipo, Nivel, Movimiento1, Movimiento2, Movimiento3, Movimiento4, LigaGanada) " +
                                   "VALUES (@IdEntrenador, @NombreEntrenador, @Ciudad, @Pokemon, @Tipo, @Nivel, @Movimiento1, @Movimiento2, @Movimiento3, @Movimiento4, @LigaGanada)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdEntrenador", entrenador.IdEntrenador);
                    cmd.Parameters.AddWithValue("@NombreEntrenador", entrenador.NombreEntrenador);
                    cmd.Parameters.AddWithValue("@Ciudad", entrenador.Ciudad);
                    cmd.Parameters.AddWithValue("@Pokemon", entrenador.Pokemon);
                    cmd.Parameters.AddWithValue("@Tipo", entrenador.Tipo);
                    cmd.Parameters.AddWithValue("@Nivel", entrenador.Nivel);
                    cmd.Parameters.AddWithValue("@Movimiento1", entrenador.Movimiento1);
                    cmd.Parameters.AddWithValue("@Movimiento2", entrenador.Movimiento2);
                    cmd.Parameters.AddWithValue("@Movimiento3", entrenador.Movimiento3);
                    cmd.Parameters.AddWithValue("@Movimiento4", entrenador.Movimiento4);
                    cmd.Parameters.AddWithValue("@LigaGanada", entrenador.LigaGanada);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("✅ Entrenador creado exitosamente.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        public List<PokemonEntrenador> Leer()
        {
            List<PokemonEntrenador> entrenadores = new List<PokemonEntrenador>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM PokemonEntrenadores";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        entrenadores.Add(new PokemonEntrenador
                        {
                            IdEntrenador = Convert.ToInt32(reader["IdEntrenador"]),
                            NombreEntrenador = reader["NombreEntrenador"].ToString(),
                            Ciudad = reader["Ciudad"].ToString(),
                            Pokemon = reader["Pokemon"].ToString(),
                            Tipo = reader["Tipo"].ToString(),
                            Nivel = Convert.ToInt32(reader["Nivel"]),
                            Movimiento1 = reader["Movimiento1"].ToString(),
                            Movimiento2 = reader["Movimiento2"].ToString(),
                            Movimiento3 = reader["Movimiento3"].ToString(),
                            Movimiento4 = reader["Movimiento4"].ToString(),
                            LigaGanada = reader["LigaGanada"].ToString()
                        });
                    }
                }
                return entrenadores;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Actualizar(PokemonEntrenador entrenador)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE PokemonEntrenadores SET NombreEntrenador = @NombreEntrenador, Ciudad = @Ciudad, Pokemon = @Pokemon, Tipo = @Tipo, Nivel = @Nivel, " +
                                   "Movimiento1 = @Movimiento1, Movimiento2 = @Movimiento2, Movimiento3 = @Movimiento3, Movimiento4 = @Movimiento4, LigaGanada = @LigaGanada " +
                                   "WHERE IdEntrenador = @IdEntrenador";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdEntrenador", entrenador.IdEntrenador);
                    cmd.Parameters.AddWithValue("@NombreEntrenador", entrenador.NombreEntrenador);
                    cmd.Parameters.AddWithValue("@Ciudad", entrenador.Ciudad);
                    cmd.Parameters.AddWithValue("@Pokemon", entrenador.Pokemon);
                    cmd.Parameters.AddWithValue("@Tipo", entrenador.Tipo);
                    cmd.Parameters.AddWithValue("@Nivel", entrenador.Nivel);
                    cmd.Parameters.AddWithValue("@Movimiento1", entrenador.Movimiento1);
                    cmd.Parameters.AddWithValue("@Movimiento2", entrenador.Movimiento2);
                    cmd.Parameters.AddWithValue("@Movimiento3", entrenador.Movimiento3);
                    cmd.Parameters.AddWithValue("@Movimiento4", entrenador.Movimiento4);
                    cmd.Parameters.AddWithValue("@LigaGanada", entrenador.LigaGanada);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("✅ Entrenador actualizado exitosamente.");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar(int idEntrenador)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM PokemonEntrenadores WHERE IdEntrenador = @IdEntrenador";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdEntrenador", idEntrenador);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("✅ Entrenador eliminado exitosamente.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }

}
