using Umi_Interface.Cadastro;

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
       cliente.Show();
    }
}
