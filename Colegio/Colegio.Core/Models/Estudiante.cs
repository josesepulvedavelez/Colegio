using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Core.Models
{
    public class Estudiante
    {
        public string NombresApellidos { get; set; }
        public int Edad { get; set; }
        public string Rh { get; set; }
        public string LugarNacimiento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ti { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Talla { get; set; }
        public decimal Peso { get; set; }
        public string Barrio { get; set; }
        public string Localidad { get; set; }
        public int Estrato { get; set; }
        public string Religion { get; set; }
        public string Padre { get; set; }
        public string OficioPadre { get; set; }
        public string CelularPadre { get; set; }
        public string LugarTrabajoPadre { get; set; }
        public string CorreoPadre { get; set; }
        public string Madre { get; set; }
        public string OficioMadre { get; set; }
        public string CelularMadre { get; set; }
        public string LugarTrabajoMadre { get; set; }
        public string CorreoMadre { get; set; }
        public string EstadoCivil { get; set; }
        public string Acudiente { get; set; }
        public string Parentesco { get; set; }
        public string DireccionParentesco { get; set; }
        public string CelularParentesco { get; set; }
        public string Observaciones { get; set; }
        public bool Estado { get; set; }

        [ForeignKey("Grado")]
        public int GradoId { get; set; }

        [Key]
        public int EstudianteId { get; set; }
    }
}
