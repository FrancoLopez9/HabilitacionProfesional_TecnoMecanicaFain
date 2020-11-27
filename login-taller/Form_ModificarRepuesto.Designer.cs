namespace login_taller
{
    partial class Form_ModificarRepuesto
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
            this.button_Buscar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.textBox_Numero = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_CodigoProveedor = new System.Windows.Forms.TextBox();
            this.textBox_Marca = new System.Windows.Forms.TextBox();
            this.textBox_PrecioCosto = new System.Windows.Forms.TextBox();
            this.textBox_Ganancia = new System.Windows.Forms.TextBox();
            this.textBox_PrecioLista = new System.Windows.Forms.TextBox();
            this.textBox_Stock = new System.Windows.Forms.TextBox();
            this.button_Seleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(12, 26);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(137, 23);
            this.button_Buscar.TabIndex = 0;
            this.button_Buscar.Text = "Buscar Número";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(175, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Eliminar repuesto";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cód. Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio de costo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ganancia %:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Precio de lista:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Stock:";
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(70, 305);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 10;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(200, 305);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 11;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // textBox_Numero
            // 
            this.textBox_Numero.Location = new System.Drawing.Point(135, 67);
            this.textBox_Numero.Name = "textBox_Numero";
            this.textBox_Numero.Size = new System.Drawing.Size(63, 22);
            this.textBox_Numero.TabIndex = 12;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(135, 123);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(152, 22);
            this.textBox_Nombre.TabIndex = 13;
            // 
            // textBox_CodigoProveedor
            // 
            this.textBox_CodigoProveedor.Location = new System.Drawing.Point(135, 95);
            this.textBox_CodigoProveedor.Name = "textBox_CodigoProveedor";
            this.textBox_CodigoProveedor.Size = new System.Drawing.Size(152, 22);
            this.textBox_CodigoProveedor.TabIndex = 14;
            // 
            // textBox_Marca
            // 
            this.textBox_Marca.Location = new System.Drawing.Point(135, 151);
            this.textBox_Marca.Name = "textBox_Marca";
            this.textBox_Marca.Size = new System.Drawing.Size(152, 22);
            this.textBox_Marca.TabIndex = 15;
            // 
            // textBox_PrecioCosto
            // 
            this.textBox_PrecioCosto.Location = new System.Drawing.Point(135, 179);
            this.textBox_PrecioCosto.Name = "textBox_PrecioCosto";
            this.textBox_PrecioCosto.Size = new System.Drawing.Size(152, 22);
            this.textBox_PrecioCosto.TabIndex = 16;
            // 
            // textBox_Ganancia
            // 
            this.textBox_Ganancia.Location = new System.Drawing.Point(135, 207);
            this.textBox_Ganancia.Name = "textBox_Ganancia";
            this.textBox_Ganancia.Size = new System.Drawing.Size(152, 22);
            this.textBox_Ganancia.TabIndex = 17;
            // 
            // textBox_PrecioLista
            // 
            this.textBox_PrecioLista.Location = new System.Drawing.Point(135, 235);
            this.textBox_PrecioLista.Name = "textBox_PrecioLista";
            this.textBox_PrecioLista.Size = new System.Drawing.Size(152, 22);
            this.textBox_PrecioLista.TabIndex = 18;
            // 
            // textBox_Stock
            // 
            this.textBox_Stock.Location = new System.Drawing.Point(135, 263);
            this.textBox_Stock.Name = "textBox_Stock";
            this.textBox_Stock.Size = new System.Drawing.Size(152, 22);
            this.textBox_Stock.TabIndex = 19;
            // 
            // button_Seleccionar
            // 
            this.button_Seleccionar.Location = new System.Drawing.Point(204, 66);
            this.button_Seleccionar.Name = "button_Seleccionar";
            this.button_Seleccionar.Size = new System.Drawing.Size(94, 23);
            this.button_Seleccionar.TabIndex = 20;
            this.button_Seleccionar.Text = "Seleccionar";
            this.button_Seleccionar.UseVisualStyleBackColor = true;
            this.button_Seleccionar.Click += new System.EventHandler(this.button_Seleccionar_Click);
            // 
            // Form_ModificarRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 345);
            this.Controls.Add(this.button_Seleccionar);
            this.Controls.Add(this.textBox_Stock);
            this.Controls.Add(this.textBox_PrecioLista);
            this.Controls.Add(this.textBox_Ganancia);
            this.Controls.Add(this.textBox_PrecioCosto);
            this.Controls.Add(this.textBox_Marca);
            this.Controls.Add(this.textBox_CodigoProveedor);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.textBox_Numero);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_Buscar);
            this.Name = "Form_ModificarRepuesto";
            this.Text = "Modificar Repuesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.TextBox textBox_Numero;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_CodigoProveedor;
        private System.Windows.Forms.TextBox textBox_Marca;
        private System.Windows.Forms.TextBox textBox_PrecioCosto;
        private System.Windows.Forms.TextBox textBox_Ganancia;
        private System.Windows.Forms.TextBox textBox_PrecioLista;
        private System.Windows.Forms.TextBox textBox_Stock;
        private System.Windows.Forms.Button button_Seleccionar;
    }
}