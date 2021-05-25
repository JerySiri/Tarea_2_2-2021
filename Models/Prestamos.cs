using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_2_2_2021.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Es obligatorio elegir un Usuario")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el Concepto")]
        public string Concepto { get; set; }

        public float Balance { get; set; } = 0;

        public float Monto { get; set; } = 0;
    }
}
