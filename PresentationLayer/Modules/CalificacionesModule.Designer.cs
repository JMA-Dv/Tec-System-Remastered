namespace PresentationLayer.Modules
{
    partial class CalificacionesModule
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbIDAlumnoCalif = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEvaluacionCalificaciones = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCalificacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTemaCalificaciones = new System.Windows.Forms.TextBox();
            this.tbMatriculaAlumnoCalif = new System.Windows.Forms.TextBox();
            this.cbGrupoCalificaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAgregarCalif = new System.Windows.Forms.Button();
            this.bEditarCalif = new System.Windows.Forms.Button();
            this.bEliminarCalif = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbIDAlumnoCalif);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(193, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 62);
            this.groupBox3.TabIndex = 167;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda";
            // 
            // tbIDAlumnoCalif
            // 
            this.tbIDAlumnoCalif.Location = new System.Drawing.Point(57, 27);
            this.tbIDAlumnoCalif.Name = "tbIDAlumnoCalif";
            this.tbIDAlumnoCalif.Size = new System.Drawing.Size(365, 20);
            this.tbIDAlumnoCalif.TabIndex = 152;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 28);
            this.label17.TabIndex = 151;
            this.label17.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEvaluacionCalificaciones);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCalificacion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbTemaCalificaciones);
            this.groupBox1.Controls.Add(this.tbMatriculaAlumnoCalif);
            this.groupBox1.Controls.Add(this.cbGrupoCalificaciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(193, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 228);
            this.groupBox1.TabIndex = 168;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calificaciones";
            // 
            // cbEvaluacionCalificaciones
            // 
            this.cbEvaluacionCalificaciones.FormattingEnabled = true;
            this.cbEvaluacionCalificaciones.Location = new System.Drawing.Point(229, 196);
            this.cbEvaluacionCalificaciones.Name = "cbEvaluacionCalificaciones";
            this.cbEvaluacionCalificaciones.Size = new System.Drawing.Size(193, 21);
            this.cbEvaluacionCalificaciones.TabIndex = 178;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 28);
            this.label3.TabIndex = 179;
            this.label3.Text = "Tipo de Evaluación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 177;
            this.label2.Text = "Calificación: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 28);
            this.label5.TabIndex = 177;
            this.label5.Text = "Tema:";
            // 
            // tbCalificacion
            // 
            this.tbCalificacion.Location = new System.Drawing.Point(229, 156);
            this.tbCalificacion.Name = "tbCalificacion";
            this.tbCalificacion.Size = new System.Drawing.Size(193, 20);
            this.tbCalificacion.TabIndex = 176;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 28);
            this.label8.TabIndex = 169;
            this.label8.Text = "Matrícula: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbTemaCalificaciones
            // 
            this.tbTemaCalificaciones.Location = new System.Drawing.Point(229, 114);
            this.tbTemaCalificaciones.Name = "tbTemaCalificaciones";
            this.tbTemaCalificaciones.Size = new System.Drawing.Size(193, 20);
            this.tbTemaCalificaciones.TabIndex = 176;
            // 
            // tbMatriculaAlumnoCalif
            // 
            this.tbMatriculaAlumnoCalif.Location = new System.Drawing.Point(229, 65);
            this.tbMatriculaAlumnoCalif.Name = "tbMatriculaAlumnoCalif";
            this.tbMatriculaAlumnoCalif.Size = new System.Drawing.Size(193, 20);
            this.tbMatriculaAlumnoCalif.TabIndex = 170;
            // 
            // cbGrupoCalificaciones
            // 
            this.cbGrupoCalificaciones.FormattingEnabled = true;
            this.cbGrupoCalificaciones.Location = new System.Drawing.Point(229, 25);
            this.cbGrupoCalificaciones.Name = "cbGrupoCalificaciones";
            this.cbGrupoCalificaciones.Size = new System.Drawing.Size(193, 21);
            this.cbGrupoCalificaciones.TabIndex = 173;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 173;
            this.label1.Text = "Grupo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bAgregarCalif);
            this.panel1.Controls.Add(this.bEditarCalif);
            this.panel1.Controls.Add(this.bEliminarCalif);
            this.panel1.Location = new System.Drawing.Point(3, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 61);
            this.panel1.TabIndex = 169;
            // 
            // bAgregarCalif
            // 
            this.bAgregarCalif.Location = new System.Drawing.Point(3, 3);
            this.bAgregarCalif.Name = "bAgregarCalif";
            this.bAgregarCalif.Size = new System.Drawing.Size(268, 53);
            this.bAgregarCalif.TabIndex = 141;
            this.bAgregarCalif.Text = "Agegar";
            this.bAgregarCalif.UseVisualStyleBackColor = true;
            // 
            // bEditarCalif
            // 
            this.bEditarCalif.Location = new System.Drawing.Point(277, 3);
            this.bEditarCalif.Name = "bEditarCalif";
            this.bEditarCalif.Size = new System.Drawing.Size(271, 53);
            this.bEditarCalif.TabIndex = 142;
            this.bEditarCalif.Text = "Editar";
            this.bEditarCalif.UseVisualStyleBackColor = true;
            // 
            // bEliminarCalif
            // 
            this.bEliminarCalif.Location = new System.Drawing.Point(554, 3);
            this.bEliminarCalif.Name = "bEliminarCalif";
            this.bEliminarCalif.Size = new System.Drawing.Size(268, 53);
            this.bEliminarCalif.TabIndex = 143;
            this.bEliminarCalif.Text = "Eliminar";
            this.bEliminarCalif.UseVisualStyleBackColor = true;
            // 
            // CalificacionesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "CalificacionesModule";
            this.Size = new System.Drawing.Size(831, 392);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbIDAlumnoCalif;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGrupoCalificaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMatriculaAlumnoCalif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTemaCalificaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCalificacion;
        private System.Windows.Forms.ComboBox cbEvaluacionCalificaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bAgregarCalif;
        private System.Windows.Forms.Button bEditarCalif;
        private System.Windows.Forms.Button bEliminarCalif;

    }
}
