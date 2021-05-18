using System;
using System.ComponentModel.DataAnnotations;

namespace Tarea_2_2_2021.Models
{
	public class Usuarios
    {
    	[Key]
    	public int UsuarioId { get; set; }

    	[Required(ErrorMessage ="Es obligatorio introducir el nombre")]
    	public string Nombre { get; set; }

    	[Required(ErrorMessage ="Es obligatorio introducir el telefono")]
    	public string Telefono { get; set; }

    	[Required(ErrorMessage ="Es obligatorio introducir el cedula")]
    	public string Cedula { get; set; }

    	[Required(ErrorMessage ="Es obligatorio introducir el dirección")]
    	public string Direccion {get; set; }

    	public DateTime FechaNacimiento { get; set; }
    }
}