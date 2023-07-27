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

    

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            // Redireciona para a tela da ana
            MessageBox.Show("Tela em construção!");

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string documento = txtCPF_CNPJ.Text;
            string senha = txtSenha.Text;
            if (documento == "" || senha == "")
            {
                if(documento == "" && senha == "")
                {
                    txtCPF_CNPJ.BackColor = Color.Tomato;
                    txtSenha.BackColor = Color.Tomato;
                }
                
                else if (documento == "")
                {
                    txtCPF_CNPJ.BackColor = Color.Tomato;
                }
                else if(senha == "")
                {
                  txtSenha.BackColor = Color.Tomato;
                }
                MessageBox.Show("Preencha todos os campos!!");
                txtCPF_CNPJ.BackColor = Color.White;
                txtSenha.BackColor = Color.White;
                return;
            }
        }

        private void lblMostrarEsconder_Click(object sender, EventArgs e)
        {
            bool mostrar = txtSenha.UseSystemPasswordChar;
            if (mostrar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                lblMostrarEsconder.Text = "Esconder senha";
                mostrar = false;
            }
            else if (mostrar == false)
            {
                txtSenha.UseSystemPasswordChar = true;
                lblMostrarEsconder.Text = "Mostrar senha";
            }
        }
    }
}
