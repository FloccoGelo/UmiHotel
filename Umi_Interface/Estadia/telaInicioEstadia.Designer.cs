namespace Umi_Interface.Estadia
{
    partial class telaInicioEstadia
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tablePai = new TableLayoutPanel();
            labelTitulo = new Label();
            tableButon = new TableLayoutPanel();
            btnNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            dataGridQuartos = new Umi_Interface.Componentes.novoDataGrid();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            estadiaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quartoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numQuartoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            previsCheckOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diariaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diasHospedagemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDiariaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numHospedesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bsQuarto = new BindingSource(components);
            dataGridEstadias = new Umi_Interface.Componentes.novoDataGrid();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            docDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codCliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emissaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsEstadia = new BindingSource(components);
            tablePai.SuspendLayout();
            tableButon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridQuartos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsQuarto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEstadias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEstadia).BeginInit();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.BackColor = Color.FromArgb(225, 253, 255);
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tablePai.Controls.Add(labelTitulo, 1, 0);
            tablePai.Controls.Add(tableButon, 1, 3);
            tablePai.Controls.Add(dataGridQuartos, 1, 2);
            tablePai.Controls.Add(dataGridEstadias, 1, 1);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 4;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tablePai.Size = new Size(915, 833);
            tablePai.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(255, 128, 128);
            labelTitulo.Location = new Point(301, 27);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(313, 46);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "== || Estadia || ==";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableButon
            // 
            tableButon.ColumnCount = 5;
            tableButon.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableButon.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableButon.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableButon.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableButon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableButon.Controls.Add(btnNovo, 0, 1);
            tableButon.Controls.Add(btnEditar, 1, 1);
            tableButon.Controls.Add(btnExcluir, 2, 1);
            tableButon.Controls.Add(btnVoltar, 3, 1);
            tableButon.Dock = DockStyle.Fill;
            tableButon.Location = new Point(33, 686);
            tableButon.Name = "tableButon";
            tableButon.RowCount = 3;
            tableButon.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableButon.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableButon.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableButon.Size = new Size(849, 144);
            tableButon.TabIndex = 1;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.FromArgb(128, 255, 255);
            btnNovo.Dock = DockStyle.Fill;
            btnNovo.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(3, 62);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(104, 44);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo\r\n";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 192);
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(113, 62);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(104, 44);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 192, 192);
            btnExcluir.Dock = DockStyle.Fill;
            btnExcluir.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(223, 62);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(104, 44);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(192, 192, 255);
            btnVoltar.Dock = DockStyle.Fill;
            btnVoltar.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(333, 62);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(104, 44);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dataGridQuartos
            // 
            dataGridQuartos.AllowUserToAddRows = false;
            dataGridQuartos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridQuartos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridQuartos.AutoGenerateColumns = false;
            dataGridQuartos.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridQuartos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridQuartos.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, estadiaIdDataGridViewTextBoxColumn, quartoIdDataGridViewTextBoxColumn, numQuartoDataGridViewTextBoxColumn, checkInDataGridViewTextBoxColumn, previsCheckOutDataGridViewTextBoxColumn, checkOutDataGridViewTextBoxColumn, diariaDataGridViewTextBoxColumn, diasHospedagemDataGridViewTextBoxColumn, totalDiariaDataGridViewTextBoxColumn, numHospedesDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn1 });
            dataGridQuartos.DataSource = bsQuarto;
            dataGridQuartos.Dock = DockStyle.Fill;
            dataGridQuartos.Font = new Font("Times New Roman", 10F);
            dataGridQuartos.Location = new Point(33, 486);
            dataGridQuartos.MultiSelect = false;
            dataGridQuartos.Name = "dataGridQuartos";
            dataGridQuartos.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.Beige;
            dataGridQuartos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridQuartos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridQuartos.Size = new Size(849, 194);
            dataGridQuartos.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // estadiaIdDataGridViewTextBoxColumn
            // 
            estadiaIdDataGridViewTextBoxColumn.DataPropertyName = "EstadiaId";
            estadiaIdDataGridViewTextBoxColumn.HeaderText = "EstadiaId";
            estadiaIdDataGridViewTextBoxColumn.Name = "estadiaIdDataGridViewTextBoxColumn";
            estadiaIdDataGridViewTextBoxColumn.ReadOnly = true;
            estadiaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // quartoIdDataGridViewTextBoxColumn
            // 
            quartoIdDataGridViewTextBoxColumn.DataPropertyName = "QuartoId";
            quartoIdDataGridViewTextBoxColumn.HeaderText = "QuartoId";
            quartoIdDataGridViewTextBoxColumn.Name = "quartoIdDataGridViewTextBoxColumn";
            quartoIdDataGridViewTextBoxColumn.ReadOnly = true;
            quartoIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // numQuartoDataGridViewTextBoxColumn
            // 
            numQuartoDataGridViewTextBoxColumn.DataPropertyName = "NumQuarto";
            numQuartoDataGridViewTextBoxColumn.HeaderText = "NumQuarto";
            numQuartoDataGridViewTextBoxColumn.Name = "numQuartoDataGridViewTextBoxColumn";
            numQuartoDataGridViewTextBoxColumn.ReadOnly = true;
            numQuartoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            checkInDataGridViewTextBoxColumn.DataPropertyName = "Check_In";
            checkInDataGridViewTextBoxColumn.HeaderText = "Check_In";
            checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            checkInDataGridViewTextBoxColumn.ReadOnly = true;
            checkInDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // previsCheckOutDataGridViewTextBoxColumn
            // 
            previsCheckOutDataGridViewTextBoxColumn.DataPropertyName = "Previs_Check_Out";
            previsCheckOutDataGridViewTextBoxColumn.HeaderText = "Previs_Check_Out";
            previsCheckOutDataGridViewTextBoxColumn.Name = "previsCheckOutDataGridViewTextBoxColumn";
            previsCheckOutDataGridViewTextBoxColumn.ReadOnly = true;
            previsCheckOutDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // checkOutDataGridViewTextBoxColumn
            // 
            checkOutDataGridViewTextBoxColumn.DataPropertyName = "Check_Out";
            checkOutDataGridViewTextBoxColumn.HeaderText = "Check_Out";
            checkOutDataGridViewTextBoxColumn.Name = "checkOutDataGridViewTextBoxColumn";
            checkOutDataGridViewTextBoxColumn.ReadOnly = true;
            checkOutDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // diariaDataGridViewTextBoxColumn
            // 
            diariaDataGridViewTextBoxColumn.DataPropertyName = "Diaria";
            diariaDataGridViewTextBoxColumn.HeaderText = "Diaria";
            diariaDataGridViewTextBoxColumn.Name = "diariaDataGridViewTextBoxColumn";
            diariaDataGridViewTextBoxColumn.ReadOnly = true;
            diariaDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // diasHospedagemDataGridViewTextBoxColumn
            // 
            diasHospedagemDataGridViewTextBoxColumn.DataPropertyName = "DiasHospedagem";
            diasHospedagemDataGridViewTextBoxColumn.HeaderText = "Dias";
            diasHospedagemDataGridViewTextBoxColumn.Name = "diasHospedagemDataGridViewTextBoxColumn";
            diasHospedagemDataGridViewTextBoxColumn.ReadOnly = true;
            diasHospedagemDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // totalDiariaDataGridViewTextBoxColumn
            // 
            totalDiariaDataGridViewTextBoxColumn.DataPropertyName = "TotalDiaria";
            totalDiariaDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDiariaDataGridViewTextBoxColumn.Name = "totalDiariaDataGridViewTextBoxColumn";
            totalDiariaDataGridViewTextBoxColumn.ReadOnly = true;
            totalDiariaDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // numHospedesDataGridViewTextBoxColumn
            // 
            numHospedesDataGridViewTextBoxColumn.DataPropertyName = "NumHospedes";
            numHospedesDataGridViewTextBoxColumn.HeaderText = "Hospedes";
            numHospedesDataGridViewTextBoxColumn.Name = "numHospedesDataGridViewTextBoxColumn";
            numHospedesDataGridViewTextBoxColumn.ReadOnly = true;
            numHospedesDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            statusDataGridViewTextBoxColumn1.ReadOnly = true;
            statusDataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            // 
            // bsQuarto
            // 
            bsQuarto.DataSource = typeof(Umi_Library.Class.classQuartoEstadia);
            // 
            // dataGridEstadias
            // 
            dataGridEstadias.AllowUserToAddRows = false;
            dataGridEstadias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.LightBlue;
            dataGridEstadias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridEstadias.AutoGenerateColumns = false;
            dataGridEstadias.BackgroundColor = Color.FromArgb(192, 255, 192);
            dataGridEstadias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEstadias.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, Column1, docDataGridViewTextBoxColumn, clienteIdDataGridViewTextBoxColumn, codCliDataGridViewTextBoxColumn, emissaoDataGridViewTextBoxColumn, fechamentoDataGridViewTextBoxColumn, vTotalDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dataGridEstadias.DataSource = bsEstadia;
            dataGridEstadias.Font = new Font("Times New Roman", 10F);
            dataGridEstadias.Location = new Point(33, 103);
            dataGridEstadias.MultiSelect = false;
            dataGridEstadias.Name = "dataGridEstadias";
            dataGridEstadias.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = Color.Beige;
            dataGridEstadias.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridEstadias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEstadias.Size = new Size(849, 377);
            dataGridEstadias.TabIndex = 4;
            dataGridEstadias.CellClick += dataGridEstadias_CellClick;
            dataGridEstadias.CellContentClick += dataGridEstadias_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.Frozen = true;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.DataPropertyName = "NomeCLiente";
            Column1.Frozen = true;
            Column1.HeaderText = "Nome";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 206;
            // 
            // docDataGridViewTextBoxColumn
            // 
            docDataGridViewTextBoxColumn.DataPropertyName = "doc";
            docDataGridViewTextBoxColumn.Frozen = true;
            docDataGridViewTextBoxColumn.HeaderText = "Doc";
            docDataGridViewTextBoxColumn.Name = "docDataGridViewTextBoxColumn";
            docDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            clienteIdDataGridViewTextBoxColumn.Frozen = true;
            clienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId";
            clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            clienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            clienteIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            clienteIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // codCliDataGridViewTextBoxColumn
            // 
            codCliDataGridViewTextBoxColumn.DataPropertyName = "CodCli";
            codCliDataGridViewTextBoxColumn.Frozen = true;
            codCliDataGridViewTextBoxColumn.HeaderText = "Cod. Cli.";
            codCliDataGridViewTextBoxColumn.Name = "codCliDataGridViewTextBoxColumn";
            codCliDataGridViewTextBoxColumn.ReadOnly = true;
            codCliDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // emissaoDataGridViewTextBoxColumn
            // 
            emissaoDataGridViewTextBoxColumn.DataPropertyName = "Emissao";
            emissaoDataGridViewTextBoxColumn.Frozen = true;
            emissaoDataGridViewTextBoxColumn.HeaderText = "Emissao";
            emissaoDataGridViewTextBoxColumn.Name = "emissaoDataGridViewTextBoxColumn";
            emissaoDataGridViewTextBoxColumn.ReadOnly = true;
            emissaoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // fechamentoDataGridViewTextBoxColumn
            // 
            fechamentoDataGridViewTextBoxColumn.DataPropertyName = "Fechamento";
            fechamentoDataGridViewTextBoxColumn.Frozen = true;
            fechamentoDataGridViewTextBoxColumn.HeaderText = "Fechado";
            fechamentoDataGridViewTextBoxColumn.Name = "fechamentoDataGridViewTextBoxColumn";
            fechamentoDataGridViewTextBoxColumn.ReadOnly = true;
            fechamentoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // vTotalDataGridViewTextBoxColumn
            // 
            vTotalDataGridViewTextBoxColumn.DataPropertyName = "VTotal";
            vTotalDataGridViewTextBoxColumn.Frozen = true;
            vTotalDataGridViewTextBoxColumn.HeaderText = "Valor";
            vTotalDataGridViewTextBoxColumn.Name = "vTotalDataGridViewTextBoxColumn";
            vTotalDataGridViewTextBoxColumn.ReadOnly = true;
            vTotalDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.Frozen = true;
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // bsEstadia
            // 
            bsEstadia.DataSource = typeof(Umi_Library.Class.classEstadia);
            // 
            // telaInicioEstadia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 833);
            Controls.Add(tablePai);
            MaximumSize = new Size(931, 872);
            MinimumSize = new Size(931, 872);
            Name = "telaInicioEstadia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "telaInicioEstadia";
            Load += telaInicioEstadia_Load;
            Shown += telaInicioEstadia_Shown;
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableButon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridQuartos).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsQuarto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEstadias).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEstadia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private Label labelTitulo;
        private TableLayoutPanel tableButon;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnVoltar;
        private BindingSource bsEstadia;
        private BindingSource bsQuarto;
        private Componentes.novoDataGrid dataGridEstadias;
        private Componentes.novoDataGrid dataGridQuartos;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn estadiaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quartoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numQuartoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn previsCheckOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diariaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diasHospedagemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDiariaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numHospedesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn docDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codCliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emissaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}