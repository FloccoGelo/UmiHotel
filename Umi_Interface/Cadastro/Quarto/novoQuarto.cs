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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Umi_Interface.Cadastro.Quarto;

public partial class novoQuarto : Form
{
    Context _context = new Context();
    quartoDAL _quartoDAL;
    private int idEdicao;
    private int foisalvo = 0;

    // --------------------------------

    public novoQuarto()
    {
        _quartoDAL = new quartoDAL(_context);
        InitializeComponent();
    }

    public novoQuarto(int idRecebido)
    {
        idEdicao = idRecebido;
        _quartoDAL = new quartoDAL(_context);
        InitializeComponent();
    }

    private void novoQuarto_Load(object sender, EventArgs e)
    {
        comboAtivo.SelectedIndex = 0;
        comboStatus.SelectedIndex = 0;

        numericCapacidade.Value = 1;
        numericCapacidade.Maximum = 8;
        numericCapacidade.Minimum = 1;

        numericCasal.Value = 0;
        numericCasal.Maximum = 2;
        numericCasal.Minimum = 0;

        numericSolteiro.Value = 0;
        numericSolteiro.Maximum = 2;
        numericSolteiro.Minimum = 0;
        if (idEdicao > 0)
        {
            preencher();
        }
    }

    // -------------------------
    // ------------- SALVAR
    private classQuarto pegarcClass()
    {
        classQuarto novoQuarto = new classQuarto()
        {
            Numero = textNumero.Text,
            Tipo = comboTipo.Text,
            Capacidade = int.Parse(numericCapacidade.Text),
            NumSolt = int.Parse(numericSolteiro.Text),
            NumCasal = int.Parse(numericCasal.Text),
            Ativo = comboAtivo.Text,
            Status = comboStatus.Text,
            Descricao = textDescricao.Text,
            Created = DateTime.Now,
            Modified = DateTime.Now,

        };
        novoQuarto.Ativo = gerarAtivo();
        if (gerarPreco() == 0)
        {
            novoQuarto.PrecoAtual = 0;
            novoQuarto.PrecoBase = 0;
        }
        else
        {
            novoQuarto.PrecoBase = decimal.Parse(textValAtual.Text);
            novoQuarto.PrecoAtual = decimal.Parse(textValBase.Text);
        }
        return novoQuarto;
    }
    int verificar;

   

    // -------------------------------
    // ----------- BINDING PREENCHER

    private void preencher()
    {
        var editQua = _quartoDAL.trazerQuarto(idEdicao);
        bsQuarto.DataSource = editQua;

        textNumero.DataBindings.Clear();
        comboTipo.DataBindings.Clear();
        numericCapacidade.DataBindings.Clear();
        numericSolteiro.DataBindings.Clear();
        numericCasal.DataBindings.Clear();
        textValBase.DataBindings.Clear();
        textValAtual.DataBindings.Clear();
        comboStatus.DataBindings.Clear();
        textDescricao.DataBindings.Clear();
        comboAtivo.DataBindings.Clear();

        textNumero.DataBindings.Add("Text", bsQuarto, "Numero");
        comboTipo.DataBindings.Add("Text", bsQuarto, "Tipo");
        numericCapacidade.DataBindings.Add("Text", bsQuarto, "Tipo");
        numericSolteiro.DataBindings.Add("Text", bsQuarto, "NumSolt");
        numericCasal.DataBindings.Add("Text", bsQuarto, "NumCasal");
        textValBase.DataBindings.Add("Text", bsQuarto, "PrecoBase", true, DataSourceUpdateMode.OnPropertyChanged);
        textValAtual.DataBindings.Add("Text", bsQuarto, "PrecoAtual", true, DataSourceUpdateMode.OnPropertyChanged);
        comboStatus.DataBindings.Add("Text", bsQuarto, "Status");
        textDescricao.DataBindings.Add("Text", bsQuarto, "Descricao");

        if (editQua.Ativo == "S")
        {
            comboAtivo.Text = "Sim";
        }
        else
        {
            comboAtivo.Text = "Não";
        }

    }

    // ----------------------
    // ------------ BOTOES
    private void btnSalvar_Click(object sender, EventArgs e)
    {
        if (validarCamposVazios() == 1)
        {
            MessageBox.Show(@"Há campos obrigatorios nao preenchidos
                Verifique os seguintes campos:

                Numero do Quarto,
                Categoria,
                Capacidade,
                Numero de camas de casal,
                Numero de camas de solteiro");

            verificar = 0;
        }
        else if (validarCamasVazias() == 1)
        {
            MessageBox.Show("Numero de camas nao inserido");
        }
        else if (bsQuarto.Current is classQuarto qua)
        {
            foisalvo = 1;
            qua.Modified = DateTime.Now;
            qua.Ativo = gerarAtivo();

            validarCamposVazios();
            _quartoDAL.Editar(qua);

            avisoOk hh = new avisoOk("Quarto editado com sucesso :)");
            hh.ShowDialog();
            this.Close();
        }
        else
        {
            foisalvo = 1;
            _quartoDAL.Adicionar(pegarcClass());
            avisoOk novo = new avisoOk("Quarto novo cadastrado com sucesso :)");
            novo.ShowDialog();
            this.Close();
        }
    }
  

    // ===============================================
    // -    VALIDAR CAMPOS
    // ===============================================
    private int validarCamposDigitados()
    {
        int camposDigitados = 0;
        if (
              textNumero.Text != "" ||
              comboTipo.Text != "" ||
              numericCapacidade.Value != 1 ||
              numericCasal.Value != 1 ||
              numericSolteiro.Value != 1 ||
              textDescricao.Text != "" ||
              textValBase.Text != "" ||
              textValAtual.Text != ""
              )
        {
            camposDigitados = 1;
        }
        return camposDigitados;
    }

    private int validarCamposVazios()
    {
        if (
            textNumero.Text == "" ||
            comboTipo.Text == "" ||
            textDescricao.Text == "" ||
            numericCapacidade.Text == "" ||
            numericSolteiro.Text == "" ||
            textValBase.Text == "" || textValBase.Text == "0" || textValBase.Text == "00" || textValBase.Text == "000" ||
            textValAtual.Text == "" || textValAtual.Text == "0" || textValAtual.Text == "00" || textValAtual.Text == "000"

            )
        {
            verificar = 1;
        }
        return verificar;
    }

    private int validarCamasVazias()
    {
        int camas = 0;
        if (numericCasal.Value == 0 && numericSolteiro.Value == 0)
        {
            camas = 1;
        }
        return camas;
    }

    // ===============================================
    // -    FECHAR TELA
    // ===============================================
    private void novoQuarto_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (validarCamposDigitados() == 1 && foisalvo == 0)
        {
            using (avisoConfirmar c = new avisoConfirmar("Há campos digitados, deseja sair sem salvar?"))
            {
                if (c.ShowDialog() == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }

    // ===============================================
    // -    CAMPOS UNICOS
    // ===============================================

    private void btnVoltar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void textValBase_KeyPress(object sender, KeyPressEventArgs e)
    {
        textValBase.MaxLength = 3;
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\r')
        {
            e.Handled = true;
        }
    }

    private void textValAtual_KeyPress(object sender, KeyPressEventArgs e)
    {
        textValAtual.MaxLength = 3;
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\r')
        {
            e.Handled = true;
        }
    }

    private string resultAtivo;
    private int resultPreco;
    private string gerarAtivo()
    {
        if (comboAtivo.Text == "Sim")
        {
            resultAtivo = "S";
        }
        else
        {
            resultAtivo = "N";
        }
        return resultAtivo;
    }

    private int gerarPreco()
    {
        if (string.IsNullOrWhiteSpace(textValAtual.Text) ||
            string.IsNullOrWhiteSpace(textValBase.Text))
        {
            resultPreco = 0;
        }
        return resultPreco;
    }
    // -- FINAL
}





