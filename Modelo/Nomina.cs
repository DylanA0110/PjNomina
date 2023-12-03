using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class Nomina : IDeduccion, IIngresos, ICargos
    {
        private int idNomina;
        private DateTime fecha;
        private DateTime fechaFin;
        private decimal ingresoOrdinario;
        private decimal salarioPorDia;
        private decimal salarioQuincenal;
        private decimal horaExtra;
        private decimal nocturnidad;
        private decimal totalIngresos;
        private decimal viaticoTransporte;
        private decimal viaticoAlimentacion;
        private decimal depreciacionVehiculo;
        private decimal riesgoLaboral;
        private decimal comisiones;
        private decimal ingresoVacaciones;
        private decimal ingresoAguinaldo;
        private decimal indemizacion;
        private decimal antiguedad;
        private decimal _INSS;
        private decimal impuestoRenta;
        private decimal prestamos;
        private decimal embargos;
        private decimal salarioNeto;
        private int idEmpleado;
        private decimal otrosIngresos;
        private decimal otrasDeducciones;

        [Required(ErrorMessage = "La nocturnidad es requerida.")]
        [Range(0, Double.MaxValue, ErrorMessage = "La nocturnidad debe ser mayor o igual a 0")]
        public decimal Nocturnidad { get => nocturnidad; set => nocturnidad = value; }  

        [Required(ErrorMessage = "La nocturnidad es requerida.")]
        [Range(0, Double.MaxValue, ErrorMessage = "otros ingresos debe ser mayor o igual a 0")]
        public decimal OtrosIngresos{ get => otrosIngresos; set => otrosIngresos = value; }    [Required(ErrorMessage = "La nocturnidad es requerida.")]
        [Range(0, Double.MaxValue, ErrorMessage = "otros ingresos debe ser mayor o igual a 0")]
        public decimal OtrasDeducciones{ get => otrasDeducciones; set => otrasDeducciones = value; }  

        [Required(ErrorMessage = "La indemizacion es requerida.")]
        [Range(0, Double.MaxValue, ErrorMessage = "La indemizacion debe ser mayor o igual a 0")]
        public decimal Indemizacion{ get => indemizacion; set => indemizacion= value; }   

        [Required(ErrorMessage = "La antiguedad es requerida.")]
        [Range(0, Double.MaxValue, ErrorMessage = "La antiguedad debe ser mayor o igual a 0")]
        public decimal Antiguedad{ get => antiguedad; set => antiguedad= value; }

        [Required(ErrorMessage = "El salario quincenal es requerida.")]
        [Range(0, Double.MaxValue, ErrorMessage = "El salario quincenal debe ser mayor o igual a 0")]
        public decimal SalarioQuincenal { get => salarioQuincenal; set => salarioQuincenal = value; }

        [Required(ErrorMessage = "El ingreso del aguinaldo es requerida.")]
        [Range(0, Double.MaxValue, ErrorMessage = "El ingreso del aguinaldo debe ser mayor o igual a 0")]
        public decimal IngresoAguinaldo { get => ingresoAguinaldo; set => ingresoAguinaldo = value; }

        [Required(ErrorMessage = "Empleado requerido.")]
        public Empleado Empleado { get; set; }

        [Required(ErrorMessage = "El ID es requerido")]
        public int IDNomina { get => idNomina; set => idNomina = value; }

        [Required(ErrorMessage = "La fecha es requerida")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get => fecha; set => fecha = value; }
        [Required(ErrorMessage = "La fecha fin de la nomina es requerida")]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }

        [Required(ErrorMessage = "El ingreso ordinario es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El ingreso ordinario debe ser mayor o igual a 0")]
        public decimal IngresoOrdinario { get => ingresoOrdinario; set => ingresoOrdinario = value; }

        [Required(ErrorMessage = "El salario por día es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El salario por día debe ser mayor o igual a 0")]
        public decimal SalarioPorDia { get => salarioPorDia; set => salarioPorDia = value; }

        [Required(ErrorMessage = "La hora extra es requerida")]
        [Range(0, Double.MaxValue, ErrorMessage = "La hora extra debe ser mayor o igual a 0")]
        public decimal HoraExtra { get => horaExtra; set => horaExtra = value; }

        [Required(ErrorMessage = "El total de ingresos es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El total de ingresos debe ser mayor o igual a 0")]
        public decimal TotalIngresos { get => totalIngresos; set => totalIngresos = value; }

        [Required(ErrorMessage = "El viático de transporte es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El viático transporte debe ser mayor o igual a 0")]
        public decimal ViaticoTransporte { get => viaticoTransporte; set => viaticoTransporte = value; }
        [Required(ErrorMessage = "El viático de alimentacion es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El viático alimentacion debe ser mayor o igual a 0")]
        public decimal ViaticoAlimentacion { get => viaticoAlimentacion; set => viaticoAlimentacion = value; }

        [Required(ErrorMessage = "La depreciación de vehículo es requerida")]
        [Range(0, Double.MaxValue, ErrorMessage = "La depreciación de vehículo debe ser mayor o igual a 0")]
        public decimal DepreciacionVehiculo { get => depreciacionVehiculo; set => depreciacionVehiculo = value; }

        [Required(ErrorMessage = "El pago por riesgo laboral es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El pago por riesgo laboral debe ser mayor o igual a 0")]
        public decimal RiesgoLaboral { get => riesgoLaboral; set => riesgoLaboral = value; }

        [Required(ErrorMessage = "El pago de comisiones es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El pago de comisiones debe ser mayor o igual a 0")]
        public decimal Comisiones { get => comisiones; set => comisiones = value; }

        [Required(ErrorMessage = "El ingreso por vacaciones es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El ingreso por vacaciones debe ser mayor o igual a 0")]
        public decimal IngresoVacaciones { get => ingresoVacaciones; set => ingresoVacaciones = value; }

        [Required(ErrorMessage = "El INSS es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El INSS debe ser mayor o igual a 0")]
        public decimal INSS { get => _INSS; set => _INSS = value; }

        [Required(ErrorMessage = "El impuesto sobre la renta es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El impuesto sobre la renta debe ser mayor o igual a 0")]
        public decimal ImpuestoRenta { get => impuestoRenta; set => impuestoRenta = value; }

        [Required(ErrorMessage = "Tiene que poner un valor en los prestamos")]
        [Range(0, Double.MaxValue, ErrorMessage = "El pago de préstamos debe ser mayor o igual a 0")]
        public decimal Prestamos { get => prestamos; set => prestamos = value; }

        [Required(ErrorMessage = "El monto de embargos es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El monto de embargos debe ser mayor o igual a 0")]
        public decimal Embargos { get => embargos; set => embargos = value; }

        [Required(ErrorMessage = "El salario neto es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El salario neto debe ser mayor o igual a 0")]
        public decimal SalarioNeto { get => salarioNeto; set => salarioNeto = value; }

        [Required(ErrorMessage = "El ID del empleado es requerido")]
        public int IDEmpleado { get => idEmpleado; set => idEmpleado = value; }

    
        public static int cantidadEmpleados { get; set; }
  
        public decimal CalcularHoraExtra()
        {
            if (HoraExtra != 0)
            {
                return CalcularSalarioPorHora() * 2 * HoraExtra;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalcularImpuestoRenta()
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

            return IR/2;//De forma quincenal
        }

    

        public decimal CalcularINSS()
        {
           return CalcularTotalIngresos() * 0.07m;
        }

        public decimal CalcularRiesgoLaboral()
        {        
            return (Empleado.SalarioOrdinario/2)*0.2M;
        }

        public decimal CalcularSalarioNeto()
        {
            return CalcularTotalIngresos() - CalcularTotalDeducciones();
        }

        public decimal CalcularSalarioPorDia()
        {
            return Empleado.SalarioOrdinario / 30;
        }

        public decimal CalcularTotalIngresos()
        {
            return calcularSalarioQuincenal() + CalcularHoraExtra() + ViaticoAlimentacion + ViaticoTransporte + Comisiones + CalcularRiesgoLaboral() + CalcularNocturnidad() + OtrosIngresos;
        }     

        public decimal CalcularIngresoAnual()
        {
            return (CalcularTotalIngresos()) * 12;
        }


        public decimal CalcularNocturnidad()
        {
            return (Empleado.SalarioOrdinario / 2) * 0.2M;
        }

        public decimal CalcularSalarioPorHora()
        {
            return SalarioPorDia / 8;
        }

        public decimal CalcularTotalDeducciones()
        {
            return CalcularINSS() + CalcularImpuestoRenta()  + Prestamos + Embargos + OtrasDeducciones;
        }

        public decimal CalcularINATEC()
        {
            return CalcularTotalIngresos() * 0.02M;
        }

        public decimal CalcularINSSPatronal()
        {
            if (cantidadEmpleados > 50)
                return CalcularTotalIngresos() * 0.225M;
            else
                return CalcularTotalIngresos() * 0.215M;
        }

        public decimal MostrarVacacionesAcumuladas()
        {
            return (Empleado.SalarioOrdinario / 2) * 0.083M;
        }

        public decimal MostrarAguinaldoAcmulado()
        {
            return (Empleado.SalarioOrdinario / 2) * 0.083M;
        }

        public decimal calcularPagoIndenmizacion()
        {

            return (Empleado.SalarioOrdinario / 2)*0.083M;
        }

        public decimal calcularSalarioQuincenal()
        {
            return Empleado.SalarioOrdinario / 2;
        }

        public decimal calcularAntiguedad()
        {
            int YearsTrabajados = calcularYearsTrabajados();
            if (YearsTrabajados > 6)
            {
                return 0;
            }
            if (YearsTrabajados < 4)
            {
                decimal antiguedad1 = Empleado.SalarioOrdinario / 24;
                return antiguedad1;
            }
            if (YearsTrabajados > 5 || YearsTrabajados < 6)
            {
                decimal antiguedad2 = (CalcularSalarioPorDia() * 20) / 24;

                return antiguedad2;
            }

            else
                return 0;
        }

        public int calcularYearsTrabajados()
        {
            DateTime fechaActual = DateTime.Now;
            int yearsTrabajados = fechaActual.Year - Empleado.FechaContratacion.Year;

            // si el empleado aún no ha cumplido un año completo de trabajo
            if (fechaActual < Empleado.FechaContratacion.AddYears(yearsTrabajados))
            {
                yearsTrabajados--;
            }

            return yearsTrabajados;
        }
    }
}
