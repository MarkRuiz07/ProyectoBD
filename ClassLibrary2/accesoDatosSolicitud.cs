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
   public class accesoDatosSolicitud
    {
        SqlConnection cnx; //Conexion 
        Solicitud so = new Solicitud(); //Capa Entidades 
        Conexion cn = new Conexion(); //Conexion
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar CRUD
        //Para cargar datos
        SqlDataReader dr = null;
        List<Solicitud> listaSolicitud = null;
        public int insertarSolicitud(Solicitud so)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion

                cm = new SqlCommand("LaSolicitud", cnx); //Nombre del procedimiento 
                cm.Parameters.AddWithValue("@b", 1); //Valores que toman los parametros
                cm.Parameters.AddWithValue("@idsolicitud", ""); //del procedimiento
                cm.Parameters.AddWithValue("@aula", so.aula);
                cm.Parameters.AddWithValue("@nivel", so.nivel);
                cm.Parameters.AddWithValue("@fechasolicitud", so.fechasolicitud);
                cm.Parameters.AddWithValue("@fechauso", so.fechauso);
                cm.Parameters.AddWithValue("@horainicio", so.horainicio);
                cm.Parameters.AddWithValue("@horafinal", so.horafinal);
                cm.Parameters.AddWithValue("@carrera", so.carrera);
                cm.Parameters.AddWithValue("@idrecursos", so.idrecursos);
                cm.Parameters.AddWithValue("@idusuario", so.idusuario);
                cm.Parameters.AddWithValue("@asignatura", so.asignatura);
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

        public List<Solicitud> listarSolicitud()
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("LaSolicitud", cnx);
                cm.Parameters.AddWithValue("b", 3);
                cm.Parameters.AddWithValue("@idsolicitud", "");
                cm.Parameters.AddWithValue("@aula", "");
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolicitud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@asignatura", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaSolicitud = new List<Solicitud>(); //Lista de comentarios
                while (dr.Read()) //Recorrer cada registro
                {
                    Solicitud s = new Solicitud();
                    s.idsolicitud = Convert.ToInt32(dr["idsolicitud"].ToString());
                    s.aula = dr["aula"].ToString();
                    s.nivel = dr["nivel"].ToString();
                    s.fechasolicitud = dr["fechasolicitud"].ToString();
                    s.fechauso = dr["fechauso"].ToString();
                    s.horainicio = dr["horainicio"].ToString();
                    s.horafinal = dr["horafinal"].ToString();
                    s.carrera = dr["carrera"].ToString();
                    s.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    s.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    s.asignatura = dr["asignatura"].ToString();

                    listaSolicitud.Add(s); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaSolicitud = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaSolicitud; //regresa lista de registros



        }

        public int eliminarSolicitud(int idsolici)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("LaSolicitud", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idsolicitud", idsolici); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@aula", "");
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolicitud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@asignatura", "");


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
        public int EditarSolicitud(Solicitud s)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("LaSolicitud", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("idsolicitud", s.idsolicitud); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@aula", s.aula);
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolicitud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@asignatura", "");

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

        public List<Solicitud> BuscarSolicitud(String dato)
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("LaSolicitud", cnx);
                cm.Parameters.AddWithValue("b", 6);
                cm.Parameters.AddWithValue("@idsolicitud", dato);
                cm.Parameters.AddWithValue("@aula", dato);
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolicitud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", dato);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@asignatura", dato);


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaSolicitud = new List<Solicitud>(); //Lista de comentarios
                while (dr.Read()) //Recorrer cada registro
                {
                    Solicitud s = new Solicitud();
                    s.idsolicitud = Convert.ToInt32(dr["idsolicitud"].ToString());
                    s.aula = dr["aula"].ToString();
                    s.nivel = dr["nivel"].ToString();
                    s.fechasolicitud = dr["fechasolicitud"].ToString();
                    s.fechauso = dr["fechauso"].ToString();
                    s.horainicio = dr["horainicio"].ToString();
                    s.horafinal = dr["horafinal"].ToString();
                    s.carrera = dr["carrera"].ToString();
                    s.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    s.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    s.asignatura = dr["asignatura"].ToString();

                    listaSolicitud.Add(s); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaSolicitud = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaSolicitud; //regresa lista de registros



        }
    }
}
