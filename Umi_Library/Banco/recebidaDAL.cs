using Biblioteca.Banco;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi_Library.Class;

namespace Umi_Library.Banco;

public class recebidaDAL
{
    Context context = new Context();
    private readonly Context _recebida;
    public recebidaDAL(Context ContextRecebida)
    {
        this._recebida = ContextRecebida;
    }

    public void Adicionar(classRecebidos recebidas)
    {
        _recebida.Add(recebidas);
        _recebida.SaveChanges();
    }

    public void Editar(classRecebidos recebidas)
    {
        _recebida.Update(recebidas);
        _recebida.SaveChanges();
    }

    public classRecebidos BuscarRecebida(String campo, String Inf)
    {
        classRecebidos recebida = null;
        using (SqlConnection cn = new SqlConnection(context.connection))
        {
            string sql = $"SELECT * FROM RECEBIDAS WHERE {campo} LIKE '{Inf}%'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    recebida = new classRecebidos()
                    {
                        Id = (int)dr["Id"],
                        docOrigem = dr["DocOrigem"].ToString(),
                        codCli = (int)dr["codCli"],
                        emissao = (DateTime)dr["EMISSAO"],
                        recebimento = (DateTime)dr["RECEBIMENTO"],
                        valor = (decimal)dr["VALOR"],
                        valRecebido = (decimal)dr["valRecebido"],
                        numParc = (int)dr["numParc"],
                        forma = dr["FORMA"].ToString(),
                        destino = dr["DESTINO"].ToString(),
                        obs = dr["OBS"].ToString(),
                    };
                }
            };
        }
        return recebida;
    }

    public List<classRecebidos> listaRecebidas(String campo, String Inf)
    {
        List<classRecebidos> lista = new List<classRecebidos>();
        classRecebidos recebida = null;
        using (SqlConnection cn = new SqlConnection(context.connection))
        {
            string sql = $"SELECT * FROM RECEBIDAS WHERE {campo} LIKE '{Inf}%'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    recebida = new classRecebidos()
                    {
                        Id = (int)dr["Id"],
                        docOrigem = dr["DocOrigem"].ToString(),
                        codCli = (int)dr["codCli"],
                        emissao = (DateTime)dr["EMISSAO"],
                        recebimento = (DateTime)dr["RECEBIMENTO"],
                        valor = (decimal)dr["VALOR"],
                        valRecebido = (decimal)dr["valRecebido"],
                        numParc = (int)dr["numParc"],
                        forma = dr["FORMA"].ToString(),
                        destino = dr["DESTINO"].ToString(),
                        obs = dr["OBS"].ToString(),
                    };
                    lista.Add(recebida);
                }
            };
        }
        return lista;
    }
    // --- fim
}
