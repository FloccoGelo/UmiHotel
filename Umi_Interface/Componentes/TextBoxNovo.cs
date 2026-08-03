using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umi_Interface.Componentes;

public partial class TextBoxNovo : TextBox
{
    public TextBoxNovo()
    {
        InitializeComponent();
        ConfigurarAparencia();
        this.BorderStyle = BorderStyle.FixedSingle;
    }
    public TextBoxNovo(IContainer container)
    {
        container.Add(this);
        InitializeComponent();
        ConfigurarAparencia();
    }

    private void ConfigurarAparencia()
    {
        this.KeyDown += TextBoxNovo_KeyDown;
        this.EnabledChanged += (s, e) => AtualizarCor();
        AtualizarCor();
    }

    private void AtualizarCor()
    {
        if (!this.Enabled || this.ReadOnly)
        {
            this.BackColor = Color.LightBlue;
        }
        else
        {
            this.BackColor = Color.White;
        }
    }

    protected override void OnReadOnlyChanged(EventArgs e)
    {
        base.OnReadOnlyChanged(e);
        AtualizarCor();
    }

    private void TextBoxNovo_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;

            Form form = this.FindForm();

            if (form != null)
            {
                form.SelectNextControl(
                    this,
                    true,
                    true,
                    true,
                    true);
            }
        }
    }
}