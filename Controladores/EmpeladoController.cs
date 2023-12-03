using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class EmpeladoController
    {
        private string conexion = Conexion.conexion;

        public void InsertarEmpleado(Empleado empleado)
        {
            using(SqlConnection conection = new SqlConnection(conexion))
            {
                conection.Open();

                string query = "INSERT INTO empleado (numeroCedula, numeroINSS, numeroRUC, primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNacimiento, sexo, estadoCivil, direccion, telefono, celular, fechaContratacion, salarioOrdinario, activo, idCargo, idHorario)" +
                    "VALUES (@numeroCedula, @numeroINSS, @numeroRUC, @primerNombre,@segundoNombre,@primerApellido, @segundoApellido, @fechaNacimiento,@sexo,@estadoCivil,@direccion,@telefono,@celular, @fechaContratacion, @salarioOrdinario, 1, @idCargo, @idHorario)";

                using(SqlCommand comando = new SqlCommand(query, conection))
                {
                    comando.Parameters.AddWithValue("@numeroCedula", empleado.NumeroCedula);
                    comando.Parameters.AddWithValue("@numeroINSS", empleado.NumeroINSS);
                    comando.Parameters.AddWithValue("@numeroRUC", empleado.NumeroRUC);
                    comando.Parameters.AddWithValue("@primerNombre", empleado.PrimerNombre);
                    comando.Parameters.AddWithValue("@segundoNombre", empleado.SegundoNombre);
                    comando.Parameters.AddWithValue("@primerApellido", empleado.PrimerApellido);
                    comando.Parameters.AddWithValue("@segundoApellido", empleado.SegundoApellido);
                    comando.Parameters.AddWithValue("@fechaNacimiento", empleado.FechaNacimiento);
                    comando.Parameters.AddWithValue("@sexo", empleado.Sexo);
                    comando.Parameters.AddWithValue("@estadoCivil", empleado.EstadoCivil);
                    comando.Parameters.AddWithValue("@direccion", empleado.Direccion);
                    comando.Parameters.AddWithValue("@telefono", empleado.Telefono);
                    comando.Parameters.AddWithValue("@celular", empleado.Celular);
                    comando.Parameters.AddWithValue("@fechaContratacion", empleado.FechaContratacion);
                    comando.Parameters.AddWithValue("@salarioOrdinario", empleado.SalarioOrdinario);
                    comando.Parameters.AddWithValue("@idCargo", empleado.IDCargo);
                    comando.Parameters.AddWithValue("@idHorario", empleado.IDHorario);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Empleado> TraerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT id, numeroCedula, numeroINSS, numeroRUC, primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNacimiento, sexo, estadoCivil, direccion, telefono, celular, fechaContratacion, salarioOrdinario, activo, idCargo, idHorario FROM empleado";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Empleado empleado = new Empleado
                            {
                                IDEmpleado = reader.GetInt32(0),
                                NumeroCedula = reader.GetString(1),
                                NumeroINSS = reader.GetString(2),
                                NumeroRUC = reader.GetString(3),
                                PrimerNombre = reader.GetString(4),
                                SegundoNombre = reader.GetString(5),
                                PrimerApellido = reader.GetString(6),
                                SegundoApellido = reader.GetString(7),
                                FechaNacimiento = reader.GetDateTime(8),
                                Sexo = reader.GetString(9),
                                EstadoCivil = reader.GetString(10),
                                Direccion = reader.GetString(11),
                                Telefono = reader.GetString(12),
                                Celular = reader.GetString(13),
                                FechaContratacion = reader.GetDateTime(14),
                                SalarioOrdinario = reader.GetDecimal(15),
                                Activo = reader.GetBoolean(16),
                                IDCargo = reader.GetInt32(17),
                                IDHorario = reader.GetInt32(18)
                            };
                            empleados.Add(empleado);
                        }
                    }
                }
            }
            return empleados;
        }

        public int CantidadEmpleados()
        {
            using(SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM empleado";
                using(SqlCommand comando = new SqlCommand(query, connection))
                {
                    int count = (int)comando.ExecuteScalar();
                    return count;
                }
            }
        }
    }
}
