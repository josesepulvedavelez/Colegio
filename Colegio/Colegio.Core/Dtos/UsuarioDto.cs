using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Core.Dtos
{
    public class UsuarioDto
    {
        public static string NombreUsuario { get; set; }
        //public string Contrasena { get; set; }
        public static string Nivel { get; set; }

        public static bool Estado { get; set; }

        //[Key]
        public static int UsuarioId { get; set; }
    }
}
