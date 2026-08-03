using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umi_Library.Class;

namespace Umi_Interface.Financeiro;

public partial class A_Receber_Teste : Form
{
    public A_Receber_Teste()
    {
        InitializeComponent();
    }

    private void A_Receber_Teste_Load(object sender, EventArgs e)
    {
        listar();
    }

    List<classAReceber> lista = new List<classAReceber>();


    private classAReceber pegarClass(int parc, decimal VParcela)
    {
        classAReceber ll = new classAReceber();

        ll.numParc = parc;
        ll.valor = VParcela;
        ll.saldo = decimal.Parse(textValor.Text);

        return ll;
    }

    private void separarParcelas()
    {
        //lista.Clear();

        decimal valor = decimal.Parse(textValor.Text);
        int parcelas = int.Parse(textParcela.Text);
        decimal novoValor = 0;

        novoValor = valor / parcelas;

        for (int i = 0; i < parcelas; i++)
        {
            lista.Add(pegarClass(i, novoValor));
        }
    }

    private void listar()
    {
        bsAReceber.DataSource = null;
        bsAReceber.DataSource = lista;
        dataGrid.DataSource = bsAReceber;
    }

    private void btn_Click(object sender, EventArgs e)
    {
        separarParcelas();
        listar();
    }
}
