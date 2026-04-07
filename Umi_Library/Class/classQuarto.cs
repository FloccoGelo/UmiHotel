using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umi_Library.Class;

public class classQuarto
{
        public int Id { get; set; }
        public string Numero { get; set; }
        public string? Tipo { get; set; }
        public int Capacidade { get; set; }
        public int NumSolt { get; set; }
        public int NumCasal { get; set; }
        public decimal? PrecoBase { get; set; }
        public decimal? PrecoAtual { get; set; }
        public string Ativo { get; set; }
        public string? Status { get; set; }
        public string? Descricao { get; set; }
        DateTime? created { get; set; }
        DateTime? modified { get; set; }
}
