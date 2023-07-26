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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string documento = txtCPF_CNPJ.Text;
            string senha = txtSenha.Text;
            if (documento =="" || senha=="")
            {
               
                MessageBox.Show("Preencha todos os campos!!");
                return;
            }
        }

        private void lblMostarEsconder_Click(object sender, EventArgs e)
        {
            bool mostrar = txtSenha.UseSystemPasswordChar;
            if (mostrar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                lblMostarEsconder.Text = "Esconder senha";
                mostrar = false;
            }
            else if (mostrar==false)
            {
                txtSenha.UseSystemPasswordChar = true;
                lblMostarEsconder.Text = "Mostrar senha";
            }
        }

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            // Redireciona para a tela da ana
            MessageBox.Show("Tela em construção!");

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
