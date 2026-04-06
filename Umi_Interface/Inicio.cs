using Umi_Interface.Cadastro;
using Umi_Library.Class;
using Umi_Interface.Cadastro.Quarto;

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
}
