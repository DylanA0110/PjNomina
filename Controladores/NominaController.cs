using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controladores
{
    public class NominaController
    {
        public string conexion = Conexion.conexion;
        public void InsertarNomina(Nomina nomina)
        {
            using(SqlConnection conecction = new SqlConnection(conexion)) 
            {
                conecction.Open();
                string query = "INSERT INTO tabla_nomina(idEmpleado, fecha, fechaFin, ingresoOrdinario, salarioPorDia, salarioQuincenal,horaExtra,nocturnidad,totalIngresos,viaticoTransporte," +
                    "viaticoAlimentacion, depreciacionVehiculo, riesgoLaboral,comisiones, ingresoVacaciones, ingresoAguinaldo, indemizacion, antiguedad, _INSS, impuestoRenta, prestamos, embargos, salarioNeto)" +
                    " VALUES(@idEmpleado, @fecha, @fechaFin, @ingresoOrdinario, @salarioPorDia, @salarioQuincenal,@horaExtra,@nocturnidad,@totalIngresos,@viaticoTransporte, @viaticoAlimentacion, @depreciacionVehiculo, @riesgoLaboral,@comisiones, @ingresoVacaciones, @ingresoAguinaldo, @indemizacion, @antiguedad, @_INSS, @impuestoRenta, @prestamos, @embargos, @salarioNeto)";
                using(SqlCommand comando = new SqlCommand(query, conecction))
                {
                    comando.Parameters.AddWithValue("@idEmpleado", nomina.Empleado.IDEmpleado);
                    comando.Parameters.AddWithValue("@fecha", nomina.Fecha);
                    comando.Parameters.AddWithValue("@fechaFin", nomina.FechaFin);
                    comando.Parameters.AddWithValue("@ingresoOrdinario", nomina.Empleado.SalarioOrdinario);
                    comando.Parameters.AddWithValue("@salarioPorDia", nomina.SalarioPorDia);
                    comando.Parameters.AddWithValue("@salarioQuincenal", nomina.SalarioQuincenal);
                    comando.Parameters.AddWithValue("@horaExtra", nomina.CalcularHoraExtra());
                    comando.Parameters.AddWithValue("@nocturnidad", nomina.Nocturnidad);
                    comando.Parameters.AddWithValue("@totalIngresos", nomina.TotalIngresos);
                    comando.Parameters.AddWithValue("@viaticoTransporte", nomina.ViaticoTransporte);
                    comando.Parameters.AddWithValue("@viaticoAlimentacion", nomina.ViaticoAlimentacion);
                    comando.Parameters.AddWithValue("@depreciacionVehiculo", nomina.DepreciacionVehiculo);
                    comando.Parameters.AddWithValue("@riesgoLaboral", nomina.RiesgoLaboral);
                    comando.Parameters.AddWithValue("@comisiones", nomina.Comisiones);
                    comando.Parameters.AddWithValue("@ingresoVacaciones", nomina.IngresoVacaciones);
                    comando.Parameters.AddWithValue("@ingresoAguinaldo", nomina.IngresoAguinaldo);
                    comando.Parameters.AddWithValue("@indemizacion", nomina.Indemizacion);
                    comando.Parameters.AddWithValue("@antiguedad", nomina.Antiguedad);
                    comando.Parameters.AddWithValue("@_INSS", nomina.INSS);
                    comando.Parameters.AddWithValue("@impuestoRenta", nomina.CalcularImpuestoRenta());
                    comando.Parameters.AddWithValue("@prestamos", nomina.Prestamos);
                    comando.Parameters.AddWithValue("@embargos", nomina.Embargos);
                    comando.Parameters.AddWithValue("@salarioNeto", nomina.SalarioNeto);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
