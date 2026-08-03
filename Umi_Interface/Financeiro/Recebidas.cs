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
using Umi_Library.Banco;
using Umi_Library.Class;

namespace Umi_Interface.Financeiro;

public partial class Recebidas : Form
{
    // ========================================
    // -    VARIAVEIS
    // ========================================
    Context context = new Context();
    recebidaDAL _Recebidas;
    List<classRecebidos> listaRecebidas = new List<classRecebidos>();


    // ========================================
    // -    CONSTRUTORES
    // ========================================
    public Recebidas()
    {
        InitializeComponent();
        _Recebidas = new recebidaDAL(context);
    }

    private void Recebidas_Load(object sender, EventArgs e)
    {
        listarRecebidas();
    }

    // ========================================
    // -    LISTAR
    // ========================================

    private void listarRecebidas()
    {
        listaRecebidas = _Recebidas.listaRecebidas("DocOrigem", "%");
        bsRecebidas.DataSource = listaRecebidas;
        dataGridRecebidas.DataSource = bsRecebidas;
    }

    private void btnNovo_Click(object sender, EventArgs e)
    {
        AReceber novo = new AReceber();
        novo.ShowDialog();
    }




    // --- FIM
}
