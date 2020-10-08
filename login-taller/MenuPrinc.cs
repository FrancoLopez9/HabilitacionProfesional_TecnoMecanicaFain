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
    public partial class MenuPrinc : Form
    {
        public MenuPrinc()
        {
            InitializeComponent();

        }

        

       
        private void agregarRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarRepuesto p = new AgregarRepuesto();
            p.Show();
        }

        private void buscarRepuestoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BuscarRepuesto p = new BuscarRepuesto();
            p.Show();
        }
    }
}
