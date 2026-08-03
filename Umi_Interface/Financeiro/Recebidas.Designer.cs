namespace Umi_Interface.Financeiro
{
    partial class Recebidas
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
            dataGridRecebidas = new Umi_Interface.Componentes.novoDataGrid();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            docOrigemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codCliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emissaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recebimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valRecebidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            destinoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            obsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsRecebidas = new BindingSource(components);
            tableBTN = new TableLayoutPanel();
            btnNovo = new Button();
            tablePai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRecebidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRecebidas).BeginInit();
            tableBTN.SuspendLayout();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.BackColor = Color.White;
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tablePai.Controls.Add(labelTitulo, 1, 0);
            tablePai.Controls.Add(dataGridRecebidas, 1, 1);
            tablePai.Controls.Add(tableBTN, 1, 2);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 4;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 207F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablePai.Size = new Size(900, 650);
            tablePai.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(336, 23);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(228, 33);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Contas Recebidas";
            // 
            // dataGridRecebidas
            // 
            dataGridRecebidas.AllowUserToAddRows = false;
            dataGridRecebidas.AllowUserToDeleteRows = false;
            dataGridRecebidas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridRecebidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridRecebidas.AutoGenerateColumns = false;
            dataGridRecebidas.BackgroundColor = Color.White;
            dataGridRecebidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRecebidas.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, docOrigemDataGridViewTextBoxColumn, codCliDataGridViewTextBoxColumn, emissaoDataGridViewTextBoxColumn, recebimentoDataGridViewTextBoxColumn, valorDataGridViewTextBoxColumn, valRecebidoDataGridViewTextBoxColumn, formaDataGridViewTextBoxColumn, destinoDataGridViewTextBoxColumn, obsDataGridViewTextBoxColumn });
            dataGridRecebidas.DataSource = bsRecebidas;
            dataGridRecebidas.Dock = DockStyle.Fill;
            dataGridRecebidas.Font = new Font("Times New Roman", 10F);
            dataGridRecebidas.Location = new Point(38, 83);
            dataGridRecebidas.MultiSelect = false;
            dataGridRecebidas.Name = "dataGridRecebidas";
            dataGridRecebidas.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.Beige;
            dataGridRecebidas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridRecebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridRecebidas.Size = new Size(824, 337);
            dataGridRecebidas.TabIndex = 1;
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
            docOrigemDataGridViewTextBoxColumn.HeaderText = "Origem";
            docOrigemDataGridViewTextBoxColumn.Name = "docOrigemDataGridViewTextBoxColumn";
            docOrigemDataGridViewTextBoxColumn.ReadOnly = true;
            docOrigemDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // codCliDataGridViewTextBoxColumn
            // 
            codCliDataGridViewTextBoxColumn.DataPropertyName = "codCli";
            codCliDataGridViewTextBoxColumn.HeaderText = "Cod. Cli";
            codCliDataGridViewTextBoxColumn.Name = "codCliDataGridViewTextBoxColumn";
            codCliDataGridViewTextBoxColumn.ReadOnly = true;
            codCliDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // emissaoDataGridViewTextBoxColumn
            // 
            emissaoDataGridViewTextBoxColumn.DataPropertyName = "emissao";
            emissaoDataGridViewTextBoxColumn.HeaderText = "Emissao";
            emissaoDataGridViewTextBoxColumn.Name = "emissaoDataGridViewTextBoxColumn";
            emissaoDataGridViewTextBoxColumn.ReadOnly = true;
            emissaoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // recebimentoDataGridViewTextBoxColumn
            // 
            recebimentoDataGridViewTextBoxColumn.DataPropertyName = "recebimento";
            recebimentoDataGridViewTextBoxColumn.HeaderText = "Recebido";
            recebimentoDataGridViewTextBoxColumn.Name = "recebimentoDataGridViewTextBoxColumn";
            recebimentoDataGridViewTextBoxColumn.ReadOnly = true;
            recebimentoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            valorDataGridViewTextBoxColumn.HeaderText = "Valor Tot";
            valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            valorDataGridViewTextBoxColumn.ReadOnly = true;
            valorDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // valRecebidoDataGridViewTextBoxColumn
            // 
            valRecebidoDataGridViewTextBoxColumn.DataPropertyName = "valRecebido";
            valRecebidoDataGridViewTextBoxColumn.HeaderText = "Val. Recb.";
            valRecebidoDataGridViewTextBoxColumn.Name = "valRecebidoDataGridViewTextBoxColumn";
            valRecebidoDataGridViewTextBoxColumn.ReadOnly = true;
            valRecebidoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // formaDataGridViewTextBoxColumn
            // 
            formaDataGridViewTextBoxColumn.DataPropertyName = "forma";
            formaDataGridViewTextBoxColumn.HeaderText = "Forma";
            formaDataGridViewTextBoxColumn.Name = "formaDataGridViewTextBoxColumn";
            formaDataGridViewTextBoxColumn.ReadOnly = true;
            formaDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            formaDataGridViewTextBoxColumn.Width = 120;
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            destinoDataGridViewTextBoxColumn.DataPropertyName = "destino";
            destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            destinoDataGridViewTextBoxColumn.ReadOnly = true;
            destinoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            obsDataGridViewTextBoxColumn.DataPropertyName = "obs";
            obsDataGridViewTextBoxColumn.HeaderText = "obs";
            obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            obsDataGridViewTextBoxColumn.ReadOnly = true;
            obsDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            obsDataGridViewTextBoxColumn.Width = 300;
            // 
            // bsRecebidas
            // 
            bsRecebidas.DataSource = typeof(Umi_Library.Class.classRecebidos);
            // 
            // tableBTN
            // 
            tableBTN.ColumnCount = 3;
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableBTN.Controls.Add(btnNovo, 0, 1);
            tableBTN.Dock = DockStyle.Fill;
            tableBTN.Location = new Point(38, 426);
            tableBTN.Name = "tableBTN";
            tableBTN.RowCount = 2;
            tableBTN.RowStyles.Add(new RowStyle(SizeType.Percent, 159F));
            tableBTN.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableBTN.Size = new Size(824, 201);
            tableBTN.TabIndex = 2;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.FromArgb(192, 255, 192);
            btnNovo.Dock = DockStyle.Fill;
            btnNovo.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(3, 144);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(144, 54);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // Recebidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 650);
            Controls.Add(tablePai);
            MinimumSize = new Size(900, 650);
            Name = "Recebidas";
            Text = "Recebidas";
            this.StartPosition = FormStartPosition.CenterScreen;
            Load += Recebidas_Load;
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRecebidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRecebidas).EndInit();
            tableBTN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private Label labelTitulo;
        private Componentes.novoDataGrid dataGridRecebidas;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn docOrigemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codCliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emissaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recebimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valRecebidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private BindingSource bsRecebidas;
        private TableLayoutPanel tableBTN;
        private Button btnNovo;
    }
}