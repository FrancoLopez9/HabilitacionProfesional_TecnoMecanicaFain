﻿namespace login_taller
{
    partial class AgregarRepuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarRepuesto));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombreRepuesto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cantidadRepuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.precioCosto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ganancia = new System.Windows.Forms.TextBox();
            this.precioLista = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(496, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Observaciones";
            // 
            // nombreRepuesto
            // 
            this.nombreRepuesto.Location = new System.Drawing.Point(15, 71);
            this.nombreRepuesto.Name = "nombreRepuesto";
            this.nombreRepuesto.Size = new System.Drawing.Size(248, 20);
            this.nombreRepuesto.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.Location = new System.Drawing.Point(16, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(378, 43);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 155);
            this.textBox3.TabIndex = 9;
            // 
            // cantidadRepuesto
            // 
            this.cantidadRepuesto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cantidadRepuesto.Location = new System.Drawing.Point(15, 175);
            this.cantidadRepuesto.Name = "cantidadRepuesto";
            this.cantidadRepuesto.ReadOnly = true;
            this.cantidadRepuesto.Size = new System.Drawing.Size(83, 20);
            this.cantidadRepuesto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad";
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.SystemColors.Window;
            this.cancelar.Location = new System.Drawing.Point(607, 370);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(92, 23);
            this.cancelar.TabIndex = 12;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio Costo";
            // 
            // precioCosto
            // 
            this.precioCosto.Location = new System.Drawing.Point(16, 230);
            this.precioCosto.Name = "precioCosto";
            this.precioCosto.Size = new System.Drawing.Size(86, 20);
            this.precioCosto.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Utilidad %";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ganancia
            // 
            this.ganancia.Location = new System.Drawing.Point(159, 230);
            this.ganancia.Name = "ganancia";
            this.ganancia.Size = new System.Drawing.Size(86, 20);
            this.ganancia.TabIndex = 16;
            // 
            // precioLista
            // 
            this.precioLista.Location = new System.Drawing.Point(16, 287);
            this.precioLista.Name = "precioLista";
            this.precioLista.Size = new System.Drawing.Size(86, 20);
            this.precioLista.TabIndex = 17;
            this.precioLista.Click += new System.EventHandler(this.precioLista_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Precio Lista";
            // 
            // agregRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 414);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.precioLista);
            this.Controls.Add(this.ganancia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.precioCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cantidadRepuesto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nombreRepuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agregRepuesto";
            this.Text = "Agregar Repuesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombreRepuesto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox cantidadRepuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox precioCosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ganancia;
        private System.Windows.Forms.TextBox precioLista;
        private System.Windows.Forms.Label label8;
    }
}