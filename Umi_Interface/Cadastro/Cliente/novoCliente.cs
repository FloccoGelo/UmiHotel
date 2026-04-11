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
    // -----------------------------------
    public novoCliente()
    {
        InitializeComponent();
        _Dal = new clienteDAL(_context);
    }
    public novoCliente(int _Idrecebido) // construtor para ediçao do cliente
    {
        InitializeComponent();
        _idEdicao = _Idrecebido;
        _Dal = new clienteDAL(_context);
    }
    private void novoCliente_Load(object sender, EventArgs e)
    {
       comboAtivo.SelectedIndex = 0;
        if (_idEdicao > 0)
        {
            preencher();
        }
    }
    // -----------------------------------------------------------------------------------------
    // ---------------------------------------------------------- GERAR CAMPOS 
    int codigo = 1;
    string resultAtivo;

    private void gerarCodigo()
    {
        int ultimo = _Dal.gerarCod();
        if (ultimo == 0)
        {
            codigo = 1;
        }
        else
        {
            codigo = ultimo + 1;
        }
    }
    private string gerarAtivo()
    {
        if (comboAtivo.Text == "Sim")
        {
            resultAtivo = "s";
        }
        else
        {
            resultAtivo = "n";
        }
        return resultAtivo;
    }

    // -----------------------------------------------------------------------------------------
    // ---------------------------------------------------------- SALVAR CLIENTE
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

            Created = DateTime.Now,
            Modified = DateTime.Now,

            
        };
        novoCliente.Ativo = gerarAtivo();
        return novoCliente;
    }

    private int verificar;
    public int verificarObrigatorio()
    {
       if(
         textNome.Text == "" || 
         comboSexo.Text == "" ||
            maskCPF.Text == "" ||
            textTell1.Text == "" ||
            dateNasc.Text == ""
         )
        {
            verificar = 1;
        }
       return verificar;
    }
    
    // -----------------------------------------------------------------------------------------
    // ------------------------------------------------------------------- BOTOES 
    private void btnSalvar_Click(object sender, EventArgs e)
    {
        // aqui ele valida se, bsCliente.Current tiver um classCliente carregado
        // se tiver um classCliente carregado, ele vai editar
        // se não tiver, ele vai adicionar um novo cliente
        if (verificarObrigatorio() == 1)
        {
            MessageBox.Show(@"Há campos obrigatorios nao preenchidos
                Verifique os seguintes campos:

                Nome,
                Data de nascimento,
                Sexo,
                CPF,
                Telefone 01");

            verificar = 0;
        }
        else if (bsCliente.Current is classCliente cli)
        {
            verificarObrigatorio();
            cli.Ativo = gerarAtivo();
            cli.Modified = DateTime.Now;
            _Dal.Editar(cli);
            MessageBox.Show("Cliente editado com sucesso :)");
            this.Close();
        }
        else
        {
            gerarCodigo();
            classCliente salvarCli = Salvar();
            _Dal.Adicionar(salvarCli);
            MessageBox.Show("Cliente salvo com sucesso :)");
            this.Close();
        }
    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    // -----------------------------------------------------------------------------------------
    // ---------------------------------------------------------- PREENCHER CAMPOS 



    // isso aqui traz os dados da funçao BuscarID e passa ao bindingSource
    // limpa os bindings atuais
    // e adiciona novos bindings com os campos do banco
    private void preencher()
    {
        var editCli = _Dal.BuscarID(_idEdicao);
        bsCliente.DataSource = editCli;

        textNome.DataBindings.Clear();
        textCodigo.DataBindings.Clear();
        dateNasc.DataBindings.Clear();
        comboSexo.DataBindings.Clear();
        maskCPF.DataBindings.Clear();
        maskRG.DataBindings.Clear();
        comboAtivo.DataBindings.Clear();
        textTell1.DataBindings.Clear();
        textTell2.DataBindings.Clear();
        textEmail.DataBindings.Clear();
        textOBS.DataBindings.Clear();
        dateCreated.DataBindings.Clear();
        dateModified.DataBindings.Clear();

        textCodigo.DataBindings.Add("Text", bsCliente, "CodCli");
        textNome.DataBindings.Add("Text", bsCliente, "Nome");
        dateNasc.DataBindings.Add("Text", bsCliente, "Nascimento");
        comboSexo.DataBindings.Add("Text", bsCliente, "Sexo");
        maskCPF.DataBindings.Add("Text", bsCliente, "CPF");
        maskRG.DataBindings.Add("Text", bsCliente, "RG");
        textTell1.DataBindings.Add("Text", bsCliente, "Telefone1");
        textTell2.DataBindings.Add("Text", bsCliente, "Telefone2");
        textEmail.DataBindings.Add("Text", bsCliente, "Email");
        textOBS.DataBindings.Add("Text", bsCliente, "Observacoes");
        dateCreated.DataBindings.Add("Text", bsCliente, "Created");
        dateModified.DataBindings.Add("Text", bsCliente, "Modified");

        comboAtivo.DataBindings.Add("Text", bsCliente, "Ativo");
        if (editCli.Ativo == "s")
        {
            comboAtivo.Text = "Sim";
        }
        else
        {
            comboAtivo.Text = "Não";
        };
    }


    // ------- FINAL TOTAL   
}

