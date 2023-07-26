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


            //estou declarando as variaveis para elas ficarem salvas no Botão salvar
            String Validade = DTPValidade.Value.ToString("yyyy-MM-dd");
            String Fabricacao = DTPFabricacao.Value.ToString("yyyy-MM-dd");
            string codigo = txtCodigo.Text;
            string Lote = txtLote.Text;
            string Nome = txtNome.Text;
            string Valor = txtValor.Text;
            string Categoria = CBCategoria.Text;
            //na proxima linha eu fiz uma variavel para aparecer esta mensagem no mensagem boox.show
            // $ este simbolo de cifrão serve para concatenar a mensagem igual ao simbolo de +
            string mensagem = $"Nome do Produto: {Nome}\n" +

                              $"Código de Barras: {codigo}\n" +

                              $"Lote: {Lote}\n" +

                              $"Categoria do Produto:{Categoria}\n"+
                              
                              $"Valor: {Valor:C}\n" +

                              $"Vencimento: {Validade}\n" +
                            
                              $"Data de Fabricação: {Fabricacao}";

            //Ao inves do menssage box, jogar para o banco de dados (depois)
            // este MessageBoxButtons serve para eu criar uma caixa com o ok ou o que eu quiser confirmar 
            // o messageBoxIcon serve para eu colocar o simbolo de informação na message show
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
