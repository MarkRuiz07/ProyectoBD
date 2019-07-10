namespace CapaPresentacionWF
{
    partial class fSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabSolicitud = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelSolicitud = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNivel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFechaSolicitud = new System.Windows.Forms.TextBox();
            this.labelFechaUso = new System.Windows.Forms.Label();
            this.textBoxFechaUso = new System.Windows.Forms.TextBox();
            this.labelHoraInicio = new System.Windows.Forms.Label();
            this.textBoxHoraInicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHoraFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCarrera = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAsignatura = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.Editar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dataGridViewSolicitud = new System.Windows.Forms.DataGridView();
            this.tabSolicitud.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSolicitud
            // 
            this.tabSolicitud.Controls.Add(this.tabPage1);
            this.tabSolicitud.Controls.Add(this.tabPage2);
            this.tabSolicitud.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSolicitud.Location = new System.Drawing.Point(0, -1);
            this.tabSolicitud.Name = "tabSolicitud";
            this.tabSolicitud.SelectedIndex = 0;
            this.tabSolicitud.Size = new System.Drawing.Size(805, 493);
            this.tabSolicitud.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxAsignatura);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBoxCarrera);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxHoraFinal);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxHoraInicio);
            this.tabPage1.Controls.Add(this.labelHoraInicio);
            this.tabPage1.Controls.Add(this.textBoxFechaUso);
            this.tabPage1.Controls.Add(this.labelFechaUso);
            this.tabPage1.Controls.Add(this.textBoxFechaSolicitud);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxNivel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxAula);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelSolicitud);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewSolicitud);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.Editar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelSolicitud
            // 
            this.labelSolicitud.AutoSize = true;
            this.labelSolicitud.BackColor = System.Drawing.Color.Orange;
            this.labelSolicitud.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolicitud.Location = new System.Drawing.Point(300, 12);
            this.labelSolicitud.Name = "labelSolicitud";
            this.labelSolicitud.Size = new System.Drawing.Size(158, 22);
            this.labelSolicitud.TabIndex = 0;
            this.labelSolicitud.Text = "Registrar Solicitud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(240, 53);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(271, 20);
            this.textBoxID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aula";
            // 
            // textBoxAula
            // 
            this.textBoxAula.Location = new System.Drawing.Point(240, 88);
            this.textBoxAula.Name = "textBoxAula";
            this.textBoxAula.Size = new System.Drawing.Size(271, 20);
            this.textBoxAula.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nivel";
            // 
            // textBoxNivel
            // 
            this.textBoxNivel.Location = new System.Drawing.Point(240, 125);
            this.textBoxNivel.Name = "textBoxNivel";
            this.textBoxNivel.Size = new System.Drawing.Size(271, 20);
            this.textBoxNivel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Solicitud";
            // 
            // textBoxFechaSolicitud
            // 
            this.textBoxFechaSolicitud.Location = new System.Drawing.Point(240, 162);
            this.textBoxFechaSolicitud.Name = "textBoxFechaSolicitud";
            this.textBoxFechaSolicitud.Size = new System.Drawing.Size(271, 20);
            this.textBoxFechaSolicitud.TabIndex = 8;
            // 
            // labelFechaUso
            // 
            this.labelFechaUso.AutoSize = true;
            this.labelFechaUso.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaUso.Location = new System.Drawing.Point(156, 202);
            this.labelFechaUso.Name = "labelFechaUso";
            this.labelFechaUso.Size = new System.Drawing.Size(78, 18);
            this.labelFechaUso.TabIndex = 9;
            this.labelFechaUso.Text = "Fecha Uso";
            // 
            // textBoxFechaUso
            // 
            this.textBoxFechaUso.Location = new System.Drawing.Point(240, 202);
            this.textBoxFechaUso.Name = "textBoxFechaUso";
            this.textBoxFechaUso.Size = new System.Drawing.Size(271, 20);
            this.textBoxFechaUso.TabIndex = 10;
            // 
            // labelHoraInicio
            // 
            this.labelHoraInicio.AutoSize = true;
            this.labelHoraInicio.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraInicio.Location = new System.Drawing.Point(154, 242);
            this.labelHoraInicio.Name = "labelHoraInicio";
            this.labelHoraInicio.Size = new System.Drawing.Size(80, 18);
            this.labelHoraInicio.TabIndex = 11;
            this.labelHoraInicio.Text = "Hora Inicio";
            // 
            // textBoxHoraInicio
            // 
            this.textBoxHoraInicio.Location = new System.Drawing.Point(240, 242);
            this.textBoxHoraInicio.Name = "textBoxHoraInicio";
            this.textBoxHoraInicio.Size = new System.Drawing.Size(270, 20);
            this.textBoxHoraInicio.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hora Final";
            // 
            // textBoxHoraFinal
            // 
            this.textBoxHoraFinal.Location = new System.Drawing.Point(240, 279);
            this.textBoxHoraFinal.Name = "textBoxHoraFinal";
            this.textBoxHoraFinal.Size = new System.Drawing.Size(270, 20);
            this.textBoxHoraFinal.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Carrera";
            // 
            // textBoxCarrera
            // 
            this.textBoxCarrera.Location = new System.Drawing.Point(239, 317);
            this.textBoxCarrera.Name = "textBoxCarrera";
            this.textBoxCarrera.Size = new System.Drawing.Size(271, 20);
            this.textBoxCarrera.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Asignatura";
            // 
            // textBoxAsignatura
            // 
            this.textBoxAsignatura.Location = new System.Drawing.Point(240, 355);
            this.textBoxAsignatura.Name = "textBoxAsignatura";
            this.textBoxAsignatura.Size = new System.Drawing.Size(271, 20);
            this.textBoxAsignatura.TabIndex = 18;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Orange;
            this.buttonGuardar.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(314, 408);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(93, 30);
            this.buttonGuardar.TabIndex = 19;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buscar";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(81, 18);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(277, 20);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.Chocolate;
            this.Editar.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.Location = new System.Drawing.Point(538, 15);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 2;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(668, 15);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSolicitud
            // 
            this.dataGridViewSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitud.Location = new System.Drawing.Point(34, 101);
            this.dataGridViewSolicitud.Name = "dataGridViewSolicitud";
            this.dataGridViewSolicitud.Size = new System.Drawing.Size(726, 343);
            this.dataGridViewSolicitud.TabIndex = 4;
            // 
            // fSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 493);
            this.Controls.Add(this.tabSolicitud);
            this.Name = "fSolicitud";
            this.Text = "fSolicitud";
            this.tabSolicitud.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSolicitud;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSolicitud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNivel;
        private System.Windows.Forms.TextBox textBoxFechaSolicitud;
        private System.Windows.Forms.Label labelHoraInicio;
        private System.Windows.Forms.TextBox textBoxFechaUso;
        private System.Windows.Forms.Label labelFechaUso;
        private System.Windows.Forms.TextBox textBoxHoraInicio;
        private System.Windows.Forms.TextBox textBoxHoraFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCarrera;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxAsignatura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.DataGridView dataGridViewSolicitud;
        private System.Windows.Forms.Button buttonEliminar;
    }
}