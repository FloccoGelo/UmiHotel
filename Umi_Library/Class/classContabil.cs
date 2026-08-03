using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umi_Library.Class;

public class classContabil
{
        public int Id { get; set; }       
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string tipoContaContabil { get; set; } // debito credito
       // public int? ContaPaiId { get; set; }
        public string Ativo { get; set; }
        public string Observacao { get; set; }
        public DateTime created {  get; set; }
        public DateTime modified { get; set; }
}
