namespace Umi_Interface.Cadastro.Contabil
{
    partial class novaContabil
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
            tableBtn = new TableLayoutPanel();
            btnNovo = new Button();
            btnFechar = new Button();
            tableForm = new TableLayoutPanel();
            tableLinha01 = new TableLayoutPanel();
            labelCodigo = new Label();
            labelNome = new Label();
            textCodigo = new Umi_Interface.Componentes.TextBoxNovo(components);
            textNome = new Umi_Interface.Componentes.TextBoxNovo(components);
            tableLinha02 = new TableLayoutPanel();
            labelTipo = new Label();
            labelObs = new Label();
            comboTipo = new Umi_Interface.Componentes.novoComboBox();
            textObs = new Umi_Interface.Componentes.TextBoxNovo(components);
            tableLinha03 = new TableLayoutPanel();
            checkAtivo = new CheckBox();
            labelCreated = new Label();
            labelModified = new Label();
            dateCreated = new Umi_Interface.Componentes.novoDateTime(components);
            dateModified = new Umi_Interface.Componentes.novoDateTime(components);
            tablePai.SuspendLayout();
            tableBtn.SuspendLayout();
            tableForm.SuspendLayout();
            tableLinha01.SuspendLayout();
            tableLinha02.SuspendLayout();
            tableLinha03.SuspendLayout();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.Controls.Add(labelTitulo, 1, 0);
            tablePai.Controls.Add(tableBtn, 1, 2);
            tablePai.Controls.Add(tableForm, 1, 1);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 4;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablePai.Size = new Size(643, 548);
            tablePai.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(188, 24);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(267, 31);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Nova Conta-Contabil";
            // 
            // tableBtn
            // 
            tableBtn.ColumnCount = 3;
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 411F));
            tableBtn.Controls.Add(btnNovo, 0, 0);
            tableBtn.Controls.Add(btnFechar, 1, 0);
            tableBtn.Dock = DockStyle.Fill;
            tableBtn.Location = new Point(33, 466);
            tableBtn.Name = "tableBtn";
            tableBtn.RowCount = 1;
            tableBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableBtn.Size = new Size(577, 59);
            tableBtn.TabIndex = 1;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.FromArgb(192, 255, 192);
            btnNovo.Cursor = Cursors.No;
            btnNovo.Dock = DockStyle.Fill;
            btnNovo.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.ForeColor = SystemColors.ControlText;
            btnNovo.Location = new Point(3, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(144, 53);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(255, 192, 192);
            btnFechar.Dock = DockStyle.Fill;
            btnFechar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(153, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(144, 53);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // tableForm
            // 
            tableForm.ColumnCount = 1;
            tableForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableForm.Controls.Add(tableLinha01, 0, 0);
            tableForm.Controls.Add(tableLinha02, 0, 1);
            tableForm.Controls.Add(tableLinha03, 0, 2);
            tableForm.Dock = DockStyle.Fill;
            tableForm.Location = new Point(33, 83);
            tableForm.Name = "tableForm";
            tableForm.RowCount = 4;
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableForm.Size = new Size(577, 377);
            tableForm.TabIndex = 2;
            // 
            // tableLinha01
            // 
            tableLinha01.ColumnCount = 2;
            tableLinha01.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLinha01.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLinha01.Controls.Add(labelCodigo, 0, 0);
            tableLinha01.Controls.Add(labelNome, 1, 0);
            tableLinha01.Controls.Add(textCodigo, 0, 1);
            tableLinha01.Controls.Add(textNome, 1, 1);
            tableLinha01.Dock = DockStyle.Fill;
            tableLinha01.Location = new Point(3, 3);
            tableLinha01.Name = "tableLinha01";
            tableLinha01.RowCount = 2;
            tableLinha01.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLinha01.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLinha01.Size = new Size(571, 54);
            tableLinha01.TabIndex = 0;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Dock = DockStyle.Bottom;
            labelCodigo.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCodigo.Location = new Point(3, 6);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(79, 15);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Codigo:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Dock = DockStyle.Bottom;
            labelNome.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(88, 6);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(480, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome:";
            // 
            // textCodigo
            // 
            textCodigo.BackColor = Color.LightBlue;
            textCodigo.BorderStyle = BorderStyle.FixedSingle;
            textCodigo.Dock = DockStyle.Fill;
            textCodigo.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCodigo.Location = new Point(3, 24);
            textCodigo.Name = "textCodigo";
            textCodigo.ReadOnly = true;
            textCodigo.Size = new Size(79, 22);
            textCodigo.TabIndex = 2;
            // 
            // textNome
            // 
            textNome.BackColor = Color.White;
            textNome.BorderStyle = BorderStyle.FixedSingle;
            textNome.Dock = DockStyle.Fill;
            textNome.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNome.Location = new Point(88, 24);
            textNome.Name = "textNome";
            textNome.Size = new Size(480, 22);
            textNome.TabIndex = 3;
            // 
            // tableLinha02
            // 
            tableLinha02.ColumnCount = 2;
            tableLinha02.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLinha02.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLinha02.Controls.Add(labelTipo, 0, 0);
            tableLinha02.Controls.Add(labelObs, 1, 0);
            tableLinha02.Controls.Add(comboTipo, 0, 1);
            tableLinha02.Controls.Add(textObs, 1, 1);
            tableLinha02.Dock = DockStyle.Fill;
            tableLinha02.Location = new Point(3, 63);
            tableLinha02.Name = "tableLinha02";
            tableLinha02.RowCount = 2;
            tableLinha02.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLinha02.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLinha02.Size = new Size(571, 64);
            tableLinha02.TabIndex = 1;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Dock = DockStyle.Bottom;
            labelTipo.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(3, 10);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(108, 15);
            labelTipo.TabIndex = 0;
            labelTipo.Text = "Tipo";
            // 
            // labelObs
            // 
            labelObs.AutoSize = true;
            labelObs.Dock = DockStyle.Bottom;
            labelObs.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelObs.Location = new Point(117, 10);
            labelObs.Name = "labelObs";
            labelObs.Size = new Size(451, 15);
            labelObs.TabIndex = 1;
            labelObs.Text = "Obs";
            // 
            // comboTipo
            // 
            comboTipo.DisabledBackColor = Color.LightBlue;
            comboTipo.DisabledForeColor = Color.Black;
            comboTipo.Dock = DockStyle.Fill;
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboTipo.FormattingEnabled = true;
            comboTipo.Items.AddRange(new object[] { "Debito", "Credito" });
            comboTipo.Location = new Point(3, 28);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(108, 23);
            comboTipo.TabIndex = 2;
            // 
            // textObs
            // 
            textObs.BackColor = Color.White;
            textObs.BorderStyle = BorderStyle.FixedSingle;
            textObs.Dock = DockStyle.Fill;
            textObs.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textObs.Location = new Point(117, 28);
            textObs.MaxLength = 500;
            textObs.Multiline = true;
            textObs.Name = "textObs";
            textObs.Size = new Size(451, 33);
            textObs.TabIndex = 3;
            // 
            // tableLinha03
            // 
            tableLinha03.ColumnCount = 4;
            tableLinha03.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLinha03.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLinha03.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLinha03.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 262F));
            tableLinha03.Controls.Add(checkAtivo, 0, 1);
            tableLinha03.Controls.Add(labelCreated, 1, 0);
            tableLinha03.Controls.Add(labelModified, 2, 0);
            tableLinha03.Controls.Add(dateCreated, 1, 1);
            tableLinha03.Controls.Add(dateModified, 2, 1);
            tableLinha03.Dock = DockStyle.Fill;
            tableLinha03.Location = new Point(3, 133);
            tableLinha03.Name = "tableLinha03";
            tableLinha03.RowCount = 2;
            tableLinha03.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha03.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLinha03.Size = new Size(571, 54);
            tableLinha03.TabIndex = 2;
            // 
            // checkAtivo
            // 
            checkAtivo.AutoSize = true;
            checkAtivo.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkAtivo.Location = new Point(3, 30);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Size = new Size(54, 19);
            checkAtivo.TabIndex = 0;
            checkAtivo.Text = "Ativo";
            checkAtivo.UseVisualStyleBackColor = true;
            // 
            // labelCreated
            // 
            labelCreated.AutoSize = true;
            labelCreated.Dock = DockStyle.Bottom;
            labelCreated.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreated.Location = new Point(83, 12);
            labelCreated.Name = "labelCreated";
            labelCreated.Size = new Size(94, 15);
            labelCreated.TabIndex = 1;
            labelCreated.Text = "Criado:";
            // 
            // labelModified
            // 
            labelModified.AutoSize = true;
            labelModified.Dock = DockStyle.Bottom;
            labelModified.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelModified.Location = new Point(183, 12);
            labelModified.Name = "labelModified";
            labelModified.Size = new Size(94, 15);
            labelModified.TabIndex = 2;
            labelModified.Text = "Modificado:";
            // 
            // dateCreated
            // 
            dateCreated.BackColor = Color.White;
            dateCreated.Dock = DockStyle.Fill;
            dateCreated.Enabled = false;
            dateCreated.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateCreated.Format = DateTimePickerFormat.Short;
            dateCreated.Location = new Point(83, 30);
            dateCreated.Name = "dateCreated";
            dateCreated.Size = new Size(94, 22);
            dateCreated.TabIndex = 3;
            // 
            // dateModified
            // 
            dateModified.BackColor = Color.White;
            dateModified.Enabled = false;
            dateModified.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateModified.Format = DateTimePickerFormat.Short;
            dateModified.Location = new Point(183, 30);
            dateModified.Name = "dateModified";
            dateModified.Size = new Size(94, 22);
            dateModified.TabIndex = 4;
            // 
            // novaContabil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 548);
            Controls.Add(tablePai);
            Name = "novaContabil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "novaContabil";
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableBtn.ResumeLayout(false);
            tableForm.ResumeLayout(false);
            tableLinha01.ResumeLayout(false);
            tableLinha01.PerformLayout();
            tableLinha02.ResumeLayout(false);
            tableLinha02.PerformLayout();
            tableLinha03.ResumeLayout(false);
            tableLinha03.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private Label labelTitulo;
        private TableLayoutPanel tableBtn;
        private Button btnNovo;
        private Button btnFechar;
        private TableLayoutPanel tableForm;
        private TableLayoutPanel tableLinha01;
        private Label labelCodigo;
        private Label labelNome;
        private Componentes.TextBoxNovo textCodigo;
        private Componentes.TextBoxNovo textNome;
        private TableLayoutPanel tableLinha02;
        private Label labelTipo;
        private Label labelObs;
        private Componentes.novoComboBox comboTipo;
        private Componentes.TextBoxNovo textObs;
        private TableLayoutPanel tableLinha03;
        private CheckBox checkAtivo;
        private Label labelCreated;
        private Label labelModified;
        private Componentes.novoDateTime dateCreated;
        private Componentes.novoDateTime dateModified;
    }
}