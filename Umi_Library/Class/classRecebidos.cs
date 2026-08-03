using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Umi_Library.Class
{
    public class classRecebidos
    {
        public int Id { get; set; }
        public string docOrigem { get; set; }
        public int codCli {  get; set; }
        public DateTime emissao { get; set; }
        public DateTime recebimento { get; set; }
        public decimal valor {  get; set; }
        public decimal valRecebido {  get; set; }
        public int numParc {  get; set; }
        public string forma { get; set; }
        public string destino { get; set; } // Caixa ou banco
        public string obs {  get; set; }
    }
}
