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
   public class accesoDatosRecursos
    {
        SqlConnection cnx; //Conexion 
        Recursos r = new Recursos(); //Capa Entidades 
        Conexion cn = new Conexion(); //Conexion
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar CRUD
        //Para cargar datos
        SqlDataReader dr = null;
        List<Recursos> listaRecursos = null;
        public int insertarRecursos(Recursos r)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion

                cm = new SqlCommand("LosRecursos", cnx); //Nombre del procedimiento 
                cm.Parameters.AddWithValue("@b", 1); //Valores que toman los parametros
                cm.Parameters.AddWithValue("@idrecursos", ""); //del procedimiento
                cm.Parameters.AddWithValue("@nombrer", r.nombrer);
                cm.Parameters.AddWithValue("@codigo", r.codigo);
                cm.Parameters.AddWithValue("@descripcion", r.descripcion);
                

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

        public List<Recursos> listarRecursos()
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("LosRecursos", cnx);
                cm.Parameters.AddWithValue("b", 3);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");
                
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaRecursos = new List<Recursos>(); //Lista de comentarios
                while (dr.Read()) //Recorrer cada registro
                {
                    Recursos r = new Recursos();
                    r.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    r.nombrer = dr["nombrer"].ToString();
                    r.codigo = dr["codigo"].ToString();
                    r.descripcion = dr["descripcion"].ToString();
                    
                    listaRecursos.Add(r); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaRecursos = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaRecursos; //regresa lista de registros



        }

        public int EliminarRecursos(int idrec)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("LosRecursos", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idrecursos", idrec); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

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
        public int EditarRecursos(Recursos r)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("LosRecursos", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("idrecursos", r.idrecursos); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("nombrer", "");
                cm.Parameters.AddWithValue("codigo", "");
                cm.Parameters.AddWithValue("@descripcion", r.descripcion);

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

        public List<Recursos> BuscarRecursos(String dato)
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("LosRecursos", cnx);
                cm.Parameters.AddWithValue("b", 5);
                cm.Parameters.AddWithValue("@idrecursos", dato);
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaRecursos = new List<Recursos>(); //Lista de comentarios
                while (dr.Read()) //Recorrer cada registro
                {
                    Recursos r = new Recursos();
                    r.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    r.nombrer = dr["nombrer"].ToString();
                    r.codigo = dr["codigo"].ToString();
                    r.descripcion = dr["descripcion"].ToString();

                    listaRecursos.Add(r); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaRecursos = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaRecursos; //regresa lista de registros



        }
    }
}
