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
    public partial class Form_RegistrarProveedor : Form
    {
        public Form_RegistrarProveedor()
        {
            InitializeComponent();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            Proveedor unProveedor = new Proveedor();
            unProveedor.CUIT = textBox_CUIT.Text;
            unProveedor.RazonSocial = textBox_RazonSocial.Text;
            unProveedor.CodigoPostal = Int32.Parse(textBox_CodigoPostal.Text); //Hay que convertir el texto en integer
            unProveedor.Domicilio = textBox_Domicilio.Text;
            unProveedor.Telefono = Int32.Parse(textBox_Telefono.Text);
            unProveedor.Email = textBox_Email.Text;
            DB_AccesoDatosSQLite.guardarProveedor(unProveedor);
            MessageBox.Show("El proveedor se ha registrado exitosamente");
        }

        private void Form_RegistrarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
