namespace Umi_Interface.Avisos
{
    partial class avisoConfirmar
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
            tablePai = new TableLayoutPanel();
            tableBTN = new TableLayoutPanel();
            btnSim = new Button();
            btnNao = new Button();
            mensagem = new Label();
            tablePai.SuspendLayout();
            tableBTN.SuspendLayout();
            SuspendLayout();
            // 
            // tablePai
            // 
            tablePai.BackColor = Color.FromArgb(192, 192, 255);
            tablePai.ColumnCount = 3;
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePai.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tablePai.Controls.Add(tableBTN, 1, 2);
            tablePai.Controls.Add(mensagem, 1, 1);
            tablePai.Dock = DockStyle.Fill;
            tablePai.Location = new Point(0, 0);
            tablePai.Name = "tablePai";
            tablePai.RowCount = 4;
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePai.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tablePai.Size = new Size(684, 221);
            tablePai.TabIndex = 0;
            // 
            // tableBTN
            // 
            tableBTN.ColumnCount = 3;
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableBTN.Controls.Add(btnSim, 0, 1);
            tableBTN.Controls.Add(btnNao, 1, 1);
            tableBTN.Dock = DockStyle.Fill;
            tableBTN.Location = new Point(28, 113);
            tableBTN.Name = "tableBTN";
            tableBTN.RowCount = 2;
            tableBTN.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableBTN.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableBTN.Size = new Size(628, 92);
            tableBTN.TabIndex = 1;
            // 
            // btnSim
            // 
            btnSim.BackColor = Color.FromArgb(192, 255, 192);
            btnSim.Dock = DockStyle.Fill;
            btnSim.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSim.Location = new Point(3, 45);
            btnSim.Name = "btnSim";
            btnSim.Size = new Size(114, 44);
            btnSim.TabIndex = 0;
            btnSim.Text = "Sim";
            btnSim.UseVisualStyleBackColor = false;
            btnSim.Click += btnSim_Click;
            // 
            // btnNao
            // 
            btnNao.BackColor = Color.FromArgb(255, 192, 192);
            btnNao.Dock = DockStyle.Fill;
            btnNao.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNao.Location = new Point(123, 45);
            btnNao.Name = "btnNao";
            btnNao.Size = new Size(114, 44);
            btnNao.TabIndex = 1;
            btnNao.Text = "Não";
            btnNao.UseVisualStyleBackColor = false;
            btnNao.Click += btnNao_Click;
            // 
            // mensagem
            // 
            mensagem.AutoSize = true;
            mensagem.Dock = DockStyle.Fill;
            mensagem.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mensagem.Location = new Point(28, 12);
            mensagem.Name = "mensagem";
            mensagem.Size = new Size(628, 98);
            mensagem.TabIndex = 2;
            mensagem.Text = "mensagem";
            mensagem.TextAlign = ContentAlignment.MiddleCenter;
            mensagem.Click += mensagem_Click;
            // 
            // avisoConfirmar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 221);
            Controls.Add(tablePai);
            KeyPreview = true;
            MaximumSize = new Size(650, 200);
            MinimumSize = new Size(650, 200);
            Name = "avisoConfirmar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "avisoConfirmar";
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableBTN.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tablePai;
        private Label mensagem;
        private TableLayoutPanel tableBTN;
        private Button btnSim;
        private Button btnNao;
    }
}