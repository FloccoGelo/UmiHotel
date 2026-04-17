using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umi_Library.Class
{
    internal class classQuartoEstadia
    {
            public int Id { get; set; }
            public int IdEstadia { get; set; }
            public int IdQuarto { get; set; }
            public string NumQuarto { get; set; }
            public DateTime CheckIn { get; set; }
            public DateTime PrevisCheckOut { get; set; }
            public DateTime? CheckOut { get; set; }
            public decimal? Diaria { get; set; }
            public int? DiasHospedagem { get; set; }
            public decimal? TotalDiaria { get; set; }
            public int? NumHospedes { get; set; }
            public string Status { get; set; }
            public string? Obs { get; set; }
            public classEstadia Estadia { get; set; }
            public classQuarto Quarto { get; set; }
    }
}
