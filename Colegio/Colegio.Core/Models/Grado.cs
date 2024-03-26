﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Core.Models
{
    public class Grado
    {
        public string GradoNombre { get; set; }
        public string Observaciones { get; set;}
        public bool Estado { get; set; }

        [Key]
        public int GradoId { get; set; }
    }
}
