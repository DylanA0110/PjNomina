using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class ComisionesController
    {
        private string conexion = Conexion.conexion;

        public void InsertarComision(Comisiones comisiones)
        {
            using (SqlConnection conection = new SqlConnection(conexion))
            {
                conection.Open();
                string query = "INSERT INTO comisiones (idCargo, porcentajeComision, MetaVentas) VALUES(@idCargo, @porcentajeComision, @Metaventas)";
                using (SqlCommand comando = new(query, conection))
                {
                    comando.Parameters.AddWithValue("@idCargo", comisiones.IDCargo);
                    comando.Parameters.AddWithValue("@porcentajeComision", comisiones.PorcentajeComision);
                    comando.Parameters.AddWithValue("@MetaVentas", comisiones.MetaVentas);

                    comando.ExecuteNonQuery();
                }
            }
        }
        public bool ComisionYaExiste(int idCargo, string metaVentas)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM comisiones WHERE idCargo = @idCargo AND MetaVentas = @MetaVentas";

                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@idCargo", idCargo);
                    command.Parameters.AddWithValue("@MetaVentas", metaVentas);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        public List<Comisiones> ObtenerComisiones()
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT id, idCargo, porcentajeComision, MetaVentas FROM comisiones";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    List<Comisiones> comisiones = new List<Comisiones>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Comisiones comision = new Comisiones
                            {
                                ID = reader.GetInt32(0),
                                IDCargo = reader.GetInt32(1),
                                PorcentajeComision = reader.GetDecimal(2),
                                MetaVentas = reader.GetString(3)
                            };

                            comisiones.Add(comision);
                        }
                    }

                    return comisiones;
                }
            }
        }

        public Comisiones ObtenerComisionPorID(int id)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT idCargo, porcentajeComision, MetaVentas FROM comisiones WHERE id = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Comisiones comision = new Comisiones
                            {
                                ID = id,
                                IDCargo = reader.GetInt32(0),
                                PorcentajeComision = reader.GetDecimal(1),
                                MetaVentas = reader.GetString(2)
                            };

                            return comision;
                        }
                    }

                    return null; 
                }
            }
        }

        public void ActualizarComision(Comisiones comisiones)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                
                connection.Open();

                string query = "UPDATE comisiones SET idCargo = @idCargo, porcentajeComision = @porcentajeComision, MetaVentas = @MetaVentas WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCargo", comisiones.IDCargo);
                    command.Parameters.AddWithValue("@porcentajeComision", comisiones.PorcentajeComision);
                    command.Parameters.AddWithValue("@MetaVentas", comisiones.MetaVentas);
                    command.Parameters.AddWithValue("@id", comisiones.ID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarCargo(int comisionID)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "DELETE FROM comisiones WHERE id = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", comisionID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ninguna comisión con el ID especificado.");
                    }
                }
            }
        }
        public decimal ObtenerPorcentajeSegunMeta(string metaVentas)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();
                string query = "SELECT porcentajeComision FROM comisiones WHERE MetaVentas = @MetaVentas";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MetaVentas", metaVentas);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }

            // Si no se encuentra la meta o hay un error, puedes devolver un valor por defecto, como 0.
            return 0;
        }

        public List<string> ObtenerMetaVentas(int idCargo)
        {
            List<string> valoresMeta = new List<string>();

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT MetaVentas FROM comisiones WHERE idCargo = @idCargo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCargo", idCargo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string metaVentas = reader.GetString(0);
                            valoresMeta.Add(metaVentas);
                        }
                    }
                }
            }

            return valoresMeta;
        }

    }
}