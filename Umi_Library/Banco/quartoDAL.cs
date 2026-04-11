using Biblioteca.Banco;
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

    public void Remover(int cod)
    {
        if(cod != 0)
        {
            _quarto.Remove(cod);
            _quarto.SaveChanges();
        }
    }
}
