namespace Aula_1___respondendo_perguntas
{
    partial class frmCadastroCNPJ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCNPJ));
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNFantsaia = new System.Windows.Forms.TextBox();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbtnInformacoes = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.pbCSenha = new System.Windows.Forms.PictureBox();
            this.pbCSenha2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCSenha2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCNPJ
            // 
            resources.ApplyResources(this.lblCNPJ, "lblCNPJ");
            this.lblCNPJ.Name = "lblCNPJ";
            // 
            // lblRazaoSocial
            // 
            resources.ApplyResources(this.lblRazaoSocial, "lblRazaoSocial");
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            // 
            // lblNomeFantasia
            // 
            resources.ApplyResources(this.lblNomeFantasia, "lblNomeFantasia");
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            // 
            // lblEndereco
            // 
            resources.ApplyResources(this.lblEndereco, "lblEndereco");
            this.lblEndereco.Name = "lblEndereco";
            // 
            // lblNumero
            // 
            resources.ApplyResources(this.lblNumero, "lblNumero");
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // lblBairro
            // 
            resources.ApplyResources(this.lblBairro, "lblBairro");
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Click += new System.EventHandler(this.lblBairro_Click);
            // 
            // lblCep
            // 
            resources.ApplyResources(this.lblCep, "lblCep");
            this.lblCep.Name = "lblCep";
            this.lblCep.Click += new System.EventHandler(this.lblCep_Click);
            // 
            // lblContato
            // 
            resources.ApplyResources(this.lblContato, "lblContato");
            this.lblContato.Name = "lblContato";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // txtNFantsaia
            // 
            resources.ApplyResources(this.txtNFantsaia, "txtNFantsaia");
            this.txtNFantsaia.Name = "txtNFantsaia";
            // 
            // txtRSocial
            // 
            resources.ApplyResources(this.txtRSocial, "txtRSocial");
            this.txtRSocial.Name = "txtRSocial";
            // 
            // txtEndereco
            // 
            resources.ApplyResources(this.txtEndereco, "txtEndereco");
            this.txtEndereco.Name = "txtEndereco";
            // 
            // txtNumero
            // 
            resources.ApplyResources(this.txtNumero, "txtNumero");
            this.txtNumero.Name = "txtNumero";
            // 
            // txtBairro
            // 
            resources.ApplyResources(this.txtBairro, "txtBairro");
            this.txtBairro.Name = "txtBairro";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // rbtnInformacoes
            // 
            resources.ApplyResources(this.rbtnInformacoes, "rbtnInformacoes");
            this.rbtnInformacoes.Name = "rbtnInformacoes";
            this.rbtnInformacoes.TabStop = true;
            this.rbtnInformacoes.UseVisualStyleBackColor = true;
            this.rbtnInformacoes.CheckedChanged += new System.EventHandler(this.rbtnInformacoes_CheckedChanged);
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbUF
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            resources.GetString("cbUF.Items"),
            resources.GetString("cbUF.Items1"),
            resources.GetString("cbUF.Items2"),
            resources.GetString("cbUF.Items3"),
            resources.GetString("cbUF.Items4"),
            resources.GetString("cbUF.Items5"),
            resources.GetString("cbUF.Items6"),
            resources.GetString("cbUF.Items7"),
            resources.GetString("cbUF.Items8"),
            resources.GetString("cbUF.Items9"),
            resources.GetString("cbUF.Items10"),
            resources.GetString("cbUF.Items11"),
            resources.GetString("cbUF.Items12"),
            resources.GetString("cbUF.Items13"),
            resources.GetString("cbUF.Items14"),
            resources.GetString("cbUF.Items15"),
            resources.GetString("cbUF.Items16"),
            resources.GetString("cbUF.Items17"),
            resources.GetString("cbUF.Items18"),
            resources.GetString("cbUF.Items19"),
            resources.GetString("cbUF.Items20"),
            resources.GetString("cbUF.Items21"),
            resources.GetString("cbUF.Items22"),
            resources.GetString("cbUF.Items23"),
            resources.GetString("cbUF.Items24"),
            resources.GetString("cbUF.Items25"),
            resources.GetString("cbUF.Items26")});
            resources.ApplyResources(this.cbUF, "cbUF");
            this.cbUF.Name = "cbUF";
            this.cbUF.SelectedIndexChanged += new System.EventHandler(this.cbUF_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // mskTelefone
            // 
            resources.ApplyResources(this.mskTelefone, "mskTelefone");
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskCNPJ
            // 
            resources.ApplyResources(this.mskCNPJ, "mskCNPJ");
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskCEP
            // 
            resources.ApplyResources(this.mskCEP, "mskCEP");
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtSenha
            // 
            resources.ApplyResources(this.txtSenha, "txtSenha");
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.UseWaitCursor = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtConfirmarSenha
            // 
            resources.ApplyResources(this.txtConfirmarSenha, "txtConfirmarSenha");
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            // 
            // pbCSenha
            // 
            resources.ApplyResources(this.pbCSenha, "pbCSenha");
            this.pbCSenha.Image = global::Aula_1___respondendo_perguntas.Properties.Resources.view;
            this.pbCSenha.Name = "pbCSenha";
            this.pbCSenha.TabStop = false;
            this.pbCSenha.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pbCSenha2
            // 
            resources.ApplyResources(this.pbCSenha2, "pbCSenha2");
            this.pbCSenha2.Image = global::Aula_1___respondendo_perguntas.Properties.Resources.view;
            this.pbCSenha2.Name = "pbCSenha2";
            this.pbCSenha2.TabStop = false;
            this.pbCSenha2.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // frmCadastroCNPJ
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.pbCSenha2);
            this.Controls.Add(this.pbCSenha);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.mskCNPJ);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.rbtnInformacoes);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtRSocial);
            this.Controls.Add(this.txtNFantsaia);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.lblCNPJ);
            this.Name = "frmCadastroCNPJ";
            this.Load += new System.EventHandler(this.frmCadastroCNPJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCSenha2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNFantsaia;
        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbtnInformacoes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.PictureBox pbCSenha;
        private System.Windows.Forms.PictureBox pbCSenha2;
        private System.Windows.Forms.TextBox txtSenha;
    }
}