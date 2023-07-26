using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_1___respondendo_perguntas
{
    public partial class frmCadastroCNPJ : Form
    {
        public frmCadastroCNPJ()
        {
            InitializeComponent();
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void lblBairro_Click(object sender, EventArgs e)
        {

        }

        private void lblCep_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cnpj = mskCNPJ.Text;
            string razao = txtRSocial.Text;
            string nome = txtNFantsaia.Text;
            string endereco = txtEndereco.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro.Text;
            string cep = mskCEP.Text;
            string estado = cbUF.Text;
            string telefone = mskTelefone.Text;
            string email = txtEmail.Text;

            string confirmar = rbtnInformacoes.Text;

            if (cnpj == "" || razao =="" || nome == "" || endereco == "" || numero == ""|| bairro == "" || cep == "" || estado == "" || telefone == "" || email == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }

           else
            {
                MessageBox.Show("Cadastro concluído!");
            } 
            
        }
    }
}
