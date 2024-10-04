using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Core.Dtos
{
    public class GradoDto
    {
        public string Observaciones { get; set; }
        public bool Estado { get; set; }

        public int GradoId { get; set; }
    }
}
