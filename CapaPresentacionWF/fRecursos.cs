using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using capaEntidades;


namespace CapaPresentacionWF
{
    public partial class fRecursos : Form
    {
        logicaNegocioRecursos logicaNR = new logicaNegocioRecursos(); //Instancia
        public fRecursos()
        {
            InitializeComponent(); 
        }

        private void fRecursos_Load(object sender, EventArgs e)
        {
            textBoxId.Visible = false; //Ocultando ID
            labelID.Visible = false;
            dataGridViewRecursos.DataSource = logicaNR.listarRecursos(); //Cargar Datos

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text== "Guardar")
                {
                    Recursos objetoRecurso = new Recursos();
                    objetoRecurso.nombrer = textBoxNombrer.Text;
                    objetoRecurso.codigo = textBoxCodigo.Text;
                    objetoRecurso.descripcion = textBoxDescripcion.Text;

                    if (logicaNR.insertarRecursos(objetoRecurso)>0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewRecursos.DataSource = logicaNR.listarRecursos();
                        textBoxNombrer.Text = "";
                        textBoxDescripcion.Text = "";
                        textBoxCodigo.Text = "";
                        TabRecursos.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Recurso");
                    }

                }

                if (buttonGuardar.Text=="Actualizar")
                {
                    Recursos objetoRecurso = new Recursos();
                    objetoRecurso.idrecursos = Convert.ToInt32(textBoxId.Text);
                    objetoRecurso.nombrer = textBoxNombrer.Text;
                    objetoRecurso.codigo = textBoxCodigo.Text;
                    objetoRecurso.descripcion = textBoxDescripcion.Text;

                    if (logicaNR.EditarRecursos(objetoRecurso)>0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewRecursos.DataSource = logicaNR.listarRecursos();
                        textBoxNombrer.Text = "";
                        textBoxDescripcion.Text = "";
                        textBoxCodigo.Text = "";
                        TabRecursos.SelectedTab = tabPage2;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true; //Mostrando ID
            textBoxId.Enabled = false;
            labelID.Visible = true;

            //asignando datos seleccionados del dataGridView a las cajas de texto
            textBoxId.Text = dataGridViewRecursos.CurrentRow.Cells["idrecursos"].Value.ToString();
            textBoxNombrer.Text = dataGridViewRecursos.CurrentRow.Cells["nombrer"].Value.ToString();
            textBoxCodigo.Text = dataGridViewRecursos.CurrentRow.Cells["codigo"].Value.ToString();
            textBoxDescripcion.Text = dataGridViewRecursos.CurrentRow.Cells["descripcion"].Value.ToString();

            TabRecursos.SelectedTab = tabPage1; //seleccionar pagina del tab
            buttonGuardar.Text = "Actualizar"; //Cambiando texto del botón Guardar

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Capturar del dataGridView codigo seleccionado para eliminar
            int codigoR = Convert.ToInt32(dataGridViewRecursos.CurrentRow.Cells["idrecursos"].Value.ToString());
            try
            {
                if (logicaNR.EliminarRecursos(codigoR)>0) //accede al metodo eliminar definido en CapaDatos
                {
                    MessageBox.Show("Eliminado con éxito!");
                    dataGridViewRecursos.DataSource = logicaNR.listarRecursos(); //muestra la lista de datos existentes
                }

            }
            catch 
            {

                MessageBox.Show("ERROR al eliminar recurso");
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            //Buscandon según dato escrito en cuadro de texto
            List<Recursos> listaRecursos = logicaNR.BuscarRecursos(textBoxBuscar.Text);
            dataGridViewRecursos.DataSource = listaRecursos;
        }
    }
}
