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
            if(razao == "")
            {
                txtRSocial.BackColor = Color.PaleVioletRed;  
            }
            else
            {
                txtRSocial.BackColor = Color.White;
            }
            if(nome == "")
            {
                txtNFantsaia.BackColor = Color.PaleVioletRed;                
            }
            else
            {
                txtNFantsaia.BackColor = Color.White;
            }
            if(endereco == "")
            {
                txtEndereco.BackColor = Color.PaleVioletRed;               
            }
            else
            {
                txtEndereco.BackColor = Color.White;
            }
            if(numero == "")
            {
                txtNumero.BackColor = Color.PaleVioletRed;               
            }
            else
            {
                txtNumero.BackColor = Color.White;
            }
            if(bairro == "")
            {
                txtBairro.BackColor = Color.PaleVioletRed;                
            }
            else
            {
                txtBairro.BackColor = Color.White;
            }
            if(cep == "")
            {
                mskCEP.BackColor = Color.PaleVioletRed;
            }
            else
            {
                mskCEP.BackColor = Color.White;
            }
            if(estado == "")
            {
                cbUF.BackColor = Color.PaleVioletRed;
            }
            else
            {
                cbUF.BackColor = Color.White;
            }
            if(telefone == "")
            {
                mskTelefone.BackColor = Color.PaleVioletRed;               
            }
            else
            {
                mskTelefone.BackColor = Color.White;
            }
            if(email == "")
            {
                txtEmail.BackColor = Color.PaleVioletRed;               
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }
            if(senha =="")
            {
                txtSenha.BackColor = Color.PaleVioletRed;             
            }
            else
            {
                txtSenha.BackColor = Color.White;
            }
            if(confirmarsenha == "")
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

        private void frmCadastroCNPJ_Load(object sender, EventArgs e)
        {

        }

        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cbUF.SelectedItem.ToString();
        }

        private void rbtnInformacoes_CheckedChanged(object sender, EventArgs e)
        {
               
        }
    }
}
