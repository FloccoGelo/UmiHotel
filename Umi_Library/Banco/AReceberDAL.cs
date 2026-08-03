using Biblioteca.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi_Library.Class;

namespace Umi_Library.Banco;

public class AReceberDAL
{
    Context context = new Context();

    private readonly Context _Receber;
    public AReceberDAL(Context receberContext)
    {
        this._Receber = receberContext;
    }
    
    
    public void Adicionar(classAReceber receber)
    {
        _Receber.Add(receber);
        _Receber.SaveChanges();
    }

    public void Editar(classAReceber receber)
    {
        _Receber.Update(receber);
        _Receber.SaveChanges();
    }


}
