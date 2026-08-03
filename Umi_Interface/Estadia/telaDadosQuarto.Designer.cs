namespace Umi_Interface.Estadia
{
    partial class telaDadosQuarto
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
            labelTitulo = new Label();
            tableForm = new TableLayoutPanel();
            tableLinha01 = new TableLayoutPanel();
            btnNovo = new Button();
            btnLimpar = new Button();
            labelNumero = new Label();
            labelNumPessoas = new Label();
            labelDiasHospedagens = new Label();
            labelValDiaria = new Label();
            labelTotDiaria = new Label();
            textNumero = new Umi_Interface.Componentes.TextBoxNovo(components);
            numericNumPessoas = new Umi_Interface.Componentes.novoNumeric(components);
            numericDias = new Umi_Interface.Componentes.novoNumeric(components);
            textValDiaria = new Umi_Interface.Componentes.TextBoxNovo(components);
            textTotDiaria = new Umi_Interface.Componentes.TextBoxNovo(components);
            tableLinha02 = new TableLayoutPanel();
            labelDescricao = new Label();
            textDescricao = new Umi_Interface.Componentes.TextBoxNovo(components);
            tableLinha03 = new TableLayoutPanel();
            labelStatus = new Label();
            labelEntrada = new Label();
            labelPrevisSaida = new Label();
            labelSaida = new Label();
            comboStatus = new Umi_Interface.Componentes.novoComboBox();
            dateEntrada = new Umi_Interface.Componentes.novoDateTime(components);
            datePrevisSaida = new Umi_Interface.Componentes.novoDateTime(components);
            dateSaida = new Umi_Interface.Componentes.novoDateTime(components);
            tableLinha4 = new TableLayoutPanel();
            labelObs = new Label();
            textObs = new Umi_Interface.Componentes.TextBoxNovo(components);
            tableBtn = new TableLayoutPanel();
            buttonSalvar = new Button();
            buttonVoltar = new Button();
            bsQuarto = new BindingSource(components);
            tablePai.SuspendLayout();
            tableForm.SuspendLayout();
            tableLinha01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericNumPessoas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDias).BeginInit();
            tableLinha02.SuspendLayout();
            tableLinha03.SuspendLayout();
            tableLinha4.SuspendLayout();
            tableBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsQuarto).BeginInit();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.Controls.Add(labelTitulo, 1, 0);
            tablePai.Controls.Add(tableForm, 1, 1);
            tablePai.Controls.Add(tableLinha02, 1, 2);
            tablePai.Controls.Add(tableLinha03, 1, 3);
            tablePai.Controls.Add(tableLinha4, 1, 4);
            tablePai.Controls.Add(tableBtn, 1, 5);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 6;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tablePai.Size = new Size(634, 361);
            tablePai.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(192, 0, 0);
            labelTitulo.Location = new Point(194, 12);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(246, 36);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Pesquisar Quarto";
            // 
            // tableForm
            // 
            tableForm.AllowDrop = true;
            tableForm.ColumnCount = 1;
            tableForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableForm.Controls.Add(tableLinha01, 0, 0);
            tableForm.Dock = DockStyle.Fill;
            tableForm.Location = new Point(33, 63);
            tableForm.Name = "tableForm";
            tableForm.RowCount = 2;
            tableForm.RowStyles.Add(new RowStyle(SizeType.Percent, 92.66055F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Percent, 7.33944941F));
            tableForm.Size = new Size(568, 64);
            tableForm.TabIndex = 1;
            // 
            // tableLinha01
            // 
            tableLinha01.ColumnCount = 7;
            tableLinha01.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLinha01.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLinha01.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLinha01.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLinha01.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLinha01.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLinha01.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLinha01.Controls.Add(btnNovo, 0, 0);
            tableLinha01.Controls.Add(btnLimpar, 1, 0);
            tableLinha01.Controls.Add(labelNumero, 2, 0);
            tableLinha01.Controls.Add(labelNumPessoas, 3, 0);
            tableLinha01.Controls.Add(labelDiasHospedagens, 4, 0);
            tableLinha01.Controls.Add(labelValDiaria, 5, 0);
            tableLinha01.Controls.Add(labelTotDiaria, 6, 0);
            tableLinha01.Controls.Add(textNumero, 2, 1);
            tableLinha01.Controls.Add(numericNumPessoas, 3, 1);
            tableLinha01.Controls.Add(numericDias, 4, 1);
            tableLinha01.Controls.Add(textValDiaria, 5, 1);
            tableLinha01.Controls.Add(textTotDiaria, 6, 1);
            tableLinha01.Dock = DockStyle.Fill;
            tableLinha01.Location = new Point(3, 3);
            tableLinha01.Name = "tableLinha01";
            tableLinha01.RowCount = 2;
            tableLinha01.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha01.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha01.Size = new Size(562, 53);
            tableLinha01.TabIndex = 0;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.FromArgb(128, 255, 128);
            btnNovo.Dock = DockStyle.Fill;
            btnNovo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(3, 3);
            btnNovo.Name = "btnNovo";
            tableLinha01.SetRowSpan(btnNovo, 2);
            btnNovo.Size = new Size(44, 47);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "+";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 128, 128);
            btnLimpar.Dock = DockStyle.Fill;
            btnLimpar.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.Black;
            btnLimpar.Location = new Point(53, 3);
            btnLimpar.Name = "btnLimpar";
            tableLinha01.SetRowSpan(btnLimpar, 2);
            btnLimpar.Size = new Size(44, 47);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "-";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Dock = DockStyle.Bottom;
            labelNumero.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumero.Location = new Point(103, 11);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(94, 15);
            labelNumero.TabIndex = 2;
            labelNumero.Text = "Numero";
            // 
            // labelNumPessoas
            // 
            labelNumPessoas.AutoSize = true;
            labelNumPessoas.Dock = DockStyle.Bottom;
            labelNumPessoas.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNumPessoas.Location = new Point(203, 10);
            labelNumPessoas.Name = "labelNumPessoas";
            labelNumPessoas.Size = new Size(89, 16);
            labelNumPessoas.TabIndex = 4;
            labelNumPessoas.Text = "Num Pessoas *";
            // 
            // labelDiasHospedagens
            // 
            labelDiasHospedagens.AutoSize = true;
            labelDiasHospedagens.Dock = DockStyle.Bottom;
            labelDiasHospedagens.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDiasHospedagens.Location = new Point(298, 10);
            labelDiasHospedagens.Name = "labelDiasHospedagens";
            labelDiasHospedagens.Size = new Size(64, 16);
            labelDiasHospedagens.TabIndex = 6;
            labelDiasHospedagens.Text = "Dias *";
            // 
            // labelValDiaria
            // 
            labelValDiaria.AutoSize = true;
            labelValDiaria.Dock = DockStyle.Bottom;
            labelValDiaria.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelValDiaria.Location = new Point(368, 10);
            labelValDiaria.Name = "labelValDiaria";
            labelValDiaria.Size = new Size(92, 16);
            labelValDiaria.TabIndex = 8;
            labelValDiaria.Text = "Val Diaria *";
            // 
            // labelTotDiaria
            // 
            labelTotDiaria.AutoSize = true;
            labelTotDiaria.Dock = DockStyle.Bottom;
            labelTotDiaria.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTotDiaria.Location = new Point(466, 10);
            labelTotDiaria.Name = "labelTotDiaria";
            labelTotDiaria.Size = new Size(93, 16);
            labelTotDiaria.TabIndex = 9;
            labelTotDiaria.Text = "Tot Diaria";
            labelTotDiaria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textNumero
            // 
            textNumero.BackColor = Color.LightBlue;
            textNumero.BorderStyle = BorderStyle.FixedSingle;
            textNumero.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textNumero.Location = new Point(103, 29);
            textNumero.Name = "textNumero";
            textNumero.ReadOnly = true;
            textNumero.Size = new Size(94, 22);
            textNumero.TabIndex = 12;
            // 
            // numericNumPessoas
            // 
            numericNumPessoas.Dock = DockStyle.Fill;
            numericNumPessoas.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericNumPessoas.Location = new Point(203, 29);
            numericNumPessoas.Name = "numericNumPessoas";
            numericNumPessoas.Size = new Size(89, 22);
            numericNumPessoas.TabIndex = 13;
            // 
            // numericDias
            // 
            numericDias.Dock = DockStyle.Fill;
            numericDias.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericDias.Location = new Point(298, 29);
            numericDias.Name = "numericDias";
            numericDias.Size = new Size(64, 22);
            numericDias.TabIndex = 14;
            numericDias.ValueChanged += numericDias_ValueChanged;
            // 
            // textValDiaria
            // 
            textValDiaria.BackColor = Color.White;
            textValDiaria.BorderStyle = BorderStyle.FixedSingle;
            textValDiaria.Dock = DockStyle.Fill;
            textValDiaria.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textValDiaria.Location = new Point(368, 29);
            textValDiaria.MaxLength = 3;
            textValDiaria.Name = "textValDiaria";
            textValDiaria.Size = new Size(92, 22);
            textValDiaria.TabIndex = 15;
            textValDiaria.TextChanged += textValDiaria_TextChanged;
            // 
            // textTotDiaria
            // 
            textTotDiaria.BackColor = Color.White;
            textTotDiaria.BorderStyle = BorderStyle.FixedSingle;
            textTotDiaria.Dock = DockStyle.Fill;
            textTotDiaria.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTotDiaria.Location = new Point(466, 29);
            textTotDiaria.MaxLength = 3;
            textTotDiaria.Name = "textTotDiaria";
            textTotDiaria.Size = new Size(93, 22);
            textTotDiaria.TabIndex = 16;
            textTotDiaria.TextChanged += textTotDiaria_TextChanged;
            // 
            // tableLinha02
            // 
            tableLinha02.ColumnCount = 1;
            tableLinha02.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLinha02.Controls.Add(labelDescricao, 0, 0);
            tableLinha02.Controls.Add(textDescricao, 0, 1);
            tableLinha02.Dock = DockStyle.Fill;
            tableLinha02.Location = new Point(33, 133);
            tableLinha02.Name = "tableLinha02";
            tableLinha02.RowCount = 2;
            tableLinha02.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLinha02.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLinha02.Size = new Size(568, 44);
            tableLinha02.TabIndex = 2;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Dock = DockStyle.Bottom;
            labelDescricao.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDescricao.Location = new Point(3, 1);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(562, 16);
            labelDescricao.TabIndex = 0;
            labelDescricao.Text = "Descriçao";
            // 
            // textDescricao
            // 
            textDescricao.BackColor = Color.LightBlue;
            textDescricao.BorderStyle = BorderStyle.FixedSingle;
            textDescricao.Dock = DockStyle.Fill;
            textDescricao.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDescricao.Location = new Point(3, 20);
            textDescricao.Name = "textDescricao";
            textDescricao.ReadOnly = true;
            textDescricao.Size = new Size(562, 22);
            textDescricao.TabIndex = 1;
            // 
            // tableLinha03
            // 
            tableLinha03.ColumnCount = 5;
            tableLinha03.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tableLinha03.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLinha03.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLinha03.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLinha03.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLinha03.Controls.Add(labelStatus, 0, 0);
            tableLinha03.Controls.Add(labelEntrada, 1, 0);
            tableLinha03.Controls.Add(labelPrevisSaida, 2, 0);
            tableLinha03.Controls.Add(labelSaida, 3, 0);
            tableLinha03.Controls.Add(comboStatus, 0, 1);
            tableLinha03.Controls.Add(dateEntrada, 1, 1);
            tableLinha03.Controls.Add(datePrevisSaida, 2, 1);
            tableLinha03.Controls.Add(dateSaida, 3, 1);
            tableLinha03.Dock = DockStyle.Fill;
            tableLinha03.Location = new Point(33, 183);
            tableLinha03.Name = "tableLinha03";
            tableLinha03.RowCount = 2;
            tableLinha03.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLinha03.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLinha03.Size = new Size(568, 44);
            tableLinha03.TabIndex = 3;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Dock = DockStyle.Bottom;
            labelStatus.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(3, 1);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(129, 16);
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Status *";
            // 
            // labelEntrada
            // 
            labelEntrada.AutoSize = true;
            labelEntrada.Dock = DockStyle.Bottom;
            labelEntrada.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelEntrada.Location = new Point(138, 1);
            labelEntrada.Name = "labelEntrada";
            labelEntrada.Size = new Size(119, 16);
            labelEntrada.TabIndex = 2;
            labelEntrada.Text = "Entrada *";
            // 
            // labelPrevisSaida
            // 
            labelPrevisSaida.AutoSize = true;
            labelPrevisSaida.Dock = DockStyle.Bottom;
            labelPrevisSaida.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPrevisSaida.Location = new Point(263, 1);
            labelPrevisSaida.Name = "labelPrevisSaida";
            labelPrevisSaida.Size = new Size(119, 16);
            labelPrevisSaida.TabIndex = 3;
            labelPrevisSaida.Text = "Previs. Saida";
            // 
            // labelSaida
            // 
            labelSaida.AutoSize = true;
            labelSaida.Dock = DockStyle.Bottom;
            labelSaida.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelSaida.Location = new Point(388, 1);
            labelSaida.Name = "labelSaida";
            labelSaida.Size = new Size(119, 16);
            labelSaida.TabIndex = 4;
            labelSaida.Text = "Saida";
            // 
            // comboStatus
            // 
            comboStatus.DisabledBackColor = Color.LightBlue;
            comboStatus.DisabledForeColor = Color.Black;
            comboStatus.Dock = DockStyle.Fill;
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Livre", "Ocupado", "Reservado" });
            comboStatus.Location = new Point(3, 20);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(129, 23);
            comboStatus.TabIndex = 8;
            // 
            // dateEntrada
            // 
            dateEntrada.BackColor = Color.White;
            dateEntrada.Dock = DockStyle.Fill;
            dateEntrada.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateEntrada.Format = DateTimePickerFormat.Short;
            dateEntrada.Location = new Point(138, 20);
            dateEntrada.Name = "dateEntrada";
            dateEntrada.Size = new Size(119, 22);
            dateEntrada.TabIndex = 9;
            dateEntrada.ValueChanged += dateEntrada_ValueChanged;
            // 
            // datePrevisSaida
            // 
            datePrevisSaida.BackColor = Color.White;
            datePrevisSaida.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePrevisSaida.Format = DateTimePickerFormat.Short;
            datePrevisSaida.Location = new Point(263, 20);
            datePrevisSaida.Name = "datePrevisSaida";
            datePrevisSaida.Size = new Size(119, 22);
            datePrevisSaida.TabIndex = 10;
            datePrevisSaida.ValueChanged += datePrevisSaida_ValueChanged;
            // 
            // dateSaida
            // 
            dateSaida.BackColor = Color.White;
            dateSaida.Dock = DockStyle.Fill;
            dateSaida.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateSaida.Format = DateTimePickerFormat.Short;
            dateSaida.Location = new Point(388, 20);
            dateSaida.Name = "dateSaida";
            dateSaida.Size = new Size(119, 22);
            dateSaida.TabIndex = 11;
            // 
            // tableLinha4
            // 
            tableLinha4.ColumnCount = 1;
            tableLinha4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLinha4.Controls.Add(labelObs, 0, 0);
            tableLinha4.Controls.Add(textObs, 0, 1);
            tableLinha4.Dock = DockStyle.Fill;
            tableLinha4.Location = new Point(33, 233);
            tableLinha4.Name = "tableLinha4";
            tableLinha4.RowCount = 2;
            tableLinha4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLinha4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLinha4.Size = new Size(568, 69);
            tableLinha4.TabIndex = 4;
            // 
            // labelObs
            // 
            labelObs.AutoSize = true;
            labelObs.Dock = DockStyle.Bottom;
            labelObs.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelObs.Location = new Point(3, 7);
            labelObs.Name = "labelObs";
            labelObs.Size = new Size(562, 16);
            labelObs.TabIndex = 0;
            labelObs.Text = "Obs";
            // 
            // textObs
            // 
            textObs.BackColor = Color.White;
            textObs.BorderStyle = BorderStyle.FixedSingle;
            textObs.Dock = DockStyle.Fill;
            textObs.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textObs.Location = new Point(3, 26);
            textObs.MaxLength = 300;
            textObs.Multiline = true;
            textObs.Name = "textObs";
            textObs.Size = new Size(562, 40);
            textObs.TabIndex = 1;
            // 
            // tableBtn
            // 
            tableBtn.ColumnCount = 3;
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableBtn.Controls.Add(buttonSalvar, 0, 0);
            tableBtn.Controls.Add(buttonVoltar, 1, 0);
            tableBtn.Dock = DockStyle.Fill;
            tableBtn.Location = new Point(33, 308);
            tableBtn.Name = "tableBtn";
            tableBtn.RowCount = 2;
            tableBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableBtn.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tableBtn.Size = new Size(568, 50);
            tableBtn.TabIndex = 5;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.FromArgb(128, 255, 255);
            buttonSalvar.Dock = DockStyle.Fill;
            buttonSalvar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalvar.Location = new Point(3, 3);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 30);
            buttonSalvar.TabIndex = 0;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.FromArgb(255, 128, 255);
            buttonVoltar.Dock = DockStyle.Fill;
            buttonVoltar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVoltar.Location = new Point(103, 3);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(94, 30);
            buttonVoltar.TabIndex = 1;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // telaDadosQuarto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 361);
            Controls.Add(tablePai);
            KeyPreview = true;
            MaximumSize = new Size(650, 400);
            MinimumSize = new Size(650, 400);
            Name = "telaDadosQuarto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "selecionarQuarto";
            FormClosing += telaDadosQuarto_FormClosing;
            Load += telaDadosQuarto_Load;
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableForm.ResumeLayout(false);
            tableLinha01.ResumeLayout(false);
            tableLinha01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericNumPessoas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDias).EndInit();
            tableLinha02.ResumeLayout(false);
            tableLinha02.PerformLayout();
            tableLinha03.ResumeLayout(false);
            tableLinha03.PerformLayout();
            tableLinha4.ResumeLayout(false);
            tableLinha4.PerformLayout();
            tableBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsQuarto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private Label labelTitulo;
        private TableLayoutPanel tableForm;
        private TableLayoutPanel tableLinha01;
        private Button btnNovo;
        private Button btnLimpar;
        private Label labelNumero;
        private Label labelNumPessoas;
        private Label labelDiasHospedagens;
        private Label labelValDiaria;
        private Label labelTotDiaria;
        private TableLayoutPanel tableLinha02;
        private Label labelDescricao;
        private TableLayoutPanel tableLinha03;
        private Label labelStatus;
        private Label labelEntrada;
        private Label labelPrevisSaida;
        private Label labelSaida;
        private TableLayoutPanel tableLinha4;
        private Label labelObs;
        private TableLayoutPanel tableBtn;
        private Button buttonSalvar;
        private Button buttonVoltar;
        private BindingSource bsQuarto;
        private Componentes.TextBoxNovo textNumero;
        private Componentes.novoNumeric numericNumPessoas;
        private Componentes.novoNumeric numericDias;
        private Componentes.TextBoxNovo textValDiaria;
        private Componentes.TextBoxNovo textTotDiaria;
        private Componentes.TextBoxNovo textDescricao;
        private Componentes.novoComboBox comboStatus;
        private Componentes.novoDateTime dateEntrada;
        private Componentes.novoDateTime datePrevisSaida;
        private Componentes.novoDateTime dateSaida;
        private Componentes.TextBoxNovo textObs;
    }
}