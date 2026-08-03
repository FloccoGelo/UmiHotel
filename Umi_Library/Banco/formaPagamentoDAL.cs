using Biblioteca.Banco;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi_Library.Class;

namespace Umi_Library.Banco;

public class formaPagamentoDAL
{
    Context context = new Context();
    private readonly Context _forma;
    public formaPagamentoDAL(Context formaConta)
    {
        this._forma = formaConta;
    }

    public void Adicionar(classFormaPagamento forma)
    {
        _forma.Add(forma);
        _forma.SaveChanges();
    }

    public void Editar(classFormaPagamento forma)
    {
        _forma.Update(forma);
        _forma.SaveChanges();
    }

    public void Excluir(classFormaPagamento forma)
    {
        _forma.Remove(forma);
        _forma.SaveChanges();
    }

    public List<classFormaPagamento> listaFormas(string campo, string Inf, String Ativo)
    {
        List<classFormaPagamento> lista = new List<classFormaPagamento>();

        using (SqlConnection cn = new SqlConnection(context.connection))
        {
            string sql = $"SELECT * FROM FORMAPAGAMENTO WHERE {campo} LIKE '{Inf}%' AND ATIVO = '{Ativo}'";
            // salva como s e n
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    classFormaPagamento forma = new classFormaPagamento
                    {
                        Id = (int)dr["Id"],
                        codigo = (int)dr["CODIGO"],
                        nome = dr["NOME"].ToString(),
                        banco = dr["BANCO"].ToString(),
                        tipoPagamento = dr["TIPOPAGAMENTO"].ToString(),
                        taxa = (decimal)dr["CREATED"],
                        ativo = dr["ATIVO"].ToString(),
                        obs = dr["OBS"].ToString(),
                        created = (DateTime)dr["CREATED"],
                        modified = (DateTime)dr["MODIFIED"]
                    };
                    lista.Add(forma);
                }
            }
            ;
        }
        return lista;
    }


}
