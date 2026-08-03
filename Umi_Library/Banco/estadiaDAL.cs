using Biblioteca.Banco;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi_Library.Class;

namespace Umi_Library.Banco;

public class estadiaDAL
{
    Context context = new Context();
    private readonly Context _estadia;

    public estadiaDAL (Context estadiaContext)
    {
        this._estadia = estadiaContext;
    }

    public void Adicionar(classEstadia estadia)
    {
        _estadia.Add(estadia);
        _estadia.SaveChanges();
    }

    public void Editar(classEstadia estadia)
    {
        _estadia.Update(estadia);
        _estadia.SaveChanges();
    }

    public void excluir(int id)
    {
        using (SqlConnection conn = new SqlConnection(context.connection))
        {
            string sql = "DELETE ESTADIA WHERE ID = @idRecebido";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idRecebido", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }        
    }
    public int gerarDoc()
    {
        int documento = 0;
        using (SqlConnection conn = new SqlConnection(context.connection))
        {
            string sql = "SELECT DOC FROM ESTADIA ORDER BY DOC DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            object result = cmd.ExecuteScalar();
            if(result != null)
            {
                documento = (int)result;
            }
        }
        return documento;
    }

    public classEstadia TrazerEstadia(String campo, String inf)
    {
        classEstadia estadia = null;
        using (SqlConnection conn = new SqlConnection(context.connection))
        {
            string sql = $"SELECT * FROM ESTADIA WHERE {campo} = {inf}";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@id", cod);
            conn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    estadia = new classEstadia()
                    {
                        Id = (int)dr["ID"],
                        doc = (int)dr["DOC"],
                        ClienteId = (int)dr["CLIENTEID"],
                        CodCli = (int)dr["CODCLI"],
                        Emissao = (DateTime)dr["EMISSAO"],
                        Fechamento = dr["FECHAMENTO"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["FECHAMENTO"],
                        VTotal = (decimal)dr["VTOTAL"],
                        Status = dr["STATUS"].ToString(),
                        Obs = dr["OBS"].ToString(),
                    };
                }
            }
        };
        return estadia;
    }

    public List<classEstadia> listarEstadias()
    {
        List<classEstadia> lista = new List<classEstadia>();
        using (SqlConnection conn = new SqlConnection(context.connection))
        {
            //string sql = $"SELECT * FROM ESTADIA WHERE {campo} LIKE '{inf}%'";
            string sql = $"SELECT * FROM ESTADIA";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    classEstadia t = new classEstadia()
                    {
                        Id = (int)dr["ID"],
                        doc = (int)dr["DOC"],
                        ClienteId = (int)dr["CLIENTEID"],
                        CodCli = (int)dr["CODCLI"],
                        Emissao = (DateTime)dr["EMISSAO"],
                        Fechamento = dr["FECHAMENTO"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["FECHAMENTO"],
                        VTotal = (decimal)dr["VTOTAL"],
                        Status = dr["STATUS"].ToString(),
                        Obs = dr["OBS"].ToString(),
                    };
                    lista.Add(t);
                }
            }
        }
        return lista;
    }


    public List<classEstadia> listarEstadiasCliente()
    {
        List<classEstadia> lista = new List<classEstadia>();
        using (SqlConnection conn = new SqlConnection(context.connection))
        {
            //string sql = $"SELECT * FROM ESTADIA WHERE {campo} LIKE '{inf}%'";
            string sql = $"SELECT * FROM ESTADIA INNER JOIN CLIENTE ON CLIENTE.CODCLI = ESTADIA.CODCLI";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    classEstadia t = new classEstadia()
                    {
                        Id = (int)dr["ID"],
                        doc = (int)dr["DOC"],
                        ClienteId = (int)dr["CLIENTEID"],
                        CodCli = (int)dr["CODCLI"],
                        Emissao = (DateTime)dr["EMISSAO"],
                        Fechamento = dr["FECHAMENTO"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["FECHAMENTO"],
                        VTotal = (decimal)dr["VTOTAL"],
                        Status = dr["STATUS"].ToString(),
                        Obs = dr["OBS"].ToString(),
                        NomeCLiente = dr["Nome"].ToString(),
                    };
                    /*classCliente h = new classCliente()
                    {
                        Nome = dr["NOME"].ToString(),
                    };*/
                    //MessageBox.Show("Cliente: "+h.Nome);
                    //String nomeCli = h.Nome;
                    //lista.Add((nomeCli, t));
                    lista.Add((t));
                }
            }
        }
        return lista;
    }

}
