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

namespace Umi_Interface.Cadastro.Quarto
{
    public partial class novoQuarto : Form
    {
        Context _context = new Context();
        quartoDAL _quartoDAL;
        public novoQuarto()
        {
            _quartoDAL = new quartoDAL(_context);
            InitializeComponent();
        }
        private void novoQuarto_Load(object sender, EventArgs e)
        {
            comboAtivo.SelectedIndex = 0;
        }

        private string resultAtivo;
        private int resultPreco;
        private string gerarAtivo()
        {
            if(comboAtivo.Text == "Sim")
            {
                resultAtivo = "S";
            } else
            {
                resultAtivo = "N";
            }
            return resultAtivo;
        }
        private int gerarPreco()
        {
            if (string.IsNullOrWhiteSpace(maskValAtual.Text) || 
                string.IsNullOrWhiteSpace(maskValBase.Text))
            {
                resultPreco = 0;
            }
                return resultPreco;
        }



        private classQuarto salvarQuarto()
        {
            classQuarto novoQuarto = new classQuarto()
            {
                Numero = textNumero.Text,
                Tipo = comboTipo.Text,
                Capacidade = int.Parse(numericCapacidade.Text),
                NumSolt = int.Parse(numericSolteiro.Text),
                NumCasal = int.Parse(numericCasal.Text),
                Ativo = comboAtivo.Text,
                Status = comboStatus.Text,
                Descricao = textDescricao.Text,
                Created = DateTime.Now,
                Modified = DateTime.Now,

            };
            novoQuarto.Ativo = gerarAtivo();
            if(gerarPreco() == 0)
            {
                novoQuarto.PrecoAtual = 0;
                novoQuarto.PrecoBase = 0;
            } else
            {
                novoQuarto.PrecoBase = decimal.Parse(maskValBase.Text);
                novoQuarto.PrecoAtual = decimal.Parse(maskValAtual.Text);
            }
                return novoQuarto;
        }
        int verificar;
        private int validarCamposVazios()
        {
            if (
                textNumero.Text == "" ||
                comboTipo.Text == "" ||
                numericCapacidade.Text == "" ||
                numericCasal.Text == "" ||
                numericSolteiro.Text == ""
                )
            {
                verificar = 1;
            }
            return verificar;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validarCamposVazios() == 1)
            {
                MessageBox.Show(@"Há campos obrigatorios nao preenchidos
                Verifique os seguintes campos:

                Numero do Quarto,
                Categoria,
                Capacidade,
                Numero de camas de casal,
                Numero de camas de solteiro");

                verificar = 0;
            } else
            {
                //classQuarto adicionar = new classQuarto();
                //adicionar = salvarQuarto();

                _quartoDAL.Adicionar(salvarQuarto());
                MessageBox.Show("Quarto cadastrado com sucesso ;)");
                this.Close();
            }
        }


    }
}
