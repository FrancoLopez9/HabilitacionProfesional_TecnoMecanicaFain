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
    public partial class Form_RegistrarVehiculo : Form
    {
        public Form_RegistrarVehiculo()
        {
            InitializeComponent();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            Vehiculo unVehiculo = new Vehiculo();
            unVehiculo.Dominio = textBox_Dominio.Text;
            unVehiculo.Marca = textBox_Marca.Text;
            unVehiculo.Modelo = textBox_Modelo.Text; //Hay que convertir el texto en integer
            unVehiculo.Observaciones = textBox_Observaciones.Text;
            unVehiculo.Año = Int32.Parse(textBox_Año.Text);
            DB_AccesoDatosSQLite.guardarVehiculo(unVehiculo);
            MessageBox.Show("El vehículo se ha registrado exitosamente");
        }
    }
}
