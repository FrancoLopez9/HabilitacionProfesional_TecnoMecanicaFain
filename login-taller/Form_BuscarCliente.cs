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
    public partial class Form_BuscarCliente : Form
    {
        public Form_BuscarCliente()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB_AccesoDatosSQLite.cargarClientes();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB_AccesoDatosSQLite.cargarClientes().Where(x => x.DNI.ToString().Contains(textBox_DNI.Text)).ToList();
        }
    }
}
