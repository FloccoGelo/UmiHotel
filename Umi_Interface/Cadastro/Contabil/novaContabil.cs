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

namespace Umi_Interface.Cadastro.Contabil;

public partial class novaContabil : Form
{
    Context _context = new Context();
    contabilDAL _Dal;

    public novaContabil()
    {
        _Dal = new contabilDAL(_context);
        InitializeComponent();
    }

    //------------------------------------
    classContabil editarConta = new classContabil();
    public novaContabil(classContabil conta)
    {
        _Dal = new contabilDAL(_context);
        InitializeComponent();
        editarConta = conta;
        testeRecebimento();
    }
    
    private void testeRecebimento()
    {
        if(editarConta == null)
        {
            MessageBox.Show("Nenhum");
        } else
        {
            MessageBox.Show("recebido: "+editarConta.Nome);
        }
    }

    private string gerarAtivo()
    {
        string ll;
        if (checkAtivo.Checked)
        {
            ll = "S";
        }
        else
        {
            ll = "N";
        }
        return ll;
    }

    private int gerarCodigo()
    {
        int codigo = _Dal.trazerCodigoConta();
        if (codigo == null)
        {
            codigo = 1;
        } else
        {
            codigo = codigo + 1;
        }
        return codigo;
    }

    private classContabil pegarClass()
    {
        classContabil conta = new classContabil()
        {
            Codigo = gerarCodigo(),
            Nome = textNome.Text,
            tipoContaContabil = comboTipo.Text,
            Ativo = gerarAtivo(),
            Observacao = textObs.Text,
            created = DateTime.Now,
            modified = DateTime.Now,
        };
        return conta;
    }

    private string validarVazios()
    {
        string vazio = "N";
        if (textNome.Text == "" ||
            comboTipo.Text == "" ||
            textObs.Text == "")
        {
            vazio = "S";
        }
        return vazio;
    }

    private void salvar()
    {
        _Dal.Adicionar(pegarClass());
        avisoOk ok = new avisoOk("Cadastro salvo com sucesso");
        ok.ShowDialog();
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
        if (validarVazios() == "S")
        {
            avisoOk ok = new avisoOk("Há campos em branco. Verifique!");
            ok.ShowDialog();
        } else
        {
            using (avisoConfirmar con = new avisoConfirmar("Deseja salvar cadastro?"))
            {
                if (con.ShowDialog() == DialogResult.OK)
                {
                    salvar();
                    this.Close();
                }
            }
            
        }
    }
}
