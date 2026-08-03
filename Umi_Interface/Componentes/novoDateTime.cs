using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Umi_Interface.Componentes;

public partial class novoDateTime : DateTimePicker
{
    public novoDateTime()
    {
        InitializeComponent();
        ConfigurarAparencia();
    }

    public novoDateTime(IContainer container)
    {
        container.Add(this);
        InitializeComponent();
        ConfigurarAparencia();
    }

    private void ConfigurarAparencia()
    {
        this.Format = DateTimePickerFormat.Short;
        this.KeyDown += novoDateTime_KeyDown;
        AtualizarCor();
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
        AtualizarCor();
    }

    private void AtualizarCor()
    {
        this.BackColor = this.Enabled ? Color.White : Color.LightBlue;
    }

    private void novoDateTime_KeyDown(object sender, KeyEventArgs e)
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