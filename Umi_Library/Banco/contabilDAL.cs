using Biblioteca.Banco;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi_Library.Class;

namespace Umi_Library.Banco;

public class contabilDAL
{
    Context context = new Context();
    private readonly Context _contabil;
    public contabilDAL(Context ContextConta)
    {
        this._contabil = ContextConta;
    }

    public void Adicionar(classContabil conta)
    {
        
        _contabil.Add(conta);
        _contabil.SaveChanges();
    }

    public void Editar(classContabil conta)
    {
        _contabil.Update(conta);
        _contabil.SaveChanges();
    }

    public void Excluir(classContabil conta)
    {
        _contabil.Remove(conta);
        _contabil.SaveChanges();
    }

    public List<classContabil> listaContas(string campo, string Inf, String Ativo)
    {
        List<classContabil> lista = new List<classContabil>();

        using (SqlConnection cn = new SqlConnection(context.connection))
        {
            string sql = $"SELECT * FROM CONTA WHERE {campo} LIKE '{Inf}%' AND ATIVO = '{Ativo}'";
            // salva como s e n
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    classContabil conta = new classContabil
                    {
                        Id = (int)dr["Id"],
                        Codigo = (int)dr["CODIGO"],
                        Nome = dr["NOME"].ToString(),
                        tipoContaContabil = dr["tipoContaContabil"].ToString(),
                        Ativo = dr["ATIVO"].ToString(),
                        created = (DateTime)dr["CREATED"],
                        modified = (DateTime)dr["MODIFIED"]
                    };
                    lista.Add(conta);
                }
            }
            ;
        }
        return lista;
    }

    public classContabil trazerClass(string campo, string Inf, String Ativo)
    {
        using (SqlConnection cn = new SqlConnection(context.connection))
        {
            string sql = $"SELECT * FROM CONTA WHERE {campo} LIKE '{Inf}%'";
            // salva como s e n
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {       classContabil conta = new classContabil
                    {
                        Id = (int)dr["Id"],
                        Codigo = (int)dr["CODIGO"],
                        Nome = dr["NOME"].ToString(),
                        tipoContaContabil = dr["TIPOCONTABIL"].ToString(),
                        Ativo = dr["ATIVO"].ToString(),
                        created = (DateTime)dr["CREATED"],
                        modified = (DateTime)dr["MODIFIED"]
                    };
                    return conta;
            };
        }
    }





    public int trazerCodigoConta()
    {
        using (SqlConnection cn = new SqlConnection(context.connection))
        {
            string sql = $"SELECT TOP 1 CODIGO FROM CONTA ORDER BY ID DESC";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            object codigoConta = cmd.ExecuteScalar();
            return Convert.ToInt32(codigoConta);
        }
    }


}
