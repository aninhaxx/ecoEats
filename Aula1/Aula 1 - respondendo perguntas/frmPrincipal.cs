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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lbl2.Text = "O projeto tem como um objetivo um sistema que possuirá um score da pegada de carbono e valor nutricional de certo produto alimentício dado seu código de barras";
            lbl4.Text = "1- Identificação do produto: o sistema irá identificar um produto a partir de um código de barras\n" +
                "2- Score: com a identificação do produto será gerado um score que será calculado a partir da sua pegada de carbono api\n" +
                "3- Selo: De acordo com o score do produto será gerado um selo de qualidade que poderá ser comprado pelas empresas.\n" +
                "4- Cadastro do produto: Cada produto identificado será cadastrado no sistema.\n" +
                  "5- Conexão com a API: o sistema irá se apoiar em uma API para realizar suas funções.";
            lbl6.Text = "1- Experiência do usuário: o sistema irá contar um design que facilitará sua usabilidade.\n" +
                "2- Integração para deficiência visual: o sistema irá ter habilitação auditiva dos componentes de interface.";

            lblForças.Text = "Nós temos API´s \n" +
            "Proximidades com o tema";
            lblF.Text = "Pouco conhecimento prático \n" +
                "Organização fraca";
            lblO.Text = "Acesso a ferramentas";
            lblA.Text = "Tempo curto de\n" +
                "desenvolvimento";

            string[,] swot = new string[2, 2];
            swot [0, 0] = "Nós temos API´s \n" +
            "Proximidades com o tema";
            swot [0, 1] = "Pouco conhecimento prático \n" +
                "Organização fraca";
            swot [1, 0] = "Acesso a ferramentas";
            swot [1, 1] = "Tempo curto de\n" +
                "desenvolvimento";

            lblForças.Text = swot[0, 0];
            lblF.Text = swot[0, 1];
            lblO.Text = swot[1, 0];
            lblA.Text = swot[1, 1];


            string[] vetorDeAPIs = new string[7];

            vetorDeAPIs[0] = "NinjaNutritionAPI-(Jéssica)\n" +
                "https://api-ninjas.com/api/nutrition";
            vetorDeAPIs[1] = "DietGramAPI-(Vivian)\n" +
                "https://rapidapi.com/bulat.yauheni/api/dietagram/";
            vetorDeAPIs[2] = "Food SKU-CO2-Impact-API-(Luíza)\n" +
                "https://rapidapi.com/greenswapp-api-greenswapp-api-default/api/food-sku-co2-impact-api/";
            vetorDeAPIs[3] = "Chomp Food & Nutrition Database(Bea)-\n" +
                "https://rapidapi.com/chomp/api/chomp-food-nutrition-database-v2";
            vetorDeAPIs[4] = "Sustainability(Isabele)\n" +
                "https://rapidapi.com/greenchoice-greenchoice-default/api/food-diet-nutrition-sustainability ";
            vetorDeAPIs[5] = "Edamam Food and Grocery Database(Ana)-\n" +
                "https://rapidapi.com/edamam/api/edamam-food-and-grocery-database/";
            vetorDeAPIs[6] = "Product Lookup by UPC or EAN(Alana)-\n" +
                "https://rapidapi.com/go-upc-go-upc-default/api/product-lookup-by-upc-or-ean/details";

            string textoAPIs = "";
            for (int i = 0; i < vetorDeAPIs.Length; i++)
            {
                textoAPIs += vetorDeAPIs[i] + "\n";
            }

            lblAPIs.Text = textoAPIs;



        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void lblO_Click(object sender, EventArgs e)
        {

        }

        private void lblF_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal lblIdade = numericUpDownI.Value;
            decimal lblFuncionários = numericUpDownF.Value;
            if (lblIdade < 38 && lblIdade >= 24 && lblFuncionários > 100 && lblFuncionários <= 500)
            {
                lblResposta.Text = "Usuário aprovado";
            }
            else
            {
                lblResposta.Text = "Usuário não aprovado";
            }
        }

        private void btnJessica_Click(object sender, EventArgs e)
        {
            Form frmJessica = new frmJessica();
            frmJessica.WindowState = FormWindowState.Normal;
            frmJessica.Show();

        }
    }
}
