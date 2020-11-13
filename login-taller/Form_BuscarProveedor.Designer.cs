namespace login_taller
{
    partial class Form_BuscarProveedor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_CUIT = new System.Windows.Forms.TextBox();
            this.textBox_RazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_RegistrarProveedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(487, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_CUIT
            // 
            this.textBox_CUIT.Location = new System.Drawing.Point(111, 13);
            this.textBox_CUIT.Name = "textBox_CUIT";
            this.textBox_CUIT.Size = new System.Drawing.Size(217, 22);
            this.textBox_CUIT.TabIndex = 1;
            // 
            // textBox_RazonSocial
            // 
            this.textBox_RazonSocial.Location = new System.Drawing.Point(111, 42);
            this.textBox_RazonSocial.Name = "textBox_RazonSocial";
            this.textBox_RazonSocial.Size = new System.Drawing.Size(217, 22);
            this.textBox_RazonSocial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "CUIT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Razón social:";
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(384, 29);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 5;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_RegistrarProveedor
            // 
            this.button_RegistrarProveedor.Location = new System.Drawing.Point(261, 260);
            this.button_RegistrarProveedor.Name = "button_RegistrarProveedor";
            this.button_RegistrarProveedor.Size = new System.Drawing.Size(185, 23);
            this.button_RegistrarProveedor.TabIndex = 7;
            this.button_RegistrarProveedor.Text = "Registrar Proveedor";
            this.button_RegistrarProveedor.UseVisualStyleBackColor = true;
            this.button_RegistrarProveedor.Click += new System.EventHandler(this.button_RegistrarProveedor_Click);
            // 
            // Form_BuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 309);
            this.Controls.Add(this.button_RegistrarProveedor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_RazonSocial);
            this.Controls.Add(this.textBox_CUIT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_BuscarProveedor";
            this.Text = "Buscar Proveedor";
            this.Load += new System.EventHandler(this.Form_BuscarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_CUIT;
        private System.Windows.Forms.TextBox textBox_RazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_RegistrarProveedor;
    }
}