using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Aula_1___respondendo_perguntas
{
    public partial class frmCadastroCNPJ : Form
    {
        public frmCadastroCNPJ()
        {
            InitializeComponent();
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
            string senha = txtSenha.Text;
            string confirmarsenha = txtConfirmarSenha.Text;

            if (cnpj == "")
            {
                mskCNPJ.BackColor = Color.PaleVioletRed;
            }
            else
            {
                mskCNPJ.BackColor = Color.White;
            }
            if (razao == "")
            {
                txtRSocial.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtRSocial.BackColor = Color.White;
            }
            if (nome == "")
            {
                txtNFantsaia.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtNFantsaia.BackColor = Color.White;
            }
            if (endereco == "")
            {
                txtEndereco.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtEndereco.BackColor = Color.White;
            }
            if (numero == "")
            {
                txtNumero.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtNumero.BackColor = Color.White;
            }
            if (bairro == "")
            {
                txtBairro.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBairro.BackColor = Color.White;
            }
            if (cep == "")
            {
                mskCEP.BackColor = Color.PaleVioletRed;
            }
            else
            {
                mskCEP.BackColor = Color.White;
            }
            if (estado == "")
            {
                cbUF.BackColor = Color.PaleVioletRed;
            }
            else
            {
                cbUF.BackColor = Color.White;
            }
            if (telefone == "")
            {
                mskTelefone.BackColor = Color.PaleVioletRed;
            }
            else
            {
                mskTelefone.BackColor = Color.White;
            }
            if (email == "")
            {
                txtEmail.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }
            if (senha == "")
            {
                txtSenha.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtSenha.BackColor = Color.White;
            }
            if (confirmarsenha == "")
            {
                txtConfirmarSenha.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtConfirmarSenha.BackColor = Color.White;
            }
            if (cnpj == "" || razao == "" || nome == "" || endereco == "" || numero == "" || bairro == "" || cep == "" || estado == "" || telefone == "" || email == "" || senha == "" || confirmarsenha == "")
            {
                MessageBox.Show("Prencha todos os campos!");
            }
            else
            {
                MessageBox.Show("Cadastro concluído");
            }
        }
        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cbUF.SelectedItem.ToString();
        }
        private void txtEmail_Validated(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            if (!regex.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("E-mail Inválido!");
                txtEmail.BackColor = Color.PaleVioletRed;
                txtEmail.Focus();
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.PasswordChar == '*')
            {
                txtConfirmarSenha.PasswordChar = '\0';
                pbCSenha2.Image = Image.FromFile(@"..\..\Imagens\view.png");
                txtConfirmarSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmarSenha.PasswordChar = '*';
                pbCSenha2.Image = Image.FromFile(@"..\..\Imagens\hide.png");
                txtConfirmarSenha.UseSystemPasswordChar = false;
            }
        }
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0';
                pbCSenha2.Image = Image.FromFile(@"..\..\Imagens\view.png");
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                pbCSenha2.Image = Image.FromFile(@"..\..\Imagens\hide.png");
                txtSenha.UseSystemPasswordChar = false;
            }
        }
    }
}
