using Biblioteca.Banco;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umi_Interface.Avisos;
using Umi_Interface.Cadastro;
using Umi_Interface.Cadastro.Quarto;
using Umi_Library.Banco;
using Umi_Library.Class;

namespace Umi_Interface.Estadia;

public partial class NovaEstadia : Form
{
    List<classQuartoEstadia> listaQuartos = new List<classQuartoEstadia>();
    classQuarto quartoSelecionado = new classQuarto();
    classQuartoEstadia quartoEstadia = new classQuartoEstadia();
    int indiceQuartoLista;

    int _idCLiente = 0;
    int codCLi = 0;

    int _idEstadiaEdit;

    Context _context = new Context();
    clienteDAL _cliDAL;
    quartoDAL _quaDAL;
    estadiaDAL _estDAL;
    quartoEstadiaDAL _qEstDAl;
    // ===================================================
    // =    CONSTRUTORES - LOAD
    // ===================================================
    public NovaEstadia()
    {
        _cliDAL = new clienteDAL(_context);
        _quaDAL = new quartoDAL(_context);
        _estDAL = new estadiaDAL(_context);
        _qEstDAl = new quartoEstadiaDAL(_context);
        InitializeComponent();
    }

    public NovaEstadia(int id, int idCli)
    {
        _cliDAL = new clienteDAL(_context);
        _quaDAL = new quartoDAL(_context);
        _estDAL = new estadiaDAL(_context);
        _qEstDAl = new quartoEstadiaDAL(_context);

        _idCLiente = idCli;
        _idEstadiaEdit = id;
        InitializeComponent();
    }

    private void NovaEstadia_Load(object sender, EventArgs e)
    {
        dateFechamento.Checked = false;
        comboStatusHospedagem.SelectedIndex = 0;

        if(_idEstadiaEdit > 0)
        {
            carregarDadosEdicao();
        }
    }

    private void atualizarListaQuartos()
    {
        dataGridQuarto.DataSource = null;
        dataGridQuarto.DataSource = listaQuartos;
        bsEstadiaQuarto.DataSource = listaQuartos;
        gerarTotEstadia();
    }
    // ===================================================
    // =    CLIENTE - PESQUISA
    // ===================================================
    private void buttonPesquisaCliente_Click(object sender, EventArgs e)
    {
        using (telaPesquisaCliente novoCliente = new telaPesquisaCliente())
        {
            if (novoCliente.ShowDialog() == DialogResult.OK)
            {
                _idCLiente = novoCliente._idSelecionado;
                preencherNovoCliente(novoCliente._idSelecionado);
            }
        }
    }

    private void preencherNovoCliente(int j)
    {
        string inf = j.ToString();
        String buscar = "ID";
        classCliente n = _cliDAL.BuscarID(_idCLiente);
        pesquisaCPF.Text = n.CPF;
        pesquisaNomeCli.Text = n.Nome;
        codCLi = n.CodCli;
    }

    // ===================================================
    // =    QUARTO - PESQUISA - EDIÇAO
    // ===================================================
    private void btnPesquisaQuarto_Click(object sender, EventArgs e)
    {
        using (telaDadosQuarto novoQuarto = new telaDadosQuarto())
        {
            if (novoQuarto.ShowDialog() == DialogResult.OK)
            {
                inserirQuartoLista(novoQuarto.quartoEnviado);
            }
        }
    }

    private void inserirQuartoLista(classQuartoEstadia ll)
    {
        dataGridQuarto.CurrentCell = null;
        listaQuartos.Add(ll);
        atualizarListaQuartos();
    }

    private void dataGridQuarto_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        indiceQuartoLista = e.RowIndex;
        if (bsEstadiaQuarto.Current is classQuartoEstadia QuartoLinha)
        {
            classQuarto ff = _quaDAL.trazerQuarto(QuartoLinha.QuartoId);
            textNumQuarto.Text = ff.Numero;
            textObsQuarto.Text = QuartoLinha.Obs;
            textDescQuarto.Text = ff.Descricao;
        }
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if (bsEstadiaQuarto.Current is classQuartoEstadia Q)
        {
            using (avisoConfirmar confirmar = new avisoConfirmar("Remover quarto da listaEstadias?"))
            {
                if (confirmar.ShowDialog() == DialogResult.OK)
                {
                    listaQuartos.RemoveAt(indiceQuartoLista);
                    atualizarListaQuartos();
                    dataGridQuarto.CurrentCell = null;
                }
            }
        }
        else
        {
            MessageBox.Show("Selecione um quarto da listaEstadias para excluir");
        }
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        if (bsEstadiaQuarto.Current is classQuartoEstadia Q)
        {
            using (telaDadosQuarto edit = new telaDadosQuarto(Q))
            {
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    listaQuartos[indiceQuartoLista] = edit.quartoEnviado;
                    atualizarListaQuartos();
                }
            }
        }
        else
        {
            MessageBox.Show("Selecione um quarto para editar.");
        }
    }

    // ===================================================
    // =    SALVAR CABEÇALHO
    // ===================================================

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        if (_idCLiente == 0)
        {
            MessageBox.Show("Cliente nao selecionado");
        } else if (listaQuartos.Count == 0) {
            MessageBox.Show("Selecione pelo menos um quarto para salvar");
        } else
        {
            salvarDoc();
        }
    }

    // ===================================================
    // =    PEGAR E SALVAR ESTADIA
    // ===================================================
    private classEstadia pegarCabecalho()
    {
        String inf = _idEstadiaEdit.ToString();
        String campo = "ID";
        int docB = 0;

        classEstadia estadia = _estDAL.TrazerEstadia(campo, inf);
        if (estadia != null)
        {
            docB = estadia.doc;
        } 
        else
        {
            docB = _estDAL.gerarDoc() + 1;
        }

        classEstadia novo = new classEstadia()
        {
            doc = docB,
            ClienteId = _idCLiente,
            CodCli = codCLi,
            Emissao = dateEmissaoEstadia.Value,
            Fechamento = valorDataFechamento(),
            VTotal = decimal.Parse(textTotalGeral.Text),
            Status = comboStatusHospedagem.Text,
            Obs = textObsEstadia.Text,
        };
        return novo;
    }

    private void salvarQuartosSQL(int ii)
    {
        foreach (var l in listaQuartos)
        {
            l.EstadiaId = ii;
            _qEstDAl.adicionar(l);
        }
    }

    private void salvarDoc()
    {
        if(_idEstadiaEdit > 0)
        {
            classEstadia novo = pegarCabecalho();
            novo.Id = _idEstadiaEdit;

            _estDAL.Editar(novo);
            _qEstDAl.removerQuartos(novo.Id);
            salvarQuartosSQL(novo.Id);
            avisoOk aviso = new avisoOk("Quarto editado com sucesso ;)");
            chamarParcela(pegarCabecalho());
            this.Close();
        }
        else
        {
            classEstadia novo = pegarCabecalho();
            _estDAL.Adicionar(novo);
            salvarQuartosSQL(novo.Id);
            avisoOk aviso = new avisoOk("Quarto salvo com sucesso ;)");
            chamarParcela(pegarCabecalho());
            this.Close();
        }
    }

    private void chamarParcela(classEstadia kk)
    {
        parcela nn = new parcela(kk);
        nn.ShowDialog();
    }

    

    // ===================================================
    // =    CARREGAR DADOS DE EDIÇAO
    // ===================================================

    private void zerarBinding()
    {
        dateEmissaoEstadia.DataBindings.Clear();
        dateFechamento.DataBindings.Clear();
        textTotalGeral.DataBindings.Clear();
        comboStatusHospedagem.DataBindings.Clear();
        textObsEstadia.DataBindings.Clear();
    }

    private void carregarDadosEdicao()
    {
        String inf = _idEstadiaEdit.ToString();
        String campo = "ID";

        zerarBinding();
        carregarListaQuartos();
        bsEstadia.DataSource = _estDAL.TrazerEstadia(campo, inf);
        preencherNovoCliente(_idCLiente);

        dateEmissaoEstadia.DataBindings.Add("Value", bsEstadia, "EMISSAO");
        dateFechamento.DataBindings.Add("Value", bsEstadia, "FECHAMENTO");
        textTotalGeral.DataBindings.Add("Text", bsEstadia, "VTOTAL");
        comboStatusHospedagem.DataBindings.Add("Text", bsEstadia, "STATUS");
        textObsEstadia.DataBindings.Add("Text", bsEstadia, "OBS");
    }

    private void carregarListaQuartos()
    {
        listaQuartos = _qEstDAl.trazerQuartos(_idEstadiaEdit);
        atualizarListaQuartos();
    }

    // ===================================================
    // =    INFORMAÇOES CABEÇALHO
    // ===================================================

    private decimal gerarTotEstadia()
    {
        decimal valorTot = 0;
        valorTot = listaQuartos.Sum(tot => tot.TotalDiaria) ?? 0;
        textTotalGeral.Text = valorTot.ToString();
        return valorTot;
    }
    
    private bool validarVazios()
    {
        if (_idCLiente == 0)
        {
            MessageBox.Show("Nenhum cliente selecionado.");
            return false;
        }
        else if (
            codCLi == 0 ||
            textTotalGeral.Text == "" ||
            textTotalGeral.Text == "" ||
            comboStatusHospedagem.Text == "" ||
            listaQuartos.Count == 0)
        {
            MessageBox.Show("Há campos não preenchidos.\n" +
                            "Campos Obrigatórios:\n" +
                            "Cliente\n" +
                            "Status\n" +
                            "Ao menos um quarto na listaEstadias");
            return false;
        }
        return true;
    }

    private void textTotalGeral_TextChanged(object sender, EventArgs e)
    {
        gerarTotEstadia();
    }

    private DateTime valorDataFechamento()
    {
        DateTime slvData;
        if(dateFechamento.Checked == false)
        {
            slvData = DateTime.Parse("01/01/2000");
        }
        else
        {
            return dateFechamento.Value;
        }
        return slvData;
    }

    

   



    // - fim
}
