using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Usuarios

    {
        [Key]
        public string  UsuarioId { get; set; }

        public string Nombre { get; set; }

        public string Clave { get; set; }

    }
}
