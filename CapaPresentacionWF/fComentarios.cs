using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidades;
using CapaNegocio;

namespace CapaPresentacionWF
{
    public partial class fComentarios : Form
    {

        logicaNegocioComentarios logicaNC = new logicaNegocioComentarios(); //Instancia
        private readonly object textBoxDescripcion;

        public fComentarios()
        {
            InitializeComponent();
        }

        public object TabComentarios { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Comentarios objetoComentario = new Comentarios();
                    objetoComentario.nombres = textBoxNombres.Text;
                    objetoComentario.correo = textBoxCorreo.Text;
                    objetoComentario.telefono = textBoxTelefono.Text;
                    objetoComentario.mensaje = textBoxMensaje.Text;

                    if (logicaNC.insertarComentarios(objetoComentario) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewComentarios.DataSource = logicaNC.listarComentarios();
                        textBoxNombres.Text = "";
                        textBoxCorreo.Text = "";
                        textBoxTelefono.Text = "";
                        textBoxMensaje.Text = "";
                        tabComentarios.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Recurso");
                    }

                }

                if (buttonGuardar.Text == "Actualizar")
                {
                    Comentarios objetoComentario = new Comentarios();
                    objetoComentario.idcomentario = Convert.ToInt32(textBoxID.Text);
                    objetoComentario.nombres = textBoxNombres.Text;
                    objetoComentario.correo = textBoxCorreo.Text;
                    objetoComentario.telefono = textBoxTelefono.Text;
                    objetoComentario.mensaje = textBoxMensaje.Text;

                    if (logicaNC.EditarComentarios(objetoComentario) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewComentarios.DataSource = logicaNC.listarComentarios();
                        textBoxNombres.Text = "";
                        textBoxCorreo.Text = "";
                        textBoxTelefono.Text = "";
                        textBoxMensaje.Text = "";
                        tabComentarios.SelectedTab = tabPage2;

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Recurso");
                    }
                    buttonGuardar.Text = "Guardar";
                }

            }

            catch
            {

                MessageBox.Show("ERROR");
            }

        }
    }

   }

