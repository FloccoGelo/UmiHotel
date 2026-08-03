namespace Umi_Interface.Estadia
{
    partial class telaPesquisaCliente
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
            tableOpcoes = new TableLayoutPanel();
            radioCPF = new RadioButton();
            radioNome = new RadioButton();
            textPesquisa = new TextBox();
            dataGrid = new Umi_Interface.Componentes.novoDataGrid();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codCliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cPFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefone1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsLista = new BindingSource(components);
            tablePai.SuspendLayout();
            tableOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsLista).BeginInit();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.Controls.Add(tableOpcoes, 1, 0);
            tablePai.Controls.Add(textPesquisa, 1, 1);
            tablePai.Controls.Add(dataGrid, 1, 2);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 4;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 317F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablePai.Size = new Size(784, 411);
            tablePai.TabIndex = 0;
            // 
            // tableOpcoes
            // 
            tableOpcoes.ColumnCount = 3;
            tableOpcoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableOpcoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 77F));
            tableOpcoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableOpcoes.Controls.Add(radioCPF, 0, 0);
            tableOpcoes.Controls.Add(radioNome, 1, 0);
            tableOpcoes.Dock = DockStyle.Fill;
            tableOpcoes.Location = new Point(33, 3);
            tableOpcoes.Name = "tableOpcoes";
            tableOpcoes.RowCount = 1;
            tableOpcoes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableOpcoes.Size = new Size(718, 29);
            tableOpcoes.TabIndex = 0;
            // 
            // radioCPF
            // 
            radioCPF.AutoSize = true;
            radioCPF.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioCPF.Location = new Point(3, 3);
            radioCPF.Name = "radioCPF";
            radioCPF.Size = new Size(98, 23);
            radioCPF.TabIndex = 0;
            radioCPF.TabStop = true;
            radioCPF.Text = "CPF/CNPJ";
            radioCPF.UseVisualStyleBackColor = true;
            // 
            // radioNome
            // 
            radioNome.AutoSize = true;
            radioNome.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioNome.Location = new Point(113, 3);
            radioNome.Name = "radioNome";
            radioNome.Size = new Size(65, 23);
            radioNome.TabIndex = 1;
            radioNome.TabStop = true;
            radioNome.Text = "Nome";
            radioNome.UseVisualStyleBackColor = true;
            // 
            // textPesquisa
            // 
            textPesquisa.BorderStyle = BorderStyle.FixedSingle;
            textPesquisa.Dock = DockStyle.Fill;
            textPesquisa.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPesquisa.Location = new Point(33, 38);
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(718, 21);
            textPesquisa.TabIndex = 1;
            textPesquisa.TextChanged += textPesquisa_TextChanged;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.AutoGenerateColumns = false;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, codCliDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, cPFDataGridViewTextBoxColumn, telefone1DataGridViewTextBoxColumn });
            dataGrid.DataSource = bsLista;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Font = new Font("Times New Roman", 10F);
            dataGrid.Location = new Point(33, 68);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.Beige;
            dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(718, 320);
            dataGrid.TabIndex = 2;
            dataGrid.DoubleClick += dataGrid_DoubleClick;
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
            codCliDataGridViewTextBoxColumn.HeaderText = "Cod Cli";
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
            // cPFDataGridViewTextBoxColumn
            // 
            cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefone1DataGridViewTextBoxColumn
            // 
            telefone1DataGridViewTextBoxColumn.DataPropertyName = "Telefone1";
            telefone1DataGridViewTextBoxColumn.HeaderText = "Telefone1";
            telefone1DataGridViewTextBoxColumn.Name = "telefone1DataGridViewTextBoxColumn";
            telefone1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsLista
            // 
            bsLista.AllowNew = false;
            bsLista.DataSource = typeof(Umi_Library.Class.classCliente);
            // 
            // telaPesquisaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(tablePai);
            MaximumSize = new Size(800, 450);
            MinimumSize = new Size(800, 450);
            Name = "telaPesquisaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pesquisaCliente";
            Load += telaPesquisaCliente_Load;
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableOpcoes.ResumeLayout(false);
            tableOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private TableLayoutPanel tableOpcoes;
        private RadioButton radioCPF;
        private RadioButton radioNome;
        private TextBox textPesquisa;
        private BindingSource bsLista;
        private Componentes.novoDataGrid dataGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codCliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefone1DataGridViewTextBoxColumn;
    }
}