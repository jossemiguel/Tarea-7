using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registro_Usuarios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          


            Registro usar = new Registro();
            usar.ShowDialog();

            this.Close();

            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
