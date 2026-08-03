using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umi_Interface.Componentes;

public partial class novoComboBox : ComboBox
{
    // Cores configuráveis via Designer
    [Category("Appearance")]
    [Description("Cor de fundo quando o controle está desabilitado.")]
    public Color DisabledBackColor { get; set; } = Color.LightBlue;

    [Category("Appearance")]
    [Description("Cor do texto quando o controle está desabilitado.")]
    public Color DisabledForeColor { get; set; } = Color.Black;

    public novoComboBox()
    {
        this.DropDownStyle = ComboBoxStyle.DropDownList;
        this.KeyDown += novoComboBox_KeyDown;
    }

    private void novoComboBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            MoveFocus(forward: true);
        }
        else if (e.KeyCode == Keys.Escape)
        {
            e.SuppressKeyPress = true;
            MoveFocus(forward: false);
        }
    }

    private void MoveFocus(bool forward)
    {
        this.Parent?.SelectNextControl(
            this,
            forward,
            tabStopOnly: true,
            nested: true,
            wrap: true
        );
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
        UpdateColors();
    }

    private void UpdateColors()
    {
        if (!this.Enabled)
        {
            this.BackColor = DisabledBackColor;
            this.ForeColor = DisabledForeColor;
        }
        else
        {
            this.BackColor = SystemColors.Window;
            this.ForeColor = SystemColors.WindowText;
        }
    }
}