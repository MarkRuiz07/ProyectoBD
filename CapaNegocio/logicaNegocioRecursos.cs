using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using capaEntidades;

namespace CapaNegocio
{
   public class logicaNegocioRecursos
    {
        
        accesoDatosRecursos ar = new accesoDatosRecursos();

        public int insertarRecursos(Recursos r)
        {
            return ar.insertarRecursos(r);
        }

        public List<Recursos> listarRecursos()
        {
            return ar.listarRecursos();
        }

        public int EliminarRecursos(int idrec)
        {

            return ar.EliminarRecursos(idrec);
        }

        public int EditarRecursos(Recursos r)
        {
            return ar.EditarRecursos(r);
        }

        public List<Recursos> BuscarRecursos(string dato)
        {
            return ar.BuscarRecursos(dato);

        }
        
    }
}
