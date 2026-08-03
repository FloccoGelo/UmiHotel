namespace Umi_Interface.Financeiro
{
    partial class AReceber
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tablePai = new TableLayoutPanel();
            tableTitulo = new TableLayoutPanel();
            labelTitulo = new Label();
            panelCor1 = new Panel();
            panelCor2 = new Panel();
            tableForm = new TableLayoutPanel();
            tableLinha1 = new TableLayoutPanel();
            labelDoc = new Label();
            labelCodCli = new Label();
            labelEmis = new Label();
            textDoc = new Umi_Interface.Componentes.TextBoxNovo(components);
            textCodCli = new Umi_Interface.Componentes.TextBoxNovo(components);
            textNomeCliente = new Umi_Interface.Componentes.TextBoxNovo(components);
            dateEmissao = new Umi_Interface.Componentes.novoDateTime(components);
            btnPesquisarCliente = new Button();
            tableLinha2 = new TableLayoutPanel();
            labelValor = new Label();
            labelContabil = new Label();
            labelOBS = new Label();
            textValor = new Umi_Interface.Componentes.TextBoxNovo(components);
            comboContabil = new Umi_Interface.Componentes.novoComboBox();
            textObs = new Umi_Interface.Componentes.TextBoxNovo(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLinha3 = new TableLayoutPanel();
            labelValorParcelas = new Label();
            labelNumParcs = new Label();
            labelDias = new Label();
            labelVencimento = new Label();
            labelForma = new Label();
            textValorParcela = new Umi_Interface.Componentes.TextBoxNovo(components);
            numericNumParcelas = new Umi_Interface.Componentes.novoNumeric(components);
            numericDiasParc = new Umi_Interface.Componentes.novoNumeric(components);
            dateVencimentoParcela = new Umi_Interface.Componentes.novoDateTime(components);
            comboFormaParcela = new Umi_Interface.Componentes.novoComboBox();
            labelSaldo = new Label();
            textSaldo = new Umi_Interface.Componentes.TextBoxNovo(components);
            btnNovo = new Button();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            dataGridParcelas = new Umi_Interface.Componentes.novoDataGrid();
            numParcDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diasVencDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vencimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            docOrigemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codCliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emissaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorTotDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saldoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            obsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsParcela = new BindingSource(components);
            tableBotao = new TableLayoutPanel();
            btnSalvarDocumento = new Button();
            btnFecharTela = new Button();
            tablePai.SuspendLayout();
            tableTitulo.SuspendLayout();
            tableForm.SuspendLayout();
            tableLinha1.SuspendLayout();
            tableLinha2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLinha3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericNumParcelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDiasParc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridParcelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsParcela).BeginInit();
            tableBotao.SuspendLayout();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.BackColor = Color.White;
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.Controls.Add(tableTitulo, 1, 0);
            tablePai.Controls.Add(tableForm, 1, 1);
            tablePai.Controls.Add(tableBotao, 1, 2);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 4;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9533682F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 87.04663F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tablePai.Size = new Size(1000, 600);
            tablePai.TabIndex = 0;
            // 
            // tableTitulo
            // 
            tableTitulo.ColumnCount = 3;
            tableTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableTitulo.Controls.Add(labelTitulo, 1, 0);
            tableTitulo.Controls.Add(panelCor1, 0, 0);
            tableTitulo.Controls.Add(panelCor2, 2, 0);
            tableTitulo.Dock = DockStyle.Fill;
            tableTitulo.Location = new Point(33, 3);
            tableTitulo.Name = "tableTitulo";
            tableTitulo.RowCount = 1;
            tableTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableTitulo.Size = new Size(934, 62);
            tableTitulo.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Teal;
            labelTitulo.Dock = DockStyle.Fill;
            labelTitulo.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(314, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(305, 62);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Nova conta a receber";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCor1
            // 
            panelCor1.Anchor = AnchorStyles.None;
            panelCor1.BackColor = Color.Cyan;
            panelCor1.Location = new Point(3, 20);
            panelCor1.Name = "panelCor1";
            panelCor1.Size = new Size(305, 22);
            panelCor1.TabIndex = 1;
            // 
            // panelCor2
            // 
            panelCor2.Anchor = AnchorStyles.None;
            panelCor2.BackColor = Color.Cyan;
            panelCor2.Location = new Point(625, 20);
            panelCor2.Name = "panelCor2";
            panelCor2.Size = new Size(306, 22);
            panelCor2.TabIndex = 2;
            // 
            // tableForm
            // 
            tableForm.ColumnCount = 1;
            tableForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableForm.Controls.Add(tableLinha1, 0, 0);
            tableForm.Controls.Add(tableLinha2, 0, 1);
            tableForm.Controls.Add(tableLayoutPanel1, 0, 3);
            tableForm.Dock = DockStyle.Fill;
            tableForm.Location = new Point(33, 71);
            tableForm.Name = "tableForm";
            tableForm.RowCount = 4;
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 379F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableForm.Size = new Size(934, 455);
            tableForm.TabIndex = 1;
            // 
            // tableLinha1
            // 
            tableLinha1.ColumnCount = 5;
            tableLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136F));
            tableLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tableLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 502F));
            tableLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLinha1.Controls.Add(labelDoc, 0, 0);
            tableLinha1.Controls.Add(labelCodCli, 2, 0);
            tableLinha1.Controls.Add(labelEmis, 4, 0);
            tableLinha1.Controls.Add(textDoc, 0, 1);
            tableLinha1.Controls.Add(textCodCli, 2, 1);
            tableLinha1.Controls.Add(textNomeCliente, 3, 1);
            tableLinha1.Controls.Add(dateEmissao, 4, 1);
            tableLinha1.Controls.Add(btnPesquisarCliente, 1, 1);
            tableLinha1.Dock = DockStyle.Fill;
            tableLinha1.Location = new Point(3, 3);
            tableLinha1.Name = "tableLinha1";
            tableLinha1.RowCount = 2;
            tableLinha1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLinha1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLinha1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLinha1.Size = new Size(928, 54);
            tableLinha1.TabIndex = 0;
            // 
            // labelDoc
            // 
            labelDoc.AutoSize = true;
            labelDoc.Dock = DockStyle.Bottom;
            labelDoc.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDoc.Location = new Point(3, 6);
            labelDoc.Name = "labelDoc";
            labelDoc.Size = new Size(84, 15);
            labelDoc.TabIndex = 0;
            labelDoc.Text = "Documento:";
            // 
            // labelCodCli
            // 
            labelCodCli.AutoSize = true;
            labelCodCli.Dock = DockStyle.Bottom;
            labelCodCli.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCodCli.Location = new Point(229, 6);
            labelCodCli.Name = "labelCodCli";
            labelCodCli.Size = new Size(86, 15);
            labelCodCli.TabIndex = 1;
            labelCodCli.Text = "Cliente:";
            // 
            // labelEmis
            // 
            labelEmis.AutoSize = true;
            labelEmis.Dock = DockStyle.Bottom;
            labelEmis.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmis.Location = new Point(823, 6);
            labelEmis.Name = "labelEmis";
            labelEmis.Size = new Size(104, 15);
            labelEmis.TabIndex = 2;
            labelEmis.Text = "Emissao:";
            // 
            // textDoc
            // 
            textDoc.BackColor = Color.White;
            textDoc.BorderStyle = BorderStyle.FixedSingle;
            textDoc.Dock = DockStyle.Fill;
            textDoc.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDoc.Location = new Point(3, 24);
            textDoc.MaxLength = 15;
            textDoc.Name = "textDoc";
            textDoc.Size = new Size(84, 22);
            textDoc.TabIndex = 3;
            // 
            // textCodCli
            // 
            textCodCli.BackColor = Color.LightBlue;
            textCodCli.BorderStyle = BorderStyle.FixedSingle;
            textCodCli.Dock = DockStyle.Fill;
            textCodCli.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCodCli.Location = new Point(229, 24);
            textCodCli.Name = "textCodCli";
            textCodCli.ReadOnly = true;
            textCodCli.Size = new Size(86, 22);
            textCodCli.TabIndex = 4;
            // 
            // textNomeCliente
            // 
            textNomeCliente.BackColor = Color.LightBlue;
            textNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            textNomeCliente.Dock = DockStyle.Fill;
            textNomeCliente.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNomeCliente.Location = new Point(321, 24);
            textNomeCliente.Name = "textNomeCliente";
            textNomeCliente.ReadOnly = true;
            textNomeCliente.Size = new Size(496, 22);
            textNomeCliente.TabIndex = 5;
            // 
            // dateEmissao
            // 
            dateEmissao.BackColor = Color.White;
            dateEmissao.Dock = DockStyle.Fill;
            dateEmissao.Format = DateTimePickerFormat.Short;
            dateEmissao.Location = new Point(823, 24);
            dateEmissao.Name = "dateEmissao";
            dateEmissao.Size = new Size(104, 23);
            dateEmissao.TabIndex = 6;
            dateEmissao.ValueChanged += dateEmissao_ValueChanged;
            // 
            // btnPesquisarCliente
            // 
            btnPesquisarCliente.BackColor = Color.FromArgb(255, 192, 255);
            btnPesquisarCliente.Dock = DockStyle.Fill;
            btnPesquisarCliente.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisarCliente.Location = new Point(93, 24);
            btnPesquisarCliente.Name = "btnPesquisarCliente";
            btnPesquisarCliente.Size = new Size(130, 27);
            btnPesquisarCliente.TabIndex = 7;
            btnPesquisarCliente.Text = "Pesquisar Cli.";
            btnPesquisarCliente.UseVisualStyleBackColor = false;
            btnPesquisarCliente.Click += btnPesquisarCliente_Click;
            // 
            // tableLinha2
            // 
            tableLinha2.ColumnCount = 3;
            tableLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2284489F));
            tableLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.83621F));
            tableLinha2.Controls.Add(labelValor, 0, 0);
            tableLinha2.Controls.Add(labelContabil, 1, 0);
            tableLinha2.Controls.Add(labelOBS, 2, 0);
            tableLinha2.Controls.Add(textValor, 0, 1);
            tableLinha2.Controls.Add(comboContabil, 1, 1);
            tableLinha2.Controls.Add(textObs, 2, 1);
            tableLinha2.Dock = DockStyle.Fill;
            tableLinha2.Location = new Point(3, 63);
            tableLinha2.Name = "tableLinha2";
            tableLinha2.RowCount = 2;
            tableLinha2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLinha2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLinha2.Size = new Size(928, 84);
            tableLinha2.TabIndex = 1;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Dock = DockStyle.Bottom;
            labelValor.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValor.Location = new Point(3, 18);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(179, 15);
            labelValor.TabIndex = 0;
            labelValor.Text = "Valor:";
            // 
            // labelContabil
            // 
            labelContabil.AutoSize = true;
            labelContabil.Dock = DockStyle.Bottom;
            labelContabil.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContabil.Location = new Point(188, 18);
            labelContabil.Name = "labelContabil";
            labelContabil.Size = new Size(190, 15);
            labelContabil.TabIndex = 1;
            labelContabil.Text = "Conta Contabil:";
            // 
            // labelOBS
            // 
            labelOBS.AutoSize = true;
            labelOBS.Dock = DockStyle.Bottom;
            labelOBS.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOBS.Location = new Point(384, 18);
            labelOBS.Name = "labelOBS";
            labelOBS.Size = new Size(541, 15);
            labelOBS.TabIndex = 2;
            labelOBS.Text = "Observações:";
            // 
            // textValor
            // 
            textValor.BackColor = Color.White;
            textValor.BorderStyle = BorderStyle.FixedSingle;
            textValor.Dock = DockStyle.Fill;
            textValor.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textValor.Location = new Point(3, 36);
            textValor.Name = "textValor";
            textValor.Size = new Size(179, 22);
            textValor.TabIndex = 3;
            textValor.TextChanged += textValor_TextChanged;
            textValor.KeyPress += textValor_KeyPress;
            // 
            // comboContabil
            // 
            comboContabil.DisabledBackColor = Color.LightBlue;
            comboContabil.DisabledForeColor = Color.Black;
            comboContabil.Dock = DockStyle.Fill;
            comboContabil.DropDownStyle = ComboBoxStyle.DropDownList;
            comboContabil.FormattingEnabled = true;
            comboContabil.Items.AddRange(new object[] { "Conta de teste" });
            comboContabil.Location = new Point(188, 36);
            comboContabil.Name = "comboContabil";
            comboContabil.Size = new Size(190, 23);
            comboContabil.TabIndex = 4;
            // 
            // textObs
            // 
            textObs.BackColor = Color.White;
            textObs.BorderStyle = BorderStyle.FixedSingle;
            textObs.Dock = DockStyle.Fill;
            textObs.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textObs.Location = new Point(384, 36);
            textObs.Multiline = true;
            textObs.Name = "textObs";
            textObs.Size = new Size(541, 45);
            textObs.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLinha3, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridParcelas, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.ForeColor = Color.Black;
            tableLayoutPanel1.Location = new Point(3, 181);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(928, 274);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLinha3
            // 
            tableLinha3.BackColor = Color.FromArgb(192, 255, 255);
            tableLinha3.ColumnCount = 9;
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLinha3.Controls.Add(labelValorParcelas, 2, 0);
            tableLinha3.Controls.Add(labelNumParcs, 1, 0);
            tableLinha3.Controls.Add(labelDias, 3, 0);
            tableLinha3.Controls.Add(labelVencimento, 4, 0);
            tableLinha3.Controls.Add(labelForma, 5, 0);
            tableLinha3.Controls.Add(textValorParcela, 2, 1);
            tableLinha3.Controls.Add(numericNumParcelas, 1, 1);
            tableLinha3.Controls.Add(numericDiasParc, 3, 1);
            tableLinha3.Controls.Add(dateVencimentoParcela, 4, 1);
            tableLinha3.Controls.Add(comboFormaParcela, 5, 1);
            tableLinha3.Controls.Add(labelSaldo, 0, 0);
            tableLinha3.Controls.Add(textSaldo, 0, 1);
            tableLinha3.Controls.Add(btnNovo, 0, 2);
            tableLinha3.Controls.Add(btnSalvar, 1, 2);
            tableLinha3.Controls.Add(btnLimpar, 4, 2);
            tableLinha3.Controls.Add(btnEditar, 2, 2);
            tableLinha3.Controls.Add(btnExcluir, 3, 2);
            tableLinha3.Controls.Add(btnVoltar, 5, 2);
            tableLinha3.Dock = DockStyle.Fill;
            tableLinha3.Location = new Point(3, 3);
            tableLinha3.Name = "tableLinha3";
            tableLinha3.RowCount = 3;
            tableLinha3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLinha3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLinha3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLinha3.Size = new Size(922, 78);
            tableLinha3.TabIndex = 4;
            // 
            // labelValorParcelas
            // 
            labelValorParcelas.AutoSize = true;
            labelValorParcelas.Dock = DockStyle.Bottom;
            labelValorParcelas.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValorParcelas.Location = new Point(173, 5);
            labelValorParcelas.Name = "labelValorParcelas";
            labelValorParcelas.Size = new Size(74, 15);
            labelValorParcelas.TabIndex = 0;
            labelValorParcelas.Text = "Valor:";
            // 
            // labelNumParcs
            // 
            labelNumParcs.AutoSize = true;
            labelNumParcs.Dock = DockStyle.Bottom;
            labelNumParcs.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumParcs.Location = new Point(83, 5);
            labelNumParcs.Name = "labelNumParcs";
            labelNumParcs.Size = new Size(84, 15);
            labelNumParcs.TabIndex = 1;
            labelNumParcs.Text = "Parcelas:";
            // 
            // labelDias
            // 
            labelDias.AutoSize = true;
            labelDias.Dock = DockStyle.Bottom;
            labelDias.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDias.Location = new Point(253, 5);
            labelDias.Name = "labelDias";
            labelDias.Size = new Size(74, 15);
            labelDias.TabIndex = 2;
            labelDias.Text = "Dias:";
            // 
            // labelVencimento
            // 
            labelVencimento.AutoSize = true;
            labelVencimento.Dock = DockStyle.Bottom;
            labelVencimento.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVencimento.Location = new Point(333, 5);
            labelVencimento.Name = "labelVencimento";
            labelVencimento.Size = new Size(94, 15);
            labelVencimento.TabIndex = 3;
            labelVencimento.Text = "Vencimento:";
            // 
            // labelForma
            // 
            labelForma.AutoSize = true;
            labelForma.Dock = DockStyle.Bottom;
            labelForma.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelForma.Location = new Point(433, 5);
            labelForma.Name = "labelForma";
            labelForma.Size = new Size(214, 15);
            labelForma.TabIndex = 4;
            labelForma.Text = "Forma de pagamento:";
            // 
            // textValorParcela
            // 
            textValorParcela.BackColor = Color.White;
            textValorParcela.BorderStyle = BorderStyle.FixedSingle;
            textValorParcela.Dock = DockStyle.Fill;
            textValorParcela.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textValorParcela.Location = new Point(173, 23);
            textValorParcela.Name = "textValorParcela";
            textValorParcela.Size = new Size(74, 22);
            textValorParcela.TabIndex = 5;
            // 
            // numericNumParcelas
            // 
            numericNumParcelas.Dock = DockStyle.Fill;
            numericNumParcelas.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericNumParcelas.Location = new Point(83, 23);
            numericNumParcelas.Name = "numericNumParcelas";
            numericNumParcelas.Size = new Size(84, 22);
            numericNumParcelas.TabIndex = 6;
            numericNumParcelas.KeyDown += numericNumParcelas_KeyDown;
            // 
            // numericDiasParc
            // 
            numericDiasParc.Dock = DockStyle.Fill;
            numericDiasParc.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericDiasParc.Location = new Point(253, 23);
            numericDiasParc.Name = "numericDiasParc";
            numericDiasParc.Size = new Size(74, 22);
            numericDiasParc.TabIndex = 7;
            numericDiasParc.ValueChanged += numericDiasParc_ValueChanged;
            // 
            // dateVencimentoParcela
            // 
            dateVencimentoParcela.BackColor = Color.White;
            dateVencimentoParcela.Dock = DockStyle.Fill;
            dateVencimentoParcela.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateVencimentoParcela.Format = DateTimePickerFormat.Short;
            dateVencimentoParcela.Location = new Point(333, 23);
            dateVencimentoParcela.Name = "dateVencimentoParcela";
            dateVencimentoParcela.Size = new Size(94, 22);
            dateVencimentoParcela.TabIndex = 8;
            // 
            // comboFormaParcela
            // 
            comboFormaParcela.DisabledBackColor = Color.LightBlue;
            comboFormaParcela.DisabledForeColor = Color.Black;
            comboFormaParcela.Dock = DockStyle.Fill;
            comboFormaParcela.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFormaParcela.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboFormaParcela.FormattingEnabled = true;
            comboFormaParcela.Items.AddRange(new object[] { "Forma de teste" });
            comboFormaParcela.Location = new Point(433, 23);
            comboFormaParcela.Name = "comboFormaParcela";
            comboFormaParcela.Size = new Size(214, 23);
            comboFormaParcela.TabIndex = 9;
            // 
            // labelSaldo
            // 
            labelSaldo.AutoSize = true;
            labelSaldo.Dock = DockStyle.Bottom;
            labelSaldo.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSaldo.Location = new Point(3, 5);
            labelSaldo.Name = "labelSaldo";
            labelSaldo.Size = new Size(74, 15);
            labelSaldo.TabIndex = 10;
            labelSaldo.Text = "Saldo:";
            // 
            // textSaldo
            // 
            textSaldo.BackColor = Color.LightBlue;
            textSaldo.BorderStyle = BorderStyle.FixedSingle;
            textSaldo.Dock = DockStyle.Fill;
            textSaldo.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSaldo.Location = new Point(3, 23);
            textSaldo.Name = "textSaldo";
            textSaldo.ReadOnly = true;
            textSaldo.Size = new Size(74, 22);
            textSaldo.TabIndex = 11;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.None;
            btnNovo.BackColor = Color.FromArgb(192, 255, 192);
            btnNovo.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(3, 53);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(74, 23);
            btnNovo.TabIndex = 12;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(192, 192, 255);
            btnSalvar.Dock = DockStyle.Fill;
            btnSalvar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(83, 53);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(84, 24);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.White;
            btnLimpar.Dock = DockStyle.Fill;
            btnLimpar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(333, 53);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 24);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar List";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 224, 192);
            btnEditar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(173, 53);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(74, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 192, 192);
            btnExcluir.Dock = DockStyle.Fill;
            btnExcluir.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(253, 53);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(74, 24);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.TopCenter;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(255, 255, 192);
            btnVoltar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(433, 53);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dataGridParcelas
            // 
            dataGridParcelas.AllowUserToAddRows = false;
            dataGridParcelas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridParcelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridParcelas.AutoGenerateColumns = false;
            dataGridParcelas.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridParcelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridParcelas.Columns.AddRange(new DataGridViewColumn[] { numParcDataGridViewTextBoxColumn, valorDataGridViewTextBoxColumn, diasVencDataGridViewTextBoxColumn, vencimentoDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, docOrigemDataGridViewTextBoxColumn, codCliDataGridViewTextBoxColumn, emissaoDataGridViewTextBoxColumn, valorTotDataGridViewTextBoxColumn, saldoDataGridViewTextBoxColumn, formaDataGridViewTextBoxColumn, obsDataGridViewTextBoxColumn });
            dataGridParcelas.DataSource = bsParcela;
            dataGridParcelas.Font = new Font("Times New Roman", 10F);
            dataGridParcelas.Location = new Point(3, 87);
            dataGridParcelas.MultiSelect = false;
            dataGridParcelas.Name = "dataGridParcelas";
            dataGridParcelas.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = Color.Beige;
            dataGridParcelas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridParcelas.Size = new Size(689, 184);
            dataGridParcelas.TabIndex = 5;
            dataGridParcelas.CellClick += dataGridParcelas_CellClick;
            // 
            // numParcDataGridViewTextBoxColumn
            // 
            numParcDataGridViewTextBoxColumn.DataPropertyName = "numParc";
            numParcDataGridViewTextBoxColumn.HeaderText = "Parcela";
            numParcDataGridViewTextBoxColumn.Name = "numParcDataGridViewTextBoxColumn";
            numParcDataGridViewTextBoxColumn.ReadOnly = true;
            numParcDataGridViewTextBoxColumn.Width = 60;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            valorDataGridViewTextBoxColumn.HeaderText = "valor";
            valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasVencDataGridViewTextBoxColumn
            // 
            diasVencDataGridViewTextBoxColumn.DataPropertyName = "diasVenc";
            diasVencDataGridViewTextBoxColumn.HeaderText = "Dias";
            diasVencDataGridViewTextBoxColumn.Name = "diasVencDataGridViewTextBoxColumn";
            diasVencDataGridViewTextBoxColumn.ReadOnly = true;
            diasVencDataGridViewTextBoxColumn.Width = 60;
            // 
            // vencimentoDataGridViewTextBoxColumn
            // 
            vencimentoDataGridViewTextBoxColumn.DataPropertyName = "vencimento";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            vencimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            vencimentoDataGridViewTextBoxColumn.HeaderText = "D.Venci";
            vencimentoDataGridViewTextBoxColumn.Name = "vencimentoDataGridViewTextBoxColumn";
            vencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            vencimentoDataGridViewTextBoxColumn.Width = 110;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // docOrigemDataGridViewTextBoxColumn
            // 
            docOrigemDataGridViewTextBoxColumn.DataPropertyName = "docOrigem";
            docOrigemDataGridViewTextBoxColumn.HeaderText = "docOrigem";
            docOrigemDataGridViewTextBoxColumn.Name = "docOrigemDataGridViewTextBoxColumn";
            docOrigemDataGridViewTextBoxColumn.ReadOnly = true;
            docOrigemDataGridViewTextBoxColumn.Visible = false;
            // 
            // codCliDataGridViewTextBoxColumn
            // 
            codCliDataGridViewTextBoxColumn.DataPropertyName = "codCli";
            codCliDataGridViewTextBoxColumn.HeaderText = "codCli";
            codCliDataGridViewTextBoxColumn.Name = "codCliDataGridViewTextBoxColumn";
            codCliDataGridViewTextBoxColumn.ReadOnly = true;
            codCliDataGridViewTextBoxColumn.Visible = false;
            // 
            // emissaoDataGridViewTextBoxColumn
            // 
            emissaoDataGridViewTextBoxColumn.DataPropertyName = "emissao";
            emissaoDataGridViewTextBoxColumn.HeaderText = "emissao";
            emissaoDataGridViewTextBoxColumn.Name = "emissaoDataGridViewTextBoxColumn";
            emissaoDataGridViewTextBoxColumn.ReadOnly = true;
            emissaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // valorTotDataGridViewTextBoxColumn
            // 
            valorTotDataGridViewTextBoxColumn.DataPropertyName = "valorTot";
            valorTotDataGridViewTextBoxColumn.HeaderText = "valorTot";
            valorTotDataGridViewTextBoxColumn.Name = "valorTotDataGridViewTextBoxColumn";
            valorTotDataGridViewTextBoxColumn.ReadOnly = true;
            valorTotDataGridViewTextBoxColumn.Visible = false;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            saldoDataGridViewTextBoxColumn.DataPropertyName = "saldo";
            saldoDataGridViewTextBoxColumn.HeaderText = "saldo";
            saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            saldoDataGridViewTextBoxColumn.ReadOnly = true;
            saldoDataGridViewTextBoxColumn.Visible = false;
            // 
            // formaDataGridViewTextBoxColumn
            // 
            formaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            formaDataGridViewTextBoxColumn.DataPropertyName = "forma";
            formaDataGridViewTextBoxColumn.HeaderText = "forma";
            formaDataGridViewTextBoxColumn.Name = "formaDataGridViewTextBoxColumn";
            formaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            obsDataGridViewTextBoxColumn.DataPropertyName = "obs";
            obsDataGridViewTextBoxColumn.HeaderText = "obs";
            obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            obsDataGridViewTextBoxColumn.ReadOnly = true;
            obsDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsParcela
            // 
            bsParcela.DataSource = typeof(Umi_Library.Class.classAReceber);
            // 
            // tableBotao
            // 
            tableBotao.ColumnCount = 3;
            tableBotao.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableBotao.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableBotao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableBotao.Controls.Add(btnSalvarDocumento, 0, 0);
            tableBotao.Controls.Add(btnFecharTela, 1, 0);
            tableBotao.Dock = DockStyle.Fill;
            tableBotao.Location = new Point(33, 532);
            tableBotao.Name = "tableBotao";
            tableBotao.RowCount = 1;
            tableBotao.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableBotao.Size = new Size(934, 39);
            tableBotao.TabIndex = 2;
            // 
            // btnSalvarDocumento
            // 
            btnSalvarDocumento.BackColor = Color.FromArgb(128, 255, 128);
            btnSalvarDocumento.Dock = DockStyle.Fill;
            btnSalvarDocumento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarDocumento.Location = new Point(3, 3);
            btnSalvarDocumento.Name = "btnSalvarDocumento";
            btnSalvarDocumento.Size = new Size(114, 33);
            btnSalvarDocumento.TabIndex = 0;
            btnSalvarDocumento.Text = "Salvar";
            btnSalvarDocumento.UseVisualStyleBackColor = false;
            btnSalvarDocumento.Click += btnSalvarDocumento_Click;
            // 
            // btnFecharTela
            // 
            btnFecharTela.BackColor = Color.FromArgb(255, 128, 128);
            btnFecharTela.Dock = DockStyle.Fill;
            btnFecharTela.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFecharTela.Location = new Point(123, 3);
            btnFecharTela.Name = "btnFecharTela";
            btnFecharTela.Size = new Size(114, 33);
            btnFecharTela.TabIndex = 1;
            btnFecharTela.Text = "Fechar";
            btnFecharTela.UseVisualStyleBackColor = false;
            btnFecharTela.Click += btnFecharTela_Click;
            // 
            // AReceber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(tablePai);
            MinimumSize = new Size(1000, 600);
            Name = "AReceber";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AReceber";
            Load += AReceber_Load;
            tablePai.ResumeLayout(false);
            tableTitulo.ResumeLayout(false);
            tableTitulo.PerformLayout();
            tableForm.ResumeLayout(false);
            tableLinha1.ResumeLayout(false);
            tableLinha1.PerformLayout();
            tableLinha2.ResumeLayout(false);
            tableLinha2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLinha3.ResumeLayout(false);
            tableLinha3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericNumParcelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDiasParc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridParcelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsParcela).EndInit();
            tableBotao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private TableLayoutPanel tableTitulo;
        private Label labelTitulo;
        private Panel panelCor1;
        private Panel panelCor2;
        private TableLayoutPanel tableForm;
        private TableLayoutPanel tableLinha1;
        private Label labelDoc;
        private Label labelCodCli;
        private Label labelEmis;
        private Componentes.TextBoxNovo textDoc;
        private Componentes.TextBoxNovo textCodCli;
        private Componentes.TextBoxNovo textNomeCliente;
        private Componentes.novoDateTime dateEmissao;
        private TableLayoutPanel tableLinha2;
        private Label labelValor;
        private Label labelContabil;
        private Label labelOBS;
        private Componentes.TextBoxNovo textValor;
        private Componentes.novoComboBox comboContabil;
        private Componentes.TextBoxNovo textObs;
        private TableLayoutPanel tableLayoutPanel1;
        private BindingSource bsParcela;
        private Button btnPesquisarCliente;
        private Componentes.novoDataGrid dataGridParcelas;
        private TableLayoutPanel tableLinha3;
        private Label labelValorParcelas;
        private Label labelNumParcs;
        private Label labelDias;
        private Label labelVencimento;
        private Label labelForma;
        private Componentes.TextBoxNovo textValorParcela;
        private Componentes.novoNumeric numericNumParcelas;
        private Componentes.novoNumeric numericDiasParc;
        private Componentes.novoDateTime dateVencimentoParcela;
        private Componentes.novoComboBox comboFormaParcela;
        private Label labelSaldo;
        private Componentes.TextBoxNovo textSaldo;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnEditar;
        private DataGridViewTextBoxColumn numParcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diasVencDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vencimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn docOrigemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codCliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emissaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private Button btnExcluir;
        private Button btnVoltar;
        private TableLayoutPanel tableBotao;
        private Button btnSalvarDocumento;
        private Button btnFecharTela;
    }
}