using System;
using System.Windows.Forms;
using Entidades;
using BLL;
namespace Registro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();

            string agregar= " insert intro Datos (UsuarioID,Contasena, Repetircontrasena) value ('" + textID.Text + "','" + textCON.Text + "','" + textRCON.Text + "' )";

            //Usuario.UsuariosId = 0;
            //Usuario.Nombre = "Jose Miguel";
            //Usuario.Clave = "123456";

            if (UsuariosBLL.Insertar(Usuario))
            {
                MessageBox.Show(" Guardado");

            }

            textID.Clear();
            textCON.Clear();
            textRCON.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
