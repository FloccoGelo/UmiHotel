using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umi_Interface.Avisos;

public partial class avisoOk : Form
{
    public avisoOk(string texto)
    {
        InitializeComponent();
        mensagem.Text = texto;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
