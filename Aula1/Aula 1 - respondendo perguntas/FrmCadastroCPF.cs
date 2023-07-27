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
    public partial class frmCadastroCPF : Form
    {
        public frmCadastroCPF()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = mskCpf.Text;
            string nome = txtNome.Text;
            string sexo = cmbBxSexo.Text;
            string nascimento = mskNascimento.Text;
            string uf = txtUf.Text;
            string naturalidade = txtNaturalidade.Text;
            string endereco = txtEndereco.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro.Text;
            string cep = mskCep.Text;
            string telefone = mskTelefone.Text;
            string email = txtEmail.Text;
            string confirmar = rdBtnConfirmar.Text;
            string senha = txtSenha.Text;
            string confirmarsenha = txtCSenha.Text;
            string message = "";

            if(message == "")
            {
                MessageBox.Show("Preencha todos os campos!"); 
            }
            if (cpf == "")
            {
                mskCpf.BackColor= Color.PaleVioletRed;             
            }
            if (nome == "")
            {
                txtNome.BackColor= Color.PaleVioletRed;
            }
            if (sexo == "")
            {
                cmbBxSexo.BackColor = Color.PaleVioletRed;
            }
            if (nascimento == "")
            {
                mskNascimento.BackColor = Color.PaleVioletRed;
            }
            if (uf == "")
            {
                txtUf.BackColor = Color.PaleVioletRed;
            }
            if (naturalidade == "")
            {
                txtNaturalidade.BackColor = Color.PaleVioletRed;
            }
            if (endereco == "")
            {
                txtEndereco.BackColor = Color.PaleVioletRed;
            }
            if (numero == "")
            {
                mskNascimento.BackColor = Color.PaleVioletRed;
            }
            if (bairro == "")
            {
                txtBairro.BackColor = Color.PaleVioletRed;
            }
            if (cep == "")
            {
                mskCep.BackColor = Color.PaleVioletRed;
            }
            if (telefone == "")
            {
                mskTelefone.BackColor = Color.PaleVioletRed;
            }
            if (email == "")
            {
                txtEmail.BackColor = Color.PaleVioletRed;
            }
            if (confirmar == "")
            {
                rdBtnConfirmar.BackColor = Color.PaleVioletRed;
            }
            if (senha == "")
            {
                txtSenha.BackColor = Color.PaleVioletRed;
            }
            if (confirmarsenha == "")
            {
                txtCSenha.BackColor = Color.PaleVioletRed;
            }

            else if 
                (cpf != "" ^ nome != "" ^ sexo != "" ^ nascimento != "" ^ uf != "" ^ naturalidade != "" ^ endereco != "" ^ numero != "" ^ bairro != "" ^ cep != "" ^ telefone != "" ^ email != "" ^ confirmar != "" ^ senha != "" ^ confirmarsenha != "")
            {
                MessageBox.Show("Cadastro concluído!");
            }
               
        }

        private void cmbBxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sexo = cmbBxSexo.SelectedItem.ToString();
        }

        private void rdBtnConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
