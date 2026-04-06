using System.Windows.Forms;

namespace Umi_Interface.Cadastro.Quarto
{
    partial class Quarto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tablePai = new TableLayoutPanel();
            labelTitulo = new Label();
            tableBTN = new TableLayoutPanel();
            btnNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            DataGrid = new DataGridView();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numSoltDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numCasalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoAtualDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            classQuartoBindingSource = new BindingSource(components);
            bindingQuarto = new BindingSource(components);
            tablePai.SuspendLayout();
            tableBTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classQuartoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingQuarto).BeginInit();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tablePai.Controls.Add(labelTitulo, 1, 0);
            tablePai.Controls.Add(tableBTN, 1, 2);
            tablePai.Controls.Add(DataGrid, 1, 1);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Margin = new Padding(4, 3, 4, 3);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 3;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tablePai.Size = new Size(915, 833);
            tablePai.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 32.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(230, 58);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(454, 49);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Gerenciador de Quartos";
            // 
            // tableBTN
            // 
            tableBTN.ColumnCount = 6;
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableBTN.Controls.Add(btnNovo, 1, 1);
            tableBTN.Controls.Add(btnEditar, 2, 1);
            tableBTN.Controls.Add(btnExcluir, 3, 1);
            tableBTN.Controls.Add(btnVoltar, 4, 1);
            tableBTN.Dock = DockStyle.Fill;
            tableBTN.Location = new Point(38, 668);
            tableBTN.Name = "tableBTN";
            tableBTN.RowCount = 3;
            tableBTN.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableBTN.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableBTN.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableBTN.Size = new Size(839, 162);
            tableBTN.TabIndex = 1;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.FromArgb(192, 255, 192);
            btnNovo.Dock = DockStyle.Fill;
            btnNovo.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(202, 100);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(104, 44);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(192, 192, 255);
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(312, 100);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(104, 44);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 192, 192);
            btnExcluir.Dock = DockStyle.Fill;
            btnExcluir.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(422, 100);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(104, 44);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(192, 255, 255);
            btnVoltar.Dock = DockStyle.Fill;
            btnVoltar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(532, 100);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(104, 44);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AutoGenerateColumns = false;
            DataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { numeroDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, capacidadeDataGridViewTextBoxColumn, numSoltDataGridViewTextBoxColumn, numCasalDataGridViewTextBoxColumn, precoAtualDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, Descricao });
            DataGrid.DataSource = classQuartoBindingSource;
            DataGrid.Location = new Point(38, 169);
            DataGrid.MultiSelect = false;
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new Size(839, 493);
            DataGrid.TabIndex = 2;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.ReadOnly = true;
            numeroDataGridViewTextBoxColumn.Width = 80;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacidadeDataGridViewTextBoxColumn
            // 
            capacidadeDataGridViewTextBoxColumn.DataPropertyName = "Capacidade";
            capacidadeDataGridViewTextBoxColumn.HeaderText = "Capacidade";
            capacidadeDataGridViewTextBoxColumn.Name = "capacidadeDataGridViewTextBoxColumn";
            capacidadeDataGridViewTextBoxColumn.ReadOnly = true;
            capacidadeDataGridViewTextBoxColumn.Width = 80;
            // 
            // numSoltDataGridViewTextBoxColumn
            // 
            numSoltDataGridViewTextBoxColumn.DataPropertyName = "NumSolt";
            numSoltDataGridViewTextBoxColumn.HeaderText = "NumSolt";
            numSoltDataGridViewTextBoxColumn.Name = "numSoltDataGridViewTextBoxColumn";
            numSoltDataGridViewTextBoxColumn.ReadOnly = true;
            numSoltDataGridViewTextBoxColumn.Width = 75;
            // 
            // numCasalDataGridViewTextBoxColumn
            // 
            numCasalDataGridViewTextBoxColumn.DataPropertyName = "NumCasal";
            numCasalDataGridViewTextBoxColumn.HeaderText = "NumCasal";
            numCasalDataGridViewTextBoxColumn.Name = "numCasalDataGridViewTextBoxColumn";
            numCasalDataGridViewTextBoxColumn.ReadOnly = true;
            numCasalDataGridViewTextBoxColumn.Width = 75;
            // 
            // precoAtualDataGridViewTextBoxColumn
            // 
            precoAtualDataGridViewTextBoxColumn.DataPropertyName = "PrecoAtual";
            precoAtualDataGridViewTextBoxColumn.HeaderText = "PrecoAtual";
            precoAtualDataGridViewTextBoxColumn.Name = "precoAtualDataGridViewTextBoxColumn";
            precoAtualDataGridViewTextBoxColumn.ReadOnly = true;
            precoAtualDataGridViewTextBoxColumn.Width = 75;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descricao";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 300;
            // 
            // classQuartoBindingSource
            // 
            classQuartoBindingSource.DataSource = typeof(Umi_Library.Class.classQuarto);
            // 
            // bindingQuarto
            // 
            bindingQuarto.DataSource = typeof(Umi_Library.Class.classQuarto);
            // 
            // Quarto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 833);
            Controls.Add(tablePai);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(931, 872);
            MinimumSize = new Size(931, 872);
            Name = "Quarto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quarto";
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableBTN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)classQuartoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingQuarto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private Label labelTitulo;
        private DataGridView DataGrid;
        private TableLayoutPanel tableBTN;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnVoltar;
        private BindingSource bindingQuarto;
        private BindingSource classQuartoBindingSource;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numSoltDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numCasalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoAtualDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Descricao;
    }
}