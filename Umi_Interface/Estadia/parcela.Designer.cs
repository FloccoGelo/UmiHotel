namespace Umi_Interface.Estadia
{
    partial class parcela
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
            table1 = new TableLayoutPanel();
            labelDoc = new Label();
            labelValorTot = new Label();
            labelEmissao = new Label();
            textDoc = new Umi_Interface.Componentes.TextBoxNovo(components);
            textValorTot = new Umi_Interface.Componentes.TextBoxNovo(components);
            dateEmissao = new Umi_Interface.Componentes.novoDateTime(components);
            label1 = new Label();
            comboForma = new Umi_Interface.Componentes.novoComboBox();
            tableBtn = new TableLayoutPanel();
            btnSalvar = new Button();
            btnFechar = new Button();
            bindingSource1 = new BindingSource(components);
            tablePai.SuspendLayout();
            table1.SuspendLayout();
            tableBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.BackColor = Color.White;
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tablePai.Controls.Add(table1, 1, 1);
            tablePai.Controls.Add(tableBtn, 1, 2);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 4;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablePai.Size = new Size(530, 230);
            tablePai.TabIndex = 0;
            // 
            // table1
            // 
            table1.ColumnCount = 4;
            table1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            table1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            table1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            table1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            table1.Controls.Add(labelDoc, 0, 0);
            table1.Controls.Add(labelValorTot, 1, 0);
            table1.Controls.Add(labelEmissao, 2, 0);
            table1.Controls.Add(textDoc, 0, 1);
            table1.Controls.Add(textValorTot, 1, 1);
            table1.Controls.Add(dateEmissao, 2, 1);
            table1.Controls.Add(label1, 3, 0);
            table1.Controls.Add(comboForma, 3, 1);
            table1.Dock = DockStyle.Fill;
            table1.Location = new Point(38, 23);
            table1.Name = "table1";
            table1.RowCount = 4;
            table1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table1.Size = new Size(454, 114);
            table1.TabIndex = 0;
            // 
            // labelDoc
            // 
            labelDoc.AutoSize = true;
            labelDoc.Dock = DockStyle.Bottom;
            labelDoc.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDoc.Location = new Point(3, 13);
            labelDoc.Name = "labelDoc";
            labelDoc.Size = new Size(114, 15);
            labelDoc.TabIndex = 0;
            labelDoc.Text = "Documento:";
            // 
            // labelValorTot
            // 
            labelValorTot.AutoSize = true;
            labelValorTot.Dock = DockStyle.Bottom;
            labelValorTot.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValorTot.Location = new Point(123, 13);
            labelValorTot.Name = "labelValorTot";
            labelValorTot.Size = new Size(74, 15);
            labelValorTot.TabIndex = 2;
            labelValorTot.Text = "Valor:";
            // 
            // labelEmissao
            // 
            labelEmissao.AutoSize = true;
            labelEmissao.Dock = DockStyle.Bottom;
            labelEmissao.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmissao.Location = new Point(203, 13);
            labelEmissao.Name = "labelEmissao";
            labelEmissao.Size = new Size(104, 15);
            labelEmissao.TabIndex = 4;
            labelEmissao.Text = "Emissao:";
            // 
            // textDoc
            // 
            textDoc.BackColor = Color.LightBlue;
            textDoc.BorderStyle = BorderStyle.FixedSingle;
            textDoc.Dock = DockStyle.Fill;
            textDoc.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textDoc.Location = new Point(3, 31);
            textDoc.Name = "textDoc";
            textDoc.ReadOnly = true;
            textDoc.Size = new Size(114, 22);
            textDoc.TabIndex = 9;
            // 
            // textValorTot
            // 
            textValorTot.BackColor = Color.LightBlue;
            textValorTot.BorderStyle = BorderStyle.FixedSingle;
            textValorTot.Dock = DockStyle.Fill;
            textValorTot.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textValorTot.Location = new Point(123, 31);
            textValorTot.Name = "textValorTot";
            textValorTot.ReadOnly = true;
            textValorTot.Size = new Size(74, 22);
            textValorTot.TabIndex = 10;
            // 
            // dateEmissao
            // 
            dateEmissao.BackColor = Color.White;
            dateEmissao.Enabled = false;
            dateEmissao.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateEmissao.Format = DateTimePickerFormat.Short;
            dateEmissao.Location = new Point(203, 31);
            dateEmissao.Name = "dateEmissao";
            dateEmissao.Size = new Size(104, 22);
            dateEmissao.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, 13);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 14;
            label1.Text = "Forma";
            // 
            // comboForma
            // 
            comboForma.DisabledBackColor = Color.LightBlue;
            comboForma.DisabledForeColor = Color.Black;
            comboForma.Dock = DockStyle.Fill;
            comboForma.DropDownStyle = ComboBoxStyle.DropDownList;
            comboForma.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboForma.FormattingEnabled = true;
            comboForma.Items.AddRange(new object[] { "Dinheiro", "Pix", "Deposito", "Cartao Debito", "Cartao Credito" });
            comboForma.Location = new Point(313, 31);
            comboForma.Name = "comboForma";
            comboForma.Size = new Size(138, 23);
            comboForma.TabIndex = 15;
            // 
            // tableBtn
            // 
            tableBtn.ColumnCount = 3;
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableBtn.Controls.Add(btnSalvar, 0, 1);
            tableBtn.Controls.Add(btnFechar, 1, 1);
            tableBtn.Dock = DockStyle.Fill;
            tableBtn.Location = new Point(38, 143);
            tableBtn.Name = "tableBtn";
            tableBtn.RowCount = 2;
            tableBtn.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableBtn.Size = new Size(454, 64);
            tableBtn.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(192, 255, 192);
            btnSalvar.Dock = DockStyle.Fill;
            btnSalvar.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(3, 23);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(104, 38);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(255, 192, 192);
            btnFechar.Dock = DockStyle.Fill;
            btnFechar.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(113, 23);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(104, 38);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Umi_Library.Class.classParcela);
            // 
            // parcela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 230);
            Controls.Add(tablePai);
            Name = "parcela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "parcela";
            Load += parcela_Load;
            tablePai.ResumeLayout(false);
            table1.ResumeLayout(false);
            table1.PerformLayout();
            tableBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tablePai;
        private TableLayoutPanel table1;
        private Label labelDoc;
        private Label labelValorTot;
        private Label labelEmissao;
        private BindingSource bindingSource1;
        private Componentes.TextBoxNovo textDoc;
        private Componentes.TextBoxNovo textValorTot;
        private Componentes.novoDateTime dateEmissao;
        private Label label1;
        private Componentes.novoComboBox comboForma;
        private TableLayoutPanel tableBtn;
        private Button btnSalvar;
        private Button btnFechar;
    }
}