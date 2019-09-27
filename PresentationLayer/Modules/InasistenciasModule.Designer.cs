namespace PresentationLayer.Modules
{
    partial class InasistenciasModule
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFechaFalta = new System.Windows.Forms.DateTimePicker();
            this.cbTipoFalta = new System.Windows.Forms.ComboBox();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAgregarInasistencia = new System.Windows.Forms.Button();
            this.bEditarInasistencia = new System.Windows.Forms.Button();
            this.bEliminarInasistencia = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbID);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(39, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 62);
            this.groupBox3.TabIndex = 170;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(57, 27);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(365, 20);
            this.tbID.TabIndex = 152;
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
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpFechaFalta);
            this.groupBox1.Controls.Add(this.cbTipoFalta);
            this.groupBox1.Controls.Add(this.cbGrupo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbMatricula);
            this.groupBox1.Location = new System.Drawing.Point(39, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 231);
            this.groupBox1.TabIndex = 171;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Inasistencias";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 28);
            this.label10.TabIndex = 172;
            this.label10.Text = "Tipo de inasistencia:";
            // 
            // dtpFechaFalta
            // 
            this.dtpFechaFalta.Location = new System.Drawing.Point(12, 141);
            this.dtpFechaFalta.Name = "dtpFechaFalta";
            this.dtpFechaFalta.Size = new System.Drawing.Size(357, 20);
            this.dtpFechaFalta.TabIndex = 173;
            // 
            // cbTipoFalta
            // 
            this.cbTipoFalta.FormattingEnabled = true;
            this.cbTipoFalta.Location = new System.Drawing.Point(229, 189);
            this.cbTipoFalta.Name = "cbTipoFalta";
            this.cbTipoFalta.Size = new System.Drawing.Size(290, 21);
            this.cbTipoFalta.TabIndex = 173;
            // 
            // cbGrupo
            // 
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(229, 70);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(290, 21);
            this.cbGrupo.TabIndex = 179;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 28);
            this.label4.TabIndex = 172;
            this.label4.Text = "Fecha en que faltó:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 178;
            this.label5.Text = "Grupo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 28);
            this.label8.TabIndex = 173;
            this.label8.Text = "Matrícula: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(229, 24);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(290, 20);
            this.tbMatricula.TabIndex = 174;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bAgregarInasistencia);
            this.panel1.Controls.Add(this.bEditarInasistencia);
            this.panel1.Controls.Add(this.bEliminarInasistencia);
            this.panel1.Location = new System.Drawing.Point(3, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 61);
            this.panel1.TabIndex = 172;
            // 
            // bAgregarInasistencia
            // 
            this.bAgregarInasistencia.Location = new System.Drawing.Point(3, 3);
            this.bAgregarInasistencia.Name = "bAgregarInasistencia";
            this.bAgregarInasistencia.Size = new System.Drawing.Size(268, 53);
            this.bAgregarInasistencia.TabIndex = 141;
            this.bAgregarInasistencia.Text = "Agegar";
            this.bAgregarInasistencia.UseVisualStyleBackColor = true;
            // 
            // bEditarInasistencia
            // 
            this.bEditarInasistencia.Location = new System.Drawing.Point(277, 3);
            this.bEditarInasistencia.Name = "bEditarInasistencia";
            this.bEditarInasistencia.Size = new System.Drawing.Size(271, 53);
            this.bEditarInasistencia.TabIndex = 142;
            this.bEditarInasistencia.Text = "Editar";
            this.bEditarInasistencia.UseVisualStyleBackColor = true;
            // 
            // bEliminarInasistencia
            // 
            this.bEliminarInasistencia.Location = new System.Drawing.Point(554, 3);
            this.bEliminarInasistencia.Name = "bEliminarInasistencia";
            this.bEliminarInasistencia.Size = new System.Drawing.Size(268, 53);
            this.bEliminarInasistencia.TabIndex = 143;
            this.bEliminarInasistencia.Text = "Eliminar";
            this.bEliminarInasistencia.UseVisualStyleBackColor = true;
            // 
            // InasistenciasModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "InasistenciasModule";
            this.Size = new System.Drawing.Size(834, 410);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaFalta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTipoFalta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bAgregarInasistencia;
        private System.Windows.Forms.Button bEditarInasistencia;
        private System.Windows.Forms.Button bEliminarInasistencia;

    }
}
