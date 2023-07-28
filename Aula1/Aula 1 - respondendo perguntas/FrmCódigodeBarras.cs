using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_1___respondendo_perguntas
{
    public partial class FrmCódigodeBarras : Form
    {
        public FrmCódigodeBarras()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string cod = textBoxDigCod.Text;
            if ( cod == "")
             {
                MessageBox.Show ("Digite algum código de barras");
                return;
             }

            MessageBox.Show("Código:" + cod);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDigiteCod_Click(object sender, EventArgs e)
        {

        }
    }
}
