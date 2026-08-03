namespace Umi_Interface.Financeiro
{
    partial class A_Receber_Teste
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
            textValor = new Umi_Interface.Componentes.TextBoxNovo(components);
            dataGrid = new Umi_Interface.Componentes.novoDataGrid();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            docOrigemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codCliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emissaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vencimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saldoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numParcDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            obsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsAReceber = new BindingSource(components);
            textParcela = new Umi_Interface.Componentes.TextBoxNovo(components);
            btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAReceber).BeginInit();
            SuspendLayout();
            // 
            // textValor
            // 
            textValor.BackColor = Color.White;
            textValor.BorderStyle = BorderStyle.FixedSingle;
            textValor.Location = new Point(137, 90);
            textValor.Name = "textValor";
            textValor.Size = new Size(100, 23);
            textValor.TabIndex = 1;
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
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, docOrigemDataGridViewTextBoxColumn, codCliDataGridViewTextBoxColumn, emissaoDataGridViewTextBoxColumn, vencimentoDataGridViewTextBoxColumn, valorDataGridViewTextBoxColumn, saldoDataGridViewTextBoxColumn, numParcDataGridViewTextBoxColumn, formaDataGridViewTextBoxColumn, obsDataGridViewTextBoxColumn });
            dataGrid.DataSource = bsAReceber;
            dataGrid.Font = new Font("Times New Roman", 10F);
            dataGrid.GridColor = Color.White;
            dataGrid.Location = new Point(137, 133);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.Beige;
            dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(618, 264);
            dataGrid.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docOrigemDataGridViewTextBoxColumn
            // 
            docOrigemDataGridViewTextBoxColumn.DataPropertyName = "docOrigem";
            docOrigemDataGridViewTextBoxColumn.HeaderText = "docOrigem";
            docOrigemDataGridViewTextBoxColumn.Name = "docOrigemDataGridViewTextBoxColumn";
            docOrigemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codCliDataGridViewTextBoxColumn
            // 
            codCliDataGridViewTextBoxColumn.DataPropertyName = "codCli";
            codCliDataGridViewTextBoxColumn.HeaderText = "codCli";
            codCliDataGridViewTextBoxColumn.Name = "codCliDataGridViewTextBoxColumn";
            codCliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emissaoDataGridViewTextBoxColumn
            // 
            emissaoDataGridViewTextBoxColumn.DataPropertyName = "emissao";
            emissaoDataGridViewTextBoxColumn.HeaderText = "emissao";
            emissaoDataGridViewTextBoxColumn.Name = "emissaoDataGridViewTextBoxColumn";
            emissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vencimentoDataGridViewTextBoxColumn
            // 
            vencimentoDataGridViewTextBoxColumn.DataPropertyName = "vencimento";
            vencimentoDataGridViewTextBoxColumn.HeaderText = "vencimento";
            vencimentoDataGridViewTextBoxColumn.Name = "vencimentoDataGridViewTextBoxColumn";
            vencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            valorDataGridViewTextBoxColumn.HeaderText = "valor";
            valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            saldoDataGridViewTextBoxColumn.DataPropertyName = "saldo";
            saldoDataGridViewTextBoxColumn.HeaderText = "saldo";
            saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            saldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numParcDataGridViewTextBoxColumn
            // 
            numParcDataGridViewTextBoxColumn.DataPropertyName = "numParc";
            numParcDataGridViewTextBoxColumn.HeaderText = "numParc";
            numParcDataGridViewTextBoxColumn.Name = "numParcDataGridViewTextBoxColumn";
            numParcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaDataGridViewTextBoxColumn
            // 
            formaDataGridViewTextBoxColumn.DataPropertyName = "forma";
            formaDataGridViewTextBoxColumn.HeaderText = "forma";
            formaDataGridViewTextBoxColumn.Name = "formaDataGridViewTextBoxColumn";
            formaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            obsDataGridViewTextBoxColumn.DataPropertyName = "obs";
            obsDataGridViewTextBoxColumn.HeaderText = "obs";
            obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            obsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsAReceber
            // 
            bsAReceber.DataSource = typeof(Umi_Library.Class.classAReceber);
            // 
            // textParcela
            // 
            textParcela.BackColor = Color.White;
            textParcela.BorderStyle = BorderStyle.FixedSingle;
            textParcela.Location = new Point(243, 90);
            textParcela.Name = "textParcela";
            textParcela.Size = new Size(100, 23);
            textParcela.TabIndex = 3;
            // 
            // btn
            // 
            btn.Location = new Point(463, 90);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 4;
            btn.Text = "button1";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // A_Receber_Teste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn);
            Controls.Add(textParcela);
            Controls.Add(dataGrid);
            Controls.Add(textValor);
            Name = "A_Receber_Teste";
            Text = "A_Receber_Teste";
            Load += A_Receber_Teste_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAReceber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Componentes.TextBoxNovo textValor;
        private Componentes.novoDataGrid dataGrid;
        private BindingSource bsAReceber;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn docOrigemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codCliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emissaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vencimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numParcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private Componentes.TextBoxNovo textParcela;
        private Button btn;
    }
}