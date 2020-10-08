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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();   
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
            MenuPrinc p = new MenuPrinc();
            p.Show();
            Close();
            
        }

        
    }
}