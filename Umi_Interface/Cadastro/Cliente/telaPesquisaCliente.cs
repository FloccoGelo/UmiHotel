using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umi_Library.Class;
using Umi_Library.Banco;
using Biblioteca.Banco;

namespace Umi_Interface.Estadia;

public partial class telaPesquisaCliente : Form
{
    //classCliente _cliente = new classCliente;
    Context _context = new Context();
    clienteDAL _dal;
    public telaPesquisaCliente()
    {
        _dal = new clienteDAL(_context);
        InitializeComponent();
    }
    private void telaPesquisaCliente_Load(object sender, EventArgs e)
    {
        listar();
        radioCPF.Checked = true;
        radioNome.Checked = false;

        dataGrid.ClearSelection();
    }

    private string pesquisarPor()
    {
        string pesquisa;
        if (radioCPF.Checked)
        {
            pesquisa = "CPF";
        } else
        {
            pesquisa = "NOME";
        }
        return pesquisa;
    }

    private void listar()
    {
        String ativo = "s";
        String pesquisa = textPesquisa.Text;

        List<classCliente> lista = _dal.listaClientes(pesquisarPor(), pesquisa, ativo);
        bsLista.DataSource = lista;
        dataGrid.DataSource = bsLista;
    }
    
    public int _idSelecionado;
    private void dataGrid_DoubleClick(object sender, EventArgs e)
    {
        if (bsLista.Current is classCliente cli)
        {
            _idSelecionado = cli.Id;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        else
        {
            MessageBox.Show("ID NAO SELECIONADO :( :( :(");
        }
    }

    private void textPesquisa_TextChanged(object sender, EventArgs e)
    {
        listar();
    }
}
