using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umi_Library.Class;

public class classAReceber
{
        public int Id { get; set; }
        public string docOrigem { get; set; }
        public int codCli { get; set; }
        public DateTime emissao { get; set; }
        public int diasVenc {  get; set; }
        public DateTime vencimento { get; set; }
        public decimal valor { get; set; }
        public decimal valorTot { get; set; }
        public decimal saldo { get; set; }
        public int numParc { get; set; }
        public string forma { get; set; }
        public string obs { get; set; }
}
