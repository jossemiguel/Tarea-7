using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Usuarios
{
    public partial class Registro : Form
    {
        Boolean modificar;
        Datos db = new Datos();
        string codigo = "";
        
        public Registro()
        {
            InitializeComponent();
            

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            modificar =false;
            Datos objeto = new Datos();
             objeto.Actualizar(Despliegue, "select * from Datos");
           
        }

        private void TextGuardar_Click(object sender, EventArgs e)
        {
            if(modificar)
            {
                
                db.Conectar();

                String Query = "update Datos set nombre='" + TextNombre.Text + "', Apellidos = '" + TextApellidos.Text + "', edad=" + TextEdad.Text + "',Fecha="+ Fecha.Text+", where ID ='" + codigo + "';";
                db.ejecutarSql(Query);
                db.Actualizar(Despliegue, "select *from Datos");
                TextModificar.Enabled = true;
                TextID.Clear();
                TextNombre.Clear();
                TextApellidos.Clear();
                TextEdad.Clear();
                db.Desconecar();
                
                modificar = false;
                TextID.Enabled = true;
            }

            else
            {

                db.Conectar();
                String query = " insert into Datos (ID, Nombre, Apellidos,Fecha, Edad) values ('" + TextID.Text + "','" + TextNombre.Text + "','" + TextApellidos.Text + "', '"+ Fecha.Text+"'," + TextEdad.Text + ")";


                db.ejecutarSql(query);
                db.Actualizar(Despliegue, "select *from Datos;");
                TextID.Clear();
                TextNombre.Clear();
                TextApellidos.Clear();
                TextEdad.Clear();
                db.Desconecar();
            }

}
        private void TextModificar_Click(object sender, EventArgs e)
        {
            modificar = true;
            TextID.Enabled = false;
          

            codigo = Despliegue.CurrentRow.Cells[0].Value.ToString();
            TextNombre.Text = Despliegue.CurrentRow.Cells[1].Value.ToString();
            TextApellidos.Text = Despliegue.CurrentRow.Cells[2].Value.ToString();
            TextEdad.Text = Despliegue.CurrentRow.Cells[3].Value.ToString();


        }

        

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            db.Actualizar(Despliegue, "select * from Datos where nombre like '" + textBuscar.Text + "%';");

        }

        private void TextEliminar_Click(object sender, EventArgs e)
        {
            codigo = Despliegue.CurrentRow.Cells[0].Value.ToString();

            var resultado = MessageBox.Show("Estas Seguro que deseas Borrar este Dato", "Confirme ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado==DialogResult.Yes)
            {
                db.Conectar();
                String Query = " delete from Datos where ID = '" + codigo + "';";
                db.ejecutarSql(Query);
                db.Actualizar(Despliegue, "select * from Datos");
                db.Desconecar();

            }
            else
            {
                return;
            }

        }

        private void Despliegue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
