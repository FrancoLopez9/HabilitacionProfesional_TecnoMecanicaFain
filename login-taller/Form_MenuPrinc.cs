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
    }
}
