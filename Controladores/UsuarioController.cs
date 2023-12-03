using System; 
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace Controladores
{
    public class UsuarioController
    {
        private string conexion = Conexion.conexion;


        public void InsertarUsuario(Usuario usuario)
        {
            using (SqlConnection conection = new SqlConnection(conexion))
            {
                conection.Open();
                string query = "INSERT INTO usuario (nombre, segundoNombre, primerApellido, segundoApellido, nombre_usuario, password, correo_electronico, fecha_nac, fecha_registro, idRol, telefono) " +
                          "VALUES (@nombre, @segundoNombre, @primerApellido, @segundoApellido, @nombre_usuario, @password, @correo_electronico, @fecha_nac, GETDATE(), @idRol, @telefono)";
                using (SqlCommand command = new SqlCommand(query, conection))
                {
                    command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@segundoNombre", usuario.SegundoNombre);
                    command.Parameters.AddWithValue("@primerApellido", usuario.PrimerApellido);
                    command.Parameters.AddWithValue("@segundoApellido", usuario.SegundoApellido);
                    command.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                    command.Parameters.AddWithValue("@password", usuario.Password);
                    command.Parameters.AddWithValue("@correo_electronico", usuario.CorreoElectronico);
                    command.Parameters.AddWithValue("@fecha_nac", usuario.FechaNac);
                    command.Parameters.AddWithValue("@idRol", usuario.IdRol);
                    command.Parameters.AddWithValue("@telefono", usuario.Telefono);

                    command.ExecuteNonQuery();
                }
            }
        }

        public bool Login(Usuario user)
        {
            string query = "SELECT * FROM usuario WHERE nombre_usuario = @nombre_usuario AND password = @password";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre_usuario", user.NombreUsuario);
                    command.Parameters.AddWithValue("@password", user.Password);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
        }

        public void ActualizarUltimoAcceso(Usuario user)
        {
            string query = "UPDATE usuario SET ultimo_acceso = GETDATE() WHERE nombre_usuario = @nombre_usuario";
            using (SqlConnection conecction = new SqlConnection(conexion))
            {
                conecction.Open();

                using (SqlCommand command = new SqlCommand(query, conecction))
                {
                    command.Parameters.AddWithValue("@nombre_usuario", user.NombreUsuario);

                    command.ExecuteNonQuery();
                }
            }
        }

        public bool UsuarioExiste(string nombreUser)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @nombre_usuario";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre_usuario", nombreUser);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error de base de datos: " + ex.Message);
                    return false;
                }
            }
        }
        public Usuario SelectUserPorID(int ID)
        {
            using (SqlConnection conection = new SqlConnection(conexion))
            {
                conection.Open();

                string query = "SELECT nombre, segundoNombre, primerApellido, segundoApellido, nombre_usuario, password," +
                    "correo_electronico, fecha_nac, idRol, telefono FROM usuario WHERE id = @id";

                using (SqlCommand comando = new SqlCommand(query, conection))
                {
                    comando.Parameters.AddWithValue("@id", ID);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.Nombre = lector.GetString(0);
                            usuario.SegundoNombre = lector.GetString(1);
                            usuario.PrimerApellido = lector.GetString(2);
                            usuario.SegundoApellido = lector.GetString(3);
                            usuario.NombreUsuario = lector.GetString(4);
                            usuario.Password = lector.GetString(5);
                            usuario.CorreoElectronico = lector.GetString(6);
                            usuario.FechaNac = lector.GetDateTime(7);
                            usuario.IdRol = lector.GetInt32(8);
                            usuario.Telefono = lector.GetString(9);
                            return usuario;
                        }
                    }
                    return null;
                }
            }
        }
        public Usuario SelectUserPorNombreUsuario(string nombreUsuario)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();
                string query = "SELECT id, nombre, segundoNombre, primerApellido, segundoApellido, password," +
                    "correo_electronico, fecha_nac, idRol, telefono FROM usuario WHERE nombre_usuario = @nombre_usuario";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.ID = reader.GetInt32(0);
                            usuario.Nombre = reader.GetString(1);
                            usuario.SegundoNombre = reader.GetString(2);
                            usuario.PrimerApellido = reader.GetString(3);
                            usuario.SegundoApellido = reader.GetString(4);
                            usuario.Password = reader.GetString(5);
                            usuario.CorreoElectronico = reader.GetString(6);
                            usuario.FechaNac = reader.GetDateTime(7);
                            usuario.IdRol = reader.GetInt32(8);
                            usuario.Telefono = reader.GetString(9);
                            return usuario;
                        }
                    }
                    return null;
                }
            }
        }

        public void ActualizarUsuario(Usuario user)
        {
            string query = "UPDATE usuario SET nombre = @nuevoNombre, segundoNombre = @nuevoSegundoN, " +
                           "primerApellido = @nuevoPrimerApellido, segundoApellido = @nuevoSegundoApellido, " +
                           "password = @nuevapassword, correo_electronico = @nuevoCorreoElectronico, " +
                           "fecha_nac = @nuevaFechaNacimiento, telefono = @nuevoTelefono WHERE id = @id1";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nuevoNombre", user.Nombre);
                    command.Parameters.AddWithValue("@nuevoSegundoN", user.SegundoNombre);
                    command.Parameters.AddWithValue("@nuevoPrimerApellido", user.PrimerApellido);
                    command.Parameters.AddWithValue("@nuevoSegundoApellido", user.SegundoApellido);
                    command.Parameters.AddWithValue("@nuevapassword", user.Password);
                    command.Parameters.AddWithValue("@nuevoCorreoElectronico", user.CorreoElectronico);
                    command.Parameters.AddWithValue("@nuevaFechaNacimiento", user.FechaNac);
                    command.Parameters.AddWithValue("@nuevoTelefono", user.Telefono);
                    command.Parameters.AddWithValue("@id1", user.ID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("El usuario se ha actualizado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo actualizar el usuario.");
                    }
                }
            }
        }
        
        public IEnumerable<Usuario> TraerUsuarios()
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT id, nombre, segundoNombre, primerApellido, segundoApellido, nombre_usuario, " +
                               "correo_electronico, fecha_nac, fecha_registro, ultimo_acceso, idRol, telefono FROM usuario";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                ID = reader.IsDBNull(reader.GetOrdinal("id")) ? 0 : reader.GetInt32(reader.GetOrdinal("id")),
                                Nombre = reader.IsDBNull(reader.GetOrdinal("nombre")) ? string.Empty : reader.GetString(reader.GetOrdinal("nombre")),
                                SegundoNombre = reader.IsDBNull(reader.GetOrdinal("segundoNombre")) ? string.Empty : reader.GetString(reader.GetOrdinal("segundoNombre")),
                                PrimerApellido = reader.IsDBNull(reader.GetOrdinal("primerApellido")) ? string.Empty : reader.GetString(reader.GetOrdinal("primerApellido")),
                                SegundoApellido = reader.IsDBNull(reader.GetOrdinal("segundoApellido")) ? string.Empty : reader.GetString(reader.GetOrdinal("segundoApellido")),
                                NombreUsuario = reader.IsDBNull(reader.GetOrdinal("nombre_usuario")) ? string.Empty : reader.GetString(reader.GetOrdinal("nombre_usuario")),
                                CorreoElectronico = reader.IsDBNull(reader.GetOrdinal("correo_electronico")) ? string.Empty : reader.GetString(reader.GetOrdinal("correo_electronico")),
                                FechaNac = reader.IsDBNull(reader.GetOrdinal("fecha_nac")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("fecha_nac")),
                                FechaRegistro = reader.IsDBNull(reader.GetOrdinal("fecha_registro")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("fecha_registro")),
                                UltimoAcceso = reader.IsDBNull(reader.GetOrdinal("ultimo_acceso")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("ultimo_acceso")),
                                IdRol = reader.IsDBNull(reader.GetOrdinal("idRol")) ? 0 : reader.GetInt32(reader.GetOrdinal("idRol")),
                                Telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? string.Empty : reader.GetString(reader.GetOrdinal("telefono"))
                            };

                            yield return usuario;
                        }
                    }
                }
            }
        }
        public int CantidadUsuarios()
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM usuario";
                using(SqlCommand comando = new SqlCommand(query, connection))
                {
                    int count = (int)comando.ExecuteScalar();
                    return count;
                }
            }
        }

    }
}

