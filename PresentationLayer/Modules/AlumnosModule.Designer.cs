namespace PresentationLayer.Modules
{
    partial class AlumnosModule
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
            this.matricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.alumcarrera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eliminar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(183, 246);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(292, 20);
            this.matricula.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 75;
            this.label3.Text = "Matrícula: ";
            // 
            // alumcarrera
            // 
            this.alumcarrera.Location = new System.Drawing.Point(183, 199);
            this.alumcarrera.Name = "alumcarrera";
            this.alumcarrera.Size = new System.Drawing.Size(292, 20);
            this.alumcarrera.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 73;
            this.label2.Text = "Carrera:";
            // 
            // tutor
            // 
            this.tutor.Location = new System.Drawing.Point(183, 158);
            this.tutor.Name = "tutor";
            this.tutor.Size = new System.Drawing.Size(292, 20);
            this.tutor.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 71;
            this.label1.Text = "Tutor: ";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(513, 107);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(163, 28);
            this.status.TabIndex = 78;
            this.status.Text = "Active/Inactive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 77;
            this.label4.Text = "Estatus:";
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(348, 309);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(159, 53);
            this.eliminar.TabIndex = 101;
            this.eliminar.Text = "Modificar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(183, 309);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(159, 53);
            this.editar.TabIndex = 100;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(18, 309);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(159, 53);
            this.agregar.TabIndex = 99;
            this.agregar.Text = "Agegar";
            this.agregar.UseVisualStyleBackColor = true;
            // 
            // AlumnosModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alumcarrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tutor);
            this.Controls.Add(this.label1);
            this.Name = "AlumnosModule";
            this.Size = new System.Drawing.Size(675, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alumcarrera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button agregar;
    }
}
