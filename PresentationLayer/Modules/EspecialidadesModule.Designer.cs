namespace PresentationLayer.Modules
{
    partial class EspecialidadesModule
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
            this.spcareer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.specialty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // spcareer
            // 
            this.spcareer.Location = new System.Drawing.Point(149, 170);
            this.spcareer.Name = "spcareer";
            this.spcareer.Size = new System.Drawing.Size(292, 20);
            this.spcareer.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 97;
            this.label2.Text = "Carrera:";
            // 
            // specialty
            // 
            this.specialty.Location = new System.Drawing.Point(149, 129);
            this.specialty.Name = "specialty";
            this.specialty.Size = new System.Drawing.Size(292, 20);
            this.specialty.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 95;
            this.label1.Text = "Nombre:";
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(347, 238);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(159, 53);
            this.eliminar.TabIndex = 101;
            this.eliminar.Text = "Modificar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(182, 238);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(159, 53);
            this.editar.TabIndex = 100;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(17, 238);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(159, 53);
            this.agregar.TabIndex = 99;
            this.agregar.Text = "Agegar";
            this.agregar.UseVisualStyleBackColor = true;
            // 
            // EspecialidadesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.spcareer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.specialty);
            this.Controls.Add(this.label1);
            this.Name = "EspecialidadesModule";
            this.Size = new System.Drawing.Size(529, 303);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox spcareer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox specialty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button agregar;
    }
}
