using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using capaEntidades;

namespace CapaNegocio
{
   public class logicaNegocioCuentas
    {
        public class logicaNegocioComentarios
        {
            accesoDatosCuentas acu = new accesoDatosCuentas();

            public int insertarCuentas(Cuentas cu)
            {
                return acu.insertarCuentas(cu);
            }

            public List<Cuentas> listarCuentas()
            {
                return acu.listarCuentas();
            }

            public int eliminarCuentas(int idcuent)
            {

                return acu.eliminarCuentas(idcuent);
            }

            public int EditarCuentas(Cuentas cu)
            {
                return acu.EditarCuentas(cu);
            }

            public List<Cuentas> BuscarCuentas(string dato)
            {
                return acu.BuscarCuentas(dato);

            }
        }
    }
}
