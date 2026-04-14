using Umi_Library.Migrations;

namespace Umi_Interface.Cadastro.Quarto
{
    partial class novoQuarto
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
            Label labelAtivo;
            tablePai = new TableLayoutPanel();
            labelTitulo = new Label();
            tableButton = new TableLayoutPanel();
            btnSalvar = new Button();
            btnVoltar = new Button();
            tableForm = new TableLayoutPanel();
            tableLinha1 = new TableLayoutPanel();
            labelCodigo = new Label();
            textNumero = new TextBox();
            labelTipo = new Label();
            comboTipo = new ComboBox();
            labelCapac = new Label();
            labelCamSolt = new Label();
            labelCamCasal = new Label();
            numericCapacidade = new NumericUpDown();
            numericSolteiro = new NumericUpDown();
            numericCasal = new NumericUpDown();
            tableLinha2 = new TableLayoutPanel();
            labelDescri = new Label();
            textDescricao = new TextBox();
            tableLinha3 = new TableLayoutPanel();
            labelValorBase = new Label();
            maskValBase = new MaskedTextBox();
            labelValAtual = new Label();
            maskValAtual = new MaskedTextBox();
            labelStatus = new Label();
            comboStatus = new ComboBox();
            comboAtivo = new ComboBox();
            tableLinha4 = new TableLayoutPanel();
            labelCreated = new Label();
            dateCreated = new DateTimePicker();
            labelModified = new Label();
            dateModified = new DateTimePicker();
            panelCor = new Panel();
            bsQuarto = new BindingSource(components);
            labelAtivo = new Label();
            tablePai.SuspendLayout();
            tableButton.SuspendLayout();
            tableForm.SuspendLayout();
            tableLinha1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCapacidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSolteiro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCasal).BeginInit();
            tableLinha2.SuspendLayout();
            tableLinha3.SuspendLayout();
            tableLinha4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsQuarto).BeginInit();
            SuspendLayout();
            // 
            // labelAtivo
            // 
            labelAtivo.AutoSize = true;
            labelAtivo.Dock = DockStyle.Bottom;
            labelAtivo.FlatStyle = FlatStyle.Popup;
            labelAtivo.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAtivo.Location = new Point(393, 12);
            labelAtivo.Name = "labelAtivo";
            labelAtivo.Size = new Size(111, 15);
            labelAtivo.TabIndex = 6;
            labelAtivo.Text = "Ativo: ";
            // 
            // tablePai
            // 
            tablePai.BackColor = Color.WhiteSmoke;
            tablePai.ColumnCount = 1;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tablePai.Controls.Add(labelTitulo, 0, 0);
            tablePai.Controls.Add(tableButton, 0, 2);
            tablePai.Controls.Add(tableForm, 0, 1);
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
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(194, 40);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(321, 43);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Cadastro de Quarto";
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
            tableForm.Dock = DockStyle.Fill;
            tableForm.Location = new Point(3, 127);
            tableForm.Name = "tableForm";
            tableForm.RowCount = 10;
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
            tableForm.Size = new Size(703, 577);
            tableForm.TabIndex = 3;
            // 
            // tableLinha1
            // 
            tableLinha1.BackColor = Color.FromArgb(192, 255, 255);
            tableLinha1.ColumnCount = 5;
            tableLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLinha1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLinha1.Controls.Add(labelCodigo, 0, 0);
            tableLinha1.Controls.Add(textNumero, 0, 1);
            tableLinha1.Controls.Add(labelTipo, 1, 0);
            tableLinha1.Controls.Add(comboTipo, 1, 1);
            tableLinha1.Controls.Add(labelCapac, 2, 0);
            tableLinha1.Controls.Add(labelCamSolt, 3, 0);
            tableLinha1.Controls.Add(labelCamCasal, 4, 0);
            tableLinha1.Controls.Add(numericCapacidade, 2, 1);
            tableLinha1.Controls.Add(numericSolteiro, 3, 1);
            tableLinha1.Controls.Add(numericCasal, 4, 1);
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
            labelCodigo.Size = new Size(169, 15);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Num Quarto: *";
            // 
            // textNumero
            // 
            textNumero.BorderStyle = BorderStyle.FixedSingle;
            textNumero.Dock = DockStyle.Fill;
            textNumero.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNumero.Location = new Point(3, 30);
            textNumero.MaxLength = 15;
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(169, 21);
            textNumero.TabIndex = 1;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Dock = DockStyle.Bottom;
            labelTipo.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(178, 12);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(169, 15);
            labelTipo.TabIndex = 2;
            labelTipo.Text = "Categoria: *";
            // 
            // comboTipo
            // 
            comboTipo.Dock = DockStyle.Fill;
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboTipo.FormattingEnabled = true;
            comboTipo.Items.AddRange(new object[] { "Solteiro", "Casal", "Familia", "Sim", "Não" });
            comboTipo.Location = new Point(178, 30);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(169, 23);
            comboTipo.TabIndex = 3;
            // 
            // labelCapac
            // 
            labelCapac.AutoSize = true;
            labelCapac.Dock = DockStyle.Bottom;
            labelCapac.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCapac.Location = new Point(353, 0);
            labelCapac.Name = "labelCapac";
            labelCapac.Size = new Size(99, 27);
            labelCapac.TabIndex = 4;
            labelCapac.Text = "max 6\rCapacidade: * ";
            // 
            // labelCamSolt
            // 
            labelCamSolt.AutoSize = true;
            labelCamSolt.Dock = DockStyle.Bottom;
            labelCamSolt.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCamSolt.Location = new Point(458, 0);
            labelCamSolt.Name = "labelCamSolt";
            labelCamSolt.Size = new Size(99, 27);
            labelCamSolt.TabIndex = 6;
            labelCamSolt.Text = "max 2 \rCamas Solt: *";
            // 
            // labelCamCasal
            // 
            labelCamCasal.AutoSize = true;
            labelCamCasal.Dock = DockStyle.Bottom;
            labelCamCasal.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCamCasal.Location = new Point(563, 0);
            labelCamCasal.Name = "labelCamCasal";
            labelCamCasal.Size = new Size(101, 27);
            labelCamCasal.TabIndex = 8;
            labelCamCasal.Text = "max 2\nCamas Casal: *";
            // 
            // numericCapacidade
            // 
            numericCapacidade.BorderStyle = BorderStyle.FixedSingle;
            numericCapacidade.Dock = DockStyle.Fill;
            numericCapacidade.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericCapacidade.Location = new Point(353, 30);
            numericCapacidade.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericCapacidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCapacidade.Name = "numericCapacidade";
            numericCapacidade.Size = new Size(99, 21);
            numericCapacidade.TabIndex = 9;
            numericCapacidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericSolteiro
            // 
            numericSolteiro.BorderStyle = BorderStyle.FixedSingle;
            numericSolteiro.Dock = DockStyle.Fill;
            numericSolteiro.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericSolteiro.Location = new Point(458, 30);
            numericSolteiro.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numericSolteiro.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericSolteiro.Name = "numericSolteiro";
            numericSolteiro.Size = new Size(99, 21);
            numericSolteiro.TabIndex = 10;
            numericSolteiro.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericCasal
            // 
            numericCasal.BorderStyle = BorderStyle.FixedSingle;
            numericCasal.Dock = DockStyle.Fill;
            numericCasal.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericCasal.Location = new Point(563, 30);
            numericCasal.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numericCasal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCasal.Name = "numericCasal";
            numericCasal.Size = new Size(101, 21);
            numericCasal.TabIndex = 11;
            numericCasal.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tableLinha2
            // 
            tableLinha2.BackColor = Color.FromArgb(192, 255, 255);
            tableLinha2.ColumnCount = 1;
            tableLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5427284F));
            tableLinha2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.5772133F));
            tableLinha2.Controls.Add(labelDescri, 0, 0);
            tableLinha2.Controls.Add(textDescricao, 0, 1);
            tableLinha2.Dock = DockStyle.Fill;
            tableLinha2.Location = new Point(33, 113);
            tableLinha2.Name = "tableLinha2";
            tableLinha2.RowCount = 2;
            tableLinha2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha2.Size = new Size(667, 54);
            tableLinha2.TabIndex = 1;
            // 
            // labelDescri
            // 
            labelDescri.AutoSize = true;
            labelDescri.Dock = DockStyle.Bottom;
            labelDescri.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescri.Location = new Point(3, 12);
            labelDescri.Name = "labelDescri";
            labelDescri.Size = new Size(661, 15);
            labelDescri.TabIndex = 0;
            labelDescri.Text = "Descriçao:";
            // 
            // textDescricao
            // 
            textDescricao.BorderStyle = BorderStyle.FixedSingle;
            textDescricao.Dock = DockStyle.Fill;
            textDescricao.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDescricao.Location = new Point(3, 30);
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(661, 21);
            textDescricao.TabIndex = 1;
            // 
            // tableLinha3
            // 
            tableLinha3.BackColor = Color.FromArgb(192, 255, 255);
            tableLinha3.ColumnCount = 5;
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLinha3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLinha3.Controls.Add(labelValorBase, 0, 0);
            tableLinha3.Controls.Add(maskValBase, 0, 1);
            tableLinha3.Controls.Add(labelValAtual, 1, 0);
            tableLinha3.Controls.Add(maskValAtual, 1, 1);
            tableLinha3.Controls.Add(labelStatus, 2, 0);
            tableLinha3.Controls.Add(comboStatus, 2, 1);
            tableLinha3.Controls.Add(labelAtivo, 3, 0);
            tableLinha3.Controls.Add(comboAtivo, 3, 1);
            tableLinha3.Dock = DockStyle.Fill;
            tableLinha3.Location = new Point(33, 199);
            tableLinha3.Name = "tableLinha3";
            tableLinha3.RowCount = 2;
            tableLinha3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha3.Size = new Size(667, 54);
            tableLinha3.TabIndex = 2;
            // 
            // labelValorBase
            // 
            labelValorBase.AutoSize = true;
            labelValorBase.Dock = DockStyle.Bottom;
            labelValorBase.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValorBase.Location = new Point(3, 12);
            labelValorBase.Name = "labelValorBase";
            labelValorBase.Size = new Size(111, 15);
            labelValorBase.TabIndex = 0;
            labelValorBase.Text = "Valor Base:";
            // 
            // maskValBase
            // 
            maskValBase.BorderStyle = BorderStyle.FixedSingle;
            maskValBase.Dock = DockStyle.Fill;
            maskValBase.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskValBase.Location = new Point(3, 30);
            maskValBase.Mask = "00000";
            maskValBase.Name = "maskValBase";
            maskValBase.PromptChar = ' ';
            maskValBase.Size = new Size(111, 21);
            maskValBase.TabIndex = 1;
            // 
            // labelValAtual
            // 
            labelValAtual.AutoSize = true;
            labelValAtual.Dock = DockStyle.Bottom;
            labelValAtual.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValAtual.Location = new Point(120, 12);
            labelValAtual.Name = "labelValAtual";
            labelValAtual.Size = new Size(111, 15);
            labelValAtual.TabIndex = 2;
            labelValAtual.Text = "Valor Atual:";
            // 
            // maskValAtual
            // 
            maskValAtual.BorderStyle = BorderStyle.FixedSingle;
            maskValAtual.Dock = DockStyle.Fill;
            maskValAtual.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskValAtual.Location = new Point(120, 30);
            maskValAtual.Mask = "00000";
            maskValAtual.Name = "maskValAtual";
            maskValAtual.PromptChar = ' ';
            maskValAtual.Size = new Size(111, 21);
            maskValAtual.TabIndex = 3;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Dock = DockStyle.Bottom;
            labelStatus.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(237, 12);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(150, 15);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Status:";
            // 
            // comboStatus
            // 
            comboStatus.Dock = DockStyle.Fill;
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.FlatStyle = FlatStyle.System;
            comboStatus.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Disponivel", "Ocupado", "Manutenção" });
            comboStatus.Location = new Point(237, 30);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(150, 23);
            comboStatus.TabIndex = 5;
            // 
            // comboAtivo
            // 
            comboAtivo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAtivo.FormattingEnabled = true;
            comboAtivo.Items.AddRange(new object[] { "Sim", "Não" });
            comboAtivo.Location = new Point(393, 30);
            comboAtivo.Name = "comboAtivo";
            comboAtivo.Size = new Size(111, 23);
            comboAtivo.TabIndex = 7;
            // 
            // tableLinha4
            // 
            tableLinha4.BackColor = Color.FromArgb(192, 255, 255);
            tableLinha4.ColumnCount = 3;
            tableLinha4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLinha4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLinha4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLinha4.Controls.Add(labelCreated, 0, 0);
            tableLinha4.Controls.Add(dateCreated, 0, 1);
            tableLinha4.Controls.Add(labelModified, 1, 0);
            tableLinha4.Controls.Add(dateModified, 1, 1);
            tableLinha4.Dock = DockStyle.Fill;
            tableLinha4.Location = new Point(33, 279);
            tableLinha4.Name = "tableLinha4";
            tableLinha4.RowCount = 2;
            tableLinha4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha4.Size = new Size(667, 54);
            tableLinha4.TabIndex = 3;
            // 
            // labelCreated
            // 
            labelCreated.AutoSize = true;
            labelCreated.Dock = DockStyle.Bottom;
            labelCreated.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreated.Location = new Point(3, 12);
            labelCreated.Name = "labelCreated";
            labelCreated.Size = new Size(119, 15);
            labelCreated.TabIndex = 0;
            labelCreated.Text = "Criado:";
            // 
            // dateCreated
            // 
            dateCreated.Dock = DockStyle.Fill;
            dateCreated.Enabled = false;
            dateCreated.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateCreated.Format = DateTimePickerFormat.Short;
            dateCreated.Location = new Point(3, 30);
            dateCreated.Name = "dateCreated";
            dateCreated.Size = new Size(119, 21);
            dateCreated.TabIndex = 1;
            // 
            // labelModified
            // 
            labelModified.AutoSize = true;
            labelModified.Dock = DockStyle.Bottom;
            labelModified.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelModified.Location = new Point(128, 12);
            labelModified.Name = "labelModified";
            labelModified.Size = new Size(119, 15);
            labelModified.TabIndex = 2;
            labelModified.Text = "Editado:";
            // 
            // dateModified
            // 
            dateModified.CalendarFont = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateModified.Enabled = false;
            dateModified.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateModified.Format = DateTimePickerFormat.Short;
            dateModified.Location = new Point(128, 30);
            dateModified.Name = "dateModified";
            dateModified.Size = new Size(119, 21);
            dateModified.TabIndex = 3;
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
            // bsQuarto
            // 
            bsQuarto.DataSource = typeof(Umi_Library.Class.classQuarto);
            // 
            // novoQuarto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 833);
            Controls.Add(panelCor);
            Controls.Add(tablePai);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(931, 872);
            MinimumSize = new Size(931, 872);
            Name = "novoQuarto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "novoCliente";
            Load += novoQuarto_Load;
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableButton.ResumeLayout(false);
            tableForm.ResumeLayout(false);
            tableLinha1.ResumeLayout(false);
            tableLinha1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCapacidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSolteiro).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCasal).EndInit();
            tableLinha2.ResumeLayout(false);
            tableLinha2.PerformLayout();
            tableLinha3.ResumeLayout(false);
            tableLinha3.PerformLayout();
            tableLinha4.ResumeLayout(false);
            tableLinha4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsQuarto).EndInit();
            ResumeLayout(false);


        }

        #endregion

        private TableLayoutPanel tablePai;
        private Panel panelCor;
        private Label labelTitulo;
        private TableLayoutPanel tableButton;
        private Button btnSalvar;
        private Button btnVoltar;
        private TableLayoutPanel tableForm;
        private TableLayoutPanel tableLinha1;
        private TableLayoutPanel tableLinha2;
        private TableLayoutPanel tableLinha3;
        private TableLayoutPanel tableLinha4;
        private Label labelCodigo;
        private TextBox textNumero;
        private Label labelTipo;
        private ComboBox comboTipo;
        private Label labelCapac;
        private Label labelCamSolt;
        private Label labelCamCasal;
        private Label labelDescri;
        private TextBox textDescricao;
        private Label labelValorBase;
        private MaskedTextBox maskValBase;
        private Label labelValAtual;
        private Label labelStatus;
        private ComboBox comboStatus;
        private Label labelAtivo;
        private Label labelCreated;
        private DateTimePicker dateCreated;
        private Label labelModified;
        private DateTimePicker dateModified;
        private MaskedTextBox maskValAtual;
        private ComboBox comboAtivo;
        private NumericUpDown numericCapacidade;
        private NumericUpDown numericSolteiro;
        private NumericUpDown numericCasal;
        private BindingSource bsQuarto;
    }
}