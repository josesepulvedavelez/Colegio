using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Core.Models
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Nivel { get; set; }

        public bool Estado { get; set; }

        [Key]
        public int UsuarioId { get; set; }
    }
}
