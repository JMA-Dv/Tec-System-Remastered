namespace PresentationLayer.Modules
{
    partial class CarrerasModule
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
            this.eliminar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.coordinador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.career = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(350, 236);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(159, 53);
            this.eliminar.TabIndex = 97;
            this.eliminar.Text = "Modificar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(185, 236);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(159, 53);
            this.editar.TabIndex = 96;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(20, 236);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(159, 53);
            this.agregar.TabIndex = 95;
            this.agregar.Text = "Agegar";
            this.agregar.UseVisualStyleBackColor = true;
            // 
            // coordinador
            // 
            this.coordinador.Location = new System.Drawing.Point(249, 164);
            this.coordinador.Name = "coordinador";
            this.coordinador.Size = new System.Drawing.Size(292, 20);
            this.coordinador.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 100;
            this.label2.Text = "Coordinador:";
            // 
            // career
            // 
            this.career.Location = new System.Drawing.Point(249, 123);
            this.career.Name = "career";
            this.career.Size = new System.Drawing.Size(292, 20);
            this.career.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 28);
            this.label1.TabIndex = 98;
            this.label1.Text = "Nombre de carrera: ";
            // 
            // CarrerasModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.coordinador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.career);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.agregar);
            this.Name = "CarrerasModule";
            this.Size = new System.Drawing.Size(633, 302);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.TextBox coordinador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox career;
        private System.Windows.Forms.Label label1;
    }
}
