using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_2_2_2021.Models;

namespace Tarea_2_2_2021.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Prestamos> Prestamos { get; set; }

        public DbSet<MorasDetalle> MorasDetalle { get; set; }

        public DbSet<Moras> Moras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data\Registros.db");
        }

    }
}
