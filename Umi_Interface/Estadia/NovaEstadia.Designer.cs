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
            labelTitulo = new Label();
            tableForm = new TableLayoutPanel();
            tablePesquisaCliente = new TableLayoutPanel();
            buttonPesquisaCliente = new Button();
            labelPesquisa1 = new Label();
            labelPesquisa2 = new Label();
            pesquisaNomeCli = new TextBox();
            pesquisaCPF = new MaskedTextBox();
            tablePesquisaQuarto = new TableLayoutPanel();
            btnPesquisaQuarto = new Button();
            labelNumQuarto = new Label();
            textNumQuarto = new TextBox();
            labelDescQuarto = new Label();
            textDescQuarto = new TextBox();
            dataGridQuarto = new DataGridView();
            bsCliente = new BindingSource(components);
            bsQuarto = new BindingSource(components);
            tableLateral = new TableLayoutPanel();
            tablePai.SuspendLayout();
            tableButton.SuspendLayout();
            tableForm.SuspendLayout();
            tablePesquisaCliente.SuspendLayout();
            tablePesquisaQuarto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridQuarto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsQuarto).BeginInit();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.Controls.Add(tableButton, 1, 2);
            tablePai.Controls.Add(labelTitulo, 1, 0);
            tablePai.Controls.Add(tableForm, 1, 1);
            tablePai.Dock = DockStyle.Left;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 3;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablePai.Size = new Size(771, 833);
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
            tableButton.Location = new Point(33, 710);
            tableButton.Name = "tableButton";
            tableButton.RowCount = 3;
            tableButton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableButton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableButton.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableButton.Size = new Size(705, 120);
            tableButton.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(128, 255, 255);
            btnSalvar.Dock = DockStyle.Fill;
            btnSalvar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(33, 48);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 39);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(255, 128, 128);
            btnVoltar.Dock = DockStyle.Fill;
            btnVoltar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(133, 48);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 39);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.DarkGreen;
            labelTitulo.Location = new Point(273, 40);
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
            tableForm.Controls.Add(dataGridQuarto, 0, 3);
            tableForm.Dock = DockStyle.Fill;
            tableForm.Location = new Point(33, 127);
            tableForm.Name = "tableForm";
            tableForm.RowCount = 4;
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableForm.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableForm.Size = new Size(705, 577);
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
            tablePesquisaCliente.Controls.Add(pesquisaNomeCli, 2, 1);
            tablePesquisaCliente.Controls.Add(pesquisaCPF, 1, 1);
            tablePesquisaCliente.Dock = DockStyle.Fill;
            tablePesquisaCliente.Location = new Point(3, 3);
            tablePesquisaCliente.Name = "tablePesquisaCliente";
            tablePesquisaCliente.RowCount = 2;
            tablePesquisaCliente.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePesquisaCliente.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePesquisaCliente.Size = new Size(699, 64);
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
            labelPesquisa1.Size = new Size(83, 19);
            labelPesquisa1.TabIndex = 1;
            labelPesquisa1.Text = "CPF:";
            // 
            // labelPesquisa2
            // 
            labelPesquisa2.AutoSize = true;
            labelPesquisa2.Dock = DockStyle.Bottom;
            labelPesquisa2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPesquisa2.Location = new Point(192, 13);
            labelPesquisa2.Name = "labelPesquisa2";
            labelPesquisa2.Size = new Size(504, 19);
            labelPesquisa2.TabIndex = 2;
            labelPesquisa2.Text = "Nome:";
            // 
            // pesquisaNomeCli
            // 
            pesquisaNomeCli.BorderStyle = BorderStyle.FixedSingle;
            pesquisaNomeCli.Dock = DockStyle.Fill;
            pesquisaNomeCli.Enabled = false;
            pesquisaNomeCli.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pesquisaNomeCli.Location = new Point(192, 35);
            pesquisaNomeCli.Name = "pesquisaNomeCli";
            pesquisaNomeCli.Size = new Size(504, 21);
            pesquisaNomeCli.TabIndex = 4;
            // 
            // pesquisaCPF
            // 
            pesquisaCPF.Dock = DockStyle.Fill;
            pesquisaCPF.Enabled = false;
            pesquisaCPF.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pesquisaCPF.Location = new Point(103, 35);
            pesquisaCPF.Name = "pesquisaCPF";
            pesquisaCPF.Size = new Size(83, 21);
            pesquisaCPF.TabIndex = 5;
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
            tablePesquisaQuarto.Controls.Add(textNumQuarto, 1, 1);
            tablePesquisaQuarto.Controls.Add(labelDescQuarto, 2, 0);
            tablePesquisaQuarto.Controls.Add(textDescQuarto, 2, 1);
            tablePesquisaQuarto.Dock = DockStyle.Fill;
            tablePesquisaQuarto.Location = new Point(3, 83);
            tablePesquisaQuarto.Name = "tablePesquisaQuarto";
            tablePesquisaQuarto.RowCount = 3;
            tablePesquisaQuarto.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tablePesquisaQuarto.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tablePesquisaQuarto.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tablePesquisaQuarto.Size = new Size(699, 114);
            tablePesquisaQuarto.TabIndex = 1;
            // 
            // btnPesquisaQuarto
            // 
            btnPesquisaQuarto.BackColor = Color.FromArgb(255, 128, 255);
            btnPesquisaQuarto.Dock = DockStyle.Fill;
            btnPesquisaQuarto.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisaQuarto.ForeColor = SystemColors.ControlText;
            btnPesquisaQuarto.Location = new Point(3, 28);
            btnPesquisaQuarto.Name = "btnPesquisaQuarto";
            btnPesquisaQuarto.Size = new Size(94, 24);
            btnPesquisaQuarto.TabIndex = 0;
            btnPesquisaQuarto.Text = "Pesquisar";
            btnPesquisaQuarto.UseVisualStyleBackColor = false;
            // 
            // labelNumQuarto
            // 
            labelNumQuarto.AutoSize = true;
            labelNumQuarto.Dock = DockStyle.Bottom;
            labelNumQuarto.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumQuarto.Location = new Point(103, 0);
            labelNumQuarto.Name = "labelNumQuarto";
            labelNumQuarto.Size = new Size(83, 25);
            labelNumQuarto.TabIndex = 1;
            labelNumQuarto.Text = "Num Quarto:";
            // 
            // textNumQuarto
            // 
            textNumQuarto.BorderStyle = BorderStyle.FixedSingle;
            textNumQuarto.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNumQuarto.Location = new Point(103, 28);
            textNumQuarto.Name = "textNumQuarto";
            textNumQuarto.Size = new Size(83, 21);
            textNumQuarto.TabIndex = 2;
            // 
            // labelDescQuarto
            // 
            labelDescQuarto.AutoSize = true;
            labelDescQuarto.Dock = DockStyle.Bottom;
            labelDescQuarto.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescQuarto.Location = new Point(192, 6);
            labelDescQuarto.Name = "labelDescQuarto";
            labelDescQuarto.Size = new Size(504, 19);
            labelDescQuarto.TabIndex = 3;
            labelDescQuarto.Text = "Descriçao:";
            // 
            // textDescQuarto
            // 
            textDescQuarto.BorderStyle = BorderStyle.FixedSingle;
            textDescQuarto.Dock = DockStyle.Fill;
            textDescQuarto.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDescQuarto.Location = new Point(192, 28);
            textDescQuarto.Name = "textDescQuarto";
            textDescQuarto.Size = new Size(504, 21);
            textDescQuarto.TabIndex = 4;
            // 
            // dataGridQuarto
            // 
            dataGridQuarto.BackgroundColor = Color.Gray;
            dataGridQuarto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridQuarto.Dock = DockStyle.Fill;
            dataGridQuarto.Location = new Point(3, 203);
            dataGridQuarto.Name = "dataGridQuarto";
            dataGridQuarto.Size = new Size(699, 371);
            dataGridQuarto.TabIndex = 2;
            // 
            // bsCliente
            // 
            bsCliente.DataSource = typeof(Umi_Library.Class.classCliente);
            // 
            // tableLateral
            // 
            tableLateral.ColumnCount = 2;
            tableLateral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLateral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLateral.Dock = DockStyle.Right;
            tableLateral.Location = new Point(777, 0);
            tableLateral.Name = "tableLateral";
            tableLateral.RowCount = 10;
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9699879F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Percent, 75.030014F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLateral.Size = new Size(138, 833);
            tableLateral.TabIndex = 4;
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
            Text = "Estadia";
            Load += NovaEstadia_Load;
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableButton.ResumeLayout(false);
            tableForm.ResumeLayout(false);
            tablePesquisaCliente.ResumeLayout(false);
            tablePesquisaCliente.PerformLayout();
            tablePesquisaQuarto.ResumeLayout(false);
            tablePesquisaQuarto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridQuarto).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsQuarto).EndInit();
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
        private TextBox pesquisaNomeCli;
        private MaskedTextBox pesquisaCPF;
        private BindingSource bsCliente;
        private TableLayoutPanel tablePesquisaQuarto;
        private Button btnPesquisaQuarto;
        private Label labelNumQuarto;
        private TextBox textNumQuarto;
        private Label labelDescQuarto;
        private TextBox textDescQuarto;
        private DataGridView dataGridQuarto;
        private BindingSource bsQuarto;
        private TableLayoutPanel tableLateral;
    }
}