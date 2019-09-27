namespace PresentationLayer.Modules
{
    partial class GruposModule
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
            this.tbMateria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProfesor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClaveGrupoIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbClaveGrupoOut = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAgregarGrupo = new System.Windows.Forms.Button();
            this.bEditarGrupo = new System.Windows.Forms.Button();
            this.bEliminarGrupo = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMateria
            // 
            this.tbMateria.Location = new System.Drawing.Point(241, 63);
            this.tbMateria.Name = "tbMateria";
            this.tbMateria.Size = new System.Drawing.Size(320, 20);
            this.tbMateria.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 98;
            this.label4.Text = "Materia:";
            // 
            // tbProfesor
            // 
            this.tbProfesor.Location = new System.Drawing.Point(241, 103);
            this.tbProfesor.Name = "tbProfesor";
            this.tbProfesor.Size = new System.Drawing.Size(320, 20);
            this.tbProfesor.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 96;
            this.label2.Text = "Profesor:";
            // 
            // tbClaveGrupoIn
            // 
            this.tbClaveGrupoIn.Location = new System.Drawing.Point(241, 24);
            this.tbClaveGrupoIn.Name = "tbClaveGrupoIn";
            this.tbClaveGrupoIn.Size = new System.Drawing.Size(320, 20);
            this.tbClaveGrupoIn.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 28);
            this.label3.TabIndex = 92;
            this.label3.Text = "Clave del Grupo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbClaveGrupoOut);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(113, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 62);
            this.groupBox3.TabIndex = 168;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda";
            // 
            // tbClaveGrupoOut
            // 
            this.tbClaveGrupoOut.Location = new System.Drawing.Point(196, 27);
            this.tbClaveGrupoOut.Name = "tbClaveGrupoOut";
            this.tbClaveGrupoOut.Size = new System.Drawing.Size(365, 20);
            this.tbClaveGrupoOut.TabIndex = 152;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 28);
            this.label17.TabIndex = 151;
            this.label17.Text = "Clave del Grupo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbClaveGrupoIn);
            this.groupBox1.Controls.Add(this.tbMateria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbProfesor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(113, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 137);
            this.groupBox1.TabIndex = 169;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Grupo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bAgregarGrupo);
            this.panel1.Controls.Add(this.bEditarGrupo);
            this.panel1.Controls.Add(this.bEliminarGrupo);
            this.panel1.Location = new System.Drawing.Point(0, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 61);
            this.panel1.TabIndex = 170;
            // 
            // bAgregarGrupo
            // 
            this.bAgregarGrupo.Location = new System.Drawing.Point(3, 3);
            this.bAgregarGrupo.Name = "bAgregarGrupo";
            this.bAgregarGrupo.Size = new System.Drawing.Size(268, 53);
            this.bAgregarGrupo.TabIndex = 141;
            this.bAgregarGrupo.Text = "Agegar";
            this.bAgregarGrupo.UseVisualStyleBackColor = true;
            // 
            // bEditarGrupo
            // 
            this.bEditarGrupo.Location = new System.Drawing.Point(277, 3);
            this.bEditarGrupo.Name = "bEditarGrupo";
            this.bEditarGrupo.Size = new System.Drawing.Size(271, 53);
            this.bEditarGrupo.TabIndex = 142;
            this.bEditarGrupo.Text = "Editar";
            this.bEditarGrupo.UseVisualStyleBackColor = true;
            // 
            // bEliminarGrupo
            // 
            this.bEliminarGrupo.Location = new System.Drawing.Point(554, 3);
            this.bEliminarGrupo.Name = "bEliminarGrupo";
            this.bEliminarGrupo.Size = new System.Drawing.Size(268, 53);
            this.bEliminarGrupo.TabIndex = 143;
            this.bEliminarGrupo.Text = "Eliminar";
            this.bEliminarGrupo.UseVisualStyleBackColor = true;
            // 
            // GruposModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "GruposModule";
            this.Size = new System.Drawing.Size(831, 371);
            this.Load += new System.EventHandler(this.GruposModule_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProfesor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClaveGrupoIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbClaveGrupoOut;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bAgregarGrupo;
        private System.Windows.Forms.Button bEditarGrupo;
        private System.Windows.Forms.Button bEliminarGrupo;
    }
}
