using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;

namespace Registro_Usuarios
{
    public class Datos
    {
       private  SqlConnection MiConecxion;
        private string ConnectionString = "Data Source=.;Initial Catalog=Usuarios;Integrated Security=True";

        public void Conectar ()
        {
            MiConecxion = new SqlConnection(ConnectionString);
            MiConecxion.Open();

        }   

        public void Desconecar()
        {
            MiConecxion.Close();
        }



        public void ejecutarSql(String Query)
        {



            SqlCommand MiComando = new SqlCommand(Query, MiConecxion);
            int filas = 0;
            filas = MiComando.ExecuteNonQuery();



            if (filas > 0)

                MessageBox.Show("Operacion Realizada", "La Base de Datos ha sido Modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se Realizo La Operacion", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void Actualizar(DataGridView dg, string Query)
        {
            this.Conectar();
            System.Data.DataSet MiDataset = new System.Data.DataSet();
            
            

            SqlDataAdapter DataAdapter = new SqlDataAdapter(Query,MiConecxion);
            
            DataAdapter.Fill(MiDataset, "Datos");
            dg.DataSource = MiDataset;
            dg.DataMember = "Datos";
            Desconecar();


        }
    }
}
