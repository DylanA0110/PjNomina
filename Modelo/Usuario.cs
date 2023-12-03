using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string segundoNombre;
        private string primerApellido;
        private string segundoApellido;
        private string nombre_usuario;
        private string password;
        private string correo_electronico;
        private string telefono;
        private DateTime fechaNac;
        private DateTime fechaRegistro;
        private DateTime ultimoAcceso;
        private int idRol;

        [Required(ErrorMessage = "El ID es requerido")]
        public int ID {get => id;set => id = value;}

        [Required(ErrorMessage = "El nombre es requerido.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El nombre debe contener solo letras.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres.")]
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        [Required(ErrorMessage = "El segundo nombre es requerido.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El segundo nombre debe contener solo letras.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El segundo nombre debe tener entre 3 y 50 caracteres.")]
        public string SegundoNombre
        {
            get => segundoNombre;
            set => segundoNombre = value;
        }

        [Required(ErrorMessage = "El primer apellido es requerido.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El primer apellido debe contener solo letras.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El primer apellido debe tener entre 3 y 50 caracteres.")]
        public string PrimerApellido
        {
            get => primerApellido;
            set => primerApellido = value;
        }

        [Required(ErrorMessage = "El segundo apellido es requerido.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El segundo apellido debe contener solo letras.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El segundo apellido debe tener entre 3 y 50 caracteres.")]
        public string SegundoApellido
        {
            get => segundoApellido;
            set => segundoApellido = value;
        }

        [Required(ErrorMessage = "El nombre de usuario es requerido.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre de usuario debe tener entre 3 y 50 caracteres.")]
        public string NombreUsuario
        {
            get => nombre_usuario;
            set => nombre_usuario = value;
        }

        [Required(ErrorMessage = "La contraseña es requerida.")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public string Password
        {
            get => password;
            set => password = value;
        }

        [Required(ErrorMessage = "El correo electrónico es requerido.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        [StringLength(100, ErrorMessage = "El correo electrónico debe tener como máximo 100 caracteres.")]
        public string CorreoElectronico
        {
            get => correo_electronico;
            set => correo_electronico = value;
        }

        [Required(ErrorMessage = "La fecha de nacimiento es requerida.")]
        [DataType(DataType.Date)]
        public DateTime FechaNac
        {
            get => fechaNac;
            set => fechaNac = value;
        }

        public DateTime FechaRegistro
        {
            get => fechaRegistro;
            set => fechaRegistro = value;
        }

        public DateTime UltimoAcceso
        {
            get => ultimoAcceso;
            set => ultimoAcceso = value;
        }

        [Required(ErrorMessage = "El ID de rol es requerido.")]
        public int IdRol
        {
            get => idRol;
            set => idRol = value;
        }

        [Required(ErrorMessage = "El teléfono es requerido")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "El teléfono debe tener solo 8 dígitos.")]
        public string Telefono
        {
            get => telefono;
            set => telefono = value;
        }

    }
}
