using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_1___respondendo_perguntas
{
    public partial class txtLimpar : Form
    {
        public txtLimpar()
        {
            InitializeComponent();
        }

        private void FrmIsabele_Load(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String Validade = DTPValidade.Value.ToString("yyyy-MM-dd");
            String Fabricacao = DTPFabricacao.Value.ToString("yyyy-MM-dd");
            string codigo = txtCodigo.Text;
            string Lote = txtLote.Text;
            string Nome = txtNome.Text;
            string Valor = txtValor.Text;
            string Categoria = txtCategoria.Text;
            string mensagem = $"Nome do Produto: {Nome}\n" +

                              $"Código de Barras: {codigo}\n" +

                              $"Lote: {Lote}\n" +

                              $"Categoria do Produto:{Categoria}\n"+
                              
                              $"Valor: {Valor:C}\n" +

                              $"Vencimento: {Validade}\n" +
                            
                              $"Data de Fabricação: {Fabricacao}";

            //Ao inves do menssage box jogar para o banco de dados 

            MessageBox.Show(mensagem, "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);






        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            txtLote.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtDescricao.Text = string.Empty;   
            txtValor.Text = string.Empty;
            DTPValidade.Value = DateTime.Now;
            DTPFabricacao.Value = DateTime.Now;
        }
    }
}
