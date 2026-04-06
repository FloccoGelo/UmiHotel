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

namespace Umi_Interface.Cadastro;

public partial class Cliente : Form
{
    clienteDAL _Dal;
    Context _context = new Context();
    public Cliente()
    {
        _Dal = new clienteDAL(_context);
        InitializeComponent();
    }
    private void Cliente_Load(object sender, EventArgs e)
    {
        atualizar();
    }
    private void atualizar()
    {
        listar();
    }




    // --------------------------------------------------------------------------
    // --------------------------------------------------------------- BOTOES
    private void btnNovo_Click(object sender, EventArgs e)
    {
        novoCliente _novoCliente = new novoCliente();
        _novoCliente.ShowDialog();
        atualizar();
    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        if (_idSelecionado > 0)
        {
            novoCliente editarCli = new novoCliente(_idSelecionado);
            editarCli.ShowDialog();
            atualizar();
        }
        else
        {
            MessageBox.Show("Selecione um cliente para editar.");
        }
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if(_idSelecionado > 0)
        {
            _Dal.Remover(_idSelecionado);
            atualizar();
        } else
        {
            MessageBox.Show("Selecione um cliente para excluir");
        }
        
    }

    // --------------------------------------------------------------------------
    // ----------------------------------------------------------------- LISTAR

    private void verID() // id por algum motivo nao lista usando o binding, precisei criar essa funçao
    {
        DataGrid.Columns.Add(new DataGridViewTextBoxColumn()
        {
            Name = "Id",
            HeaderText = "Id",
            DataPropertyName = "Id",
            Visible = false,
        });
    }
    private void listar()
    {
        verID();
        DataGrid.AutoGenerateColumns = false;
        List<classCliente> Lista = _context.Cliente.Select(c => new classCliente
        {
            Id = c.Id,
            CodCli = c.CodCli,
            Nome = c.Nome,
            CPF = c.CPF,
            Telefone1 = c.Telefone1
        }).ToList();
        bindingCliente.DataSource = Lista;
        DataGrid.DataSource = bindingCliente;

        DataGrid.CurrentCell = null;
    }

    // --------------------------------------------------------------------------
    // ------------------------------------------------------------- PEGAR ID
    private int _idSelecionado;
    private void DataGrid_SelectionChanged(object sender, EventArgs e)
    {
        // current é o item selecionado, se for do tipo classCliente, pega o id, senao seta 0
        if (bindingCliente.Current is classCliente cli) 
        {
            _idSelecionado = cli.Id;
        }
        else
        {
            _idSelecionado = 0;
        }
    }
}
// - - -