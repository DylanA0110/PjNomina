using System.ComponentModel.DataAnnotations;

namespace Modelo
{ 
    public class Empleado
    {
        private int idEmpleado{ get; set; }
        private string numeroCedula { get; set; }
        private string numeroINSS { get; set; }
        private string numeroRUC { get; set; }
        private string primerNombre { get; set; }
        private string segundoNombre { get; set; }
        private string primerApellido { get; set; }
        private string segundoApellido { get; set; }
        private DateTime fechaNacimiento { get; set; }
        private string sexo { get; set; }
        private string estadoCivil { get; set; }
        private string direccion { get; set; }
        private string telefono { get; set; }
        private string celular { get; set; }
        private DateTime fechaContratacion { get; set; }
        private DateTime fechaCierreContrato { get; set; }
        private decimal salarioOrdinario { get; set; }
        private bool activo{ get; set; }
        private int idHorario { get; set; }
        private int idCargo { get; set; }
        private List<Nomina> Nominas { get; set; }

        [Required(ErrorMessage = "El ID del empleado es requerido")]
        public int IDEmpleado{ get => idEmpleado; set => idEmpleado = value; }

        [Required(ErrorMessage = "La cedula es requerida")]
        [RegularExpression(@"^\d{3}-\d{6}-\d{4}[A-Z]$", ErrorMessage = "El formato de la cédula no es válido.")]
        public string NumeroCedula { get => numeroCedula; set => numeroCedula = value; }

        [Required(ErrorMessage = "El numero INSS es requerido")]
        [RegularExpression(@"^\d{7}-\d{1}$", ErrorMessage = "El formato del numero INSS no es válido.")]
        public string NumeroINSS { get => numeroINSS;set => numeroINSS = value; }

        [Required(ErrorMessage = "El numero RUC es requerido")]
        public string NumeroRUC { get => numeroRUC; set => numeroRUC = value;}

        [Required(ErrorMessage = "El primer nombre es requerido.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El nombre debe contener solo letras.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres.")]
        public string PrimerNombre {get => primerNombre;set => primerNombre = value;}

        [Required(ErrorMessage = "El segundo nombre es requerido.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El segundo nombre debe contener solo letras.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El segundo nombre debe tener entre 3 y 50 caracteres.")]
        public string SegundoNombre { get => segundoNombre;set => segundoNombre = value;}

        [Required(ErrorMessage = "El primer apellido es requerido.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El primer apellido debe contener solo letras.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El primer apellido debe tener entre 3 y 50 caracteres.")]
        public string PrimerApellido {get => primerApellido;set => primerApellido = value;}

        [Required(ErrorMessage = "El segundo apellido es requerido.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El segundo apellido debe contener solo letras.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El segundo apellido debe tener entre 3 y 50 caracteres.")]
        public string SegundoApellido{get => segundoApellido;set => segundoApellido = value;}


        [Required(ErrorMessage = "La fecha de nacimiento es requerida.")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento
        {get => fechaNacimiento;set => fechaNacimiento = value;}

        [Required(ErrorMessage = "El sexo es requerido")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El sexo debe contener solo letras")]
        public string Sexo { get => sexo; set => sexo = value; }

        [Required(ErrorMessage = "El estado civil es requerido")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El estado civil debe contener solo letras")]
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

        [Required(ErrorMessage = "La dirección es requerida")]
        public string Direccion { get => direccion; set => direccion = value; }

        [Required(ErrorMessage = "El teléfono es requerido")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "El teléfono debe tener solo 8 dígitos")]
        public string Telefono { get => telefono; set => telefono = value; }

        [Required(ErrorMessage = "El celular es requerido")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "El celular debe tener solo 8 dígitos")]
        public string Celular { get =>  celular; set => celular = value; }

        [Required(ErrorMessage = "La fecha de contratación es requerida")]
        [DataType(DataType.Date)]
        public DateTime FechaContratacion { get => fechaContratacion; set => fechaContratacion = value; }
        [Required(ErrorMessage = "La fecha de contratación es requerida")]
        [DataType(DataType.Date)]
        public DateTime FechaCierreContrato { get => fechaCierreContrato; set => fechaCierreContrato = value; }

        [Required(ErrorMessage = "El salario ordinario es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El salario ordinario debe ser mayor o igual a 0")]
        public decimal SalarioOrdinario { get => salarioOrdinario; set => salarioOrdinario = value; }

        [Required(ErrorMessage = "El estado es requerido")]
        public bool Activo { get => activo; set => activo = value; }

        [Required(ErrorMessage = "El Horario es requerido")]
        public int IDHorario { get => idHorario;set => idHorario = value; }

        [Required(ErrorMessage = "El Cargo es requerido")]
        public int IDCargo { get => idCargo;set => idCargo = value; }

    }
}
