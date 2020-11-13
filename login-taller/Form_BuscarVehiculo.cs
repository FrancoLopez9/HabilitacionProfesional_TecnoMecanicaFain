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
    public partial class Form_BuscarVehiculo : Form
    {
        public Form_BuscarVehiculo()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB_AccesoDatosSQLite.cargarVehiculos();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB_AccesoDatosSQLite.cargarVehiculos().Where(x =>
            x.Dominio.Contains(textBox_Dominio.Text)).ToList();
        }

        private void button_RegistrarVehiculo_Click(object sender, EventArgs e)
        {
            Form_RegistrarVehiculo p = new Form_RegistrarVehiculo();
            p.Show();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
