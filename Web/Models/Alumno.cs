using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Alumno : Plantilla
    {
       
        public string NumMatricula { get; set; }
        public int Edad { get; set; }
        public int Semestre { get; set; }
        public string Genero { get; set; }

        [ForeignKey("FKCarreras")]
        public int CarreraId { get; set; }  
        public virtual Carrera FKCarreras { get; set; }
    }
}