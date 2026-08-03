using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umi_Library.Class;

public class classFormaPagamento
{
    public int Id { get; set; }
    public int contabilId { get; set; }
    public string contabil { get; set; }
    public int codigo { get; set; }
    public string nome { get; set; }
    public string banco { get; set; } // banco ou caixa de destino do dinheiro vinculado na forma
    public string tipoPagamento {  get; set; } // a prazo ou a vista
    public decimal taxa { get; set; }
    public string ativo { get; set; }
    public string obs { get; set; }
    public DateTime created { get; set; }
    public DateTime modified { get; set; }
}
