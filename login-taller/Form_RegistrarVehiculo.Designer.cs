namespace login_taller
{
    partial class Form_RegistrarVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Dominio = new System.Windows.Forms.TextBox();
            this.textBox_Marca = new System.Windows.Forms.TextBox();
            this.textBox_Modelo = new System.Windows.Forms.TextBox();
            this.textBox_Año = new System.Windows.Forms.TextBox();
            this.textBox_Observaciones = new System.Windows.Forms.TextBox();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dominio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observaciones:";
            // 
            // textBox_Dominio
            // 
            this.textBox_Dominio.Location = new System.Drawing.Point(130, 13);
            this.textBox_Dominio.Name = "textBox_Dominio";
            this.textBox_Dominio.Size = new System.Drawing.Size(179, 22);
            this.textBox_Dominio.TabIndex = 5;
            // 
            // textBox_Marca
            // 
            this.textBox_Marca.Location = new System.Drawing.Point(130, 41);
            this.textBox_Marca.Name = "textBox_Marca";
            this.textBox_Marca.Size = new System.Drawing.Size(179, 22);
            this.textBox_Marca.TabIndex = 6;
            // 
            // textBox_Modelo
            // 
            this.textBox_Modelo.Location = new System.Drawing.Point(130, 69);
            this.textBox_Modelo.Name = "textBox_Modelo";
            this.textBox_Modelo.Size = new System.Drawing.Size(179, 22);
            this.textBox_Modelo.TabIndex = 7;
            // 
            // textBox_Año
            // 
            this.textBox_Año.Location = new System.Drawing.Point(130, 97);
            this.textBox_Año.Name = "textBox_Año";
            this.textBox_Año.Size = new System.Drawing.Size(179, 22);
            this.textBox_Año.TabIndex = 8;
            // 
            // textBox_Observaciones
            // 
            this.textBox_Observaciones.Location = new System.Drawing.Point(13, 148);
            this.textBox_Observaciones.Multiline = true;
            this.textBox_Observaciones.Name = "textBox_Observaciones";
            this.textBox_Observaciones.Size = new System.Drawing.Size(296, 127);
            this.textBox_Observaciones.TabIndex = 9;
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(61, 290);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 10;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(197, 290);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 11;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // Form_RegistrarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 325);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.textBox_Observaciones);
            this.Controls.Add(this.textBox_Año);
            this.Controls.Add(this.textBox_Modelo);
            this.Controls.Add(this.textBox_Marca);
            this.Controls.Add(this.textBox_Dominio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_RegistrarVehiculo";
            this.Text = "Registrar Vehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Dominio;
        private System.Windows.Forms.TextBox textBox_Marca;
        private System.Windows.Forms.TextBox textBox_Modelo;
        private System.Windows.Forms.TextBox textBox_Año;
        private System.Windows.Forms.TextBox textBox_Observaciones;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Guardar;
    }
}