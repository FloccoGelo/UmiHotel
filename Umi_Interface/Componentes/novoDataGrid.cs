using System.Drawing;
using System.Windows.Forms;

namespace Umi_Interface.Componentes;

public partial class novoDataGrid : DataGridView
{
    public novoDataGrid()
    {
        Configurar();
        InitializeComponent();
    }

    private void Configurar()
    {
        SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        MultiSelect = false;

        Font = new Font("Times New Roman", 10);

        RowsDefaultCellStyle.BackColor = Color.Beige;
        AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

        RowPostPaint += NovoDataGrid_RowPostPaint;
    }

    private void NovoDataGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
    {
        Rectangle headerBounds = new Rectangle(
            e.RowBounds.Left,
            e.RowBounds.Top,
            this.RowHeadersWidth,
            e.RowBounds.Height);

        TextRenderer.DrawText(
            e.Graphics,
            (e.RowIndex + 1).ToString(),
            this.Font,
            headerBounds,
            Color.Black,
            TextFormatFlags.HorizontalCenter |
            TextFormatFlags.VerticalCenter);
    }
}