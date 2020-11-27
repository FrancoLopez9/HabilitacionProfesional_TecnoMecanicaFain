using System;
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
    public partial class Form_ModificarRepuesto : Form
    {
        Repuesto unRepuesto = new Repuesto();
        public Form_ModificarRepuesto()
        {
            InitializeComponent();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            Form_BuscarRepuesto p = new Form_BuscarRepuesto();
            p.Show();
        }

        private void button_Seleccionar_Click(object sender, EventArgs e)
        {
            unRepuesto = DB_AccesoDatosSQLite.devolverRepuesto(Int32.Parse(textBox_Numero.Text));
            textBox_CodigoProveedor.Text = unRepuesto.CodigoProveedor.ToString();
            textBox_Nombre.Text = unRepuesto.Nombre;
            textBox_Marca.Text = unRepuesto.Marca;
            textBox_PrecioCosto.Text = unRepuesto.PrecioCosto.ToString();
            textBox_PrecioLista.Text = unRepuesto.PrecioLista.ToString();
            textBox_Ganancia.Text = unRepuesto.Ganancia.ToString();
            textBox_Stock.Text = unRepuesto.Stock.ToString();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            unRepuesto.CodigoProveedor = Int32.Parse(textBox_CodigoProveedor.Text);
            unRepuesto.Nombre = textBox_Nombre.Text;
            unRepuesto.Marca = textBox_Marca.Text;
            unRepuesto.PrecioCosto = float.Parse(textBox_PrecioCosto.Text);
            unRepuesto.PrecioLista = float.Parse(textBox_PrecioLista.Text);
            unRepuesto.Ganancia = Int32.Parse(textBox_Ganancia.Text);
            unRepuesto.Stock = Int32.Parse(textBox_Stock.Text);
            DB_AccesoDatosSQLite.modificarRepuesto(unRepuesto);
            MessageBox.Show("El repuesto se ha modificado exitosamente");
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
