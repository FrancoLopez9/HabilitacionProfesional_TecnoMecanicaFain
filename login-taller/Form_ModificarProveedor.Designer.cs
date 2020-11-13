namespace login_taller
{
    partial class Form_ModificarProveedor
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_RazonSocial = new System.Windows.Forms.TextBox();
            this.textBox_CodigoPostal = new System.Windows.Forms.TextBox();
            this.textBox_Domicilio = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_CUIT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Seleccionar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_NumeroProveedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_BuscarNumero
            // 
            this.button_BuscarNumero.Location = new System.Drawing.Point(28, 24);
            this.button_BuscarNumero.Name = "button_BuscarNumero";
            this.button_BuscarNumero.Size = new System.Drawing.Size(159, 23);
            this.button_BuscarNumero.TabIndex = 0;
            this.button_BuscarNumero.Text = "Buscar Número";
            this.button_BuscarNumero.UseVisualStyleBackColor = true;
            this.button_BuscarNumero.Click += new System.EventHandler(this.button_BuscarNumero_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(228, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Eliminar Proveedor";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cód. Postal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Razón social:";
            // 
            // textBox_RazonSocial
            // 
            this.textBox_RazonSocial.Location = new System.Drawing.Point(121, 126);
            this.textBox_RazonSocial.Name = "textBox_RazonSocial";
            this.textBox_RazonSocial.Size = new System.Drawing.Size(236, 22);
            this.textBox_RazonSocial.TabIndex = 4;
            // 
            // textBox_CodigoPostal
            // 
            this.textBox_CodigoPostal.Location = new System.Drawing.Point(121, 266);
            this.textBox_CodigoPostal.Name = "textBox_CodigoPostal";
            this.textBox_CodigoPostal.Size = new System.Drawing.Size(236, 22);
            this.textBox_CodigoPostal.TabIndex = 5;
            // 
            // textBox_Domicilio
            // 
            this.textBox_Domicilio.Location = new System.Drawing.Point(121, 238);
            this.textBox_Domicilio.Name = "textBox_Domicilio";
            this.textBox_Domicilio.Size = new System.Drawing.Size(236, 22);
            this.textBox_Domicilio.TabIndex = 6;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(121, 210);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(236, 22);
            this.textBox_Email.TabIndex = 7;
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(121, 182);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(236, 22);
            this.textBox_Telefono.TabIndex = 8;
            // 
            // textBox_CUIT
            // 
            this.textBox_CUIT.Location = new System.Drawing.Point(121, 154);
            this.textBox_CUIT.Name = "textBox_CUIT";
            this.textBox_CUIT.Size = new System.Drawing.Size(236, 22);
            this.textBox_CUIT.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "CUIT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Domicilio:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(225, 316);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 15;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Seleccionar
            // 
            this.button_Seleccionar.Location = new System.Drawing.Point(261, 78);
            this.button_Seleccionar.Name = "button_Seleccionar";
            this.button_Seleccionar.Size = new System.Drawing.Size(96, 28);
            this.button_Seleccionar.TabIndex = 16;
            this.button_Seleccionar.Text = "Seleccionar";
            this.button_Seleccionar.UseVisualStyleBackColor = true;
            this.button_Seleccionar.Click += new System.EventHandler(this.button_Seleccionar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "N° Proveedor:";
            // 
            // textBox_NumeroProveedor
            // 
            this.textBox_NumeroProveedor.Location = new System.Drawing.Point(126, 81);
            this.textBox_NumeroProveedor.Name = "textBox_NumeroProveedor";
            this.textBox_NumeroProveedor.Size = new System.Drawing.Size(129, 22);
            this.textBox_NumeroProveedor.TabIndex = 18;
            // 
            // Form_ModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 381);
            this.Controls.Add(this.textBox_NumeroProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Seleccionar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CUIT);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Domicilio);
            this.Controls.Add(this.textBox_CodigoPostal);
            this.Controls.Add(this.textBox_RazonSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_BuscarNumero);
            this.Name = "Form_ModificarProveedor";
            this.Text = "Modificar Proveedor";
            this.Load += new System.EventHandler(this.Form_ModificarProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_BuscarNumero;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_RazonSocial;
        private System.Windows.Forms.TextBox textBox_CodigoPostal;
        private System.Windows.Forms.TextBox textBox_Domicilio;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_CUIT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Seleccionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_NumeroProveedor;
    }
}