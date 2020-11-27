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
    public partial class Form_ModificarCliente : Form
    {
        Cliente unCliente = new Cliente();
        public Form_ModificarCliente()
        {
            InitializeComponent();
        }

        private void Form_ModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button_Seleccionar_Click(object sender, EventArgs e)
        {
            unCliente = DB_AccesoDatosSQLite.devolverCliente(Int32.Parse(textBox_NumeroCliente.Text));
            textBox_DNI.Text = unCliente.DNI.ToString();
            textBox_Nombre.Text = unCliente.Nombre;
            textBox_Apellido.Text = unCliente.Apellido;
            textBox_Telefono.Text = unCliente.Telefono;
            textBox_Domicilio.Text = unCliente.Domicilio;
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            unCliente.DNI = Int32.Parse(textBox_DNI.Text);
            unCliente.Nombre = textBox_Nombre.Text;
            unCliente.Apellido = textBox_Apellido.Text;
            unCliente.Telefono = textBox_Telefono.Text;
            unCliente.Domicilio = textBox_Domicilio.Text;
            DB_AccesoDatosSQLite.modificarCliente(unCliente);
            MessageBox.Show("El cliente se ha modificado exitosamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_BuscarCliente p = new Form_BuscarCliente();
            p.Show();
        }
    }
}
