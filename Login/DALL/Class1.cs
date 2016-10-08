using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;


namespace DALL
{
    public class Compraventadb : DbContext
    {
        public Compraventadb() : base ("name=ConStr")
        {
                
        }

        public virtual DbSet<Usuarios> Usuarios { get; set; }
   
}
