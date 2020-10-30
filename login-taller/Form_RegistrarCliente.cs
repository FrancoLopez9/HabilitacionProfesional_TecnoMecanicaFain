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
    public partial class Form_RegistrarCliente : Form
    {
        public Form_RegistrarCliente()
        {
            InitializeComponent();
        }

        private void agregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente unCliente = new Cliente();
            unCliente.Nombre = textBox_Nombre.Text;
            unCliente.Apellido = textBox_Apellido.Text;
            unCliente.DNI = Int32.Parse(textBox_DNI.Text); //Hay que convertir el texto en integer
            unCliente.Domicilio = textBox_Domicilio.Text;
            unCliente.Telefono = textBox_Telefono.Text;
            DB_AccesoDatosSQLite.guardarClientes(unCliente);

        }
    }
}
