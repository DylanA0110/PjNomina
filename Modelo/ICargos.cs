using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal interface ICargos
    {
        static int cantidadEmpleados { get; set; }
        decimal CalcularINATEC();
        decimal CalcularINSSPatronal();
        decimal MostrarVacacionesAcumuladas();
        decimal MostrarAguinaldoAcmulado();
        decimal calcularPagoIndenmizacion();
    }
}
