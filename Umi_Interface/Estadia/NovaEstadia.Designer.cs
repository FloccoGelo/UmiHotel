namespace Umi_Interface.Estadia
{
    partial class NovaEstadia
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
            tablePai = new TableLayoutPanel();
            tableButton = new TableLayoutPanel();
            btnSalvar = new Button();
            btnVoltar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelEmissao = new Label();
            dateEmissaoEstadia = new DateTimePicker();
            labelFechamento = new Label();
            dateFechamento = new DateTimePicker();
            labelTotalGeral = new Label();
            textTotalGeral = new TextBox();
            labelStatus = new Label();
            comboStatusHospedagem = new ComboBox();
            labelObs1 = new Label();
            textObsEstadia = new TextBox();
            labelTitulo = new Label();
            tableForm = new TableLayoutPanel();
            tablePesquisaCliente = new TableLayoutPanel();
            buttonPesquisaCliente = new Button();
            labelPesquisa1 = new Label();
            labelPesquisa2 = new Label();
            pesquisaCPF = new Umi_Interface.Componentes.TextBoxNovo(components);
            pesquisaNomeCli = new Umi_Interface.Componentes.TextBoxNovo(components);
            tablePesquisaQuarto = new TableLayoutPanel();
            btnPesquisaQuarto = new Button();
            labelNumQuarto = new Label();
            labelDescQuarto = new Label();
            labelObs = new Label();
            textObsQuarto = new TextBox();
            bsEstadiaQuarto = new BindingSource(components);
            btnEditar = new Button();
            btnExcluir = new Button();
            textNumQuarto = new Umi_Interface.Componentes.TextBoxNovo(components);
            textDescQuarto = new Umi_Interface.Componentes.TextBoxNovo(components);
            dataGridQuarto = new DataGridView();
            numQuartoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diasHospedagemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diariaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDiariaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numHospedesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Check_In = new DataGridViewTextBoxColumn();
            Previs_Check_Out = new DataGridViewTextBoxColumn();
            Check_Out = new DataGridViewTextBoxColumn();
            labelAviso = new Label();
            bsCliente = new BindingSource(components);
            bsClassQuarto = new BindingSource(components);
            tableLateral = new TableLayoutPanel();
            bsEstadia = new BindingSource(components);
            tablePai.SuspendLayout();
            tableButton.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableForm.SuspendLayout();
            tablePesquisaCliente.SuspendLayout();
            tablePesquisaQuarto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsEstadiaQuarto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridQuarto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClassQuarto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEstadia).BeginInit();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.ColumnCount = 2;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePai.Controls.Add(tableButton, 1, 2);
            tablePai.Controls.Add(labelTitulo, 1, 0);
            tablePai.Controls.Add(tableForm, 1, 1);
            tablePai.Dock = DockStyle.Left;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 3;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 67.5870361F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 18.4873943F));
            tablePai.Size = new Size(727, 833);
            tablePai.TabIndex = 0;
            // 
            // tableButton
            // 
            tableButton.ColumnCount = 4;
            tableButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableButton.Controls.Add(btnSalvar, 1, 1);
            tableButton.Controls.Add(btnVoltar, 2, 1);
            tableButton.Controls.Add(tableLayoutPanel1, 3, 0);
            tableButton.Dock = DockStyle.Fill;
            tableButton.Location = new Point(33, 681);
            tableButton.Name = "tableButton";
            tableButton.RowCount = 3;
            tableButton.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableButton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableButton.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableButton.Size = new Size(691, 149);
            tableButton.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(128, 255, 255);
            btnSalvar.Dock = DockStyle.Fill;
            btnSalvar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(33, 63);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 53);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(255, 128, 128);
            btnVoltar.Dock = DockStyle.Fill;
            btnVoltar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(133, 63);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 53);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(labelEmissao, 1, 0);
            tableLayoutPanel1.Controls.Add(dateEmissaoEstadia, 1, 1);
            tableLayoutPanel1.Controls.Add(labelFechamento, 2, 0);
            tableLayoutPanel1.Controls.Add(dateFechamento, 2, 1);
            tableLayoutPanel1.Controls.Add(labelTotalGeral, 3, 0);
            tableLayoutPanel1.Controls.Add(textTotalGeral, 3, 1);
            tableLayoutPanel1.Controls.Add(labelStatus, 4, 0);
            tableLayoutPanel1.Controls.Add(comboStatusHospedagem, 4, 1);
            tableLayoutPanel1.Controls.Add(labelObs1, 0, 2);
            tableLayoutPanel1.Controls.Add(textObsEstadia, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(233, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableButton.SetRowSpan(tableLayoutPanel1, 3);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Size = new Size(455, 143);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // labelEmissao
            // 
            labelEmissao.AutoSize = true;
            labelEmissao.Dock = DockStyle.Bottom;
            labelEmissao.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmissao.Location = new Point(53, 16);
            labelEmissao.Name = "labelEmissao";
            labelEmissao.Size = new Size(94, 15);
            labelEmissao.TabIndex = 0;
            labelEmissao.Text = "Emissao:";
            // 
            // dateEmissaoEstadia
            // 
            dateEmissaoEstadia.CalendarFont = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateEmissaoEstadia.Dock = DockStyle.Fill;
            dateEmissaoEstadia.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateEmissaoEstadia.Format = DateTimePickerFormat.Short;
            dateEmissaoEstadia.Location = new Point(53, 34);
            dateEmissaoEstadia.Name = "dateEmissaoEstadia";
            dateEmissaoEstadia.Size = new Size(94, 21);
            dateEmissaoEstadia.TabIndex = 1;
            // 
            // labelFechamento
            // 
            labelFechamento.AutoSize = true;
            labelFechamento.Dock = DockStyle.Bottom;
            labelFechamento.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechamento.Location = new Point(153, 16);
            labelFechamento.Name = "labelFechamento";
            labelFechamento.Size = new Size(94, 15);
            labelFechamento.TabIndex = 2;
            labelFechamento.Text = "Fechamento:";
            // 
            // dateFechamento
            // 
            dateFechamento.Dock = DockStyle.Fill;
            dateFechamento.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateFechamento.Format = DateTimePickerFormat.Custom;
            dateFechamento.Location = new Point(153, 34);
            dateFechamento.Name = "dateFechamento";
            dateFechamento.ShowCheckBox = true;
            dateFechamento.Size = new Size(94, 21);
            dateFechamento.TabIndex = 3;
            dateFechamento.UseWaitCursor = true;
            dateFechamento.Value = new DateTime(2026, 6, 7, 0, 0, 0, 0);
            // 
            // labelTotalGeral
            // 
            labelTotalGeral.AutoSize = true;
            labelTotalGeral.Dock = DockStyle.Bottom;
            labelTotalGeral.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalGeral.Location = new Point(253, 16);
            labelTotalGeral.Name = "labelTotalGeral";
            labelTotalGeral.Size = new Size(69, 15);
            labelTotalGeral.TabIndex = 4;
            labelTotalGeral.Text = "Total:";
            // 
            // textTotalGeral
            // 
            textTotalGeral.BorderStyle = BorderStyle.FixedSingle;
            textTotalGeral.Dock = DockStyle.Fill;
            textTotalGeral.Enabled = false;
            textTotalGeral.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTotalGeral.Location = new Point(253, 34);
            textTotalGeral.Name = "textTotalGeral";
            textTotalGeral.Size = new Size(69, 21);
            textTotalGeral.TabIndex = 5;
            textTotalGeral.TextChanged += textTotalGeral_TextChanged;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Dock = DockStyle.Bottom;
            labelStatus.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(328, 16);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(124, 15);
            labelStatus.TabIndex = 6;
            labelStatus.Text = "Status hospedagem";
            // 
            // comboStatusHospedagem
            // 
            comboStatusHospedagem.Dock = DockStyle.Fill;
            comboStatusHospedagem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatusHospedagem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboStatusHospedagem.FormattingEnabled = true;
            comboStatusHospedagem.Items.AddRange(new object[] { "Aberto", "Fechado" });
            comboStatusHospedagem.Location = new Point(328, 34);
            comboStatusHospedagem.Name = "comboStatusHospedagem";
            comboStatusHospedagem.Size = new Size(124, 23);
            comboStatusHospedagem.TabIndex = 7;
            // 
            // labelObs1
            // 
            labelObs1.AutoSize = true;
            labelObs1.Dock = DockStyle.Right;
            labelObs1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelObs1.Location = new Point(15, 62);
            labelObs1.Name = "labelObs1";
            labelObs1.Size = new Size(32, 53);
            labelObs1.TabIndex = 8;
            labelObs1.Text = "Obs:";
            // 
            // textObsEstadia
            // 
            textObsEstadia.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(textObsEstadia, 4);
            textObsEstadia.Dock = DockStyle.Fill;
            textObsEstadia.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textObsEstadia.Location = new Point(53, 65);
            textObsEstadia.MaxLength = 400;
            textObsEstadia.Multiline = true;
            textObsEstadia.Name = "textObsEstadia";
            textObsEstadia.Size = new Size(399, 47);
            textObsEstadia.TabIndex = 9;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.DarkGreen;
            labelTitulo.Location = new Point(266, 36);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(225, 43);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Nova Estadia";
            // 
            // tableForm
            // 
            tableForm.ColumnCount = 1;
            tableForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableForm.Controls.Add(tablePesquisaCliente, 0, 0);
            tableForm.Controls.Add(tablePesquisaQuarto, 0, 2);
            tableForm.Controls.Add(dataGridQuarto, 0, 4);
            tableForm.Controls.Add(labelAviso, 0, 3);
            tableForm.Dock = DockStyle.Fill;
            tableForm.Location = new Point(33, 119);
            tableForm.Name = "tableForm";
            tableForm.RowCount = 5;
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableForm.Size = new Size(691, 556);
            tableForm.TabIndex = 3;
            // 
            // tablePesquisaCliente
            // 
            tablePesquisaCliente.BackColor = Color.FromArgb(192, 255, 255);
            tablePesquisaCliente.ColumnCount = 3;
            tablePesquisaCliente.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tablePesquisaCliente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tablePesquisaCliente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tablePesquisaCliente.Controls.Add(buttonPesquisaCliente, 0, 1);
            tablePesquisaCliente.Controls.Add(labelPesquisa1, 1, 0);
            tablePesquisaCliente.Controls.Add(labelPesquisa2, 2, 0);
            tablePesquisaCliente.Controls.Add(pesquisaCPF, 1, 1);
            tablePesquisaCliente.Controls.Add(pesquisaNomeCli, 2, 1);
            tablePesquisaCliente.Dock = DockStyle.Fill;
            tablePesquisaCliente.Location = new Point(3, 3);
            tablePesquisaCliente.Name = "tablePesquisaCliente";
            tablePesquisaCliente.RowCount = 2;
            tablePesquisaCliente.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePesquisaCliente.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePesquisaCliente.Size = new Size(685, 64);
            tablePesquisaCliente.TabIndex = 0;
            // 
            // buttonPesquisaCliente
            // 
            buttonPesquisaCliente.BackColor = SystemColors.ActiveCaption;
            buttonPesquisaCliente.Dock = DockStyle.Fill;
            buttonPesquisaCliente.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPesquisaCliente.Location = new Point(3, 35);
            buttonPesquisaCliente.Name = "buttonPesquisaCliente";
            buttonPesquisaCliente.Size = new Size(94, 26);
            buttonPesquisaCliente.TabIndex = 0;
            buttonPesquisaCliente.Text = "Pesquisar";
            buttonPesquisaCliente.UseVisualStyleBackColor = false;
            buttonPesquisaCliente.Click += buttonPesquisaCliente_Click;
            // 
            // labelPesquisa1
            // 
            labelPesquisa1.AutoSize = true;
            labelPesquisa1.Dock = DockStyle.Bottom;
            labelPesquisa1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPesquisa1.Location = new Point(103, 13);
            labelPesquisa1.Name = "labelPesquisa1";
            labelPesquisa1.Size = new Size(81, 19);
            labelPesquisa1.TabIndex = 1;
            labelPesquisa1.Text = "CPF:";
            // 
            // labelPesquisa2
            // 
            labelPesquisa2.AutoSize = true;
            labelPesquisa2.Dock = DockStyle.Bottom;
            labelPesquisa2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPesquisa2.Location = new Point(190, 13);
            labelPesquisa2.Name = "labelPesquisa2";
            labelPesquisa2.Size = new Size(492, 19);
            labelPesquisa2.TabIndex = 2;
            labelPesquisa2.Text = "Nome:";
            // 
            // pesquisaCPF
            // 
            pesquisaCPF.BackColor = Color.LightBlue;
            pesquisaCPF.BorderStyle = BorderStyle.FixedSingle;
            pesquisaCPF.Dock = DockStyle.Fill;
            pesquisaCPF.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pesquisaCPF.Location = new Point(103, 35);
            pesquisaCPF.Name = "pesquisaCPF";
            pesquisaCPF.ReadOnly = true;
            pesquisaCPF.Size = new Size(81, 22);
            pesquisaCPF.TabIndex = 5;
            // 
            // pesquisaNomeCli
            // 
            pesquisaNomeCli.BackColor = Color.LightBlue;
            pesquisaNomeCli.BorderStyle = BorderStyle.FixedSingle;
            pesquisaNomeCli.Dock = DockStyle.Fill;
            pesquisaNomeCli.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pesquisaNomeCli.Location = new Point(190, 35);
            pesquisaNomeCli.Name = "pesquisaNomeCli";
            pesquisaNomeCli.ReadOnly = true;
            pesquisaNomeCli.Size = new Size(492, 22);
            pesquisaNomeCli.TabIndex = 6;
            // 
            // tablePesquisaQuarto
            // 
            tablePesquisaQuarto.BackColor = Color.FromArgb(192, 255, 255);
            tablePesquisaQuarto.ColumnCount = 3;
            tablePesquisaQuarto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tablePesquisaQuarto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tablePesquisaQuarto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tablePesquisaQuarto.Controls.Add(btnPesquisaQuarto, 0, 1);
            tablePesquisaQuarto.Controls.Add(labelNumQuarto, 1, 0);
            tablePesquisaQuarto.Controls.Add(labelDescQuarto, 2, 0);
            tablePesquisaQuarto.Controls.Add(labelObs, 1, 2);
            tablePesquisaQuarto.Controls.Add(textObsQuarto, 1, 3);
            tablePesquisaQuarto.Controls.Add(btnEditar, 0, 2);
            tablePesquisaQuarto.Controls.Add(btnExcluir, 0, 3);
            tablePesquisaQuarto.Controls.Add(textNumQuarto, 1, 1);
            tablePesquisaQuarto.Controls.Add(textDescQuarto, 2, 1);
            tablePesquisaQuarto.Dock = DockStyle.Fill;
            tablePesquisaQuarto.Location = new Point(3, 83);
            tablePesquisaQuarto.Name = "tablePesquisaQuarto";
            tablePesquisaQuarto.RowCount = 4;
            tablePesquisaQuarto.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tablePesquisaQuarto.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tablePesquisaQuarto.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tablePesquisaQuarto.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tablePesquisaQuarto.Size = new Size(685, 104);
            tablePesquisaQuarto.TabIndex = 1;
            // 
            // btnPesquisaQuarto
            // 
            btnPesquisaQuarto.BackColor = Color.FromArgb(255, 128, 255);
            btnPesquisaQuarto.Dock = DockStyle.Fill;
            btnPesquisaQuarto.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisaQuarto.ForeColor = SystemColors.ControlText;
            btnPesquisaQuarto.Location = new Point(3, 21);
            btnPesquisaQuarto.Name = "btnPesquisaQuarto";
            btnPesquisaQuarto.Size = new Size(94, 24);
            btnPesquisaQuarto.TabIndex = 0;
            btnPesquisaQuarto.Text = "Pesquisar";
            btnPesquisaQuarto.UseVisualStyleBackColor = false;
            btnPesquisaQuarto.Click += btnPesquisaQuarto_Click;
            // 
            // labelNumQuarto
            // 
            labelNumQuarto.AutoSize = true;
            labelNumQuarto.Dock = DockStyle.Bottom;
            labelNumQuarto.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumQuarto.Location = new Point(103, 0);
            labelNumQuarto.Name = "labelNumQuarto";
            labelNumQuarto.Size = new Size(81, 18);
            labelNumQuarto.TabIndex = 1;
            labelNumQuarto.Text = "Num Quarto:";
            // 
            // labelDescQuarto
            // 
            labelDescQuarto.AutoSize = true;
            labelDescQuarto.Dock = DockStyle.Bottom;
            labelDescQuarto.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescQuarto.Location = new Point(190, 0);
            labelDescQuarto.Name = "labelDescQuarto";
            labelDescQuarto.Size = new Size(492, 18);
            labelDescQuarto.TabIndex = 3;
            labelDescQuarto.Text = "Descriçao:";
            // 
            // labelObs
            // 
            labelObs.AutoSize = true;
            labelObs.Dock = DockStyle.Bottom;
            labelObs.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelObs.Location = new Point(103, 63);
            labelObs.Name = "labelObs";
            labelObs.Size = new Size(81, 15);
            labelObs.TabIndex = 5;
            labelObs.Text = "Obs:";
            // 
            // textObsQuarto
            // 
            textObsQuarto.BorderStyle = BorderStyle.FixedSingle;
            tablePesquisaQuarto.SetColumnSpan(textObsQuarto, 2);
            textObsQuarto.DataBindings.Add(new Binding("Text", bsEstadiaQuarto, "Obs", true));
            textObsQuarto.Dock = DockStyle.Fill;
            textObsQuarto.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textObsQuarto.Location = new Point(103, 81);
            textObsQuarto.Name = "textObsQuarto";
            textObsQuarto.Size = new Size(579, 21);
            textObsQuarto.TabIndex = 6;
            // 
            // bsEstadiaQuarto
            // 
            bsEstadiaQuarto.DataSource = typeof(Umi_Library.Class.classQuartoEstadia);
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(3, 51);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 24);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Dock = DockStyle.Fill;
            btnExcluir.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(3, 81);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 24);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // textNumQuarto
            // 
            textNumQuarto.BackColor = Color.LightBlue;
            textNumQuarto.BorderStyle = BorderStyle.FixedSingle;
            textNumQuarto.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNumQuarto.Location = new Point(103, 21);
            textNumQuarto.Name = "textNumQuarto";
            textNumQuarto.ReadOnly = true;
            textNumQuarto.Size = new Size(81, 22);
            textNumQuarto.TabIndex = 9;
            // 
            // textDescQuarto
            // 
            textDescQuarto.BackColor = Color.LightBlue;
            textDescQuarto.BorderStyle = BorderStyle.FixedSingle;
            textDescQuarto.Dock = DockStyle.Fill;
            textDescQuarto.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDescQuarto.Location = new Point(190, 21);
            textDescQuarto.Name = "textDescQuarto";
            textDescQuarto.ReadOnly = true;
            textDescQuarto.Size = new Size(492, 22);
            textDescQuarto.TabIndex = 10;
            // 
            // dataGridQuarto
            // 
            dataGridQuarto.AllowUserToAddRows = false;
            dataGridQuarto.AllowUserToDeleteRows = false;
            dataGridQuarto.AutoGenerateColumns = false;
            dataGridQuarto.BackgroundColor = Color.White;
            dataGridQuarto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridQuarto.Columns.AddRange(new DataGridViewColumn[] { numQuartoDataGridViewTextBoxColumn, diasHospedagemDataGridViewTextBoxColumn, diariaDataGridViewTextBoxColumn, totalDiariaDataGridViewTextBoxColumn, numHospedesDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, Check_In, Previs_Check_Out, Check_Out });
            dataGridQuarto.DataSource = bsEstadiaQuarto;
            dataGridQuarto.Dock = DockStyle.Fill;
            dataGridQuarto.Location = new Point(3, 211);
            dataGridQuarto.MultiSelect = false;
            dataGridQuarto.Name = "dataGridQuarto";
            dataGridQuarto.ReadOnly = true;
            dataGridQuarto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridQuarto.Size = new Size(685, 342);
            dataGridQuarto.TabIndex = 2;
            dataGridQuarto.CellClick += dataGridQuarto_CellClick;
            // 
            // numQuartoDataGridViewTextBoxColumn
            // 
            numQuartoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            numQuartoDataGridViewTextBoxColumn.DataPropertyName = "NumQuarto";
            numQuartoDataGridViewTextBoxColumn.FillWeight = 50F;
            numQuartoDataGridViewTextBoxColumn.HeaderText = "Quarto";
            numQuartoDataGridViewTextBoxColumn.Name = "numQuartoDataGridViewTextBoxColumn";
            numQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            numQuartoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // diasHospedagemDataGridViewTextBoxColumn
            // 
            diasHospedagemDataGridViewTextBoxColumn.DataPropertyName = "DiasHospedagem";
            diasHospedagemDataGridViewTextBoxColumn.HeaderText = "N. Dias";
            diasHospedagemDataGridViewTextBoxColumn.Name = "diasHospedagemDataGridViewTextBoxColumn";
            diasHospedagemDataGridViewTextBoxColumn.ReadOnly = true;
            diasHospedagemDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            diasHospedagemDataGridViewTextBoxColumn.Width = 50;
            // 
            // diariaDataGridViewTextBoxColumn
            // 
            diariaDataGridViewTextBoxColumn.DataPropertyName = "Diaria";
            diariaDataGridViewTextBoxColumn.HeaderText = "Diaria";
            diariaDataGridViewTextBoxColumn.Name = "diariaDataGridViewTextBoxColumn";
            diariaDataGridViewTextBoxColumn.ReadOnly = true;
            diariaDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            diariaDataGridViewTextBoxColumn.Width = 50;
            // 
            // totalDiariaDataGridViewTextBoxColumn
            // 
            totalDiariaDataGridViewTextBoxColumn.DataPropertyName = "TotalDiaria";
            totalDiariaDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDiariaDataGridViewTextBoxColumn.Name = "totalDiariaDataGridViewTextBoxColumn";
            totalDiariaDataGridViewTextBoxColumn.ReadOnly = true;
            totalDiariaDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            totalDiariaDataGridViewTextBoxColumn.Width = 50;
            // 
            // numHospedesDataGridViewTextBoxColumn
            // 
            numHospedesDataGridViewTextBoxColumn.DataPropertyName = "NumHospedes";
            numHospedesDataGridViewTextBoxColumn.HeaderText = "Hospedes";
            numHospedesDataGridViewTextBoxColumn.Name = "numHospedesDataGridViewTextBoxColumn";
            numHospedesDataGridViewTextBoxColumn.ReadOnly = true;
            numHospedesDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            numHospedesDataGridViewTextBoxColumn.Width = 65;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // Check_In
            // 
            Check_In.DataPropertyName = "Check_In";
            Check_In.HeaderText = "Check_In";
            Check_In.Name = "Check_In";
            Check_In.ReadOnly = true;
            Check_In.Resizable = DataGridViewTriState.False;
            // 
            // Previs_Check_Out
            // 
            Previs_Check_Out.DataPropertyName = "Previs_Check_Out";
            Previs_Check_Out.HeaderText = "Previs_Check_Out";
            Previs_Check_Out.Name = "Previs_Check_Out";
            Previs_Check_Out.ReadOnly = true;
            Previs_Check_Out.Resizable = DataGridViewTriState.False;
            // 
            // Check_Out
            // 
            Check_Out.DataPropertyName = "Check_Out";
            Check_Out.HeaderText = "Check_Out";
            Check_Out.Name = "Check_Out";
            Check_Out.ReadOnly = true;
            Check_Out.Resizable = DataGridViewTriState.False;
            // 
            // labelAviso
            // 
            labelAviso.AutoSize = true;
            labelAviso.Dock = DockStyle.Bottom;
            labelAviso.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAviso.ForeColor = Color.Purple;
            labelAviso.Location = new Point(3, 193);
            labelAviso.Name = "labelAviso";
            labelAviso.Size = new Size(685, 15);
            labelAviso.TabIndex = 3;
            labelAviso.Text = "Clique na linha para editar as informações";
            // 
            // bsCliente
            // 
            bsCliente.DataSource = typeof(Umi_Library.Class.classCliente);
            // 
            // bsClassQuarto
            // 
            bsClassQuarto.DataSource = typeof(Umi_Library.Class.classQuarto);
            // 
            // tableLateral
            // 
            tableLateral.BackColor = Color.FromArgb(128, 255, 255);
            tableLateral.ColumnCount = 2;
            tableLateral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLateral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLateral.Dock = DockStyle.Right;
            tableLateral.Location = new Point(733, 0);
            tableLateral.Name = "tableLateral";
            tableLateral.RowCount = 19;
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLateral.Size = new Size(182, 833);
            tableLateral.TabIndex = 4;
            // 
            // bsEstadia
            // 
            bsEstadia.DataSource = typeof(Umi_Library.Class.classEstadia);
            // 
            // NovaEstadia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 833);
            Controls.Add(tablePai);
            Controls.Add(tableLateral);
            MaximumSize = new Size(931, 872);
            MinimumSize = new Size(931, 872);
            Name = "NovaEstadia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadia";
            Load += NovaEstadia_Load;
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableButton.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableForm.ResumeLayout(false);
            tableForm.PerformLayout();
            tablePesquisaCliente.ResumeLayout(false);
            tablePesquisaCliente.PerformLayout();
            tablePesquisaQuarto.ResumeLayout(false);
            tablePesquisaQuarto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsEstadiaQuarto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridQuarto).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClassQuarto).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEstadia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private Label labelTitulo;
        private TableLayoutPanel tableButton;
        private Button btnSalvar;
        private Button btnVoltar;
        private TableLayoutPanel tableForm;
        private TableLayoutPanel tablePesquisaCliente;
        private Button buttonPesquisaCliente;
        private Label labelPesquisa1;
        private Label labelPesquisa2;
        private BindingSource bsCliente;
        private TableLayoutPanel tablePesquisaQuarto;
        private Button btnPesquisaQuarto;
        private Label labelNumQuarto;
        private Label labelDescQuarto;
        private BindingSource bsEstadiaQuarto;
        private Label labelObs;
        private TextBox textObsQuarto;
        private Label labelAviso;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelEmissao;
        private DateTimePicker dateEmissaoEstadia;
        private Label labelFechamento;
        private DateTimePicker dateFechamento;
        private Label labelTotalGeral;
        private TextBox textTotalGeral;
        private Label labelStatus;
        private ComboBox comboStatusHospedagem;
        private Label labelObs1;
        private TextBox textObsEstadia;
        private DataGridView dataGridQuarto;
        private DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private BindingSource bsClassQuarto;
        private TableLayoutPanel tableLateral;
        private Button btnEditar;
        private Button btnExcluir;
        private BindingSource bsEstadia;
        private DataGridViewTextBoxColumn numQuartoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diasHospedagemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diariaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDiariaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numHospedesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Check_In;
        private DataGridViewTextBoxColumn Previs_Check_Out;
        private DataGridViewTextBoxColumn Check_Out;
        private Componentes.TextBoxNovo pesquisaCPF;
        private Componentes.TextBoxNovo pesquisaNomeCli;
        private Componentes.TextBoxNovo textNumQuarto;
        private Componentes.TextBoxNovo textDescQuarto;
    }
}