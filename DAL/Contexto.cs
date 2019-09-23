using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Parcial1AP1.Entidades;

namespace Parcial1AP1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public Contexto() : base("ConStr")
    {

    }
   
  }


    
}
