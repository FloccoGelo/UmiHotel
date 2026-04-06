using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umi_Library.Class;


public class classCliente
{
    public int Id { get; set; }
    public int CodCli { get; set; }
    public String Nome { get; set; }
    public DateTime? Nascimento { get; set; }
    public string? Sexo { get; set; }
    public string CPF { get; set; }
    public string? RG { get; set; }
    public bool Ativo { get; set; }
    public string? Telefone1 { get; set; }
    public string? Telefone2 { get; set; }
    public string? Email { get; set; }
    public string? Observacoes { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? Modified { get; set; }

    /*
        Id - int
        CodCli - int
        Nome - varchar(120)

        Nascimento - datetime2
        Sexo - varchar(25)
        CPF - varchar(16)
        RG - varchar(16)

        Telefone1 - varchar(20)
        Telefone2 - varchar(20)
        Email - varchar(120)
      
        Observacoes - nvarchar(max)

        Ativo - bit
        Created - datetime2
        Modified - datetime2
    */
}
