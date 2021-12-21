using Abordo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abordo.Models
{
    public class Cadastrar
    {
        public int IdCli { get; set; }

        public string NomeCli { get; set; }
        public string CPFCli { get; set; }
        public DateTime NasCli { get; set; }
        public string CEPCli { get; set; }
        public string BairroCli { get; set; }
        public string EnderecoCli { get; set; }
        public int NumeroCli { get; set; }
        public int TelefoneCli { get; set; }
        public string EmailCli { get; set; }

        public Situacao Situacao { get; set; }
    }
}
