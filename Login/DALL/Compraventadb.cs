using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DALL
{
    class Compraventadb : DbContext
    {
        public Compraventadb(): base ("name= Constr");



    }

    
}
