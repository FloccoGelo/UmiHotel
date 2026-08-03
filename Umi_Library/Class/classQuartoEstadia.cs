using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umi_Library.Class;

public class classQuartoEstadia
{
    public int Id { get; set; }
    public int EstadiaId { get; set; }
    public int QuartoId { get; set; }
    public string NumQuarto { get; set; }
    public DateTime Check_In { get; set; }
    public DateTime Previs_Check_Out { get; set; }
    public DateTime? Check_Out { get; set; }
    public decimal? Diaria { get; set; }
    public int? DiasHospedagem { get; set; }
    public decimal? TotalDiaria { get; set; }
    public int? NumHospedes { get; set; }
    public string Status { get; set; }
    public string? Obs { get; set; }
    public classEstadia Estadia { get; set; }
    public classQuarto Quarto { get; set; }
}
