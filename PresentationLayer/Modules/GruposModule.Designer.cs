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
            this.gmateria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clabe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.curso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gmatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eliminar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gmateria
            // 
            this.gmateria.Location = new System.Drawing.Point(171, 272);
            this.gmateria.Name = "gmateria";
            this.gmateria.Size = new System.Drawing.Size(243, 20);
            this.gmateria.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 98;
            this.label4.Text = "Materia:";
            // 
            // clabe
            // 
            this.clabe.Location = new System.Drawing.Point(171, 229);
            this.clabe.Name = "clabe";
            this.clabe.Size = new System.Drawing.Size(243, 20);
            this.clabe.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 96;
            this.label2.Text = "Clave:";
            // 
            // curso
            // 
            this.curso.Location = new System.Drawing.Point(171, 190);
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(243, 20);
            this.curso.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 94;
            this.label1.Text = "Tipo curso:";
            // 
            // gmatricula
            // 
            this.gmatricula.Location = new System.Drawing.Point(171, 150);
            this.gmatricula.Name = "gmatricula";
            this.gmatricula.Size = new System.Drawing.Size(243, 20);
            this.gmatricula.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 92;
            this.label3.Text = "Matrícula: ";
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(347, 342);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(159, 53);
            this.eliminar.TabIndex = 102;
            this.eliminar.Text = "Modificar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(182, 342);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(159, 53);
            this.editar.TabIndex = 101;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(17, 342);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(159, 53);
            this.agregar.TabIndex = 100;
            this.agregar.Text = "Agegar";
            this.agregar.UseVisualStyleBackColor = true;
            // 
            // GruposModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.gmateria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clabe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.curso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gmatricula);
            this.Controls.Add(this.label3);
            this.Name = "GruposModule";
            this.Size = new System.Drawing.Size(565, 408);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gmateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clabe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox curso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gmatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button agregar;
    }
}
