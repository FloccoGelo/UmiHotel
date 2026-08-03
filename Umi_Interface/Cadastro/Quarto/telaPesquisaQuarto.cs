using Biblioteca.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umi_Library.Banco;
using Umi_Library.Class;

namespace Umi_Interface.Estadia
{
    public partial class telaPesquisaQuarto : Form
    {
        classQuarto _quarto = new classQuarto();
        Context _context = new Context();
        quartoDAL _dal;
        public telaPesquisaQuarto()
        {
            _dal = new quartoDAL(_context);
            InitializeComponent();
        }

        private void telaPesquisaQuarto_Load(object sender, EventArgs e)
        {
            listar();
            dataGrid.ClearSelection();
            radioDescricao.Checked = true;
            radioNumero.Checked = false;
        }

        private String campoPesquisa()
        {
            String campo;
            if (radioNumero.Checked)
            {
                campo = "NUMERO";
            }
            else
            {
                campo = "DESCRICAO";
            }
            return campo;
        }

        private void listar()
        {
            String j = textPesquisa.Text;
            List<classQuarto> listaQ = _dal.trazerListaQuarto(campoPesquisa(), j, "s");

            bsLista.DataSource = listaQ;
            dataGrid.DataSource = bsLista;
        }

        public int idSelecionado;
        private void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (bsLista.Current is classQuarto quart)
            {
                idSelecionado = quart.Id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("ID NAO SELECIONADO :( :( :(");
            }
        }


        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            listar();
        }
    }
}
