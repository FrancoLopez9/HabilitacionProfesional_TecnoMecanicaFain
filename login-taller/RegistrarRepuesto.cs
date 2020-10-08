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
    public partial class RegistrarRepuesto : Form
    {
        public float valor1;
        public float valor2;

        public RegistrarRepuesto()
        {
            InitializeComponent();
            cantidadRepuesto.Text = Convert.ToString('0');


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
            string var = precioCosto.Text;
            valor1 = float.Parse(var);
            string var1 = ganancia.Text;
            valor2 = 1 + (float.Parse(var1) / 100);
            float valor = (valor1 * valor2);
            precioLista.Text = Convert.ToString(valor);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
    


