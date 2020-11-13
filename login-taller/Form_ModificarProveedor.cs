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
    public partial class Form_ModificarProveedor : Form
    {
        Proveedor unProveedor = new Proveedor();
        public Form_ModificarProveedor()
        {
            InitializeComponent();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            unProveedor.CUIT = textBox_CUIT.Text;
            unProveedor.RazonSocial = textBox_RazonSocial.Text;
            unProveedor.Email = textBox_Email.Text;
            unProveedor.Telefono = Int32.Parse(textBox_Telefono.Text);
            unProveedor.Domicilio = textBox_Domicilio.Text;
            unProveedor.CodigoPostal = Int32.Parse(textBox_CodigoPostal.Text);
            DB_AccesoDatosSQLite.modificarProveedor(unProveedor);
            MessageBox.Show("El proveedor se ha modificado exitosamente");
        }

        private void button_Seleccionar_Click(object sender, EventArgs e)
        {
            unProveedor = DB_AccesoDatosSQLite.devolverProveedor(Int32.Parse(textBox_NumeroProveedor.Text));
            textBox_CUIT.Text = unProveedor.CUIT;
            textBox_RazonSocial.Text = unProveedor.RazonSocial;
            textBox_Email.Text = unProveedor.Email;
            textBox_Telefono.Text = unProveedor.Telefono.ToString();
            textBox_Domicilio.Text = unProveedor.Domicilio;
            textBox_CodigoPostal.Text = unProveedor.CodigoPostal.ToString();
        }

        private void button_BuscarNumero_Click(object sender, EventArgs e)
        {
            Form_BuscarProveedor p = new Form_BuscarProveedor();
            p.Show();
        }

        private void Form_ModificarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
