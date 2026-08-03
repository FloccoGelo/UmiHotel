namespace Umi_Interface.Avisos
{
    partial class avisoOk
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
            btnOK = new Button();
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
            tablePai.Size = new Size(634, 161);
            tablePai.TabIndex = 0;
            // 
            // tableBTN
            // 
            tableBTN.ColumnCount = 2;
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableBTN.Controls.Add(btnOK, 0, 1);
            tableBTN.Dock = DockStyle.Fill;
            tableBTN.Location = new Point(28, 83);
            tableBTN.Name = "tableBTN";
            tableBTN.RowCount = 2;
            tableBTN.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableBTN.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableBTN.Size = new Size(578, 62);
            tableBTN.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.FromArgb(192, 255, 192);
            btnOK.Dock = DockStyle.Fill;
            btnOK.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(3, 15);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(114, 44);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK!";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // mensagem
            // 
            mensagem.AutoSize = true;
            mensagem.Dock = DockStyle.Fill;
            mensagem.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mensagem.Location = new Point(28, 12);
            mensagem.Name = "mensagem";
            mensagem.Size = new Size(578, 68);
            mensagem.TabIndex = 2;
            mensagem.Text = "mensagem";
            mensagem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // avisoOk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 161);
            Controls.Add(tablePai);
            KeyPreview = true;
            MaximumSize = new Size(650, 200);
            MinimumSize = new Size(650, 200);
            Name = "avisoOk";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ok";
            tablePai.ResumeLayout(false);
            tablePai.PerformLayout();
            tableBTN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablePai;
        private Button btnOK;
        private TableLayoutPanel tableBTN;
        private Label mensagem;
    }
}