using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using CapaDatos;

namespace CapaNegocio
{
  public  class logicaNegocioSolicitud
    {

            accesoDatosSolicitud acs = new accesoDatosSolicitud();

            public int insertarSolicitud(Solicitud s)
            {
                return acs.insertarSolicitud(s);
            }

            public List<Solicitud> listarSolicitud()
            {
                return acs.listarSolicitud();
            }

            public int eliminarSolicitud(int idsolici)
            {

                return acs.eliminarSolicitud(idsolici);
            }

            public int EditarSolicitud(Solicitud s)
            {
                return acs.EditarSolicitud(s);
            }

            public List<Solicitud> BuscarSolicitud(string dato)
            {
                return acs.BuscarSolicitud(dato);

            }

    }
}
