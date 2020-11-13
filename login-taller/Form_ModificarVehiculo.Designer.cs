namespace login_taller
{
    partial class Form_ModificarVehiculo
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
            this.button_BuscarNumero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_Dominio = new System.Windows.Forms.TextBox();
            this.textBox_Año = new System.Windows.Forms.TextBox();
            this.textBox_Marca = new System.Windows.Forms.TextBox();
            this.textBox_Modelo = new System.Windows.Forms.TextBox();
            this.textBox_Observaciones = new System.Windows.Forms.TextBox();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_NumeroVehiculo = new System.Windows.Forms.TextBox();
            this.button_Seleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_BuscarNumero
            // 
            this.button_BuscarNumero.Location = new System.Drawing.Point(22, 22);
            this.button_BuscarNumero.Name = "button_BuscarNumero";
            this.button_BuscarNumero.Size = new System.Drawing.Size(157, 23);
            this.button_BuscarNumero.TabIndex = 0;
            this.button_BuscarNumero.Text = "Buscar Número";
            this.button_BuscarNumero.UseVisualStyleBackColor = true;
            this.button_BuscarNumero.Click += new System.EventHandler(this.button_BuscarNumero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dominio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Observaciones:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(216, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Eliminar Vehículo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_Dominio
            // 
            this.textBox_Dominio.Location = new System.Drawing.Point(115, 157);
            this.textBox_Dominio.Name = "textBox_Dominio";
            this.textBox_Dominio.Size = new System.Drawing.Size(220, 22);
            this.textBox_Dominio.TabIndex = 7;
            // 
            // textBox_Año
            // 
            this.textBox_Año.Location = new System.Drawing.Point(115, 241);
            this.textBox_Año.Name = "textBox_Año";
            this.textBox_Año.Size = new System.Drawing.Size(220, 22);
            this.textBox_Año.TabIndex = 8;
            // 
            // textBox_Marca
            // 
            this.textBox_Marca.Location = new System.Drawing.Point(115, 213);
            this.textBox_Marca.Name = "textBox_Marca";
            this.textBox_Marca.Size = new System.Drawing.Size(220, 22);
            this.textBox_Marca.TabIndex = 9;
            // 
            // textBox_Modelo
            // 
            this.textBox_Modelo.Location = new System.Drawing.Point(115, 185);
            this.textBox_Modelo.Name = "textBox_Modelo";
            this.textBox_Modelo.Size = new System.Drawing.Size(220, 22);
            this.textBox_Modelo.TabIndex = 10;
            // 
            // textBox_Observaciones
            // 
            this.textBox_Observaciones.Location = new System.Drawing.Point(17, 297);
            this.textBox_Observaciones.Multiline = true;
            this.textBox_Observaciones.Name = "textBox_Observaciones";
            this.textBox_Observaciones.Size = new System.Drawing.Size(318, 87);
            this.textBox_Observaciones.TabIndex = 11;
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(47, 409);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 12;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(211, 409);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 13;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "N° Vehículo:";
            // 
            // textBox_NumeroVehiculo
            // 
            this.textBox_NumeroVehiculo.Location = new System.Drawing.Point(125, 87);
            this.textBox_NumeroVehiculo.Name = "textBox_NumeroVehiculo";
            this.textBox_NumeroVehiculo.Size = new System.Drawing.Size(100, 22);
            this.textBox_NumeroVehiculo.TabIndex = 15;
            // 
            // button_Seleccionar
            // 
            this.button_Seleccionar.Location = new System.Drawing.Point(245, 86);
            this.button_Seleccionar.Name = "button_Seleccionar";
            this.button_Seleccionar.Size = new System.Drawing.Size(90, 23);
            this.button_Seleccionar.TabIndex = 16;
            this.button_Seleccionar.Text = "Seleccionar";
            this.button_Seleccionar.UseVisualStyleBackColor = true;
            this.button_Seleccionar.Click += new System.EventHandler(this.button_Seleccionar_Click);
            // 
            // Form_ModificarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 468);
            this.Controls.Add(this.button_Seleccionar);
            this.Controls.Add(this.textBox_NumeroVehiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.textBox_Observaciones);
            this.Controls.Add(this.textBox_Modelo);
            this.Controls.Add(this.textBox_Marca);
            this.Controls.Add(this.textBox_Año);
            this.Controls.Add(this.textBox_Dominio);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_BuscarNumero);
            this.Name = "Form_ModificarVehiculo";
            this.Text = "Modificar Vehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_BuscarNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox_Dominio;
        private System.Windows.Forms.TextBox textBox_Año;
        private System.Windows.Forms.TextBox textBox_Marca;
        private System.Windows.Forms.TextBox textBox_Modelo;
        private System.Windows.Forms.TextBox textBox_Observaciones;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_NumeroVehiculo;
        private System.Windows.Forms.Button button_Seleccionar;
    }
}