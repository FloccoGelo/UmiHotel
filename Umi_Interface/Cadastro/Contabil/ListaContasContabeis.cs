using Biblioteca.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umi_Library.Banco;
using Umi_Library.Class;

namespace Umi_Interface.Cadastro.Contabil;

public partial class ListaContasContabeis : Form
{
    List<classContabil> lista = new List<classContabil>();
    Context _context = new Context();
    contabilDAL _Dal;

    public ListaContasContabeis()
    {
        _Dal = new contabilDAL(_context);
        InitializeComponent();
    }
    private void ListaContasContabeis_Load(object sender, EventArgs e)
    {
        listar();
    }



    private void btnNovo_Click(object sender, EventArgs e)
    {
        novaContabil nova = new novaContabil();
        nova.ShowDialog();
        listar();
    }

    private void listar()
    {
        lista = _Dal.listaContas("NOME", "%", "S");
        bsContabil.DataSource = lista;
        dataGridConta.DataSource = bsContabil;
    }

    private classContabil editar()
    {
        classContabil ed = new classContabil();
        if (bsContabil.Current is classContabil con)
        {
            ed = con;
        }
        return ed;
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        if (editar() == null)
        {
            MessageBox.Show("Selecione uma conta contabil para editar");
        }
        else
        {
            novaContabil ll = new novaContabil(editar());
            ll.ShowDialog();
        }


    }
}
