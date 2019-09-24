using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Parcial1AP1.DAL;
using Parcial1AP1.Entidades;

namespace Parcial1AP1.BLL
{
    public class RegistroDeEvaluacionesBLL
    {
        public static bool Guardar(Estudiante estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Estudiantes.Add(estudiante) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


    }
}
