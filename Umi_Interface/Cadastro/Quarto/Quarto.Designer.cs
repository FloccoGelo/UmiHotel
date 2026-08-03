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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tablePai = new TableLayoutPanel();
            labelTitulo = new Label();
            tableBTN = new TableLayoutPanel();
            btnNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            tablePesquisa = new TableLayoutPanel();
            radioNumero = new RadioButton();
            radioDescr = new RadioButton();
            textPesquisa = new Umi_Interface.Componentes.TextBoxNovo(components);
            comboAtivo = new Umi_Interface.Componentes.novoComboBox();
            DataGrid = new Umi_Interface.Componentes.novoDataGrid();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numSoltDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numCasalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoAtualDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingQuarto = new BindingSource(components);
            tablePai.SuspendLayout();
            tableBTN.SuspendLayout();
            tablePesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
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
            tablePai.Controls.Add(tableBTN, 1, 3);
            tablePai.Controls.Add(tablePesquisa, 1, 1);
            tablePai.Controls.Add(DataGrid, 1, 2);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Margin = new Padding(4, 3, 4, 3);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 4;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
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
            labelTitulo.Location = new Point(230, 51);
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
            tableBTN.Location = new Point(38, 682);
            tableBTN.Name = "tableBTN";
            tableBTN.RowCount = 3;
            tableBTN.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableBTN.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableBTN.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableBTN.Size = new Size(839, 148);
            tableBTN.TabIndex = 1;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.FromArgb(192, 255, 192);
            btnNovo.Dock = DockStyle.Fill;
            btnNovo.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(202, 88);
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
            btnEditar.Location = new Point(312, 88);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(104, 44);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 192, 192);
            btnExcluir.Dock = DockStyle.Fill;
            btnExcluir.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(422, 88);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(104, 44);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(192, 255, 255);
            btnVoltar.Dock = DockStyle.Fill;
            btnVoltar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(532, 88);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(104, 44);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // tablePesquisa
            // 
            tablePesquisa.ColumnCount = 3;
            tablePesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tablePesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tablePesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePesquisa.Controls.Add(radioNumero, 0, 0);
            tablePesquisa.Controls.Add(radioDescr, 1, 0);
            tablePesquisa.Controls.Add(textPesquisa, 0, 1);
            tablePesquisa.Controls.Add(comboAtivo, 2, 0);
            tablePesquisa.Dock = DockStyle.Fill;
            tablePesquisa.Location = new Point(38, 155);
            tablePesquisa.Name = "tablePesquisa";
            tablePesquisa.RowCount = 2;
            tablePesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 46.2962952F));
            tablePesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 53.7037048F));
            tablePesquisa.Size = new Size(839, 63);
            tablePesquisa.TabIndex = 3;
            // 
            // radioNumero
            // 
            radioNumero.AutoSize = true;
            radioNumero.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioNumero.Location = new Point(3, 3);
            radioNumero.Name = "radioNumero";
            radioNumero.Size = new Size(69, 19);
            radioNumero.TabIndex = 0;
            radioNumero.TabStop = true;
            radioNumero.Text = "Numero";
            radioNumero.UseVisualStyleBackColor = true;
            // 
            // radioDescr
            // 
            radioDescr.AutoSize = true;
            radioDescr.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioDescr.Location = new Point(88, 3);
            radioDescr.Name = "radioDescr";
            radioDescr.Size = new Size(80, 19);
            radioDescr.TabIndex = 1;
            radioDescr.TabStop = true;
            radioDescr.Text = "Descrição";
            radioDescr.UseVisualStyleBackColor = true;
            // 
            // textPesquisa
            // 
            textPesquisa.BackColor = Color.White;
            textPesquisa.BorderStyle = BorderStyle.FixedSingle;
            tablePesquisa.SetColumnSpan(textPesquisa, 3);
            textPesquisa.Dock = DockStyle.Fill;
            textPesquisa.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPesquisa.Location = new Point(3, 32);
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(833, 22);
            textPesquisa.TabIndex = 2;
            textPesquisa.TextChanged += textPesquisa_TextChanged;
            // 
            // comboAtivo
            // 
            comboAtivo.DisabledBackColor = Color.LightBlue;
            comboAtivo.DisabledForeColor = Color.Black;
            comboAtivo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAtivo.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboAtivo.FormattingEnabled = true;
            comboAtivo.Items.AddRange(new object[] { "Sim", "Não" });
            comboAtivo.Location = new Point(178, 3);
            comboAtivo.Name = "comboAtivo";
            comboAtivo.Size = new Size(121, 23);
            comboAtivo.TabIndex = 3;
            comboAtivo.SelectedIndexChanged += comboAtivo_SelectedIndexChanged;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGrid.AutoGenerateColumns = false;
            DataGrid.BackgroundColor = Color.White;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, numeroDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, capacidadeDataGridViewTextBoxColumn, numSoltDataGridViewTextBoxColumn, numCasalDataGridViewTextBoxColumn, precoAtualDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn });
            DataGrid.DataSource = bindingQuarto;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.Font = new Font("Times New Roman", 10F);
            DataGrid.Location = new Point(38, 224);
            DataGrid.MultiSelect = false;
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.Beige;
            DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new Size(839, 452);
            DataGrid.TabIndex = 4;
            DataGrid.SelectionChanged += DataGrid_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.ReadOnly = true;
            numeroDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            tipoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // capacidadeDataGridViewTextBoxColumn
            // 
            capacidadeDataGridViewTextBoxColumn.DataPropertyName = "Capacidade";
            capacidadeDataGridViewTextBoxColumn.HeaderText = "Capacidade";
            capacidadeDataGridViewTextBoxColumn.Name = "capacidadeDataGridViewTextBoxColumn";
            capacidadeDataGridViewTextBoxColumn.ReadOnly = true;
            capacidadeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // numSoltDataGridViewTextBoxColumn
            // 
            numSoltDataGridViewTextBoxColumn.DataPropertyName = "NumSolt";
            numSoltDataGridViewTextBoxColumn.HeaderText = "NumSolt";
            numSoltDataGridViewTextBoxColumn.Name = "numSoltDataGridViewTextBoxColumn";
            numSoltDataGridViewTextBoxColumn.ReadOnly = true;
            numSoltDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // numCasalDataGridViewTextBoxColumn
            // 
            numCasalDataGridViewTextBoxColumn.DataPropertyName = "NumCasal";
            numCasalDataGridViewTextBoxColumn.HeaderText = "NumCasal";
            numCasalDataGridViewTextBoxColumn.Name = "numCasalDataGridViewTextBoxColumn";
            numCasalDataGridViewTextBoxColumn.ReadOnly = true;
            numCasalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // precoAtualDataGridViewTextBoxColumn
            // 
            precoAtualDataGridViewTextBoxColumn.DataPropertyName = "PrecoAtual";
            precoAtualDataGridViewTextBoxColumn.HeaderText = "Valor";
            precoAtualDataGridViewTextBoxColumn.Name = "precoAtualDataGridViewTextBoxColumn";
            precoAtualDataGridViewTextBoxColumn.ReadOnly = true;
            precoAtualDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            descricaoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            descricaoDataGridViewTextBoxColumn.Width = 300;
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
            Load += Quarto_Load;
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableBTN.ResumeLayout(false);
            tablePesquisa.ResumeLayout(false);
            tablePesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingQuarto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private Label labelTitulo;
        private TableLayoutPanel tableBTN;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnVoltar;
        private BindingSource bindingQuarto;
        private TableLayoutPanel tablePesquisa;
        private RadioButton radioNumero;
        private RadioButton radioDescr;
        private Componentes.TextBoxNovo textPesquisa;
        private Componentes.novoDataGrid DataGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numSoltDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numCasalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoAtualDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private Componentes.novoComboBox comboAtivo;
    }
}