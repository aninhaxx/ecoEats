﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

            if (cpf == "")
            {
                mskCpf.BackColor= Color.PaleVioletRed;             
            }
            else
            {
                mskCpf.BackColor = Color.White;
            }
            if (nome == "")
            {
                txtNome.BackColor= Color.PaleVioletRed;
            }
            else
            {
                txtNome.BackColor = Color.White;
            }
            if (sexo == "")
            {
                cmbBxSexo.BackColor = Color.PaleVioletRed;
            }
            else
            {
                cmbBxSexo.BackColor = Color.White;
            }
            if (nascimento == "")
            {
                mskNascimento.BackColor = Color.PaleVioletRed;
            }
            else
            {
                mskNascimento.BackColor = Color.White;
            }
            if (uf == "")
            {
                txtUf.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtUf.BackColor = Color.White;
            }
            if (naturalidade == "")
            {
                txtNaturalidade.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtNaturalidade.BackColor = Color.White;
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
                mskCep.BackColor = Color.PaleVioletRed;
            }
            else
            {
                mskCep.BackColor = Color.White;
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
                txtCSenha.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtCSenha.BackColor = Color.White;
            }

            if 
                (cpf == "" || nome == "" || sexo == "" || nascimento == "" || uf == "" || naturalidade == "" || endereco == "" || numero == "" || bairro == "" || cep == "" || telefone == "" || email == "" || senha == "" || confirmarsenha == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            if (!regex.IsMatch(email))
            {
                MessageBox.Show("Email inválido!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pbSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0'; 
                pbSenha.Image = Image.FromFile(@"..\..\Imagens\view.png");
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.PasswordChar = '*'; 
                pbSenha.Image = Image.FromFile(@"..\..\Imagens\hide.png");
                txtSenha.UseSystemPasswordChar = false;
            }
            
        }

        private void pbConfirmarSenha_Click(object sender, EventArgs e)
        {

            if (txtCSenha.PasswordChar == '*')
            {
                txtCSenha.PasswordChar = '\0'; 
                pbConfirmarSenha.Image = Image.FromFile(@"..\..\Imagens\view.png");
                txtCSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtCSenha.PasswordChar = '*'; 
                pbConfirmarSenha.Image = Image.FromFile(@"..\..\Imagens\hide.png");
                txtCSenha.UseSystemPasswordChar = false;
            }
        }
    }
} 
