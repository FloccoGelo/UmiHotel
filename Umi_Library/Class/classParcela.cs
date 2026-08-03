using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umi_Library.Class;
public class classParcela
{
    public int Id {  get; set; }
    public int Doc { get; set; }
    public decimal Valor { get; set; }
    public DateOnly Emissao { get; set; }
    public string Forma { get; set; }
}
