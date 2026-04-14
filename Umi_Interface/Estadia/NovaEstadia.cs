using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umi_Library.Class;
using Umi_Library.Banco;
using Biblioteca.Banco;

namespace Umi_Interface.Estadia
{
    public partial class NovaEstadia : Form
    {
        Context _context = new Context();
        clienteDAL _dal;
        public NovaEstadia()
        {
            _dal = new clienteDAL(_context);
            InitializeComponent();
        }
        int id;
        public NovaEstadia(int idRecebido)
        {
            this.id = idRecebido;
            InitializeComponent();
        }
        private void NovaEstadia_Load(object sender, EventArgs e)
        {
            
            if (id > 0)
            {
                preencherCliente();
            }
        }


        // ----------------------
        // ----------- BOTAO

        private void buttonPesquisaCliente_Click(object sender, EventArgs e)
        {            
            using (telaPesquisaCliente pesquisa = new telaPesquisaCliente())
            {
                if(pesquisa.ShowDialog() == DialogResult.OK)
                {
                    id = pesquisa._idSelecionado;
                    MessageBox.Show("ID recebido com sucesso " + id);
                }
            }
        }


        // -------------------------
        // ------------- BINDING


        private classCliente preencherCliente()
        {
            var clienteVenda = _dal.BuscarID(id);
            bsCliente.DataSource = clienteVenda;

            pesquisaCPF.DataBindings.Clear();
            pesquisaNomeCli.DataBindings.Clear();

            pesquisaCPF.DataBindings.Add("Text", bsCliente, "Nome");
            pesquisaNomeCli.DataBindings.Add("Text", bsCliente, "CPF");

            return clienteVenda;
        }
    }
}
