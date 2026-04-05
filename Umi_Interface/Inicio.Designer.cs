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
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.DarkSeaGreen;
            btnCliente.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCliente.ForeColor = SystemColors.ControlText;
            btnCliente.Location = new Point(73, 319);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(124, 67);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCliente);
            Name = "Inicio";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCliente;
    }
}
