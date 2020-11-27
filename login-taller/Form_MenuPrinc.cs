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
    public partial class Form_MenuPrinc : Form
    {
        public Form_MenuPrinc()
        {
            InitializeComponent();

        }

        

       
        private void agregarRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RegistrarRepuesto p = new Form_RegistrarRepuesto();
            p.Show();
        }

        private void buscarRepuestoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_BuscarRepuesto p = new Form_BuscarRepuesto();
            p.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_RegistrarCliente p = new Form_RegistrarCliente();
            p.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BuscarCliente p = new Form_BuscarCliente();
            p.Show();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ModificarCliente p = new Form_ModificarCliente();
            p.Show();
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RegistrarProveedor p = new Form_RegistrarProveedor();
            p.Show();
        }

        private void modificarProveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_ModificarProveedor p = new Form_ModificarProveedor();
            p.Show();
        }

        private void buscarProveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_BuscarProveedor p = new Form_BuscarProveedor();
            p.Show();
        }

        private void Form_MenuPrinc_Load(object sender, EventArgs e)
        {

        }

        private void registrarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RegistrarVehiculo p = new Form_RegistrarVehiculo();
            p.Show();
        }

        private void modificarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ModificarVehiculo p = new Form_ModificarVehiculo();
            p.Show();
        }

        private void buscarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BuscarVehiculo p = new Form_BuscarVehiculo();
            p.Show();
        }

        private void modificarRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ModificarRepuesto p = new Form_ModificarRepuesto();
            p.Show();
        }
    }
}
