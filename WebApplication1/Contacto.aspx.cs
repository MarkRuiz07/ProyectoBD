using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using capaEntidades;

namespace WebApplication1
{
    public partial class Contacto : System.Web.UI.Page
    {

        Comentarios CE = new Comentarios();
        logicaNegocioComentarios CN = new logicaNegocioComentarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btcontacto_Click(object sender, EventArgs e)
        {
            try
            {
                //Asignando valores de los cuadros de texto
                CE.nombres = txtnombres.Value;
                CE.correo = txtcorreo.Value;
                CE.telefono = txttelefono.Value;
                CE.mensaje = txtmensaje.Value;

                //Llamada al método insertar con el objeto comentario como parámetro
                if (CN.insertarComentarios(CE) == 1)
                {
                    indicador.Text = "Enviado!!!";
                    indicador.CssClass = "label label-sucess";

                    txtnombres.Value = "";
                    txtcorreo.Value = "";
                    txttelefono.Value = "";
                    txtmensaje.Value = "";

                }
                else
                    //etiqueta

                    indicador.Text = "Error al enviar";
                    indicador.CssClass = "label label-danger";

            }
            catch (Exception ex)
            {

                //Muestra etiqueta la execpcion ocurrida
                indicador.Text = ex.Message.ToString();
            }

        }
    }
}