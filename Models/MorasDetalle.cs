using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_2_2_2021.Models
{
    public class MorasDetalle
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required(ErrorMessage = "Es obligatorio introducir el codigo de la Mora.")]
        public int MoraId { get; set; }

        [Required(ErrorMessage = "Es obligatorio elegir el prestamo.")]
        public int? PrestamoId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el valor.")]
        public float Valor { get; set; } = 0f;

    }
}
