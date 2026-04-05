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
using Umi_Library;
using Umi_Library.Banco;
using Umi_Library.Class;

namespace Umi_Interface.Cadastro;

public partial class novoCliente : Form
{
    int _idEdicao;

    private clienteDAL _Dal;
    Context _context = new Context();
    public novoCliente()
    {
        InitializeComponent();
        _Dal = new clienteDAL(_context);

        comboAtivo.SelectedIndex = 0;
    }

    public novoCliente(int _Idrecebido) // construtor para ediçao do cliente
    {
        InitializeComponent();
        _idEdicao = _Idrecebido;
        _Dal = new clienteDAL(_context);
    }
    private void novoCliente_Load(object sender, EventArgs e)
    {
        if (_idEdicao > 0)
        {
            preencher();
        }
    }
    // -----------------------------------------------------------------------------------------
    // ---------------------------------------------------------- GERAR CAMPOS 
    int codigo;
    private void gerarCodigo()
    {
        int cod;
        cod = _Dal.gerarCod();
        codigo = cod + 1;
    }

    bool resultAtivo;
    private void gerarAtivo()
    {
        if (comboAtivo.Text == "Sim")
        {
            resultAtivo = true;
        }
        else
        {
            resultAtivo = false;
        }
    }

    DateTime resultCreated;
    private DateTime gerarCreated()
    {
        if (_idEdicao == 0)
        {
            resultCreated = DateTime.Now;
        }
        return resultCreated;
    }


    // -----------------------------------------------------------------------------------------
    // ---------------------------------------------------------- FUNÇOES CRUD 
    private classCliente Salvar()
    {
        classCliente novoCliente = new classCliente()
        {
            CodCli = codigo,
            Nome = textNome.Text,
            Nascimento = DateTime.Parse(dateNasc.Text),
            Sexo = comboSexo.Text,
            CPF = maskCPF.Text,
            RG = maskRG.Text,
            Telefone1 = textTell1.Text,
            Telefone2 = textTell2.Text,
            Email = textEmail.Text,

            Ativo = resultAtivo,
            Created = resultCreated,
            Modified = DateTime.Now,
        };
        return novoCliente;
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        if (_idEdicao == 0)
        {
            classCliente salvarCli = Salvar();
            _Dal.Adicionar(salvarCli);
            MessageBox.Show("Cliente salvo com sucesso :)");
            this.Close();
        }
        else if(bsCliente.Current is classCliente cli)
        {
            _Dal.Editar(cli);
            MessageBox.Show("Cliente salvo com sucesso :)");
            this.Close();
        }
    }

    // -----------------------------------------------------------------------------------------
    // ---------------------------------------------------------- PREENCHER CAMPOS 

    private void preencher()
    {
        var editCli = _Dal.BuscarID(_idEdicao);
        bsCliente.DataSource = editCli;

        textNome.DataBindings.Clear(); 
        textCodigo.DataBindings.Clear();

        textCodigo.DataBindings.Add("Text", bsCliente, "CodCli");
        textNome.DataBindings.Add("Text", bsCliente, "Nome");

    }
    // ------- FINAL TOTAL   
}

