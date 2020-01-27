using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDGol.Models
{
    public class Aeronave
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int QtdPassageiros { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
