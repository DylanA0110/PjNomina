using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface IIngresos
    {     

        decimal CalcularSalarioPorDia();
        decimal calcularSalarioQuincenal();
        decimal CalcularHoraExtra();
        decimal CalcularSalarioPorHora();
        decimal CalcularTotalIngresos();
        decimal CalcularRiesgoLaboral();
        decimal CalcularNocturnidad();
        decimal CalcularIngresoAnual();

        decimal calcularAntiguedad();
        
    }
}
