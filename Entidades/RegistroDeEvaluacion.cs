using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1AP1.Entidades
{
   public class RegistroDeEvaluacion
    {
        [Key]
        public int Id { get; set; }
        public string Estudiante { get; set; }
        public DateTime Fecha { get; set; }
        

        public RegistroDeEvaluacion()
        {
            Id = 0;
            Estudiante = string.Empty;
            Fecha = DateTime.Now;

        }

        public RegistroDeEvaluacion (int id, string estudiante, DateTime fecha)
        {
            Id = id;
            Estudiante = estudiante;
            Fecha = fecha;
        }
    }
}
