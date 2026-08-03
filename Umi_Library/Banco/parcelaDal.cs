using Biblioteca.Banco;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi_Library.Class;

namespace Umi_Library.Banco;

public class parcelaDal
{
        Context context = new Context();

        private readonly Context _parcela;
        public parcelaDal(Context ContextParcela)
        {
            this._parcela = ContextParcela;
        }


        public void Adicionar(classParcela parcela)
        {
            _parcela.Add(parcela);
            _parcela.SaveChanges();
        }


        public void Editar(classParcela parcela)
        {
            _parcela.Update(parcela);
            _parcela.SaveChanges();
        }


        public void Remover(int Cod)
        {
            var CodExcluir = _parcela.Parcela.SingleOrDefault(x => x.Id == Cod);

            if (CodExcluir != null)
            {
            _parcela.Parcela.Remove(CodExcluir);
            _parcela.SaveChanges();
            }
        }


    public classParcela BuscarParcela(String campo, String Inf)
    {
        classParcela parcela = null;
        using (SqlConnection cn = new SqlConnection(context.connection))
        {
            string sql = $"SELECT * FROM PARCELA WHERE {campo} LIKE '{Inf}%'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    parcela = new classParcela()
                    {
                        Id = (int)dr["Id"],
                        Doc = (int)dr["DOC"],
                        Emissao = DateOnly.FromDateTime((DateTime)dr["EMISSAO"]),
                        Forma = dr["FORMA"].ToString(),
                        Valor = (decimal)dr["VALOR"],
                    };
                }
            };
        }
        return parcela;
    }
}
