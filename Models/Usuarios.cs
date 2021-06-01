using System;
using System.ComponentModel.DataAnnotations;

namespace Tarea_2_2_2021.Models
{
	public class Usuarios
    {
    	[Key]
    	public int UsuarioId { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir el nombre.")]
        [MinLength(4, ErrorMessage = "El Nombre debe tener por lo menos 4 caracteres.")]
        public string Nombre { get; set; }
        
    	[Required(ErrorMessage ="Es obligatorio introducir el telefono")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",ErrorMessage = "Introdusca el formato valido de numero de Teléfono Ejemplo: 000-000-0000")]
        public string Telefono { get; set; }

    	[Required(ErrorMessage ="Es obligatorio introducir el cedula")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{7})[-. ]?([0-9]{1})$", ErrorMessage = "Introdusca el formato valido de la Cédula Ejemplo: 000-0000000-0")]
        public string Cedula { get; set; }

    	[Required(ErrorMessage ="Es obligatorio introducir el dirección.")]
    	public string Direccion {get; set; }

        public DateTime FechaNacimiento { get; set; } = DateTime.Now;

        public float Balance { get; set; } = 0;
    }
}