namespace login_taller
{
    partial class Form_BuscarVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Dominio = new System.Windows.Forms.TextBox();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_RegistrarVehiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(523, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dominio:";
            // 
            // textBox_Dominio
            // 
            this.textBox_Dominio.Location = new System.Drawing.Point(90, 17);
            this.textBox_Dominio.Name = "textBox_Dominio";
            this.textBox_Dominio.Size = new System.Drawing.Size(145, 22);
            this.textBox_Dominio.TabIndex = 2;
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(353, 17);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 3;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(141, 225);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 4;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_RegistrarVehiculo
            // 
            this.button_RegistrarVehiculo.Location = new System.Drawing.Point(312, 225);
            this.button_RegistrarVehiculo.Name = "button_RegistrarVehiculo";
            this.button_RegistrarVehiculo.Size = new System.Drawing.Size(141, 23);
            this.button_RegistrarVehiculo.TabIndex = 5;
            this.button_RegistrarVehiculo.Text = "Registrar Vehículo";
            this.button_RegistrarVehiculo.UseVisualStyleBackColor = true;
            this.button_RegistrarVehiculo.Click += new System.EventHandler(this.button_RegistrarVehiculo_Click);
            // 
            // Form_BuscarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 266);
            this.Controls.Add(this.button_RegistrarVehiculo);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.textBox_Dominio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_BuscarVehiculo";
            this.Text = "Buscar Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Dominio;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_RegistrarVehiculo;
    }
}