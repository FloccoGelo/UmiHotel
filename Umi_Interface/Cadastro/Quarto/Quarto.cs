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

namespace Umi_Interface.Cadastro.Quarto;

public partial class Quarto : Form
{
    Context _context = new Context();
    quartoDAL _quartoDAL;
    public Quarto()
    {
        _quartoDAL = new quartoDAL(_context);
        InitializeComponent();
    }
    private void Quarto_Load(object sender, EventArgs e)
    {
        listar();
    }

    // ------ PEGAR ID
    private int idSelecionado;
    private void DataGrid_SelectionChanged(object sender, EventArgs e)
    {
        if (bindingQuarto.Current is classQuarto qua)
        {
            idSelecionado = qua.Id;
        }
        else
        {
            idSelecionado = 0;
        }
    }
    // ---------------------------------
    // -------------------- LISTAR DADOS
    private void listar()
    {
        DataGrid.AutoGenerateColumns = false;
        List<classQuarto> lista = _context.Quarto.Select(q => new classQuarto
        {
            Id = q.Id,
            Numero = q.Numero,
            Tipo = q.Tipo,
            Capacidade = q.Capacidade,
            PrecoAtual = q.PrecoAtual,
            Status = q.Status,
            Descricao = q.Descricao
        }).ToList();
        bindingQuarto.DataSource = lista;
        DataGrid.DataSource = bindingQuarto;
    }

    // --------------------------
    // ---------------- BOTOES
    private void btnNovo_Click(object sender, EventArgs e)
    {
        novoQuarto novoQuarto = new novoQuarto();
        novoQuarto.ShowDialog();
        listar();
    }
    private void btnEditar_Click(object sender, EventArgs e)
    {
        if (idSelecionado > 0)
        {
            novoQuarto quartoEditar = new novoQuarto(idSelecionado);
            quartoEditar.ShowDialog();
            listar();
        }
        else
        {
            MessageBox.Show("Selecione um cliente para editar.");
        }
    }
    private void btnExcluir_Click(object sender, EventArgs e)
    {
        _quartoDAL.Remover(idSelecionado);
        MessageBox.Show("Quarto excluido com sucesso");
        listar();
    }
}
