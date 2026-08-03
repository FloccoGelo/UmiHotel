using Biblioteca.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umi_Interface.Avisos;
using Umi_Library;
using Umi_Library.Banco;
using Umi_Library.Class;

namespace Umi_Interface.Estadia;
public partial class parcela : Form
{
    classEstadia _classEstadia = new classEstadia();
    List<classParcela> listaParcelas = new List<classParcela>();
    parcelaDal _Dal;
    recebidaDAL _recDAL;
    Context context = new Context();
    private int salvo = 0;
    // =========================================
    //      CONSTRUTOR
    // =========================================

    public parcela(classEstadia estadia)
    {
        _recDAL = new recebidaDAL(context);
        _Dal = new parcelaDal(context);
        _classEstadia = estadia;

        InitializeComponent();
    }

    private void parcela_Load(object sender, EventArgs e)
    {
        preencherCamposNovo();
    }

    // =========================================
    // -    CARREGAR NOVA PARCELA
    // =========================================

    private void preencherCamposNovo()
    {
        classParcela nn = trazerParcelaExistente();
        textDoc.Text = _classEstadia.doc.ToString();
        textValorTot.Text = _classEstadia.VTotal.ToString();

        if (nn != null)
        {
            dateEmissao.Value = nn.Emissao.ToDateTime(default);
            comboForma.Text = nn.Forma;
        }
        else
        {
            dateEmissao.Value = DateTime.Now;
        }

    }
    
    // =========================================
    // -     TRAZER PARCELA EXISTENTE
    // =========================================

    private classParcela trazerParcelaExistente()
    {
        // verifica se existe no sql esse codumento
        // se nao existir "parcelaEx" é null

        String g = _classEstadia.doc.ToString();
        classParcela parcelaEx = _Dal.BuscarParcela("DOC", g);
        return parcelaEx;
    }

    private classRecebidos trazerRecebimentoExistente()
    {
        // verifica se existe no sql esse codumento
        // se nao existir "recebidos" é null

        String g = _classEstadia.doc.ToString();
        classRecebidos recebidos = _recDAL.BuscarRecebida("docOrigem", g);
        return recebidos;
    }

    // =========================================
    // -     PEGAR CLASSES
    // =========================================
    
    private classParcela pegarClassParcela(int idRec)
    {
        classParcela parcela = new classParcela()
        {
            Id = idRec,
            Doc = int.Parse(textDoc.Text),
            Valor = decimal.Parse(textValorTot.Text),
            Emissao = DateOnly.FromDateTime(dateEmissao.Value),
            Forma = comboForma.Text,
        };
        return parcela;
    }

    private classRecebidos pegarClassRecebido(int idRec)
    {
        String doc = _classEstadia.doc.ToString();

        classRecebidos recebida = new classRecebidos()
        {
            Id = idRec,
            docOrigem = doc,
            codCli = _classEstadia.CodCli,
            emissao = DateTime.Now,
            recebimento = DateTime.Now,
            valor = decimal.Parse(textValorTot.Text),
            valRecebido = decimal.Parse(textValorTot.Text),
            numParc = 1,
            forma = comboForma.Text,
            destino = "Bolso do Patrao",
        };
        return recebida;
    }  

    // =========================================
    // -     BOTAO SALVAR
    // =========================================

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        classParcela parcela = trazerParcelaExistente();
        classRecebidos recebidos = trazerRecebimentoExistente();
        
        if (comboForma.Text == "")
        {
            MessageBox.Show("Seleciona uma forma de pagamento");
        }
        else if (trazerParcelaExistente() == null)
        {
            _Dal.Adicionar(pegarClassParcela(0));
            _recDAL.Adicionar(pegarClassRecebido(0));
            this.Close();
        } else
        {
            _Dal.Editar(pegarClassParcela(parcela.Id));
            _recDAL.Editar(pegarClassRecebido(recebidos.Id));
            this.Close();
        }   
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        this.Close();
    }



    // --- FIM
}
