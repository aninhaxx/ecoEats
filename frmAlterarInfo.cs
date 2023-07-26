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
    public partial class frmAlterarInfo : Form
    {
        public frmAlterarInfo()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string confirmação = "";
            if (rbtnEmail.Checked == true)
            {
                confirmação = "Email";

            }
            else
            {
                confirmação = "celular";
            }

            string email = lblEmail.Text;

            string novasenha = lblNSenha.Text;

            string recuperasenha = lblRsenha.Text;

            string confirmasenha = lblConfirm.Text;



        }

          private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
          
            txtNsenha.UseSystemPasswordChar = false; 

            txtRsenha.UseSystemPasswordChar = false; 

            

        }

        private void txtNsenha_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
