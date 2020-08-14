using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class EscuelaDbContext : DbContext
    {
        public EscuelaDbContext()
            : base("EscuelaDBContext")
        {

        }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
    }
}