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
using Umi_Interface.Avisos;
using System.Reflection.Metadata.Ecma335;

namespace Umi_Interface.Cadastro;



public partial class Cliente : Form
{
    private int _idSelecionado = 0;
    private int codigo;
    private String nome;

    clienteDAL _Dal;
    estadiaDAL _EstDal;
    Context _context = new Context();
    List<classCliente> listaClientes = new List<classCliente>();

    // ==================================================
    // -    CONSTRUTOR
    // ==================================================
    public Cliente()
    {
        _EstDal = new estadiaDAL(_context);
        _Dal = new clienteDAL(_context);
        InitializeComponent();
    }
    private void Cliente_Load(object sender, EventArgs e)
    {
        atualizar();
        radioNome.Checked = true;
        radioCPF.Checked = false;
        comboAtivo.SelectedIndex = 0;
    }
    private void atualizar()
    {
        listar();
    }



    // ==================================================
    // -    BOTOES - novo-editar-excluir-voltar
    // ==================================================
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
            avisoOk aviso = new avisoOk("Selecione um cliente para editar.");
            aviso.ShowDialog();
        }

        //String pesquisa = textPesquisa.Text;
        //MessageBox.Show(campoPesquisa() + "---" + pesquisa);
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if (_idSelecionado == 0)
        {
            avisoOk t = new avisoOk("Selecione um cliente para excluir.");
            t.ShowDialog();
        }
        else if (verificarExistencia() == 1)
        {
            String mensagem = "Cliente ja vinculado a outros documentos\nNao é possivel excluir, desabilite o cadastro";
            avisoOk aviso = new avisoOk(mensagem);
            aviso.ShowDialog();
        }
        else
        {
            using (avisoConfirmar aviso = new avisoConfirmar("Deseja excluir o cadastro selecionado?"))
            {
                if (aviso.ShowDialog() == DialogResult.OK)
                {
                    _Dal.Remover(_idSelecionado);
                    String mensagem = "Cliente excluido com sucesso";
                    avisoOk aviso2 = new avisoOk(mensagem);
                    atualizar();
                }
            }
        }
    }

    // ==================================================
    // -    LISTAR NA TELA
    // ==================================================

    private String campoPesquisa()
    {
        String campo;
        if (radioNome.Checked)
        {
            campo = "NOME";
        }
        else
        {
            campo = "CPF";
        }
        return campo;
    }

    private void listar()
    {

        String ativoSim = "s";
        String hh = textPesquisa.Text;
        String ativo = comboAtivo.Text;

        listaClientes.Clear();
        bindingCliente.DataSource = null;

        if (ativo == "Sim")
        {
            listaClientes = _Dal.listaClientes(campoPesquisa(), hh, ativoSim);
            bindingCliente.DataSource = listaClientes;
            DataGrid.DataSource = bindingCliente;
        }
        else
        {
            listaClientes = _Dal.listaClientes(campoPesquisa(), hh, "n");
            bindingCliente.DataSource = listaClientes;
            DataGrid.DataSource = bindingCliente;
        }


    }

    private void textPesquisa_TextChanged(object sender, EventArgs e)
    {
        listar();
    }

    // =================================================
    // -    PEGAR ID DA LINHA SELEC
    // =================================================

    private void DataGrid_SelectionChanged(object sender, EventArgs e)
    {
        // current é o item selecionado, se for do tipo classCliente, pega o cli_id, senao seta 0
        if (bindingCliente.Current is classCliente cli)
        {
            nome = cli.Nome;
            _idSelecionado = cli.Id;
            codigo = cli.CodCli;
        }
        else
        {
            _idSelecionado = 0;
        }
    }

    // =================================================
    // -    VALIDAR SE EXISTE EM ESTADIA
    // =================================================


    private int verificarExistencia()
    {
        int v = 0;
        string inf = _idSelecionado.ToString();
        classEstadia est = _EstDal.TrazerEstadia("clienteid", inf);

        if (est == null)
        {
            v = 0;
        } else
        {
            v = 1;
        }
        // se v for 1 significa que existe estadia com esse cliente
        return v;
    }

    private void comboAtivo_SelectedIndexChanged(object sender, EventArgs e)
    {
        listar();
    }

    // -- FIM
}
// - - -