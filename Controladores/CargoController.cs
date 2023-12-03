using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;

namespace Controladores
{
    public class CargoController
    {
        private string conexion = Conexion.conexion;

        public List<Cargo> ObtenerCargos()
        {
            List<Cargo> cargos = new List<Cargo>();

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT id, nombre, aplicarComisiones, aplicarRiesgoLaboral  FROM cargo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cargo cargo = new Cargo
                            {
                                IDCargo = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                AplicaComisiones = reader.GetBoolean(2),
                                AplicaRiesgoLaboral = reader.GetBoolean(3)
                                
                            };

                            cargos.Add(cargo);
                        }
                    }
                }
            }

            return cargos;
        }

        public Cargo ObtenerCargoPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT nombre, aplicarComisiones, aplicarRiesgoLaboral FROM cargo WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Cargo
                            {
                                IDCargo= id,
                                Nombre = reader.GetString(0),
                                AplicaComisiones= reader.GetBoolean(1),
                                AplicaRiesgoLaboral = reader.GetBoolean(2)
                            };
                        }
                    }
                }
            }

            return null; 
        }

        public bool CargoExiste(string nombre)
        {
            using(SqlConnection conection = new SqlConnection(conexion))
            {
                conection.Open();
                string query = "SELECT COUNT(*) FROM cargo WHERE nombre = @nombre";

                using(SqlCommand comando = new(query,conection))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    int count = (int)comando.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void InsertarCargo(Cargo cargo)
        {
            using(SqlConnection conection = new SqlConnection(conexion))
            {
                conection.Open();
                string query = "INSERT INTO cargo (nombre, aplicarComisiones, aplicarRiesgoLaboral) VALUES(@nombre, @aplicarComisiones, @aplicarRiesgoLaboral)";
                using(SqlCommand comando = new(query, conection))
                {
                    comando.Parameters.AddWithValue("@nombre", cargo.Nombre);
                    comando.Parameters.AddWithValue("@aplicarComisiones", cargo.AplicaComisiones);
                    comando.Parameters.AddWithValue("@aplicarRiesgoLaboral", cargo.AplicaRiesgoLaboral);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarCargo(Cargo cargo)
        {
            string query = "UPDATE cargo SET nombre = @nombre, aplicarComisiones = @aplicarComisiones, aplicarRiesgolaboral = @aplicarRiesgolaboral WHERE id = @id";

            using (SqlConnection conecction = new SqlConnection(conexion))
            {
                conecction.Open();

                using (SqlCommand command = new SqlCommand(query, conecction))
                {
                    command.Parameters.AddWithValue("@nombre", cargo.Nombre);
                    command.Parameters.AddWithValue("@aplicarComisiones", cargo.AplicaComisiones);
                    command.Parameters.AddWithValue("@aplicarRiesgoLaboral", cargo.AplicaRiesgoLaboral);
                    command.Parameters.AddWithValue("@id", cargo.IDCargo);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void EliminarCargo(int idCargo)
        {
            string query = "DELETE FROM cargo WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", idCargo);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
