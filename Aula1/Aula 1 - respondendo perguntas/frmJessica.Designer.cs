﻿namespace Aula_1___respondendo_perguntas
{
    partial class frmJessica
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
            this.lblFormadepagamento = new System.Windows.Forms.Label();
            this.ckbCredito = new System.Windows.Forms.CheckBox();
            this.ckbDebito = new System.Windows.Forms.CheckBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDataDeValidade = new System.Windows.Forms.Label();
            this.lblNumeroDoCartao = new System.Windows.Forms.Label();
            this.lblNomeNoCartao = new System.Windows.Forms.Label();
            this.btnConfirmarPagamento = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNomeNoCartao = new System.Windows.Forms.TextBox();
            this.txtNumeroDoCartao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtpDataDeValidade = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblFormadepagamento
            // 
            this.lblFormadepagamento.AutoSize = true;
            this.lblFormadepagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFormadepagamento.Location = new System.Drawing.Point(47, 27);
            this.lblFormadepagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormadepagamento.Name = "lblFormadepagamento";
            this.lblFormadepagamento.Size = new System.Drawing.Size(130, 13);
            this.lblFormadepagamento.TabIndex = 0;
            this.lblFormadepagamento.Text = "Forma de Pagamento:";
            // 
            // ckbCredito
            // 
            this.ckbCredito.AutoSize = true;
            this.ckbCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ckbCredito.Location = new System.Drawing.Point(198, 23);
            this.ckbCredito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbCredito.Name = "ckbCredito";
            this.ckbCredito.Size = new System.Drawing.Size(66, 17);
            this.ckbCredito.TabIndex = 2;
            this.ckbCredito.Text = "Crédito";
            this.ckbCredito.UseVisualStyleBackColor = false;
            // 
            // ckbDebito
            // 
            this.ckbDebito.AutoSize = true;
            this.ckbDebito.Location = new System.Drawing.Point(198, 70);
            this.ckbDebito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckbDebito.Name = "ckbDebito";
            this.ckbDebito.Size = new System.Drawing.Size(63, 17);
            this.ckbDebito.TabIndex = 3;
            this.ckbDebito.Text = "Débito";
            this.ckbDebito.UseVisualStyleBackColor = true;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCpf.Location = new System.Drawing.Point(50, 133);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(92, 13);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF do titular :";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCodigo.Location = new System.Drawing.Point(47, 323);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código :";
            // 
            // lblDataDeValidade
            // 
            this.lblDataDeValidade.AutoSize = true;
            this.lblDataDeValidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDataDeValidade.Location = new System.Drawing.Point(47, 278);
            this.lblDataDeValidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDeValidade.Name = "lblDataDeValidade";
            this.lblDataDeValidade.Size = new System.Drawing.Size(112, 13);
            this.lblDataDeValidade.TabIndex = 7;
            this.lblDataDeValidade.Text = "Data de validade :";
            // 
            // lblNumeroDoCartao
            // 
            this.lblNumeroDoCartao.AutoSize = true;
            this.lblNumeroDoCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNumeroDoCartao.Location = new System.Drawing.Point(47, 227);
            this.lblNumeroDoCartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDoCartao.Name = "lblNumeroDoCartao";
            this.lblNumeroDoCartao.Size = new System.Drawing.Size(116, 13);
            this.lblNumeroDoCartao.TabIndex = 8;
            this.lblNumeroDoCartao.Text = "Número do cartão :";
            // 
            // lblNomeNoCartao
            // 
            this.lblNomeNoCartao.AutoSize = true;
            this.lblNomeNoCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNomeNoCartao.Location = new System.Drawing.Point(47, 175);
            this.lblNomeNoCartao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeNoCartao.Name = "lblNomeNoCartao";
            this.lblNomeNoCartao.Size = new System.Drawing.Size(105, 13);
            this.lblNomeNoCartao.TabIndex = 9;
            this.lblNomeNoCartao.Text = "Nome no cartão :";
            // 
            // btnConfirmarPagamento
            // 
            this.btnConfirmarPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConfirmarPagamento.Location = new System.Drawing.Point(530, 358);
            this.btnConfirmarPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfirmarPagamento.Name = "btnConfirmarPagamento";
            this.btnConfirmarPagamento.Size = new System.Drawing.Size(145, 51);
            this.btnConfirmarPagamento.TabIndex = 10;
            this.btnConfirmarPagamento.Text = "Confirmar pagamento";
            this.btnConfirmarPagamento.UseVisualStyleBackColor = false;
            this.btnConfirmarPagamento.Click += new System.EventHandler(this.btnConfirmarPagamento_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(169, 133);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(158, 20);
            this.txtCpf.TabIndex = 11;
            // 
            // txtNomeNoCartao
            // 
            this.txtNomeNoCartao.Location = new System.Drawing.Point(169, 168);
            this.txtNomeNoCartao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomeNoCartao.Name = "txtNomeNoCartao";
            this.txtNomeNoCartao.Size = new System.Drawing.Size(233, 20);
            this.txtNomeNoCartao.TabIndex = 12;
            // 
            // txtNumeroDoCartao
            // 
            this.txtNumeroDoCartao.Location = new System.Drawing.Point(169, 220);
            this.txtNumeroDoCartao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumeroDoCartao.Name = "txtNumeroDoCartao";
            this.txtNumeroDoCartao.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroDoCartao.TabIndex = 13;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(132, 316);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo.TabIndex = 14;
            // 
            // dtpDataDeValidade
            // 
            this.dtpDataDeValidade.CustomFormat = "MM/yy";
            this.dtpDataDeValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataDeValidade.Location = new System.Drawing.Point(169, 272);
            this.dtpDataDeValidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDataDeValidade.MaxDate = new System.DateTime(9998, 12, 1, 0, 0, 0, 0);
            this.dtpDataDeValidade.Name = "dtpDataDeValidade";
            this.dtpDataDeValidade.Size = new System.Drawing.Size(233, 20);
            this.dtpDataDeValidade.TabIndex = 15;
            this.dtpDataDeValidade.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // frmJessica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.dtpDataDeValidade);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNumeroDoCartao);
            this.Controls.Add(this.txtNomeNoCartao);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnConfirmarPagamento);
            this.Controls.Add(this.lblNomeNoCartao);
            this.Controls.Add(this.lblNumeroDoCartao);
            this.Controls.Add(this.lblDataDeValidade);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.ckbDebito);
            this.Controls.Add(this.ckbCredito);
            this.Controls.Add(this.lblFormadepagamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmJessica";
            this.Text = "Compra de selo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormadepagamento;
        private System.Windows.Forms.CheckBox ckbCredito;
        private System.Windows.Forms.CheckBox ckbDebito;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDataDeValidade;
        private System.Windows.Forms.Label lblNumeroDoCartao;
        private System.Windows.Forms.Label lblNomeNoCartao;
        private System.Windows.Forms.Button btnConfirmarPagamento;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNomeNoCartao;
        private System.Windows.Forms.TextBox txtNumeroDoCartao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dtpDataDeValidade;
    }
}