using Biblioteca.Banco;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi_Library.Class;

namespace Umi_Library.Banco;

public class quartoDAL
{
    Context context = new Context();
    private readonly Context _quarto;
    public quartoDAL(Context contextQuarto)
    {
        this._quarto = contextQuarto;
    }


    public void Adicionar(classQuarto quarto)
    {
        _quarto.Add(quarto);
        _quarto.SaveChanges();
    }

    public void Editar(classQuarto quarto)
    {
        _quarto.Update(quarto);
        _quarto.SaveChanges();
    }

    public void Remover(int id)
    {
        using (SqlConnection conn = new SqlConnection(context.connection))
        {
            string sql = "DELETE QUARTO WHERE ID = @idRecebido";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idRecebido", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public classQuarto trazerQuarto(int id)
    {
        classQuarto _quarto = null;
        using(SqlConnection cn = new SqlConnection(context.connection))
        {
            string sql = "SELECT * FROM QUARTO WHERE ID = @id";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    _quarto = new classQuarto()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Numero = dr["NUMERO"].ToString(),
                        Tipo = dr["TIPO"].ToString(),
                        Capacidade = (int)dr["CAPACIDADE"],
                        NumSolt = Convert.ToInt32(dr["NUMSOLT"]),
                        NumCasal = Convert.ToInt32(dr["NUMCASAL"]),
                        PrecoBase = Convert.ToDecimal(dr["PRECOBASE"]),
                        PrecoAtual = Convert.ToDecimal(dr["PRECOATUAL"]),
                        Ativo = dr["ATIVO"].ToString(),
                        Status = dr["STATUS"].ToString(),
                        Descricao = dr["DESCRICAO"].ToString(),
                        Created = Convert.ToDateTime(dr["CREATED"]),
                        Modified = Convert.ToDateTime(dr["MODIFIED"])
                    };

                };
            };
        };
        return _quarto;
    }
    public List<classQuarto> trazerListaQuarto(string campo, string inf, string ativo)
    {
        List<classQuarto> quartos = new List<classQuarto>();
   
        using (SqlConnection cn = new SqlConnection(context.connection))
        {
            string sql = $"SELECT * FROM QUARTO WHERE {campo} LIKE '{inf}%' AND ATIVO = '{ativo}'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    classQuarto _quarto = new classQuarto()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Numero = dr["NUMERO"].ToString(),
                        Tipo = dr["TIPO"].ToString(),
                        Capacidade = (int)dr["CAPACIDADE"],
                        NumSolt = Convert.ToInt32(dr["NUMSOLT"]),
                        NumCasal = Convert.ToInt32(dr["NUMCASAL"]),
                        PrecoBase = Convert.ToDecimal(dr["PRECOBASE"]),
                        PrecoAtual = Convert.ToDecimal(dr["PRECOATUAL"]),
                        Ativo = dr["ATIVO"].ToString(),
                        Status = dr["STATUS"].ToString(),
                        Descricao = dr["DESCRICAO"].ToString(),
                        Created = Convert.ToDateTime(dr["CREATED"]),
                        Modified = Convert.ToDateTime(dr["MODIFIED"])
                    };
                    quartos.Add(_quarto);
                };
            };
        };
        return quartos;
    }
}
