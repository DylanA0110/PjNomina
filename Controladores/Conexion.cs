using System.Data.SqlClient;

namespace Controladores
{
    public static class Conexion
    {
        static string name = "DESKTOP-IO3CIEI\\DYLANSQL";
        static string user = "sa";
        static string password = "dylanaraica123";
        //la primer conexion se usa para crear la base de datos, la segunda es cuando ya esta creada
        public static string conexionInicial = $"Data Source={name};Initial Catalog=master;User ID={user};Password={password}";
        //Cambiar Conexion cuando se crea la base de datos
        public static string conexion = $"Data Source={name};Initial Catalog=nomina;User ID={user};Password={password}";
        
        public static void CrearBaseDeDatosYTablaSiNoExisten()
        {
            string nombreDataBase = "nomina";

            string crearDataBase = $"IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = '{nombreDataBase}') CREATE DATABASE {nombreDataBase};";

            string createTableQuery = @"
                USE nomina;
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'rol')
                BEGIN
                    CREATE TABLE rol (
                        id INT IDENTITY(1, 1) PRIMARY KEY,
                        nombre NVARCHAR(50) NOT NULL
                    )
                END

                INSERT INTO rol (nombre)
                SELECT 'Administrador' WHERE NOT EXISTS (SELECT * FROM rol WHERE nombre = 'Administrador');

                INSERT INTO rol (nombre)
                SELECT 'Gerente' WHERE NOT EXISTS (SELECT * FROM rol WHERE nombre = 'Gerente');

                INSERT INTO rol (nombre)
                SELECT 'Contador General' WHERE NOT EXISTS (SELECT * FROM rol WHERE nombre = 'Contador General');

                INSERT INTO rol (nombre)
                SELECT 'Asistente Contable' WHERE NOT EXISTS (SELECT * FROM rol WHERE nombre = 'Asistente Contable');
                                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'usuario')
                BEGIN
                    CREATE TABLE usuario (
                        id INT IDENTITY(1, 1) PRIMARY KEY,
                        nombre NVARCHAR(100) NOT NULL,
                        segundoNombre NVARCHAR(100),
                        primerApellido NVARCHAR(100) NOT NULL,
                        segundoApellido NVARCHAR(100),
                        nombre_usuario NVARCHAR(50) NOT NULL,
                        password NVARCHAR(50) NOT NULL,
                        correo_electronico NVARCHAR(100) NOT NULL,
                        fecha_nac DATE,
                        fecha_registro DATETIME,
                        ultimo_acceso DATETIME,
                        idRol INT FOREIGN KEY REFERENCES rol(id),
                        telefono NVARCHAR(20)
                    )
                END
                 IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'cargo')
                  BEGIN
                      CREATE TABLE cargo (
                          id INT IDENTITY(1, 1) PRIMARY KEY,
                          nombre VARCHAR(50),
                          aplicarComisiones BIT,
                          aplicarRiesgoLaboral BIT
                      );
                  END;
                  IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'horario')
                  BEGIN
                      CREATE TABLE horario (
                          id INT IDENTITY(1, 1) PRIMARY KEY,
                          nombre VARCHAR(50)
                      );

                    INSERT INTO horario (nombre)
                    SELECT 'Diurno' WHERE NOT EXISTS (SELECT * FROM horario WHERE nombre = 'Diurno');

                    INSERT INTO horario (nombre)
                    SELECT 'Nocturno' WHERE NOT EXISTS (SELECT * FROM horario WHERE nombre = 'Nocturno');

                    INSERT INTO horario (nombre)
                    SELECT 'Mixto' WHERE NOT EXISTS (SELECT * FROM horario WHERE nombre = 'Mixto');
                            END;
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'empleado')
                BEGIN
                    CREATE TABLE empleado (
                       id INT IDENTITY(1, 1) PRIMARY KEY,
                    numeroCedula VARCHAR(50),
                    numeroINSS VARCHAR(50),
                    numeroRUC VARCHAR(50),
                    primerNombre VARCHAR(50),
                    segundoNombre VARCHAR(50),
                    primerApellido VARCHAR(50),
                    segundoApellido VARCHAR(50),
                    fechaNacimiento DATE,
                    sexo VARCHAR(10),
                    estadoCivil VARCHAR(20),
                    direccion VARCHAR(100),
                    telefono VARCHAR(20),
                    celular VARCHAR(20),
                    fechaContratacion DATE,
                    salarioOrdinario DECIMAL(18, 2),
                    activo BIT,
                     idCargo INT FOREIGN KEY REFERENCES cargo(id),
                    idHorario INT FOREIGN KEY REFERENCES horario(id)
                    );
                END;
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'comisiones')
            BEGIN
                CREATE TABLE comisiones (
                    id INT IDENTITY(1, 1) PRIMARY KEY,
                    idCargo INT FOREIGN KEY REFERENCES cargo(id),
                    porcentajeComision DECIMAL(18, 2),
                    MetaVentas VARCHAR(50)
                );
            END;
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tabla_nomina')
                BEGIN
                    CREATE TABLE tabla_nomina (
                        id INT IDENTITY(1, 1) PRIMARY KEY,
                        idEmpleado INT FOREIGN KEY REFERENCES empleado(id),
                        fecha DATE,
                        fechaFin DATE,
                        ingresoOrdinario DECIMAL(18, 2),
                        salarioPorDia DECIMAL(18, 2),
                        salarioQuincenal DECIMAL(18, 2),
                        horaExtra DECIMAL(18, 2),
                        nocturnidad DECIMAL(18, 2),
                        totalIngresos DECIMAL(18, 2),
                        viaticoTransporte DECIMAL(18, 2),
                        viaticoAlimentacion DECIMAL(18, 2),
                        depreciacionVehiculo DECIMAL(18, 2),
                        riesgoLaboral DECIMAL(18, 2),
                        comisiones DECIMAL(18, 2),
                        ingresoVacaciones DECIMAL(18, 2),
                        ingresoAguinaldo DECIMAL(18, 2),
                        indemizacion DECIMAL(18, 2),
                        antiguedad DECIMAL(18, 2),
                        _INSS DECIMAL(18, 2),
                        impuestoRenta DECIMAL(18, 2),
                        prestamos DECIMAL(18, 2),
                        embargos DECIMAL(18, 2),
                        salarioNeto DECIMAL(18, 2)
                    );
                END;
           ";

            using (SqlConnection connection = new SqlConnection(conexionInicial))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(crearDataBase, connection);
                command.ExecuteNonQuery();

                command.CommandText = createTableQuery;
                command.ExecuteNonQuery();
            }
        }
    }
}