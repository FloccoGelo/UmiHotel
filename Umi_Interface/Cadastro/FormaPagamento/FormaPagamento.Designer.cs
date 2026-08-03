namespace Umi_Interface.Cadastro
{
    partial class FormaPagamento
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
            button1 = new Button();
            labelTitulo = new Label();
            dataGridFormas = new Umi_Interface.Componentes.novoDataGrid();
            bsFormas = new BindingSource(components);
            tablePai.SuspendLayout();
            tableBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFormas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsFormas).BeginInit();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.BackColor = Color.White;
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.05391526F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97.94608F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tablePai.Controls.Add(tableBtn, 1, 2);
            tablePai.Controls.Add(labelTitulo, 1, 0);
            tablePai.Controls.Add(dataGridFormas, 1, 1);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 4;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 20.74592F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 79.25408F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablePai.Size = new Size(544, 620);
            tablePai.TabIndex = 0;
            // 
            // tableBtn
            // 
            tableBtn.ColumnCount = 2;
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.0594454F));
            tableBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.94055F));
            tableBtn.Controls.Add(button1, 0, 1);
            tableBtn.Dock = DockStyle.Fill;
            tableBtn.Location = new Point(13, 494);
            tableBtn.Name = "tableBtn";
            tableBtn.RowCount = 2;
            tableBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableBtn.Size = new Size(507, 102);
            tableBtn.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 54);
            button1.Name = "button1";
            button1.Size = new Size(70, 45);
            button1.TabIndex = 0;
            button1.Text = "Novo";
            button1.UseVisualStyleBackColor = false;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(160, 39);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(213, 24);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Formas de Pagamento";
            // 
            // dataGridFormas
            // 
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridFormas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridFormas.BackgroundColor = Color.White;
            dataGridFormas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFormas.Dock = DockStyle.Fill;
            dataGridFormas.Font = new Font("Times New Roman", 10F);
            dataGridFormas.Location = new Point(13, 105);
            dataGridFormas.MultiSelect = false;
            dataGridFormas.Name = "dataGridFormas";
            dataGridViewCellStyle2.BackColor = Color.Beige;
            dataGridFormas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridFormas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridFormas.Size = new Size(507, 383);
            dataGridFormas.TabIndex = 2;
            // 
            // FormaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 620);
            Controls.Add(tablePai);
            Name = "FormaPagamento";
            Text = "FormaPagamento";
            Load += FormaPagamento_Load;
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridFormas).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsFormas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private TableLayoutPanel tableBtn;
        private Button button1;
        private Label labelTitulo;
        private Componentes.novoDataGrid dataGridFormas;
        private BindingSource bsFormas;
    }
}