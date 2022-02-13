namespace Kevin_caceres_20191000816_evalucion_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombretextBox1 = new System.Windows.Forms.TextBox();
            this.NacimientodateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TrabajodateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Procesarbutton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SueldotextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PromedioVentastextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prueba si puedes Obtener un aumento !!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre :";
            // 
            // NombretextBox1
            // 
            this.NombretextBox1.Location = new System.Drawing.Point(175, 90);
            this.NombretextBox1.Name = "NombretextBox1";
            this.NombretextBox1.Size = new System.Drawing.Size(119, 20);
            this.NombretextBox1.TabIndex = 2;
            this.NombretextBox1.TextChanged += new System.EventHandler(this.NombretextBox1_TextChanged);
            // 
            // NacimientodateTimePicker1
            // 
            this.NacimientodateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NacimientodateTimePicker1.Location = new System.Drawing.Point(175, 139);
            this.NacimientodateTimePicker1.Name = "NacimientodateTimePicker1";
            this.NacimientodateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.NacimientodateTimePicker1.TabIndex = 3;
            // 
            // TrabajodateTimePicker2
            // 
            this.TrabajodateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TrabajodateTimePicker2.Location = new System.Drawing.Point(175, 186);
            this.TrabajodateTimePicker2.Name = "TrabajodateTimePicker2";
            this.TrabajodateTimePicker2.Size = new System.Drawing.Size(136, 20);
            this.TrabajodateTimePicker2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Trabajo:";
            // 
            // Procesarbutton1
            // 
            this.Procesarbutton1.Location = new System.Drawing.Point(408, 111);
            this.Procesarbutton1.Name = "Procesarbutton1";
            this.Procesarbutton1.Size = new System.Drawing.Size(86, 28);
            this.Procesarbutton1.TabIndex = 7;
            this.Procesarbutton1.Text = "Procesar";
            this.Procesarbutton1.UseVisualStyleBackColor = true;
            this.Procesarbutton1.Click += new System.EventHandler(this.Procesarbutton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sueldo : ";
            // 
            // SueldotextBox1
            // 
            this.SueldotextBox1.Location = new System.Drawing.Point(175, 297);
            this.SueldotextBox1.Name = "SueldotextBox1";
            this.SueldotextBox1.Size = new System.Drawing.Size(119, 20);
            this.SueldotextBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Promedio de ventas :";
            // 
            // PromedioVentastextBox1
            // 
            this.PromedioVentastextBox1.Location = new System.Drawing.Point(175, 243);
            this.PromedioVentastextBox1.Name = "PromedioVentastextBox1";
            this.PromedioVentastextBox1.Size = new System.Drawing.Size(119, 20);
            this.PromedioVentastextBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 495);
            this.Controls.Add(this.PromedioVentastextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SueldotextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Procesarbutton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrabajodateTimePicker2);
            this.Controls.Add(this.NacimientodateTimePicker1);
            this.Controls.Add(this.NombretextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombretextBox1;
        private System.Windows.Forms.DateTimePicker NacimientodateTimePicker1;
        private System.Windows.Forms.DateTimePicker TrabajodateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Procesarbutton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SueldotextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PromedioVentastextBox1;
    }
}

