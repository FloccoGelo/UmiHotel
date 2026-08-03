namespace Umi_Interface.Estadia
{
    partial class telaPesquisaQuarto
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
            tableBtn = new TableLayoutPanel();
            btnVerCadastro = new Button();
            dataGrid = new Umi_Interface.Componentes.novoDataGrid();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numSoltDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numCasalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoAtualDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsLista = new BindingSource(components);
            tablePesquisa = new TableLayoutPanel();
            radioNumero = new RadioButton();
            radioDescricao = new RadioButton();
            textPesquisa = new Umi_Interface.Componentes.TextBoxNovo(components);
            tablePai.SuspendLayout();
            tableBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsLista).BeginInit();
            tablePesquisa.SuspendLayout();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.Controls.Add(tableBtn, 1, 3);
            tablePai.Controls.Add(dataGrid, 1, 2);
            tablePai.Controls.Add(tablePesquisa, 1, 1);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 5;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 317F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablePai.Size = new Size(984, 511);
            tablePai.TabIndex = 0;
            // 
            // tableBtn
            // 
            tableBtn.BackColor = Color.FromArgb(192, 255, 255);
            tableBtn.ColumnCount = 2;
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableBtn.Controls.Add(btnVerCadastro, 0, 0);
            tableBtn.Dock = DockStyle.Fill;
            tableBtn.Location = new Point(33, 439);
            tableBtn.Name = "tableBtn";
            tableBtn.RowCount = 1;
            tableBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableBtn.Size = new Size(918, 49);
            tableBtn.TabIndex = 3;
            // 
            // btnVerCadastro
            // 
            btnVerCadastro.BackColor = Color.FromArgb(128, 128, 255);
            btnVerCadastro.CausesValidation = false;
            btnVerCadastro.Dock = DockStyle.Fill;
            btnVerCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerCadastro.ForeColor = SystemColors.ButtonHighlight;
            btnVerCadastro.Location = new Point(3, 3);
            btnVerCadastro.Name = "btnVerCadastro";
            btnVerCadastro.Size = new Size(134, 43);
            btnVerCadastro.TabIndex = 0;
            btnVerCadastro.Text = "Ver Cadastro";
            btnVerCadastro.UseVisualStyleBackColor = false;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.AutoGenerateColumns = false;
            dataGrid.BackgroundColor = Color.FromArgb(255, 192, 192);
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, numeroDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, capacidadeDataGridViewTextBoxColumn, numSoltDataGridViewTextBoxColumn, numCasalDataGridViewTextBoxColumn, precoAtualDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn });
            dataGrid.DataSource = bsLista;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Font = new Font("Times New Roman", 10F);
            dataGrid.Location = new Point(33, 105);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.Beige;
            dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(918, 328);
            dataGrid.TabIndex = 4;
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
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.ReadOnly = true;
            numeroDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            tipoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // capacidadeDataGridViewTextBoxColumn
            // 
            capacidadeDataGridViewTextBoxColumn.DataPropertyName = "Capacidade";
            capacidadeDataGridViewTextBoxColumn.HeaderText = "Capacidade";
            capacidadeDataGridViewTextBoxColumn.Name = "capacidadeDataGridViewTextBoxColumn";
            capacidadeDataGridViewTextBoxColumn.ReadOnly = true;
            capacidadeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // numSoltDataGridViewTextBoxColumn
            // 
            numSoltDataGridViewTextBoxColumn.DataPropertyName = "NumSolt";
            numSoltDataGridViewTextBoxColumn.HeaderText = "Cam. Solt";
            numSoltDataGridViewTextBoxColumn.Name = "numSoltDataGridViewTextBoxColumn";
            numSoltDataGridViewTextBoxColumn.ReadOnly = true;
            numSoltDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // numCasalDataGridViewTextBoxColumn
            // 
            numCasalDataGridViewTextBoxColumn.DataPropertyName = "NumCasal";
            numCasalDataGridViewTextBoxColumn.HeaderText = "Cam Casal";
            numCasalDataGridViewTextBoxColumn.Name = "numCasalDataGridViewTextBoxColumn";
            numCasalDataGridViewTextBoxColumn.ReadOnly = true;
            numCasalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // precoAtualDataGridViewTextBoxColumn
            // 
            precoAtualDataGridViewTextBoxColumn.DataPropertyName = "PrecoAtual";
            precoAtualDataGridViewTextBoxColumn.HeaderText = "Valor";
            precoAtualDataGridViewTextBoxColumn.Name = "precoAtualDataGridViewTextBoxColumn";
            precoAtualDataGridViewTextBoxColumn.ReadOnly = true;
            precoAtualDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            descricaoDataGridViewTextBoxColumn.Width = 250;
            // 
            // bsLista
            // 
            bsLista.DataSource = typeof(Umi_Library.Class.classQuarto);
            // 
            // tablePesquisa
            // 
            tablePesquisa.ColumnCount = 3;
            tablePesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tablePesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.367981F));
            tablePesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.63202F));
            tablePesquisa.Controls.Add(radioNumero, 0, 0);
            tablePesquisa.Controls.Add(radioDescricao, 1, 0);
            tablePesquisa.Controls.Add(textPesquisa, 0, 1);
            tablePesquisa.Dock = DockStyle.Fill;
            tablePesquisa.Location = new Point(33, 38);
            tablePesquisa.Name = "tablePesquisa";
            tablePesquisa.RowCount = 2;
            tablePesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 37.9310341F));
            tablePesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 62.0689659F));
            tablePesquisa.Size = new Size(918, 61);
            tablePesquisa.TabIndex = 5;
            // 
            // radioNumero
            // 
            radioNumero.AutoSize = true;
            radioNumero.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioNumero.Location = new Point(3, 3);
            radioNumero.Name = "radioNumero";
            radioNumero.Size = new Size(69, 17);
            radioNumero.TabIndex = 0;
            radioNumero.TabStop = true;
            radioNumero.Text = "Numero";
            radioNumero.UseVisualStyleBackColor = true;
            // 
            // radioDescricao
            // 
            radioDescricao.AutoSize = true;
            radioDescricao.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioDescricao.Location = new Point(84, 3);
            radioDescricao.Name = "radioDescricao";
            radioDescricao.Size = new Size(80, 17);
            radioDescricao.TabIndex = 1;
            radioDescricao.TabStop = true;
            radioDescricao.Text = "Descrição";
            radioDescricao.UseVisualStyleBackColor = true;
            // 
            // textPesquisa
            // 
            textPesquisa.BackColor = Color.White;
            textPesquisa.BorderStyle = BorderStyle.FixedSingle;
            tablePesquisa.SetColumnSpan(textPesquisa, 3);
            textPesquisa.Dock = DockStyle.Fill;
            textPesquisa.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPesquisa.Location = new Point(3, 26);
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(912, 22);
            textPesquisa.TabIndex = 2;
            textPesquisa.TextChanged += textPesquisa_TextChanged;
            // 
            // telaPesquisaQuarto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 511);
            Controls.Add(tablePai);
            MaximumSize = new Size(1000, 550);
            MinimumSize = new Size(1000, 550);
            Name = "telaPesquisaQuarto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telaPesquisaQuarto";
            Load += telaPesquisaQuarto_Load;
            tablePai.ResumeLayout(false);
            tableBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsLista).EndInit();
            tablePesquisa.ResumeLayout(false);
            tablePesquisa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private BindingSource bsLista;
        private TableLayoutPanel tableBtn;
        private Button btnVerCadastro;
        private Componentes.novoDataGrid dataGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numSoltDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numCasalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoAtualDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private TableLayoutPanel tablePesquisa;
        private RadioButton radioNumero;
        private RadioButton radioDescricao;
        private Componentes.TextBoxNovo textPesquisa;
    }
}