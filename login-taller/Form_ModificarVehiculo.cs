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
    public partial class Form_ModificarVehiculo : Form
    {
        Vehiculo unVehiculo = new Vehiculo();
        public Form_ModificarVehiculo()
        {
            InitializeComponent();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Seleccionar_Click(object sender, EventArgs e)
        {
            unVehiculo = DB_AccesoDatosSQLite.devolverVehiculo(Int32.Parse(textBox_NumeroVehiculo.Text));
            textBox_Dominio.Text = unVehiculo.Dominio;
            textBox_Marca.Text = unVehiculo.Marca;
            textBox_Modelo.Text = unVehiculo.Modelo;
            textBox_Año.Text = unVehiculo.Año.ToString();
            textBox_Observaciones.Text = unVehiculo.Observaciones;        
        }

        private void button_BuscarNumero_Click(object sender, EventArgs e)
        {
            Form_BuscarVehiculo p = new Form_BuscarVehiculo();
            p.Show();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            unVehiculo.Dominio = textBox_Dominio.Text;
            unVehiculo.Marca = textBox_Marca.Text;
            unVehiculo.Modelo = textBox_Modelo.Text;
            unVehiculo.Año = Int32.Parse(textBox_Año.Text);
            unVehiculo.Observaciones = textBox_Observaciones.Text;
            DB_AccesoDatosSQLite.modificarVehiculo(unVehiculo);
            MessageBox.Show("El vehiculo se ha modificado exitosamente");
        }
    }
}
