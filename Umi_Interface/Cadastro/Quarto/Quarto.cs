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
using Umi_Interface.Avisos;
using Umi_Library.Banco;
using Umi_Library.Class;

namespace Umi_Interface.Cadastro.Quarto;

public partial class Quarto : Form
{
    Context _context = new Context();
    quartoDAL _quartoDAL;
    quartoEstadiaDAL _quartoEstadiaDAL;
    public Quarto()
    {
        _quartoEstadiaDAL = new quartoEstadiaDAL(_context);
        _quartoDAL = new quartoDAL(_context);
        InitializeComponent();
    }
    private void Quarto_Load(object sender, EventArgs e)
    {
        listar();
        DataGrid.ClearSelection();
        radioDescr.Checked = true;
        radioNumero.Checked = false;
        comboAtivo.SelectedIndex = 0;
    }

    // ------ PEGAR ID
    int idSelecionado = 0;
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
    int validador = 0;
    private int verificarExistencia()
    {
        // chama a funçao de trazer quarto
        // salva em uma classe declarada
        // se a classe nao for null, validador = 1, se nao = 0
        String inf = idSelecionado.ToString();
        classQuartoEstadia quarto = _quartoEstadiaDAL.trazerQuartoUnico("QuartoId", inf);

        if (quarto != null)
        {
            validador = 1;
        } else 
        {
            validador = 0;
        }
            return validador;
    }
    // ---------------------------------
    // -------------------- LISTAR DADOS

    private String campoPesquisa()
    {
        String campo;
        if (radioNumero.Checked)
        {
            campo = "NUMERO";
        }
        else
        {
            campo = "DESCRICAO";
        }
        return campo;
    }

    private void listar()
    {

        String ativo = comboAtivo.Text;
        String j = textPesquisa.Text;
        List<classQuarto> lista = new List<classQuarto>();

        if (ativo == "Sim")
        {
            lista = _quartoDAL.trazerListaQuarto(campoPesquisa(), j, "S");
        }
        else
        {
            lista = _quartoDAL.trazerListaQuarto(campoPesquisa(), j, "N");
        }

        bindingQuarto.DataSource = null;
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
        if(idSelecionado == 0)
        {
            String mensagem = "Selecione um cliente para excluir";
            avisoOk aviso = new avisoOk(mensagem);
            aviso.ShowDialog();
            listar();
        } 
        else if (verificarExistencia() == 1)
        {
            String mensagem = "Cliente ja vinculado a outros documentos\nNao é possivel excluir, desabilite o cadastro";
            avisoOk aviso = new avisoOk(mensagem);
            aviso.ShowDialog();
            listar();
        }
        else
        {
            _quartoDAL.Remover(idSelecionado);
            avisoOk aviso = new avisoOk("Quarto excluido com sucesso");
            aviso.ShowDialog();
            listar();
        }
    }


    
    private void textPesquisa_TextChanged(object sender, EventArgs e)
    {
        listar();
    }

    private void comboAtivo_SelectedIndexChanged(object sender, EventArgs e)
    {
        listar();
    }
}
