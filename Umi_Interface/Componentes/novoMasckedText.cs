using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Umi_Interface.Componentes;

public partial class novoMaskedText : MaskedTextBox
{
    public novoMaskedText()
    {
        ConfigurarAparencia();
    }

    public novoMaskedText(IContainer container)
    {
        container.Add(this);
        ConfigurarAparencia();
    }

    private void ConfigurarAparencia()
    {
        this.BorderStyle = BorderStyle.FixedSingle;
        this.KeyDown += novoMaskedText_KeyDown;
        AtualizarCor();
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
        AtualizarCor();
    }

    protected override void OnReadOnlyChanged(EventArgs e)
    {
        base.OnReadOnlyChanged(e);
        AtualizarCor();
    }

    private void AtualizarCor()
    {
        this.BackColor = (!this.Enabled || this.ReadOnly) ? Color.LightBlue : Color.White;
    }

    private void novoMaskedText_KeyDown(object sender, KeyEventArgs e)
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

    protected override void OnMouseUp(MouseEventArgs mevent)
    {
        base.OnMouseUp(mevent);

        this.SelectionStart = this.Text.Length;
    }

    protected override void OnEnter(EventArgs e)
    {
        base.OnEnter(e);

        this.SelectionStart = this.Text.Length;
    }
}