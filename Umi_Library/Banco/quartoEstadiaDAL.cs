using Biblioteca.Banco;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi_Library.Class;

namespace Umi_Library.Banco;

public class quartoEstadiaDAL
{
    Context context = new Context();
   // private readonly Context _quaEstadia;
    public quartoEstadiaDAL(Context _context)
    {
        this.context = _context;
    }

    public void adicionar(classQuartoEstadia Q_Estadia)
    {
        Q_Estadia.Id = 0;
        context.Add(Q_Estadia);
        context.SaveChanges();
    }
        
    public void editar(classQuartoEstadia Q_Estadia)
    {
        context.Update(Q_Estadia);
        context.SaveChanges();
    }


    public void removerQuartos(int idRecebido)
    {
        using(SqlConnection conn = new SqlConnection(context.connection))
        {
            string sql = "DELETE FROM QUARTOESTADIA WHERE ESTADIAID = @teste";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@teste", idRecebido);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }


    public int buscarID_Estadia()
    {
        int id = 0;
        using (SqlConnection conn = new SqlConnection(context.connection))
        {
            string SQL = "SELECT TOP 1 ID FROM ESTADIA ORDER BY ID DESC";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            conn.Open();

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                id = (int)result;
            }
        }
        return id;
    }
    public List<classQuartoEstadia> trazerQuartos(int cod)
    {
        List<classQuartoEstadia> lista = new List<classQuartoEstadia>();
        classQuartoEstadia t = null;
        using (SqlConnection conn = new SqlConnection(context.connection))
        {
            string sql = "SELECT * FROM QUARTOESTADIA WHERE ESTADIAID = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", cod);
            conn.Open();

            using(SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    t = new classQuartoEstadia()
                    {
                        Id = (int)dr["Id"],
                        EstadiaId = (int)dr["EstadiaId"],
                        QuartoId = (int)dr["QuartoId"],
                        NumQuarto = dr["NumQuarto"].ToString(),
                        Check_In = (DateTime)dr["Check_In"],
                        Previs_Check_Out = (DateTime)dr["Previs_Check_Out"],
                        Check_Out = dr["Check_Out"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["Check_Out"],
                        Diaria = (decimal)dr["Diaria"],
                        DiasHospedagem = (int)dr["DiasHospedagem"],
                        TotalDiaria = (decimal)dr["TotalDiaria"],
                        NumHospedes = (int)dr["NumHospedes"],
                        Status = dr["Status"].ToString(),
                        Obs = dr["Obs"].ToString(),
                    };
                    lista.Add(t);
                }
            }
        }
        return lista;
    }

    public classQuartoEstadia trazerQuartoUnico(String campo, String inf)
    {
        classQuartoEstadia t = null;
        using (SqlConnection conn = new SqlConnection(context.connection))
        {
            string sql = $"SELECT * FROM QUARTOESTADIA WHERE {campo} LIKE '{inf}%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            // cmd.Parameters.AddWithValue("@id", cod);
            conn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    t = new classQuartoEstadia()
                    {
                        Id = (int)dr["Id"],
                        EstadiaId = (int)dr["EstadiaId"],
                        QuartoId = (int)dr["QuartoId"],
                        NumQuarto = dr["NumQuarto"].ToString(),
                        Check_In = (DateTime)dr["Check_In"],
                        Previs_Check_Out = (DateTime)dr["Previs_Check_Out"],
                        Check_Out = dr["Check_Out"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["Check_Out"],
                        Diaria = (decimal)dr["Diaria"],
                        DiasHospedagem = (int)dr["DiasHospedagem"],
                        TotalDiaria = (decimal)dr["TotalDiaria"],
                        NumHospedes = (int)dr["NumHospedes"],
                        Status = dr["Status"].ToString(),
                        Obs = dr["Obs"].ToString(),
                    };
                }
            }
        }
        return t;
    }


}
