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
    public class accesoDatosCuentas
    {
        SqlConnection cnx; //Conexion 
        Cuentas ct = new Cuentas(); //Capa Entidades 
        Conexion cn = new Conexion(); //Conexion
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar CRUD
        //Para cargar datos
        SqlDataReader dr = null;
        List<Cuentas> listaCuentas = null;
        public int insertarCuentas(Cuentas ct)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //Conexion

                cm = new SqlCommand("LasCuentas", cnx); //Nombre del procedimiento 
                cm.Parameters.AddWithValue("@b", 1); //Valores que toman los parametros
                cm.Parameters.AddWithValue("@idcuenta", ""); //del procedimiento
                cm.Parameters.AddWithValue("@nombreuser", ct.nombreuser);
                cm.Parameters.AddWithValue("@clave", ct.clave);
                cm.Parameters.AddWithValue("@rol", ct.rol);
                cm.Parameters.AddWithValue("@idusuario", ct.idusuario);

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

        public List<Cuentas> listarCuentas()
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("LasCuentas", cnx);
                cm.Parameters.AddWithValue("b", 3);
                cm.Parameters.AddWithValue("@idcuentas", "");
                cm.Parameters.AddWithValue("@nombreuser", "");
                cm.Parameters.AddWithValue("@clave", "");
                cm.Parameters.AddWithValue("@rol", "");
                cm.Parameters.AddWithValue("@idusuario", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCuentas = new List<Cuentas>(); //Lista de cuentas
                while (dr.Read()) //Recorrer cada registro
                {
                    Comentarios c = new Comentarios();
                    ct.idcuentas = Convert.ToInt32(dr["idcuentas"].ToString());
                    ct.nombreuser = dr["nombreuser"].ToString();
                    ct.clave = dr["clave"].ToString();
                    ct.rol = dr["rol"].ToString();
                    ct.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    listaCuentas.Add(ct); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCuentas = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaCuentas; //regresa lista de registros



        }

        public int eliminarCuentas(int idcuent)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("LasCuentas", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idcuentas", idcuent); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@nombreuser", "");
                cm.Parameters.AddWithValue("@clave", "");
                cm.Parameters.AddWithValue("@rol", "");
                cm.Parameters.AddWithValue("@idusuario", "");

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
        public int EditarCuentas( Cuentas cu)
        {

            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("LasCuentas", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("idcuentas", cu.idcuentas); //parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("nombreuser", "");
                cm.Parameters.AddWithValue("clave", "");
                cm.Parameters.AddWithValue("rol", cu.rol);
                cm.Parameters.AddWithValue("@idusuario", "");

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

        public List<Cuentas> BuscarCuentas(String dato)
        {
            try
            {

                SqlConnection cnx = cn.conectar(); //Conexion
                cm = new SqlCommand("LasCuentas", cnx);
                cm.Parameters.AddWithValue("b", 5);
                cm.Parameters.AddWithValue("@idcuentas", dato);
                cm.Parameters.AddWithValue("@nombreuser", "");
                cm.Parameters.AddWithValue("@clave", "");
                cm.Parameters.AddWithValue("@rol", dato);
                cm.Parameters.AddWithValue("@idusuario", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCuentas = new List<Cuentas>(); //Lista de comentarios
                while (dr.Read()) //Recorrer cada registro
                {
                    Cuentas cu = new Cuentas();
                    cu.idcuentas = Convert.ToInt32(dr["idcuentas"].ToString());
                    cu.nombreuser = dr["nombreuser"].ToString();
                    cu.clave = dr["clave"].ToString();
                    cu.rol = dr["rol"].ToString();
                    cu.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    listaCuentas.Add(cu); //Agregar registros encontrados a lista 
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCuentas = null;

            }
            finally
            { cm.Connection.Close(); }
            return listaCuentas; //regresa lista de registros



        }
    }
}
