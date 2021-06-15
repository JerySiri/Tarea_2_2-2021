using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Tarea_2_2_2021.Models;

namespace Tarea_2_2_2021.Models
{
    public class Moras
    {
        [Key]
        public int MoraId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public float Total { get; set; }

        [ForeignKey("MoraId")]
        public virtual List<MorasDetalle> MorasDetalle { get; set; } = new List<MorasDetalle>(); 
    }
}
