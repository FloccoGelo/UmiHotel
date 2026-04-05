using Biblioteca.Banco;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi_Library.Class;

namespace Umi_Library.Banco;

public class clienteDAL
{
    Context context = new Context();

    private readonly Context _clienteContext;
    public clienteDAL(Context ContextCliente)
    {
        this._clienteContext = ContextCliente;
    }


    public void Adicionar(classCliente clientes)
    {
        _clienteContext.Add(clientes);
        _clienteContext.SaveChanges();
    }


    public void Editar(classCliente cliente)
    {
        _clienteContext.Update(cliente);
        _clienteContext.SaveChanges();
    }


    public void Remover(int Cod)
    {
        var CodExcluir = _clienteContext.Cliente.SingleOrDefault(x => x.Id == Cod);

        if (CodExcluir != null)
        {
            _clienteContext.Cliente.Remove(CodExcluir);
            _clienteContext.SaveChanges();
        }
    }


    public classCliente BuscarID(int id)
    {
        classCliente cliente = null;
        using (SqlConnection cn = new SqlConnection(context.connection))
        {
            string sql = "SELECT * FROM CLIENTE WHERE ID = @id";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);

            cn.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    cliente = new classCliente
                    {
                        Id = (int)dr["Id"],
                        CodCli = (int)dr["CODCLI"],
                        Nome = dr["NOME"].ToString(),
                        Nascimento = (DateTime)dr["NASCIMENTO"],
                        Sexo = dr["SEXO"].ToString(),
                        CPF = dr["CPF"].ToString(),
                        RG = dr["RG"].ToString(),
                        Ativo = (bool)dr["ATIVO"],
                        Telefone1 = dr["TELEFONE1"].ToString(),
                        Telefone2 = dr["TELEFONE2"].ToString(),
                        Email = dr["EMAIL"].ToString(),
                        Observacoes = dr["OBSERVACOES"].ToString(),
                        Created = (DateTime)dr["CREATED"],
                        Modified = (DateTime)dr["MODIFIED"],
                    };
                }
            }
            ;
        }
        return cliente;
    }

    public int gerarCod()
    {
        int codido = 0;
        using (SqlConnection conn = new SqlConnection(context.connection))
        {
            string sql = "SELECT TOP 1 CODCLI FROM CLIENTE ORDER BY CODCLI DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

           object result = cmd.ExecuteScalar();
            if(result != null)
            {
                codido = (int)result;
            }
        };
        return codido;
    }

}
