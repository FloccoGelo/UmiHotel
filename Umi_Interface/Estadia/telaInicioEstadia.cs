using Biblioteca.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umi_Interface.Avisos;
using Umi_Library.Banco;
using Umi_Library.Class;

namespace Umi_Interface.Estadia;

public partial class telaInicioEstadia : Form
{
    List<classEstadia> listaEstadias = new List<classEstadia>();
    List<(String, classEstadia)> listaEstadiasCliente = new List<(String, classEstadia)>();

    List<classQuartoEstadia> listaQuartos = new List<classQuartoEstadia>();

    Context _context = new Context();
    clienteDAL cliDAL;
    estadiaDAL _estDAL;
    quartoEstadiaDAL _quaDAL;
    classEstadia estadiaPegoLista = new classEstadia();
    int _idEstadiaLinha = 0;
    int idCliente = 0;

    // ==================================================
    // -    CONSTRUTORES
    // ==================================================
    public telaInicioEstadia()
    {
        _quaDAL = new quartoEstadiaDAL(_context);
        _estDAL = new estadiaDAL(_context);
        cliDAL = new clienteDAL(_context);
        InitializeComponent();
    }

    private void telaInicioEstadia_Load(object sender, EventArgs e)
    {
        listarEstadias();
    }

    private void Atualizar()
    {
        listarEstadias();
        preencherQuartos();
    }

    // ==================================================
    // -    LISTAR
    // ==================================================

    private void listarEstadias()
    {
        listaEstadias = _estDAL.listarEstadiasCliente();
        bsEstadia.DataSource = listaEstadias;
        dataGridEstadias.DataSource = bsEstadia;
    }


    private void listar_Com_Ganbiarra_fracaçada()
    {
        // sem inner join no SQL, tenta atribuir o cliente direto no codigo
        // nao funcionou

        int g = 0;
        List<classEstadia> lista = new List<classEstadia>();
        List<(String, classEstadia)> estadiaCliente = new List<(String, classEstadia)>();
        lista = _estDAL.listarEstadias();
        while (g < lista.Count)
        {
            classEstadia ee = lista[g];
            classCliente cli = cliDAL.BuscarID(ee.ClienteId);
            if (ee.CodCli == cli.CodCli)
            {
                estadiaCliente.Add((cli.Nome, ee));
            }
            g++;
        }
        bsEstadia.DataSource = estadiaCliente;
        dataGridEstadias.DataSource = bsEstadia;
    }

    private void telaInicioEstadia_Shown(object sender, EventArgs e)
    {
        dataGridEstadias.ClearSelection();
    }




    // -----------------------------
    // --------- LISTAR QUARTOS
    private void dataGridEstadias_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (bsEstadia.Current is classEstadia t)
        {
            _idEstadiaLinha = t.Id;
            idCliente = t.ClienteId;
        }
        preencherQuartos();
    }

    private void preencherQuartos()
    {
        listaQuartos = _quaDAL.trazerQuartos(_idEstadiaLinha);
        bsQuarto.DataSource = listaQuartos;
        dataGridQuartos.DataSource = bsQuarto;
    }


    // =========================
    // ============ BOTOES
    private void btnNovo_Click(object sender, EventArgs e)
    {
        NovaEstadia novo = new NovaEstadia();
        novo.ShowDialog();
        Atualizar();
    }
    private void btnVoltar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void btnEditar_Click(object sender, EventArgs e)
    {
        NovaEstadia editar = new NovaEstadia(_idEstadiaLinha, idCliente);
        editar.ShowDialog();
        Atualizar();
    }
    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if (_idEstadiaLinha == 0)
        {
            MessageBox.Show("Selecione um cliente para excluir");
        }
        else
        {
            using (avisoConfirmar confirmar = new avisoConfirmar("Deseja realmente excluir a estadia selecionada?"))
            {
                if (confirmar.ShowDialog() == DialogResult.OK)
                {
                    _quaDAL.removerQuartos(_idEstadiaLinha);
                    _estDAL.excluir(_idEstadiaLinha);
                    Atualizar();
                    MessageBox.Show("Estadia excluida com sucesso :)");
                }
            }

        }
    }

    private void dataGridEstadias_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}

