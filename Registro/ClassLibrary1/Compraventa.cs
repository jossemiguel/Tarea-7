using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Entidades;





namespace DAL
{
    public class CompraventaDb : DbContext
    {
        public  CompraventaDb (): base ("Data Source=B8D14X1;Initial Catalog=Prueba;Integrated Security=True")
        {

        }
        public virtual DbSet<Usuarios> Usuario { get; set; }

        
    }

   
}
