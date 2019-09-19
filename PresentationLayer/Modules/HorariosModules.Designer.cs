namespace PresentationLayer.Modules
{
    partial class HorariosModules
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
            this.hgrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hhour = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hdays = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.checkeddays = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hgrupo
            // 
            this.hgrupo.Location = new System.Drawing.Point(89, 90);
            this.hgrupo.Name = "hgrupo";
            this.hgrupo.Size = new System.Drawing.Size(292, 20);
            this.hgrupo.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 81;
            this.label3.Text = "Grupo:";
            // 
            // hhour
            // 
            this.hhour.AutoSize = true;
            this.hhour.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hhour.Location = new System.Drawing.Point(543, 127);
            this.hhour.Name = "hhour";
            this.hhour.Size = new System.Drawing.Size(62, 28);
            this.hhour.TabIndex = 88;
            this.hhour.Text = "Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 87;
            this.label4.Text = "Hora:";
            // 
            // hdays
            // 
            this.hdays.AutoSize = true;
            this.hdays.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdays.Location = new System.Drawing.Point(510, 90);
            this.hdays.Name = "hdays";
            this.hdays.Size = new System.Drawing.Size(131, 28);
            this.hdays.TabIndex = 86;
            this.hdays.Text = "DayOfWeek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 85;
            this.label1.Text = "Día:";
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(343, 298);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(159, 53);
            this.eliminar.TabIndex = 92;
            this.eliminar.Text = "Modificar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(178, 298);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(159, 53);
            this.editar.TabIndex = 91;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(13, 298);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(159, 53);
            this.agregar.TabIndex = 90;
            this.agregar.Text = "Agegar";
            this.agregar.UseVisualStyleBackColor = true;
            // 
            // checkeddays
            // 
            this.checkeddays.FormattingEnabled = true;
            this.checkeddays.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes"});
            this.checkeddays.Location = new System.Drawing.Point(89, 157);
            this.checkeddays.Name = "checkeddays";
            this.checkeddays.Size = new System.Drawing.Size(154, 109);
            this.checkeddays.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 93;
            this.label2.Text = "Días:";
            // 
            // HorariosModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkeddays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.hhour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hdays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hgrupo);
            this.Controls.Add(this.label3);
            this.Name = "HorariosModules";
            this.Size = new System.Drawing.Size(657, 363);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hgrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hhour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hdays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.CheckedListBox checkeddays;
        private System.Windows.Forms.Label label2;
    }
}
