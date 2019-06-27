using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    class logicaNegocioUsuarios
    {
       
            accesoDatosUsuarios au = new accesoDatosUsuarios();

            public int insertarComentarios(Usuarios u)
            {
                return au.insertarUsuarios(u);
            }

            public List<Usuarios> listarUsuarios()
            {
                return au.listarUsuarios();
            }

            public int eliminarUsuarios(int idusu)
            {

                return au.eliminarUsuarios(idusu);
            }

            public int editarUsuarios(Usuarios u)
            {
                return au.editarUsuarios(u);
            }

            public List<Usuarios> BuscarComentarios(string dato)
            {
                return au.BuscarUsuarios(dato);

            }
        }
    
}
