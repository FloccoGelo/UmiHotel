namespace Umi_Interface.Cadastro
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

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
            tableRadio = new TableLayoutPanel();
            radioNome = new RadioButton();
            radioCPF = new RadioButton();
            textPesquisa = new Umi_Interface.Componentes.TextBoxNovo(components);
            comboAtivo = new Umi_Interface.Componentes.novoComboBox();
            DataGrid = new Umi_Interface.Componentes.novoDataGrid();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codCliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nascimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cPFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefone1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingCliente = new BindingSource(components);
            classClienteBindingSource = new BindingSource(components);
            tablePai.SuspendLayout();
            tableBTN.SuspendLayout();
            tableRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classClienteBindingSource).BeginInit();
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
            tablePai.Controls.Add(tableRadio, 1, 1);
            tablePai.Controls.Add(DataGrid, 1, 2);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Margin = new Padding(4, 3, 4, 3);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 4;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
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
            labelTitulo.Location = new Point(231, 52);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(453, 49);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Gerenciador de Clientes";
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
            btnVoltar.Click += btnVoltar_Click;
            // 
            // tableRadio
            // 
            tableRadio.ColumnCount = 4;
            tableRadio.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableRadio.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableRadio.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 457F));
            tableRadio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableRadio.Controls.Add(radioNome, 0, 0);
            tableRadio.Controls.Add(radioCPF, 1, 0);
            tableRadio.Controls.Add(textPesquisa, 0, 1);
            tableRadio.Controls.Add(comboAtivo, 3, 0);
            tableRadio.Dock = DockStyle.Fill;
            tableRadio.Location = new Point(38, 156);
            tableRadio.Name = "tableRadio";
            tableRadio.RowCount = 2;
            tableRadio.RowStyles.Add(new RowStyle(SizeType.Percent, 52.83019F));
            tableRadio.RowStyles.Add(new RowStyle(SizeType.Percent, 47.16981F));
            tableRadio.Size = new Size(839, 61);
            tableRadio.TabIndex = 3;
            // 
            // radioNome
            // 
            radioNome.AutoSize = true;
            radioNome.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioNome.Location = new Point(3, 3);
            radioNome.Name = "radioNome";
            radioNome.Size = new Size(56, 19);
            radioNome.TabIndex = 0;
            radioNome.TabStop = true;
            radioNome.Text = "Nome";
            radioNome.UseVisualStyleBackColor = true;
            // 
            // radioCPF
            // 
            radioCPF.AutoSize = true;
            radioCPF.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioCPF.Location = new Point(83, 3);
            radioCPF.Name = "radioCPF";
            radioCPF.Size = new Size(49, 19);
            radioCPF.TabIndex = 1;
            radioCPF.TabStop = true;
            radioCPF.Text = "CPF";
            radioCPF.UseVisualStyleBackColor = true;
            // 
            // textPesquisa
            // 
            textPesquisa.BackColor = Color.White;
            textPesquisa.BorderStyle = BorderStyle.FixedSingle;
            tableRadio.SetColumnSpan(textPesquisa, 4);
            textPesquisa.Dock = DockStyle.Fill;
            textPesquisa.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPesquisa.Location = new Point(3, 35);
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(833, 22);
            textPesquisa.TabIndex = 2;
            textPesquisa.TextChanged += textPesquisa_TextChanged;
            // 
            // comboAtivo
            // 
            comboAtivo.DisabledBackColor = Color.LightBlue;
            comboAtivo.DisabledForeColor = Color.Black;
            comboAtivo.Dock = DockStyle.Fill;
            comboAtivo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAtivo.FormattingEnabled = true;
            comboAtivo.Items.AddRange(new object[] { "Sim", "Não" });
            comboAtivo.Location = new Point(700, 3);
            comboAtivo.Name = "comboAtivo";
            comboAtivo.Size = new Size(136, 23);
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
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, codCliDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nascimentoDataGridViewTextBoxColumn, cPFDataGridViewTextBoxColumn, telefone1DataGridViewTextBoxColumn });
            DataGrid.DataSource = bindingCliente;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.Font = new Font("Times New Roman", 10F);
            DataGrid.Location = new Point(38, 223);
            DataGrid.MultiSelect = false;
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.Beige;
            DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new Size(839, 453);
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
            // codCliDataGridViewTextBoxColumn
            // 
            codCliDataGridViewTextBoxColumn.DataPropertyName = "CodCli";
            codCliDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codCliDataGridViewTextBoxColumn.Name = "codCliDataGridViewTextBoxColumn";
            codCliDataGridViewTextBoxColumn.ReadOnly = true;
            codCliDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            nascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            nascimentoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            cPFDataGridViewTextBoxColumn.ReadOnly = true;
            cPFDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // telefone1DataGridViewTextBoxColumn
            // 
            telefone1DataGridViewTextBoxColumn.DataPropertyName = "Telefone1";
            telefone1DataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefone1DataGridViewTextBoxColumn.Name = "telefone1DataGridViewTextBoxColumn";
            telefone1DataGridViewTextBoxColumn.ReadOnly = true;
            telefone1DataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // bindingCliente
            // 
            bindingCliente.DataSource = typeof(Umi_Library.Class.classCliente);
            // 
            // classClienteBindingSource
            // 
            classClienteBindingSource.DataSource = typeof(Umi_Library.Class.classCliente);
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 833);
            Controls.Add(tablePai);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(931, 872);
            MinimumSize = new Size(931, 872);
            Name = "Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            Load += Cliente_Load;
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableBTN.ResumeLayout(false);
            tableRadio.ResumeLayout(false);
            tableRadio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)classClienteBindingSource).EndInit();
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
        private BindingSource bindingCliente;
        private BindingSource classClienteBindingSource;
        private TableLayoutPanel tableRadio;
        private RadioButton radioNome;
        private RadioButton radioCPF;
        private Button button1;
        private Componentes.TextBoxNovo textPesquisa;
        private Componentes.novoDataGrid DataGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codCliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefone1DataGridViewTextBoxColumn;
        private Componentes.novoComboBox comboAtivo;
    }
}