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

            string confirmar = rbtnInformacoes.Text;

        

            if (cnpj == "" ^ razao == "" ^ nome == "" ^ endereco == "" ^ numero == "" ^ bairro == "" ^ cep == "" ^ estado == "" ^ telefone == "" ^ email == "" ^ senha == "" ^ confirmarsenha == "")
                MessageBox.Show("Prencha todos os campos!");
            if (cnpj == "")
            {
                mskCNPJ.BackColor = Color.PaleVioletRed;
            }
            if(razao == "")
            {
                txtRSocial.BackColor = Color.PaleVioletRed;  
            }
            if(nome == "")
            {
                txtNFantsaia.BackColor = Color.PaleVioletRed;                
            }
            if(endereco == "")
            {
                txtEndereco.BackColor = Color.PaleVioletRed;               
            }
            if(numero == "")
            {
                txtNumero.BackColor = Color.PaleVioletRed;               
            }
            if(bairro == "")
            {
                txtBairro.BackColor = Color.PaleVioletRed;                
            }
            if(cep == "")
            {
                mskCEP.BackColor = Color.PaleVioletRed;
            }
            if(estado == "")
            {
                cbUF.BackColor = Color.PaleVioletRed;
            }
            if(telefone == "")
            {
                mskTelefone.BackColor = Color.PaleVioletRed;               
            }
            if(email == "")
            {
                txtEmail.BackColor = Color.PaleVioletRed;               
            }
            if(senha =="")
            {
                txtSenha.BackColor = Color.PaleVioletRed;             
            }
            if(confirmarsenha == "")
            {
                txtConfirmarSenha.BackColor = Color.PaleVioletRed;               
            
            
            
               
            }
            else
            {
                MessageBox.Show("Cadastro concluído!");
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
