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
    public partial class FrmCadastroCPF : Form
    {
        public FrmCadastroCPF()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = mskCpf.Text;
            string nome = txtNome.Text;
            string sexo = cmbBxSexo.Text;
            string nascimento = dateNascimento.Text;
            string uf = txtUf.Text;
            string naturalidade = txtNaturalidade.Text;
            string endereco = txtEndereco.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro.Text;
            string cep = mskCep.Text;
            string telefone = mskTelefone.Text;
            string email = txtEmail.Text;
            string confirmar = rdBtnConfirmar.Text;

            if (cpf == "" || nome == "" || sexo == "" || nascimento == "" || uf == "" || naturalidade == "" || endereco == "" || numero == "" || bairro == "" || cep == "" || telefone == "" || email == "" || confirmar == "")
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
