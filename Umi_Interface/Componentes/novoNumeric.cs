using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umi_Interface.Componentes
{
    public partial class novoNumeric : NumericUpDown
    {
        public novoNumeric()
        {
            InitializeComponent();
            ConfigurarAparencia();
        }
        public novoNumeric(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            ConfigurarAparencia();
        }

        private void ConfigurarAparencia()
        {
            this.KeyDown += novoNumeric_KeyDown;
        }

        private void novoNumeric_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                Form form = this.FindForm();

                if (form != null)
                {
                    form.SelectNextControl(
                        this,
                        true,
                        true,
                        true,
                        true);
                }
            }
        }
    }
}