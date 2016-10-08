using System;
using Entidades;
using DAL;


namespace BLL
{
    public class UsuariosBLL
    {
        

        public static Usuarios Usuario { get; private set; }

        public static bool Insertar(Usuarios Usuario)

        {
            bool retorno = false;
            try
            {
                CompraventaDb db = new CompraventaDb();

                db.Usuario.Add(Usuario);
                db.SaveChanges();

                retorno=  true;
                

            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }
       
    }

    
}
