using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace CapaDatos
{
   public class accesoDatosUsuarios
    {
        SqlConnection cnx; //Conexion 
        Usuarios u = new Usuarios(); //Capa Entidades 
        Conexion cn = new Conexion(); //Conexion
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar CRUD
        //Para cargar datos
        SqlDataReader dr = null;
        List<Usuarios> listaUsuarios = null;
        public int insertarUsuarios(Usuarios u)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion

                cm = new SqlCommand("LosUsuarios", cnx); //Nombre del procedimiento 
                cm.Parameters.AddWithValue("@b", 1); //Valores que toman los parametros
                cm.Parameters.AddWithValue("@idusuario", ""); //del procedimiento
                cm.Parameters.AddWithValue("@cedula", u.cedula);
                cm.Parameters.AddWithValue("@nombres", u.nombres);
                cm.Parameters.AddWithValue("@apellidos", u.apellidos);
                cm.Parameters.AddWithValue("@email", u.email);
                cm.Parameters.AddWithValue("@telefono", u.telefono);

                cm.CommandType = CommandType.StoredProcedure; //Tipo de comando ejecutado
                cnx.Open(); //Abrir conexion de BD
                cm.ExecuteNonQuery(); //Ejecucion de consulta
                indicador = 1; //Valor del indicador
            }
            catch (Exception e)
            {
                e.Message.ToString(); //Mostrar mensaje en caso error
                indicador = 0;

            }
            finally
            {
                cm.Connection.Close(); //Cierre de conexion
            }
            return indicador;


        }

        public int editarUsuarios(Usuarios u)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> listarUsuarios()
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("LosUsuarios", cnx);
                cm.Parameters.AddWithValue("b", 3);
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaUsuarios = new List<Usuarios>(); //Lista de comentarios
                while (dr.Read()) //Recorrer cada registro
                {
                    Usuarios c = new Usuarios();
                    u.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    u.cedula = dr["cedula"].ToString();
                    u.nombres = dr["nombres"].ToString();
                    u.apellidos = dr["apellidos"].ToString();
                    u.email = dr["email"].ToString();
                    u.telefono = dr["telefono"].ToString();
                    listaUsuarios.Add(c); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaUsuarios = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaUsuarios; //regresa lista de registros



        }

        public int eliminarUsuarios(int idusu)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("LosUsuarios", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idusuario", idusu); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            { cm.Connection.Close(); }
            return indicador;
        }
        //Editar Comentarios
        public int editarUsuarios(int idusu)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("LosUsuarios", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("idusuario", idusu); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@telefono", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            { cm.Connection.Close(); }
            return indicador;
        }

        public List<Usuarios> BuscarUsuarios(string dato)
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("LosUsuarios", cnx);
                cm.Parameters.AddWithValue("b", 3);
                cm.Parameters.AddWithValue("@idusuario", dato);
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaUsuarios = new List<Usuarios>(); //Lista de comentarios
                while (dr.Read()) //Recorrer cada registro
                {
                    Usuarios c = new Usuarios();
                    u.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    u.cedula = dr["cedula"].ToString();
                    u.nombres = dr["nombres"].ToString();
                    u.apellidos = dr["apellidos"].ToString();
                    u.email = dr["email"].ToString();
                    u.telefono = dr["telefono"].ToString();
                    listaUsuarios.Add(c); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaUsuarios = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaUsuarios; //regresa lista de registros



        }

    }
}
