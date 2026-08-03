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
using Umi_Interface.Cadastro.Quarto;
using Umi_Library.Banco;
using Umi_Library.Class;

namespace Umi_Interface.Estadia;

public partial class telaDadosQuarto : Form
{
    int _idRecebido;
    int _idEdit;
    int _idQuarto;
    bool salvou = false;

    quartoDAL _dal;
    Context _context = new Context();
    classQuartoEstadia classeRecebida = new classQuartoEstadia();
    public telaDadosQuarto()
    {
        _dal = new quartoDAL(_context);
        InitializeComponent();
    }
    public telaDadosQuarto(classQuartoEstadia editar)
    {
        _dal = new quartoDAL(_context);
        classeRecebida = editar;
        _idRecebido = editar.QuartoId;
        InitializeComponent();
        carregarQuarto();
    }
    private void telaDadosQuarto_Load(object sender, EventArgs e)
    {
        comboStatus.SelectedIndex = 0;
        numericNumPessoas.Minimum = 1;
        numericDias.Minimum = 1;
    }

    // =========================================
    // -    RETORNAR QUARTO DA OUTRA TELA
    // =========================================
    private void btnNovo_Click(object sender, EventArgs e)
    {
        using (telaPesquisaQuarto pesquisar = new telaPesquisaQuarto())
        {
            if (pesquisar.ShowDialog() == DialogResult.OK)
            {
                _idRecebido = pesquisar.idSelecionado;
                classQuarto Quarto = _dal.trazerQuarto(_idRecebido);
                preencherDescr(pesquisar.idSelecionado);
                textValDiaria.Text = (Quarto.PrecoAtual ?? 0).ToString();
                dateSaida.Checked = false;
                gerarTotEstadia();
            }
        }
    }

    private void preencherDescr(int id2)
    {
        classQuarto Quarto = _dal.trazerQuarto(id2);

        textNumero.Text = Quarto.Numero;
        textDescricao.Text = Quarto.Descricao;
        numericNumPessoas.Maximum = Quarto.Capacidade;
    }

    // =========================================
    // -    PEGAR DADOS DA TELA
    // =========================================
    private classQuartoEstadia pegarClass()
    {
        classQuartoEstadia novoQuarto = new classQuartoEstadia()
        {
            QuartoId = _idRecebido,
            EstadiaId = 1,
            NumQuarto = textNumero.Text,
            Check_In = dateEntrada.Value,
            Previs_Check_Out = datePrevisSaida.Value,
            Check_Out = dateSaida.Value,
            Diaria = decimal.Parse(textValDiaria.Text),
            TotalDiaria = gerarTotEstadia(),
            DiasHospedagem = int.Parse(numericDias.Text),
            NumHospedes = int.Parse(numericNumPessoas.Text),
            Status = comboStatus.Text,
            Obs = textObs.Text,
        };
        return novoQuarto;
    }

    private int validarVazios()
    {
        int v = 0;
        if (textDescricao.Text == "")
        {
            MessageBox.Show("Nenhum quarto selecionado");
            v = 1;
        }
        else if (textNumero.Text == "" ||
            numericDias.Value == 0 ||
            numericNumPessoas.Value == 0 ||
            textValDiaria.Text == "0,00" ||
            textValDiaria.Text == "" ||
            dateEntrada.Text == "")
        {
            v = 1;
            MessageBox.Show("Há campos nao preenchidos \n" +
                            "Campos Obrigatorios:\n" +
                            "Numero de Pessoas\n" +
                            "Numero de Dias\n" +
                            "Diaria");
        }
        return v;
    }

    private decimal gerarTotEstadia()
    {
        decimal total = 0;
        decimal dias = 0;
        decimal valor = 0;

        dias = numericDias.Value;
        decimal.TryParse(textValDiaria.Text, out valor);
        total = (valor * dias);
        textTotDiaria.Text = total.ToString();
        return total;
    }

    // =========================================
    // -    ENVIAR QUARTO
    // =========================================
    public classQuartoEstadia quartoEnviado = new classQuartoEstadia();

    private void buttonSalvar_Click(object sender, EventArgs e)
    {
        if (validarVazios() == 1) return;

        salvou = true;
        quartoEnviado = pegarClass();
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    // =========================================
    // -    EDITAR
    // =========================================
    private void zerarBinding()
    {
        textNumero.DataBindings.Clear();
        textDescricao.DataBindings.Clear();
        numericNumPessoas.DataBindings.Clear();
        numericDias.DataBindings.Clear();
        textValDiaria.DataBindings.Clear();
        textTotDiaria.DataBindings.Clear();
        comboStatus.DataBindings.Clear();
        dateEntrada.DataBindings.Clear();
        datePrevisSaida.DataBindings.Clear();
        dateSaida.DataBindings.Clear();
        textObs.DataBindings.Clear();
    }

    private void carregarQuarto()
    {
        bsQuarto.DataSource = classeRecebida;
        zerarBinding();
        preencherDescr(classeRecebida.QuartoId);

        numericNumPessoas.DataBindings.Add("Value", bsQuarto, "NumHospedes", true);
        numericDias.DataBindings.Add("Value", bsQuarto, "DiasHospedagem", true);
        textValDiaria.DataBindings.Add("Text", bsQuarto, "Diaria", true);
        textTotDiaria.DataBindings.Add("Text", bsQuarto, "TotalDiaria", true);
        comboStatus.DataBindings.Add("Text", bsQuarto, "Status", true);
        dateEntrada.DataBindings.Add("Value", bsQuarto, "Check_In", true);
        datePrevisSaida.DataBindings.Add("Value", bsQuarto, "Previs_Check_Out", true);
        dateSaida.DataBindings.Add("Value", bsQuarto, "Check_Out", true);
        textObs.DataBindings.Add("Text", bsQuarto, "Obs", true);
    }
    // ===
    // ===
    // ==============================
    // ===================== OUTROS
    private void dataSaida()
    {
        int dias = (int)numericDias.Value;
        datePrevisSaida.Value = dateEntrada.Value.AddDays(dias);
    }
    private void textValDiaria_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b' && e.KeyChar != '\r')
        {
            e.Handled = true;
        }
    }
    private void textTotDiaria_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b' && e.KeyChar != '\r')
        {
            e.Handled = true;
        }
    }
    private void numericDias_ValueChanged(object sender, EventArgs e)
    {
        dataSaida();
        gerarTotEstadia();
    }
    private void textValDiaria_TextChanged(object sender, EventArgs e)
    {
        gerarTotEstadia();
    }
    private void textTotDiaria_TextChanged(object sender, EventArgs e)
    {
        gerarTotEstadia();
    }
    private void dateEntrada_ValueChanged(object sender, EventArgs e)
    {
        dataSaida();
    }
    private void datePrevisSaida_ValueChanged(object sender, EventArgs e)
    {
        dataSaida();
    }

    // =========================================
    // -    DESEJA SAIR?
    // =========================================
    
   
    private void telaDadosQuarto_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (salvou)
            return;
        else if (textDescricao.Text != "" ||
            textNumero.Text != "" ||
            numericDias.Value != 0 ||
            numericNumPessoas.Value != 0 ||
            textValDiaria.Text != "0,00" ||
            textValDiaria.Text != "0" ||
            textValDiaria.Text != "" ||
            dateEntrada.Text != "")
        {
            using (avisoConfirmar confirmar = new avisoConfirmar("Deseja sair sem salvar?"))
            {
                if (confirmar.ShowDialog() != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }
    }

    private void buttonVoltar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}