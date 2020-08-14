using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Plantilla
    {
        [Column(Order = 1)]
        public int Id { get; set; }

        [Column(TypeName = "NVARCHAR", Order = 2)]
        [StringLength(40)]

        [Index("IndexNombre", IsClustered = false, IsUnique = false)]
        public string Nombre { get; set; }
    }
    public class Carrera : Plantilla
    {
        public string duracion { get; set; }
        public virtual ICollection<Alumno> Alumnos { get; set; }
    }
}