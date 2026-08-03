namespace Umi_Interface
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCliente = new Button();
            btnQuarto = new Button();
            btnEstadia = new Button();
            btnRecebidas = new Button();
            button1 = new Button();
            btnContasContabeis = new Button();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.DarkSeaGreen;
            btnCliente.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCliente.ForeColor = SystemColors.ControlText;
            btnCliente.Location = new Point(65, 319);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(152, 67);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnQuarto
            // 
            btnQuarto.BackColor = Color.FromArgb(255, 192, 128);
            btnQuarto.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnQuarto.ForeColor = SystemColors.ControlText;
            btnQuarto.Location = new Point(223, 319);
            btnQuarto.Name = "btnQuarto";
            btnQuarto.Size = new Size(152, 67);
            btnQuarto.TabIndex = 1;
            btnQuarto.Text = "Quartos";
            btnQuarto.UseVisualStyleBackColor = false;
            btnQuarto.Click += btnQuarto_Click;
            // 
            // btnEstadia
            // 
            btnEstadia.BackColor = SystemColors.ActiveCaption;
            btnEstadia.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEstadia.Location = new Point(381, 319);
            btnEstadia.Name = "btnEstadia";
            btnEstadia.Size = new Size(152, 67);
            btnEstadia.TabIndex = 2;
            btnEstadia.Text = "Estadia";
            btnEstadia.UseVisualStyleBackColor = false;
            btnEstadia.Click += btnEstadia_Click;
            // 
            // btnRecebidas
            // 
            btnRecebidas.BackColor = Color.FromArgb(128, 255, 255);
            btnRecebidas.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRecebidas.Location = new Point(539, 319);
            btnRecebidas.Name = "btnRecebidas";
            btnRecebidas.Size = new Size(152, 67);
            btnRecebidas.TabIndex = 3;
            btnRecebidas.Text = "Recebidas";
            btnRecebidas.UseVisualStyleBackColor = false;
            btnRecebidas.Click += btnRecebidas_Click;
            // 
            // button1
            // 
            button1.Location = new Point(486, 158);
            button1.Name = "button1";
            button1.Size = new Size(216, 126);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnContasContabeis
            // 
            btnContasContabeis.BackColor = Color.FromArgb(255, 255, 128);
            btnContasContabeis.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnContasContabeis.Location = new Point(65, 232);
            btnContasContabeis.Name = "btnContasContabeis";
            btnContasContabeis.Size = new Size(175, 67);
            btnContasContabeis.TabIndex = 5;
            btnContasContabeis.Text = "Conta-Contabil";
            btnContasContabeis.UseVisualStyleBackColor = false;
            btnContasContabeis.Click += btnContasContabeis_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContasContabeis);
            Controls.Add(button1);
            Controls.Add(btnRecebidas);
            Controls.Add(btnEstadia);
            Controls.Add(btnQuarto);
            Controls.Add(btnCliente);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCliente;
        private Button btnQuarto;
        private Button btnEstadia;
        private Button btnRecebidas;
        private Button button1;
        private Button btnContasContabeis;
    }
}
