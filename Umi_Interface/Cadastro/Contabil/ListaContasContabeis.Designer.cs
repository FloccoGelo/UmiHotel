namespace Umi_Interface.Cadastro.Contabil
{
    partial class ListaContasContabeis
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
            tableBtn = new TableLayoutPanel();
            btnNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            table02 = new TableLayoutPanel();
            dataGridConta = new Umi_Interface.Componentes.novoDataGrid();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoContaContabilDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            observacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsContabil = new BindingSource(components);
            tablePai.SuspendLayout();
            tableBtn.SuspendLayout();
            table02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridConta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsContabil).BeginInit();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.BackColor = Color.White;
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.75246441F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.2475357F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tablePai.Controls.Add(labelTitulo, 1, 0);
            tablePai.Controls.Add(tableBtn, 1, 2);
            tablePai.Controls.Add(table02, 1, 1);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 3;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9135561F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 84.08644F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
            tablePai.Size = new Size(934, 611);
            tablePai.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(349, 24);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(230, 32);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Contas Contabeis";
            // 
            // tableBtn
            // 
            tableBtn.ColumnCount = 4;
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.71642F));
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.28358F));
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 446F));
            tableBtn.Controls.Add(btnNovo, 0, 1);
            tableBtn.Controls.Add(btnEditar, 1, 1);
            tableBtn.Controls.Add(btnExcluir, 2, 1);
            tableBtn.Dock = DockStyle.Fill;
            tableBtn.Location = new Point(19, 512);
            tableBtn.Name = "tableBtn";
            tableBtn.RowCount = 3;
            tableBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 36F));
            tableBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 64F));
            tableBtn.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableBtn.Size = new Size(891, 96);
            tableBtn.TabIndex = 1;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Cyan;
            btnNovo.Dock = DockStyle.Fill;
            btnNovo.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(3, 28);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(191, 38);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(192, 192, 255);
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(200, 28);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(145, 38);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 192, 192);
            btnExcluir.Dock = DockStyle.Fill;
            btnExcluir.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(351, 28);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(90, 38);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // table02
            // 
            table02.ColumnCount = 1;
            table02.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table02.Controls.Add(dataGridConta, 0, 1);
            table02.Dock = DockStyle.Fill;
            table02.Location = new Point(19, 84);
            table02.Name = "table02";
            table02.RowCount = 2;
            table02.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table02.RowStyles.Add(new RowStyle(SizeType.Absolute, 367F));
            table02.Size = new Size(891, 422);
            table02.TabIndex = 2;
            // 
            // dataGridConta
            // 
            dataGridConta.AllowUserToAddRows = false;
            dataGridConta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridConta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridConta.AutoGenerateColumns = false;
            dataGridConta.BackgroundColor = Color.White;
            dataGridConta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridConta.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, codigoDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, tipoContaContabilDataGridViewTextBoxColumn, observacaoDataGridViewTextBoxColumn });
            dataGridConta.DataSource = bsContabil;
            dataGridConta.Dock = DockStyle.Fill;
            dataGridConta.Font = new Font("Times New Roman", 10F);
            dataGridConta.Location = new Point(3, 58);
            dataGridConta.MultiSelect = false;
            dataGridConta.Name = "dataGridConta";
            dataGridConta.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.Beige;
            dataGridConta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridConta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridConta.Size = new Size(885, 361);
            dataGridConta.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            codigoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            nomeDataGridViewTextBoxColumn.Width = 250;
            // 
            // tipoContaContabilDataGridViewTextBoxColumn
            // 
            tipoContaContabilDataGridViewTextBoxColumn.DataPropertyName = "tipoContaContabil";
            tipoContaContabilDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoContaContabilDataGridViewTextBoxColumn.Name = "tipoContaContabilDataGridViewTextBoxColumn";
            tipoContaContabilDataGridViewTextBoxColumn.ReadOnly = true;
            tipoContaContabilDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            observacaoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsContabil
            // 
            bsContabil.DataSource = typeof(Umi_Library.Class.classContabil);
            // 
            // ListaContasContabeis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(tablePai);
            MaximumSize = new Size(950, 650);
            MinimumSize = new Size(950, 650);
            Name = "ListaContasContabeis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaContasContabeis";
            Load += ListaContasContabeis_Load;
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableBtn.ResumeLayout(false);
            table02.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridConta).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsContabil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private Label labelTitulo;
        private TableLayoutPanel tableBtn;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
        private BindingSource bsContabil;
        private TableLayoutPanel table02;
        private Componentes.novoDataGrid dataGridConta;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoContaContabilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
    }
}