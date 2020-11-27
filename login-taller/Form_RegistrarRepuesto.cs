using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_taller
{
    public partial class Form_RegistrarRepuesto : Form
    {
        public float valor1;
        public float valor2;

        public Form_RegistrarRepuesto()
        {
            InitializeComponent();
            textBox_Stock.Text = Convert.ToString('0');


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (grabarEntrada(dtpFechaEntrada.Value.ToShortDateString(),
            //    dtpFechaFactura.Value.ToShortDateString(),
            //    txtFolioFactura.Text, txtNombreProveedor.Text, "admin"))
            //{
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {


        }

        private void precioLista_Click(object sender, EventArgs e)
        {
            string var = textBox_PrecioCosto.Text;
            valor1 = float.Parse(var);
            string var1 = textBox_Ganancia.Text;
            valor2 = 1 + (float.Parse(var1) / 100);
            float valor = (valor1 * valor2);
            textBox_PrecioLista.Text = Convert.ToString(valor);
        }

       
        private void button_BuscarProveedor_Click(object sender, EventArgs e)
        {
            Form_BuscarProveedor p = new Form_BuscarProveedor();
            p.Show();
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            Repuesto unRepuesto = new Repuesto();
            unRepuesto.CodigoProveedor = Int32.Parse(textBox_CodigoProveedor.Text);
            unRepuesto.NumeroProveedor = Int32.Parse(textBox_NumeroProveedor.Text);
            unRepuesto.Nombre = textbox_Nombre.Text;
            unRepuesto.Marca = textBox_Marca.Text;
            unRepuesto.PrecioCosto = float.Parse(textBox_PrecioCosto.Text);
            unRepuesto.PrecioLista = float.Parse(textBox_PrecioLista.Text);
            unRepuesto.Ganancia = Int32.Parse(textBox_Ganancia.Text);
            unRepuesto.Stock = Int32.Parse(textBox_Stock.Text);
            DB_AccesoDatosSQLite.guardarRepuesto(unRepuesto);
            MessageBox.Show("El repuesto se ha registrado exitosamente");
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    
    


