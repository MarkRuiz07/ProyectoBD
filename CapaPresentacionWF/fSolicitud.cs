﻿using System;
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
    public partial class fSolicitud : Form
    {
        logicaNegocioSolicitud logicaNS = new logicaNegocioSolicitud();
        public fSolicitud()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Solicitud objetoSolicitud = new Solicitud();
                    objetoSolicitud.aula = textBoxAula.Text;
                    objetoSolicitud.nivel = textBoxNivel.Text;
                    objetoSolicitud.fechasolicitud = dateTimePickerFS.Value;
                    objetoSolicitud.fechauso = dateTimePickerFU.Value;
                    objetoSolicitud.horainicio = textBoxHoraInicio.Text;
                    objetoSolicitud.horafinal = textBoxHoraFinal.Text;
                    objetoSolicitud.carrera = textBoxCarrera.Text;
                    objetoSolicitud.idrecursos = Convert.ToInt32(textBoxIDRecursos.Text);
                    objetoSolicitud.idusuario = Convert.ToInt32(textBoxIDUsuario.Text);
                    objetoSolicitud.asignatura = textBoxAsignatura.Text;

                    if (logicaNS.insertarSolicitud(objetoSolicitud) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud();
                        textBoxAula.Text = "";
                        textBoxNivel.Text = "";
                        dateTimePickerFS.Text = "";
                        dateTimePickerFU.Text = "";
                        textBoxHoraInicio.Text = "";
                        textBoxHoraFinal.Text = "";
                        textBoxCarrera.Text = "";
                        textBoxIDRecursos.Text = "";
                        textBoxIDUsuario.Text = "";
                        textBoxAsignatura.Text = "";


                        tabSolicitud.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Solicitud");
                    }

                }

                if (buttonGuardar.Text == "Actualizar")
                {
                    Solicitud objetoSolicitud = new Solicitud();
                    objetoSolicitud.idsolicitud = Convert.ToInt32(textBoxID.Text);
                    objetoSolicitud.aula = textBoxAula.Text;
                    objetoSolicitud.nivel = textBoxNivel.Text;
                    objetoSolicitud.fechasolicitud = dateTimePickerFS.Value;
                    objetoSolicitud.fechauso = dateTimePickerFU.Value;
                    objetoSolicitud.horainicio = textBoxHoraInicio.Text;
                    objetoSolicitud.horafinal = textBoxHoraFinal.Text;
                    objetoSolicitud.carrera = textBoxCarrera.Text;
                    objetoSolicitud.idrecursos = Convert.ToInt32(textBoxIDRecursos.Text);
                    objetoSolicitud.idusuario = Convert.ToInt32(textBoxIDUsuario.Text);
                    objetoSolicitud.asignatura = textBoxAsignatura.Text;

                    if (logicaNS.EditarSolicitud(objetoSolicitud) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud();
                        textBoxAula.Text = "";
                        textBoxNivel.Text = "";
                        dateTimePickerFS.Text = "";
                        dateTimePickerFU.Text = "";
                        textBoxHoraInicio.Text = "";
                        textBoxHoraFinal.Text = "";
                        textBoxCarrera.Text = "";
                        textBoxIDRecursos.Text = "";
                        textBoxIDUsuario.Text = "";
                        textBoxAsignatura.Text = "";
                        tabSolicitud.SelectedTab = tabPage2;

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSolicitud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fSolicitud_Load(object sender, EventArgs e)
        {
            textBoxID.Visible = false; //Ocultando ID
            labelID.Visible = false;
            dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud();


            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoSoli = Convert.ToInt32(dataGridViewSolicitud.CurrentRow.Cells["idsolicitud"].Value.ToString());
            try
            {
                if (logicaNS.eliminarSolicitud(codigoSoli) > 0) //accede al metodo eliminar definido en CapaDatos
                {
                    MessageBox.Show("Eliminado con éxito!");
                    dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud(); //muestra la lista de datos existentes
                }

            }
            catch
            {

                MessageBox.Show("ERROR al eliminar solicitud");
            }

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            textBoxID.Visible = true;
            textBoxID.Enabled = false;
            labelID.Visible = true;

            textBoxID.Text = dataGridViewSolicitud.CurrentRow.Cells["idsolicitud"].Value.ToString();
            textBoxAula.Text = dataGridViewSolicitud.CurrentRow.Cells["aula"].Value.ToString();
            textBoxNivel.Text = dataGridViewSolicitud.CurrentRow.Cells["nivel"].Value.ToString();
            dateTimePickerFS.Value = Convert.ToDateTime(dataGridViewSolicitud.CurrentRow.Cells["fechasolicitud"].Value);
            dateTimePickerFS.Value = Convert.ToDateTime(dataGridViewSolicitud.CurrentRow.Cells["fechauso"].Value);
            textBoxHoraInicio.Text = dataGridViewSolicitud.CurrentRow.Cells["horainicio"].Value.ToString();
            textBoxHoraFinal.Text = dataGridViewSolicitud.CurrentRow.Cells["horafinal"].Value.ToString();
            textBoxCarrera.Text = dataGridViewSolicitud.CurrentRow.Cells["carrera"].Value.ToString();
            textBoxIDRecursos.Text = dataGridViewSolicitud.CurrentRow.Cells["idrecursos"].Value.ToString();
            textBoxIDUsuario.Text = dataGridViewSolicitud.CurrentRow.Cells["idusuarios"].Value.ToString();
            textBoxAsignatura.Text = dataGridViewSolicitud.CurrentRow.Cells["asignatura"].Value.ToString();

            tabSolicitud.SelectedTab = tabPage1; 
            buttonGuardar.Text = "Actualizar";

        }
    }
    
}
