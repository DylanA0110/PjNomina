using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class NominaMensual : Nomina, IDeduccion, IIngresos, ICargos
    {
        public new decimal CalcularImpuestoRenta()
        {
            decimal ingresoAnual = CalcularIngresoAnual();

            decimal IR = 0;

            if (ingresoAnual > 500000.01m)
            {
                decimal calculo3 = (ingresoAnual - 500000m) * 0.30m;
                IR = (calculo3 + 82500m) / 12;
            }
            else if (ingresoAnual >= 350000.01m)
            {
                decimal calculo2 = (ingresoAnual - 350000m) * 0.25m;
                IR = (calculo2 + 45000m) / 12;
            }
            else if (ingresoAnual >= 200000.01m)
            {
                decimal calculo1 = (ingresoAnual - 200000m) * 0.2m;
                IR = (calculo1 + 15000m) / 12;
            }
            else if (ingresoAnual >= 100000.01m)
            {
                decimal sobreexceso1 = 100000m;
                decimal totalDeducir1 = ingresoAnual - sobreexceso1;
                IR = (totalDeducir1 * 0.15m) / 12;
            }

            return IR;//De forma mensual
        }

        public new decimal CalcularRiesgoLaboral()
        {
            return (Empleado.SalarioOrdinario) * 0.2M;
        }

        public new decimal CalcularTotalIngresos()
        {
            return Empleado.SalarioOrdinario + CalcularHoraExtra() + ViaticoAlimentacion + ViaticoTransporte + Comisiones + CalcularRiesgoLaboral() + CalcularNocturnidad() + OtrosIngresos;
        }


        public new decimal CalcularNocturnidad()
        {
            return (Empleado.SalarioOrdinario) * 0.2M;
        }

        public new decimal MostrarVacacionesAcumuladas()
        {
            return (Empleado.SalarioOrdinario) * 0.083M;
        }

        public new decimal MostrarAguinaldoAcmulado()
        {
            return (Empleado.SalarioOrdinario) * 0.083M;
        }

        public new decimal calcularPagoIndenmizacion()
        {
            return (Empleado.SalarioOrdinario) * 0.083M;
        }
        public new decimal CalcularTotalDeducciones()
        {
            return CalcularINSS() + CalcularImpuestoRenta() + Prestamos + Embargos;
        }
        public new decimal CalcularINATEC()
        {
            return CalcularTotalIngresos() * 0.02M;
        }

        public new decimal CalcularINSSPatronal()
        {
            if (cantidadEmpleados > 50)
                return CalcularTotalIngresos() * 0.225M;
            else
                return CalcularTotalIngresos() * 0.215M;
        }
        public new decimal CalcularINSS()
        {
            return CalcularTotalIngresos() * 0.07m;
        }

        public new decimal calcularAntiguedad()
        {
            int YearsTrabajados = calcularYearsTrabajados();
            if (YearsTrabajados > 6)
            {
                return 0;
            }
            if (YearsTrabajados < 4)
            {
                decimal antiguedad1 = Empleado.SalarioOrdinario / 12;
                return antiguedad1;
            }
            if (YearsTrabajados > 5 || YearsTrabajados < 6)
            {
                decimal antiguedad2 = (CalcularSalarioPorDia() * 20) / 12;

                return antiguedad2;
            }

            else
                return 0;
        }
    }
}
