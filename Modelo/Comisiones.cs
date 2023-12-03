using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comisiones
    {
        private int id;
        private int idCargo;
        private decimal porcentajeComision;
        private string metaVentas;

        [Required(ErrorMessage = "El campo ID es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El campo ID debe ser mayor que 0")]
        public int ID { get => id; set => id = value; }

        [Required(ErrorMessage = "El campo IDCargo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El campo IDCargo debe ser mayor que 0")]
        public int IDCargo { get => idCargo; set => idCargo = value; }


        [Required(ErrorMessage = "El porcentaje de comisión es requerido")]
        [DataType(DataType.Currency, ErrorMessage = "Por favor, ingresa un valor decimal válido")]
        [Range(0, 100, ErrorMessage = "El porcentaje de comisión debe estar entre 0 y 100")]
        public decimal PorcentajeComision { get => porcentajeComision; set => porcentajeComision = value; }

        [Required(ErrorMessage = "La meta de ventas es requerida")]
        public string MetaVentas { get => metaVentas; set => metaVentas = value; }
    }
}
