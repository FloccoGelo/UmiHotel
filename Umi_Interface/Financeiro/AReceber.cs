using Biblioteca.Banco;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umi_Interface.Avisos;
using Umi_Interface.Cadastro;
using Umi_Interface.Estadia;
using Umi_Library.Banco;
using Umi_Library.Class;

namespace Umi_Interface.Financeiro;







public partial class AReceber : Form
{
    // ================================================
    // -    DECLARAÇOES
    // ================================================
    int _idCliente = 0;
    String nomeCli;
    int codCLi;
    List<classAReceber> listaParcelas = new List<classAReceber>();
    bool edicao = false;

    Context _context = new Context();
    clienteDAL _cliDAL;
    AReceberDAL _receberDAL;

    // ================================================
    // -    CONSTRUTORES
    // ================================================
    public AReceber()
    {
        _cliDAL = new clienteDAL(_context);
        _receberDAL = new AReceberDAL(_context);
        InitializeComponent();
    }

    private void AReceber_Load(object sender, EventArgs e)
    {
        //textValorParcela.Text = textValor.Text;
        listar();
        estadoCampos_Inicial();
    }

    // ================================================
    // -    PESQUISAR E PREENCHER CLIENTE
    // ================================================
    private void btnPesquisarCliente_Click(object sender, EventArgs e)
    {
        using (telaPesquisaCliente ll = new telaPesquisaCliente())
        {
            if (ll.ShowDialog() == DialogResult.OK)
            {
                _idCliente = ll._idSelecionado;
                preencherCliente();
            }
        }
    }

    private void preencherCliente()
    {
        classCliente novo = _cliDAL.BuscarID(_idCliente);
        textCodCli.Text = novo.CodCli.ToString();
        textNomeCliente.Text = novo.Nome;
    }

    // ================================================
    // -    PREENCHER LISTA PARCELAS
    // ================================================

    private classAReceber pegarClass(decimal valParcela, int nParc, DateTime venc)
    {
        classAReceber novo = new classAReceber()
        {
            docOrigem = textDoc.Text,
            codCli = int.Parse(textCodCli.Text),
            emissao = dateEmissao.Value,
            vencimento = venc,
            valor = valParcela,
            valorTot = decimal.Parse(textValor.Text),
            saldo = int.Parse(textValor.Text),
            numParc = nParc,
            forma = comboFormaParcela.Text,
            obs = textObs.Text
        };
        return novo;
    }

    private DateTime separarVencimento(int nParc)
    {
        DateTime venc;
        int dias = (int)numericDiasParc.Value;
        venc = dateVencimentoParcela.Value.AddDays(dias * nParc);
        return venc;
    }


    private void preencherLista()
    {
        decimal saldo = decimal.Parse(textSaldo.Text);
        int numParc = (int)numericNumParcelas.Value;
        decimal valParc = decimal.Parse(textValorParcela.Text);
        decimal resultado = (valParc * numParc);
        decimal totalDocumento = decimal.Parse(textValor.Text);
        decimal diferenca = totalDocumento - resultado;

        if (edicao == true)
        {
            editarParcela();
            edicao = false;
            dataGridParcelas.Enabled = true;
            addSaldo();

            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        else if (edicao == false)
        {

            if (resultado > saldo)
            {
                MessageBox.Show($"Total das parcelas ({resultado}) " +
                                $"ultrapassa o restante a lançar ({saldo})");
                return;
            }

            if (resultado == 0 || resultado < 0)
            {
                MessageBox.Show($"Valor do parcelamento zero ou negativo, verifique");
                return;
            }

            decimal valAtual = valParc;
            decimal limiteArredondamento = numParc * 0.1m;
            for (int i = 1; i <= numParc; i++)
            {
                if (i == numParc && diferenca > 0 && diferenca < limiteArredondamento)
                    valAtual += diferenca;

                listaParcelas.Add(
                    pegarClass(
                        valAtual,
                        i,
                        separarVencimento(i)
                    ));
            }
            addSaldo();
        }
    }

    // =================================================================
    // PRIMEIRA VERSAO DO PREENCHER LISTA, PURA GANBIARRA ISSO AQUI
    /*

     private decimal pegarSaldo()
    {
        decimal valor;
        decimal vTot = decimal.Parse(textValorParcela.Text);
        decimal saldo = decimal.Parse(textSaldo.Text);
        if (listaParcelas.Count == 0)
        {
            valor = vTot;
        }
        else
        {
            valor = saldo;
        }
        return valor;
    }

    private void alimentarLista()
    {
        int parcelas = (int)numericNumParcelas.Value;
        decimal valorTotal = decimal.Parse(textValor.Text);
        decimal valorParcela = decimal.Parse(textValorParcela.Text);
        //decimal campoSaldo = decimal.Parse(textSaldo.Text);
        decimal saldo;
        //decimal ll = 0;

        if (pegarSaldo() == 0 && listaParcelas.Count > 0)
        {
            MessageBox.Show(
                $"Não há mais valores para informar" +
                $"",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }
        else if (valorParcela > pegarSaldo())
        {
            MessageBox.Show(
               $"Valor informado maior que o saldo disponivel" +
               $"",
               "",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
            valorTotal = pegarSaldo();
        }

        if (valorParcela <= 0 || valorParcela == valorTotal)
        {
            valorParcela = separarParcelas();
        }

        decimal totalParcelas = valorParcela * parcelas;
        decimal restante = valorTotal - totalParcelas;
        saldo = restante;

        if (totalParcelas > valorTotal)
        {
            MessageBox.Show(
                $"O total das parcelas (R$ {totalParcelas:N2}) " +
                $"ultrapassa o valor total (R$ {valorTotal:N2}).",
                "Ajuste o valor de parcela",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        // Caso sobre algum valor (diferença por arredondamento ou
        // porque o usuário informou um valor menor)



        bsParcela.ResetBindings(false);

        decimal valAtual = valorParcela;
        for (int i = 1; i <= parcelas; i++)
        {
            if (i == parcelas)
                valAtual += restante;

            listaParcelas.Add(
                pegarClass(
                    valAtual,
                    i,
                    separarVencimento(i)
                ));
        }

    }
    */

    private void listar()
    {
        bsParcela.DataSource = null;
        bsParcela.DataSource = listaParcelas;
        dataGridParcelas.DataSource = bsParcela;
    }


    // ================================================
    // -    BOTAO NOVO
    // ================================================

    private int validacao01()
    {
        // VALIDA SE TEM CAMPOS VAZIOS ANTES DE INFORMAR OS DADOS DA LISTA
        int i;
        if
            (
               textDoc.Text == "" ||
               textCodCli.Text == "" ||
               textValor.Text == "" ||
               comboContabil.Text == ""
            )
        {
            i = 1;
        }
        else
        {
            i = 0;
        }
        return i;
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
        if (validacao01() == 0)
        {
            estadoCampos_Novo();
        }
        else
        {
            avisoOk ok = new avisoOk("Há campos em branco. Verifique!!");
            ok.ShowDialog();
        }
    }

    // ================================================
    // -    BOTAO SALVAR PARCELA
    // ================================================
    private int validarCamposVazios()
    {
        // faz duas validaçoes e traz mensagens
        // se cair no else significa que todos os campos estao preenchidos
        int i = 0;
        if
            (
               textDoc.Text == "" ||
               textCodCli.Text == "" ||
               textValor.Text == "" ||
               comboContabil.Text == ""
            )
        {
            avisoOk ok = new avisoOk("Há campos em branco. Verifique!!");
            ok.ShowDialog();
        }
        else if (
            textValor.Text == "" ||
            numericNumParcelas.Value == 0 ||
            comboFormaParcela.Text == ""
            )
        {
            avisoOk ok = new avisoOk("Informaçoes de parcelamento invalidas. Verifique!!");
            ok.ShowDialog();
        }
        else
        {
            i = 1;
        }
        return i;
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        if (validarCamposVazios() == 1)
        {
            validarCamposVazios();
            preencherLista();
            dataGridParcelas.DataSource = null;
            listar();


            estadoCampos_Inicial();
        }
    }

    // ================================================
    // -    BOTAO EDITAR PARCELA
    // ================================================

    private void btnEditar_Click(object sender, EventArgs e)
    {
        if (bsParcela.Current is classAReceber arr)
        {
            estadoCampos_Ediçao(); // bloqueia os campos para o usuario nao mexer
            edicao = true;
        }
        else
        {
            MessageBox.Show("Selecione uma parcela para editar!!");
        }
    }
    private void editarParcela()
    {
        classAReceber arr = listaParcelas[indiceParcela];
        decimal valorParcela = arr.valor;
        decimal saldoRestante = decimal.Parse(textSaldo.Text);
        decimal valorDisponivel = valorParcela + saldoRestante;
        DateTime vencOriginal = arr.vencimento;

        decimal valorNovo = decimal.Parse(textValorParcela.Text);

        if (valorNovo > valorDisponivel)
        {
            MessageBox.Show("Valor digitado maior que o disponivel. Verifique!!");
            estadoCampos_Inicial();

            edicao = false;
            return;
        }

        // (decimal valParcela, int nParc, DateTime venc)
        listaParcelas[indiceParcela] = pegarClass(valorNovo, indiceParcela, dateVencimentoParcela.Value);
    }

    // ================================================
    // -    CONFIGURAÇOES DE CAMPOS
    // ================================================
    private void textValor_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }

        if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
        {
            e.Handled = true;
        }
    }

    private decimal addSaldo()
    {
        // CALCULA O SALDO RESTANTE E PREENCHE O CAMPO
        decimal saldo;
        decimal totalDocumento = decimal.Parse(textValor.Text);
        saldo = totalDocumento - valorTotalLista();
        textSaldo.Text = saldo.ToString();
        return saldo;
    }

    private void textValor_TextChanged(object sender, EventArgs e)
    {
        addSaldo();
    }

    private decimal valorTotalLista()
    {
        // CALCULA O VALOR DAS PARCELAS DA LISTA
        decimal ll = listaParcelas.Sum(x => x.valor);
        return ll;
    }

    // =======================================================================
    // =======================================================================
    // AO DAR ENTER NO CAMPO NUMERO DE PARCELAS ELE CALCULA AUTOMATICO O VALOR
    // VALOR SALDO / NUMERO DE PARCELAS
    private decimal gerarValorParcela()
    {
        decimal parcela;
        decimal total = decimal.Parse(textSaldo.Text);
        int numero = (int)numericNumParcelas.Value;

        parcela = total / numero;
        parcela = Math.Floor(parcela * 100) / 100;

        textValorParcela.Text = parcela.ToString("F2");
        return parcela;
    }

    private void numericNumParcelas_KeyDown(object sender, KeyEventArgs e)
    {
        gerarValorParcela();
    }

    // =======================================================================
    // =======================================================================

    int indiceParcela = 0;
    private void dataGridParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        indiceParcela = e.RowIndex;
        if (e.RowIndex < 0) return;
        if (bsParcela.Count == 0) return;

        if (bsParcela.Current is classAReceber arr)
        {
            textValorParcela.Text = arr.valor.ToString();
            numericNumParcelas.Value = arr.numParc;
            numericDiasParc.Value = arr.diasVenc;
            dateVencimentoParcela.Value = arr.vencimento;
        }
    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        listaParcelas.Clear();
        addSaldo();
        listar();
    }

    private void gerarCampoVencimento()
    {
        dateVencimentoParcela.Value = dateEmissao.Value.AddDays((int)numericDiasParc.Value);
    }

    private void numericDiasParc_ValueChanged(object sender, EventArgs e)
    {
        gerarCampoVencimento();
    }

    private void dateEmissao_ValueChanged(object sender, EventArgs e)
    {
        gerarCampoVencimento();
    }


    // ================================================
    // -    BOTAO EXCLUIR
    // ================================================
    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if (bsParcela.Current is classAReceber arr)
        {
            using (avisoConfirmar conf = new avisoConfirmar("Deseja excluir a parcela selecionada?"))
            {
                if (conf.ShowDialog() == DialogResult.OK)
                {
                    listaParcelas.RemoveAt(indiceParcela);

                    for (int i = indiceParcela; i < listaParcelas.Count; i++)
                    {
                        listaParcelas[i].numParc = i + 1;
                    }
                    listar();
                }
            }
        }
        else
        {
            MessageBox.Show("Selecione uma parcela para excluir");
        }
    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
        estadoCampos_Inicial();
    }

    // ================================================
    // -    ATIVAR/DESATIVAR CAMPOS
    // ================================================

    private void estadoCampos_Inicial()
    {
        btnNovo.Enabled = true;
        btnSalvar.Enabled = true;
        btnEditar.Enabled = true;
        btnExcluir.Enabled = true;
        btnLimpar.Enabled = true;
        btnVoltar.Enabled = false;

        dataGridParcelas.Enabled = true;

        numericNumParcelas.Enabled = false;
        textValorParcela.Enabled = false;
        numericDiasParc.Enabled = false;
        dateVencimentoParcela.Enabled = false;
        comboFormaParcela.Enabled = false;
    }

    private void estadoCampos_Novo()
    {
        // Quando clica em "Novo" ele libera os campos para digitar
        // Bloqueia os botoes
        numericNumParcelas.Enabled = true;
        textValorParcela.Enabled = true;
        numericDiasParc.Enabled = true;
        dateVencimentoParcela.Enabled = true;
        comboFormaParcela.Enabled = true;

        btnNovo.Enabled = false;
        btnEditar.Enabled = false;
        btnExcluir.Enabled = false;
        btnLimpar.Enabled = false;
        btnVoltar.Enabled = false;
    }


    private void estadoCampos_Ediçao()
    {
        // Quando clica em "Editar" bloqueia os campos necessarios
        dataGridParcelas.Enabled = false;
        numericNumParcelas.Enabled = false;

        textValorParcela.Enabled = true;
        numericDiasParc.Enabled = true;
        dateVencimentoParcela.Enabled = true;
        comboFormaParcela.Enabled = true;

        btnNovo.Enabled = false;
        btnEditar.Enabled = false;
        btnExcluir.Enabled = false;
        btnLimpar.Enabled = false;
        btnVoltar.Enabled = true;
    }



    private void salvarLancamento()
    {
        for (int i = 0; i < listaParcelas.Count; i++)
        {
            classAReceber arr = listaParcelas[i];
            _receberDAL.Adicionar(arr);
        }
    }

    private void btnSalvarDocumento_Click(object sender, EventArgs e)
    {
        if (listaParcelas.Count == 0)
        {
            avisoOk ok = new avisoOk("Nenhum parcelamento lançado para salvar. Verifique!");
            ok.ShowDialog();
            return;
        }
        using (avisoConfirmar con = new avisoConfirmar("Deseja realmente salvar o lançamento!"))
        {
            if (con.ShowDialog() == DialogResult.OK)
            {
                salvarLancamento();
                this.Close();
            }
        }
    }

    private void btnFecharTela_Click(object sender, EventArgs e)
    {
       
        
            using (avisoConfirmar con = new avisoConfirmar("Deseja realmente fechar sem salvar!"))
            {
                if (con.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
            }
        
            
    }



    // --- FIM
}
