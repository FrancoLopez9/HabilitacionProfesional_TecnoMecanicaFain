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
    public partial class Form_BuscarProveedor : Form
    {
        public Form_BuscarProveedor()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB_AccesoDatosSQLite.cargarProveedores();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB_AccesoDatosSQLite.cargarProveedores().Where(x =>
            x.CUIT.Contains(textBox_CUIT.Text) &
            x.RazonSocial.Contains(textBox_RazonSocial.Text)).ToList();
        }

        private void button_RegistrarProveedor_Click(object sender, EventArgs e)
        {
            Form_RegistrarProveedor p = new Form_RegistrarProveedor();
            p.Show();
        }

        private void Form_BuscarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
