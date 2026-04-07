namespace Umi_Interface.Cadastro
{
    partial class novoCliente
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
        /// 

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelCor = new Panel();
            tablePai = new TableLayoutPanel();
            tableButton = new TableLayoutPanel();
            btnSalvar = new Button();
            btnVoltar = new Button();
            tableForm = new TableLayoutPanel();
            tableLinha1 = new TableLayoutPanel();
            labelCodigo = new Label();
            labelNome = new Label();
            textCodigo = new TextBox();
            textNome = new TextBox();
            tableLinha2 = new TableLayoutPanel();
            labelNasc = new Label();
            dateNasc = new DateTimePicker();
            comboSexo = new ComboBox();
            labelSexo = new Label();
            labelCPF = new Label();
            maskCPF = new MaskedTextBox();
            labelRG = new Label();
            maskRG = new MaskedTextBox();
            tableLinha3 = new TableLayoutPanel();
            labelTell1 = new Label();
            textTell1 = new TextBox();
            labelTell2 = new Label();
            textTell2 = new TextBox();
            labelEmail = new Label();
            textEmail = new TextBox();
            tableLinha4 = new TableLayoutPanel();
            labelOBS = new Label();
            textOBS = new TextBox();
            tableLinha5 = new TableLayoutPanel();
            labelAtivo = new Label();
            labelCreated = new Label();
            dateCreated = new DateTimePicker();
            dateModified = new DateTimePicker();
            labelModified = new Label();
            labelTitulo = new Label();
            bsCliente = new BindingSource(components);
            tablePai.SuspendLayout();
            tableButton.SuspendLayout();
            tableForm.SuspendLayout();
            tableLinha1.SuspendLayout();
            tableLinha2.SuspendLayout();
            tableLinha3.SuspendLayout();
            tableLinha4.SuspendLayout();
            tableLinha5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsCliente).BeginInit();
            SuspendLayout();
            // 
            // panelCor
            // 
            panelCor.BackColor = Color.FromArgb(128, 255, 255);
            panelCor.Dock = DockStyle.Right;
            panelCor.Location = new Point(715, 0);
            panelCor.Name = "panelCor";
            panelCor.Size = new Size(200, 833);
            panelCor.TabIndex = 4;
            // 
            // tablePai
            // 
            tablePai.BackColor = Color.WhiteSmoke;
            tablePai.ColumnCount = 1;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tablePai.Controls.Add(tableButton, 0, 2);
            tablePai.Controls.Add(tableForm, 0, 1);
            tablePai.Controls.Add(labelTitulo, 0, 0);
            tablePai.Dock = DockStyle.Left;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 3;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablePai.Size = new Size(709, 833);
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
            tableButton.Dock = DockStyle.Fill;
            tableButton.Location = new Point(3, 710);
            tableButton.Name = "tableButton";
            tableButton.RowCount = 3;
            tableButton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableButton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableButton.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableButton.Size = new Size(703, 120);
            tableButton.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom;
            btnSalvar.BackColor = Color.FromArgb(192, 255, 192);
            btnSalvar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(33, 48);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 39);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Bottom;
            btnVoltar.BackColor = Color.FromArgb(192, 192, 255);
            btnVoltar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(133, 48);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 39);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // tableForm
            // 
            tableForm.ColumnCount = 2;
            tableForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableForm.Controls.Add(tableLinha1, 1, 1);
            tableForm.Controls.Add(tableLinha2, 1, 3);
            tableForm.Controls.Add(tableLinha3, 1, 5);
            tableForm.Controls.Add(tableLinha4, 1, 7);
            tableForm.Controls.Add(tableLinha5, 1, 9);
            tableForm.Dock = DockStyle.Fill;
            tableForm.Location = new Point(3, 127);
            tableForm.Name = "tableForm";
            tableForm.RowCount = 12;
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableForm.Size = new Size(703, 577);
            tableForm.TabIndex = 3;
            // 
            // tableLinha1
            // 
            tableLinha1.BackColor = Color.FromArgb(192, 255, 255);
            tableLinha1.ColumnCount = 2;
            tableLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLinha1.Controls.Add(labelCodigo, 0, 0);
            tableLinha1.Controls.Add(labelNome, 1, 0);
            tableLinha1.Controls.Add(textCodigo, 0, 1);
            tableLinha1.Controls.Add(textNome, 1, 1);
            tableLinha1.Dock = DockStyle.Fill;
            tableLinha1.Location = new Point(33, 28);
            tableLinha1.Name = "tableLinha1";
            tableLinha1.RowCount = 2;
            tableLinha1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha1.Size = new Size(667, 54);
            tableLinha1.TabIndex = 0;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Dock = DockStyle.Bottom;
            labelCodigo.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCodigo.Location = new Point(3, 12);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(94, 15);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Codigo:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Dock = DockStyle.Bottom;
            labelNome.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(103, 12);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(561, 15);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome: *";
            // 
            // textCodigo
            // 
            textCodigo.BorderStyle = BorderStyle.FixedSingle;
            textCodigo.Dock = DockStyle.Fill;
            textCodigo.Enabled = false;
            textCodigo.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCodigo.Location = new Point(3, 30);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(94, 20);
            textCodigo.TabIndex = 1;
            // 
            // textNome
            // 
            textNome.BorderStyle = BorderStyle.FixedSingle;
            textNome.Dock = DockStyle.Fill;
            textNome.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNome.Location = new Point(103, 30);
            textNome.MaxLength = 120;
            textNome.Name = "textNome";
            textNome.Size = new Size(561, 20);
            textNome.TabIndex = 3;
            // 
            // tableLinha2
            // 
            tableLinha2.BackColor = Color.FromArgb(192, 255, 255);
            tableLinha2.ColumnCount = 4;
            tableLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5427284F));
            tableLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.5772133F));
            tableLinha2.Controls.Add(labelNasc, 0, 0);
            tableLinha2.Controls.Add(dateNasc, 0, 1);
            tableLinha2.Controls.Add(comboSexo, 1, 1);
            tableLinha2.Controls.Add(labelSexo, 1, 0);
            tableLinha2.Controls.Add(labelCPF, 2, 0);
            tableLinha2.Controls.Add(maskCPF, 2, 1);
            tableLinha2.Controls.Add(labelRG, 3, 0);
            tableLinha2.Controls.Add(maskRG, 3, 1);
            tableLinha2.Dock = DockStyle.Fill;
            tableLinha2.Location = new Point(33, 113);
            tableLinha2.Name = "tableLinha2";
            tableLinha2.RowCount = 2;
            tableLinha2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha2.Size = new Size(667, 54);
            tableLinha2.TabIndex = 1;
            // 
            // labelNasc
            // 
            labelNasc.AutoSize = true;
            labelNasc.Dock = DockStyle.Bottom;
            labelNasc.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNasc.Location = new Point(3, 12);
            labelNasc.Name = "labelNasc";
            labelNasc.Size = new Size(127, 15);
            labelNasc.TabIndex = 0;
            labelNasc.Text = "Nascimento: *";
            // 
            // dateNasc
            // 
            dateNasc.CustomFormat = "dd/MM/yyyy";
            dateNasc.Dock = DockStyle.Fill;
            dateNasc.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateNasc.Format = DateTimePickerFormat.Short;
            dateNasc.Location = new Point(0, 27);
            dateNasc.Margin = new Padding(0);
            dateNasc.Name = "dateNasc";
            dateNasc.Size = new Size(133, 20);
            dateNasc.TabIndex = 1;
            // 
            // comboSexo
            // 
            comboSexo.Dock = DockStyle.Fill;
            comboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSexo.FlatStyle = FlatStyle.System;
            comboSexo.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboSexo.FormattingEnabled = true;
            comboSexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Outro" });
            comboSexo.Location = new Point(136, 30);
            comboSexo.Name = "comboSexo";
            comboSexo.Size = new Size(127, 23);
            comboSexo.TabIndex = 2;
            // 
            // labelSexo
            // 
            labelSexo.AutoSize = true;
            labelSexo.Dock = DockStyle.Bottom;
            labelSexo.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSexo.Location = new Point(136, 12);
            labelSexo.Name = "labelSexo";
            labelSexo.Size = new Size(127, 15);
            labelSexo.TabIndex = 3;
            labelSexo.Text = "Sexo: *";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Dock = DockStyle.Bottom;
            labelCPF.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCPF.Location = new Point(269, 12);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(90, 15);
            labelCPF.TabIndex = 4;
            labelCPF.Text = "CPF: *";
            // 
            // maskCPF
            // 
            maskCPF.BorderStyle = BorderStyle.FixedSingle;
            maskCPF.Dock = DockStyle.Fill;
            maskCPF.Location = new Point(269, 30);
            maskCPF.Mask = "000.000.000-00";
            maskCPF.Name = "maskCPF";
            maskCPF.Size = new Size(90, 23);
            maskCPF.TabIndex = 6;
            maskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelRG
            // 
            labelRG.AutoSize = true;
            labelRG.Dock = DockStyle.Bottom;
            labelRG.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRG.Location = new Point(365, 12);
            labelRG.Name = "labelRG";
            labelRG.Size = new Size(299, 15);
            labelRG.TabIndex = 7;
            labelRG.Text = "RG:";
            // 
            // maskRG
            // 
            maskRG.BorderStyle = BorderStyle.FixedSingle;
            maskRG.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskRG.Location = new Point(365, 30);
            maskRG.Mask = "00000-00";
            maskRG.Name = "maskRG";
            maskRG.Size = new Size(85, 21);
            maskRG.TabIndex = 8;
            // 
            // tableLinha3
            // 
            tableLinha3.BackColor = Color.FromArgb(192, 255, 255);
            tableLinha3.ColumnCount = 3;
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLinha3.Controls.Add(labelTell1, 0, 0);
            tableLinha3.Controls.Add(textTell1, 0, 1);
            tableLinha3.Controls.Add(labelTell2, 1, 0);
            tableLinha3.Controls.Add(textTell2, 1, 1);
            tableLinha3.Controls.Add(labelEmail, 2, 0);
            tableLinha3.Controls.Add(textEmail, 2, 1);
            tableLinha3.Dock = DockStyle.Fill;
            tableLinha3.Location = new Point(33, 199);
            tableLinha3.Name = "tableLinha3";
            tableLinha3.RowCount = 2;
            tableLinha3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha3.Size = new Size(667, 54);
            tableLinha3.TabIndex = 2;
            // 
            // labelTell1
            // 
            labelTell1.AutoSize = true;
            labelTell1.Dock = DockStyle.Bottom;
            labelTell1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTell1.Location = new Point(3, 12);
            labelTell1.Name = "labelTell1";
            labelTell1.Size = new Size(127, 15);
            labelTell1.TabIndex = 0;
            labelTell1.Text = "Telefone 1: *";
            // 
            // textTell1
            // 
            textTell1.BorderStyle = BorderStyle.FixedSingle;
            textTell1.Dock = DockStyle.Top;
            textTell1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTell1.Location = new Point(3, 30);
            textTell1.MaxLength = 20;
            textTell1.Name = "textTell1";
            textTell1.Size = new Size(127, 21);
            textTell1.TabIndex = 1;
            // 
            // labelTell2
            // 
            labelTell2.AutoSize = true;
            labelTell2.Dock = DockStyle.Bottom;
            labelTell2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTell2.Location = new Point(136, 12);
            labelTell2.Name = "labelTell2";
            labelTell2.Size = new Size(127, 15);
            labelTell2.TabIndex = 2;
            labelTell2.Text = "Telefone 2:";
            // 
            // textTell2
            // 
            textTell2.BorderStyle = BorderStyle.FixedSingle;
            textTell2.Dock = DockStyle.Fill;
            textTell2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTell2.Location = new Point(136, 30);
            textTell2.MaxLength = 20;
            textTell2.Name = "textTell2";
            textTell2.Size = new Size(127, 21);
            textTell2.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Dock = DockStyle.Bottom;
            labelEmail.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(269, 12);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(395, 15);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            // 
            // textEmail
            // 
            textEmail.BorderStyle = BorderStyle.FixedSingle;
            textEmail.Dock = DockStyle.Fill;
            textEmail.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEmail.Location = new Point(269, 30);
            textEmail.MaxLength = 120;
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(395, 21);
            textEmail.TabIndex = 5;
            // 
            // tableLinha4
            // 
            tableLinha4.BackColor = Color.FromArgb(192, 255, 255);
            tableLinha4.ColumnCount = 1;
            tableLinha4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLinha4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLinha4.Controls.Add(labelOBS, 0, 0);
            tableLinha4.Controls.Add(textOBS, 0, 1);
            tableLinha4.Dock = DockStyle.Fill;
            tableLinha4.Location = new Point(33, 279);
            tableLinha4.Name = "tableLinha4";
            tableLinha4.RowCount = 2;
            tableLinha4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLinha4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLinha4.Size = new Size(667, 54);
            tableLinha4.TabIndex = 3;
            // 
            // labelOBS
            // 
            labelOBS.AutoSize = true;
            labelOBS.Dock = DockStyle.Bottom;
            labelOBS.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOBS.Location = new Point(3, 6);
            labelOBS.Name = "labelOBS";
            labelOBS.Size = new Size(661, 15);
            labelOBS.TabIndex = 0;
            labelOBS.Text = "Observaçoes:";
            // 
            // textOBS
            // 
            textOBS.BorderStyle = BorderStyle.FixedSingle;
            textOBS.Dock = DockStyle.Fill;
            textOBS.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textOBS.Location = new Point(3, 24);
            textOBS.Name = "textOBS";
            textOBS.Size = new Size(661, 21);
            textOBS.TabIndex = 1;
            // 
            // tableLinha5
            // 
            tableLinha5.BackColor = Color.FromArgb(192, 255, 255);
            tableLinha5.ColumnCount = 4;
            tableLinha5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLinha5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLinha5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLinha5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLinha5.Controls.Add(labelAtivo, 1, 0);
            tableLinha5.Controls.Add(labelCreated, 2, 0);
            tableLinha5.Controls.Add(dateCreated, 2, 1);
            tableLinha5.Controls.Add(dateModified, 3, 1);
            tableLinha5.Controls.Add(labelModified, 3, 0);
            tableLinha5.Dock = DockStyle.Fill;
            tableLinha5.Location = new Point(33, 359);
            tableLinha5.Name = "tableLinha5";
            tableLinha5.RowCount = 2;
            tableLinha5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha5.Size = new Size(667, 54);
            tableLinha5.TabIndex = 4;
            // 
            // labelAtivo
            // 
            labelAtivo.AutoSize = true;
            labelAtivo.Dock = DockStyle.Bottom;
            labelAtivo.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAtivo.Location = new Point(340, 12);
            labelAtivo.Name = "labelAtivo";
            labelAtivo.RightToLeft = RightToLeft.No;
            labelAtivo.Size = new Size(104, 15);
            labelAtivo.TabIndex = 0;
            labelAtivo.Text = "Ativo:";
            // 
            // labelCreated
            // 
            labelCreated.AutoSize = true;
            labelCreated.Dock = DockStyle.Bottom;
            labelCreated.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreated.Location = new Point(450, 12);
            labelCreated.Name = "labelCreated";
            labelCreated.Size = new Size(104, 15);
            labelCreated.TabIndex = 2;
            labelCreated.Text = "Criado:";
            // 
            // dateCreated
            // 
            dateCreated.Enabled = false;
            dateCreated.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateCreated.Format = DateTimePickerFormat.Short;
            dateCreated.Location = new Point(450, 30);
            dateCreated.Name = "dateCreated";
            dateCreated.Size = new Size(104, 21);
            dateCreated.TabIndex = 3;
            // 
            // dateModified
            // 
            dateModified.CalendarFont = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateModified.Dock = DockStyle.Fill;
            dateModified.Enabled = false;
            dateModified.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateModified.Format = DateTimePickerFormat.Short;
            dateModified.Location = new Point(560, 30);
            dateModified.Name = "dateModified";
            dateModified.Size = new Size(104, 21);
            dateModified.TabIndex = 5;
            // 
            // labelModified
            // 
            labelModified.AutoSize = true;
            labelModified.Dock = DockStyle.Bottom;
            labelModified.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelModified.Location = new Point(560, 12);
            labelModified.Name = "labelModified";
            labelModified.Size = new Size(104, 15);
            labelModified.TabIndex = 6;
            labelModified.Text = "Modificado:";
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(195, 40);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(319, 43);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Cadastro de Cliente";
            // 
            // bsCliente
            // 
            bsCliente.DataSource = typeof(Umi_Library.Class.classCliente);
            // 
            // novoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 833);
            Controls.Add(tablePai);
            Controls.Add(panelCor);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(931, 872);
            MinimumSize = new Size(931, 872);
            Name = "novoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "novoCliente";
            Load += novoCliente_Load;
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableButton.ResumeLayout(false);
            tableForm.ResumeLayout(false);
            tableLinha1.ResumeLayout(false);
            tableLinha1.PerformLayout();
            tableLinha2.ResumeLayout(false);
            tableLinha2.PerformLayout();
            tableLinha3.ResumeLayout(false);
            tableLinha3.PerformLayout();
            tableLinha4.ResumeLayout(false);
            tableLinha4.PerformLayout();
            tableLinha5.ResumeLayout(false);
            tableLinha5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCor;
        private TableLayoutPanel tablePai;
        private TableLayoutPanel tableButton;
        private Button btnSalvar;
        private Button btnVoltar;
        private Label labelTitulo;
        private TableLayoutPanel tableForm;
        private TableLayoutPanel tableLinha1;
        private Label labelCodigo;
        private Label labelNome;
        private TextBox textCodigo;
        private TextBox textNome;
        private TableLayoutPanel tableLinha2;
        private Label labelNasc;
        private DateTimePicker dateNasc;
        private ComboBox comboSexo;
        private Label labelSexo;
        private Label labelCPF;
        private MaskedTextBox maskCPF;
        private Label labelRG;
        private MaskedTextBox maskRG;
        private TableLayoutPanel tableLinha3;
        private Label labelTell1;
        private TextBox textTell1;
        private Label labelTell2;
        private TextBox textTell2;
        private Label labelEmail;
        private TextBox textEmail;
        private TableLayoutPanel tableLinha4;
        private Label labelOBS;
        private TextBox textOBS;
        private TableLayoutPanel tableLinha5;
        private Label labelAtivo;
        private ComboBox comboAtivo;
        private Label labelCreated;
        private DateTimePicker dateCreated;
        private DateTimePicker dateModified;
        private Label labelModified;
        private BindingSource bsCliente;
    }
}