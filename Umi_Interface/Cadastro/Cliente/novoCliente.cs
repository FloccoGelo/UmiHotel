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
using Umi_Interface.Avisos;
using Microsoft.SqlServer.Server;

namespace Umi_Interface.Cadastro;

public partial class novoCliente : Form
{
    int naoValidar = 0;
    int _idEdicao;
    private clienteDAL _Dal;
    Context _context = new Context();

    // ===============================================
    // -    CONSTRUTORES
    // ===============================================
    public novoCliente()
    {
        InitializeComponent();
        _Dal = new clienteDAL(_context);
    }

    public novoCliente(int _Idrecebido)
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
            //ordem();
    }

    /*
    private void ordem()
    {
        textCodigo.TabIndex = 0;
        textNome.TabIndex = 1;
        dateNascimento.TabIndex = 2;
        comboSexo.TabIndex = 3;
        maskCPF.TabIndex = 4;
        maskRG.TabIndex = 5;
        textTell1.TabIndex = 6;
        textTell2.TabIndex = 7;
        textEmail.TabIndex = 8;
        textOBS.TabIndex = 9;
    }
    */
    // ===============================================
    // -    GERAR INFORMAÇOES
    // ===============================================
    private int gerarCodigo()
    {
        int codigo = 1;
        int ultimo = _Dal.gerarCod();
        if (ultimo == 0)
        {
            codigo = 1;
        }
        else
        {
            codigo = ultimo + 1;
        }
        return codigo;
    }

    private string gerarAtivo()
    {
        string resultAtivo;
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


    // ===============================================
    // -    BOTOES - salvar-voltar
    // ===============================================
    private classCliente PegarClass()
    {
        classCliente novoCliente = new classCliente()
        {
            CodCli = gerarCodigo(),
            Nome = textNome.Text,
            Nascimento = DateTime.Parse(dateNascimento.Text),
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

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        verificarObrigatorio();
        if (verificarObrigatorio() == 1)
        {
            MessageBox.Show(@"Há campos obrigatorios nao preenchidos
                Verifique os seguintes campos:

                Nome,
                Data de nascimento,
                Sexo,
                CPF,
                Telefone 01");
        }
        else if (bsCliente.Current is classCliente cli)
        {
            naoValidar = 1;
            verificarObrigatorio();
            cli.Ativo = gerarAtivo();
            cli.Modified = DateTime.Now;
            _Dal.Editar(cli);
            avisoOk t = new avisoOk("Cliente editado com sucesso :)");
            t.ShowDialog();
            this.Close();
        }
        else
        {
            naoValidar = 1;
            gerarCodigo();
            classCliente salvarCli = PegarClass();
            _Dal.Adicionar(salvarCli);
            avisoOk t = new avisoOk("Cliente novo salvo com sucesso :)");
            t.ShowDialog();
            this.Close();
        }
    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    // ===============================================
    // -    PREENCHER EDIÇAO
    // ===============================================
    private void preencher()
    {
        String campo = "ID";
        String inf = _idEdicao.ToString();

        var editCli = _Dal.BuscarID(_idEdicao);
        bsCliente.DataSource = editCli;

        textNome.DataBindings.Clear();
        textCodigo.DataBindings.Clear();
        dateNascimento.DataBindings.Clear();
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
        dateNascimento.DataBindings.Add("Text", bsCliente, "Nascimento");
        comboSexo.DataBindings.Add("Text", bsCliente, "Sexo");
        maskCPF.DataBindings.Add("Text", bsCliente, "CPF");
        maskRG.DataBindings.Add("Text", bsCliente, "RG");
        textTell1.DataBindings.Add("Text", bsCliente, "Telefone1");
        textTell2.DataBindings.Add("Text", bsCliente, "Telefone2");
        textEmail.DataBindings.Add("Text", bsCliente, "Email");
        textOBS.DataBindings.Add("Text", bsCliente, "Observacoes");
        dateCreated.DataBindings.Add("Text", bsCliente, "Created");
        dateModified.DataBindings.Add("Text", bsCliente, "Modified");
        mascaraCPF();
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

    // ========================================
    // -    KEYPRESS
    // ========================================
    private void textTell1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\r')
        {
            e.Handled = true;
        }
    }

    private void textTell2_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\r')
        {
            e.Handled = true;
        }
    }

    private void maskCPF_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\r')
        {
            e.Handled = true;
        }
    }



    // ========================================
    // -    KEYDOWN
    // ========================================
    private void mascaraCPF()
    {
        string doc = maskCPF.Text
            .Replace(".", "")
            .Replace("-", "")
            .Replace("/", "")
            .Replace("_", "") 
            .Replace(" ", "")  
            .Trim();

        if (doc.Length == 11)
        {
            maskCPF.Mask = "000.000.000-00";
            maskCPF.Text = doc;
        }
        else if (doc.Length == 14)
        {
            maskCPF.Mask = "00.000.000/0000-00";
            maskCPF.Text = doc;
        }
        else
        {
            maskCPF.Mask = "00000000000000"; 
            maskCPF.Text = "";               
        }
    }
    private void maskCPF_Leave(object sender, EventArgs e)
    {
       mascaraCPF(); 
    }

    // ===============================================
    // -    VERIFICAR PREENCHIDOS - FECHAR
    // ===============================================
    public int verificarObrigatorio()
    {
        int verificar = 0;
        if (
            textNome.Text == "" ||
             comboSexo.Text == "" ||
             maskCPF.Text == "" ||
             textTell1.Text == "" ||
             dateNascimento.Text == ""
          )
        {
            verificar = 1;
        }
        return verificar;
    }

    private int verificarPreenchido()
    {
        int u = 0;
        if (
            textCodigo.Text != "" ||
            textNome.Text != "" ||
            comboSexo.Text != "" ||
            maskCPF.Text != "" ||
            maskRG.Text != "" ||
            textTell1.Text != "" ||
            textTell2.Text != "" ||
            textEmail.Text != "" ||
            textOBS.Text != ""
            )
        {
            u = 1;
        }
        return u;
    }
    // Perguntar se quer fechar sem salvar
    private void novoCliente_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (verificarPreenchido() == 1 && naoValidar == 0)
        {
            using (avisoConfirmar confirmar = new avisoConfirmar("Há campos digitados, deseja sair sem salvar?"))
            {
                if (confirmar.ShowDialog() != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }
    }


    // ------- FINAL TOTAL   


}

