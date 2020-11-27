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
    public partial class Form_BuscarRepuesto : Form
    {
        public Form_BuscarRepuesto()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB_AccesoDatosSQLite.cargarRepuestos();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB_AccesoDatosSQLite.cargarRepuestos().Where(x =>
            x.Nombre.Contains(textBox_Nombre.Text) &
            x.CodigoProveedor.ToString().Contains(textBox_CodigoProveedor.Text)).ToList();
        }
    }
}
