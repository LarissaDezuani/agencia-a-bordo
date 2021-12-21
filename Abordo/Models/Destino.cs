using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abordo.Models
{
    public class Destino
    {
        public int IdDestino { get; set; }

        public string CPFCli { get; set; }
        public string PartidaDestino { get; set; }
        public string NomeDestino { get; set; }
        public string HoraDestino { get; set; }
        public DateTime DataDestina { get; set; }
    }
}
