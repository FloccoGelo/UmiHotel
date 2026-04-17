using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umi_Library.Class
{
    internal class classEstadia
    {
            public int Id { get; set; }
            public int IdCliente { get; set; }
            public int CodCli { get; set; }
            public DateTime Emissao { get; set; }
            public DateTime? Fechamento { get; set; }
            public decimal VTotal { get; set; }
            public string Status { get; set; }
            public string? Obs { get; set; }
            public classCliente Cliente { get; set; }
    }
}
