using Umi_Interface.Cadastro;
using Umi_Interface.Estadia;
using Umi_Library.Class;
using Umi_Interface.Cadastro.Quarto;
using Umi_Interface.Financeiro;
using Umi_Interface.Cadastro.Contabil;

namespace Umi_Interface;

public partial class Inicio : Form
{
    public Inicio()
    {
        InitializeComponent();
    }

    private void btnCliente_Click(object sender, EventArgs e)
    {
        Cliente cliente = new Cliente();
        cliente.ShowDialog();
    }

    private void btnQuarto_Click(object sender, EventArgs e)
    {
        Quarto novoQuarto = new Quarto();
        novoQuarto.ShowDialog();
    }

    private void btnEstadia_Click(object sender, EventArgs e)
    {
        telaInicioEstadia novo = new telaInicioEstadia();
        novo.ShowDialog();

    }

    private void btnRecebidas_Click(object sender, EventArgs e)
    {
        Recebidas novo = new Recebidas();
        novo.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        A_Receber_Teste teste = new A_Receber_Teste();
        teste.Show();
    }

    private void btnContasContabeis_Click(object sender, EventArgs e)
    {
        ListaContasContabeis conta = new ListaContasContabeis();
        conta.Show();
    }
}
