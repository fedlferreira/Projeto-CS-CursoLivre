﻿
namespace ProjetoMosquitoVelho
{
    partial class frmListarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarProdutos));
            this.btnCarregar = new System.Windows.Forms.Button();
            this.ltbListaProdutos = new System.Windows.Forms.ListBox();
            this.cbbProdutos = new System.Windows.Forms.ComboBox();
            this.lbLProdutos = new System.Windows.Forms.Label();
            this.lblListaProdutos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbListarItens = new System.Windows.Forms.ComboBox();
            this.btnTestarPessoa = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTestaPessoa = new System.Windows.Forms.Label();
            this.txtDigitaNome = new System.Windows.Forms.TextBox();
            this.lblDigiteSeuNome = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumeroDoCartao = new System.Windows.Forms.Label();
            this.lblMostrarDoc = new System.Windows.Forms.Label();
            this.lblMostrarCar = new System.Windows.Forms.Label();
            this.mkdNumeroDoCartao = new System.Windows.Forms.MaskedTextBox();
            this.btnTestaLogin = new System.Windows.Forms.Button();
            this.txtTestaLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCarregar.Location = new System.Drawing.Point(458, 386);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(92, 37);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "&Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // ltbListaProdutos
            // 
            this.ltbListaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ltbListaProdutos.FormattingEnabled = true;
            this.ltbListaProdutos.ItemHeight = 20;
            this.ltbListaProdutos.Location = new System.Drawing.Point(458, 96);
            this.ltbListaProdutos.Name = "ltbListaProdutos";
            this.ltbListaProdutos.Size = new System.Drawing.Size(185, 284);
            this.ltbListaProdutos.TabIndex = 1;
            // 
            // cbbProdutos
            // 
            this.cbbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbProdutos.FormattingEnabled = true;
            this.cbbProdutos.Location = new System.Drawing.Point(29, 74);
            this.cbbProdutos.Name = "cbbProdutos";
            this.cbbProdutos.Size = new System.Drawing.Size(121, 28);
            this.cbbProdutos.TabIndex = 2;
            // 
            // lbLProdutos
            // 
            this.lbLProdutos.AutoSize = true;
            this.lbLProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbLProdutos.Location = new System.Drawing.Point(25, 39);
            this.lbLProdutos.Name = "lbLProdutos";
            this.lbLProdutos.Size = new System.Drawing.Size(73, 20);
            this.lbLProdutos.TabIndex = 3;
            this.lbLProdutos.Tag = "";
            this.lbLProdutos.Text = "Produtos";
            // 
            // lblListaProdutos
            // 
            this.lblListaProdutos.AutoSize = true;
            this.lblListaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblListaProdutos.Location = new System.Drawing.Point(455, 61);
            this.lblListaProdutos.Name = "lblListaProdutos";
            this.lblListaProdutos.Size = new System.Drawing.Size(136, 20);
            this.lblListaProdutos.TabIndex = 4;
            this.lblListaProdutos.Text = "Lista De Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(201, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 6;
            this.label1.Tag = "";
            this.label1.Text = "Listar Itens";
            // 
            // cbbListarItens
            // 
            this.cbbListarItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbListarItens.FormattingEnabled = true;
            this.cbbListarItens.Location = new System.Drawing.Point(205, 74);
            this.cbbListarItens.Name = "cbbListarItens";
            this.cbbListarItens.Size = new System.Drawing.Size(121, 28);
            this.cbbListarItens.TabIndex = 5;
            this.cbbListarItens.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbListarItens_MouseClick);
            // 
            // btnTestarPessoa
            // 
            this.btnTestarPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTestarPessoa.Location = new System.Drawing.Point(12, 260);
            this.btnTestarPessoa.Name = "btnTestarPessoa";
            this.btnTestarPessoa.Size = new System.Drawing.Size(92, 37);
            this.btnTestarPessoa.TabIndex = 7;
            this.btnTestarPessoa.Text = "Testar Pessoa";
            this.btnTestarPessoa.UseVisualStyleBackColor = true;
            this.btnTestarPessoa.Click += new System.EventHandler(this.btnTestarPessoa_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(6, 401);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 37);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblTestaPessoa
            // 
            this.lblTestaPessoa.AutoSize = true;
            this.lblTestaPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTestaPessoa.Location = new System.Drawing.Point(130, 234);
            this.lblTestaPessoa.Name = "lblTestaPessoa";
            this.lblTestaPessoa.Size = new System.Drawing.Size(0, 20);
            this.lblTestaPessoa.TabIndex = 9;
            this.lblTestaPessoa.Tag = "";
            // 
            // txtDigitaNome
            // 
            this.txtDigitaNome.Location = new System.Drawing.Point(12, 234);
            this.txtDigitaNome.Name = "txtDigitaNome";
            this.txtDigitaNome.Size = new System.Drawing.Size(100, 20);
            this.txtDigitaNome.TabIndex = 10;
            // 
            // lblDigiteSeuNome
            // 
            this.lblDigiteSeuNome.AutoSize = true;
            this.lblDigiteSeuNome.Location = new System.Drawing.Point(13, 218);
            this.lblDigiteSeuNome.Name = "lblDigiteSeuNome";
            this.lblDigiteSeuNome.Size = new System.Drawing.Size(87, 13);
            this.lblDigiteSeuNome.TabIndex = 11;
            this.lblDigiteSeuNome.Text = "Digite Seu Nome";
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReservar.Location = new System.Drawing.Point(12, 309);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(92, 37);
            this.btnReservar.TabIndex = 12;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(162, 325);
            this.txtDocumento.MaxLength = 15;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(127, 20);
            this.txtDocumento.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Digite Seu Documento";
            // 
            // lblNumeroDoCartao
            // 
            this.lblNumeroDoCartao.AutoSize = true;
            this.lblNumeroDoCartao.Location = new System.Drawing.Point(159, 367);
            this.lblNumeroDoCartao.Name = "lblNumeroDoCartao";
            this.lblNumeroDoCartao.Size = new System.Drawing.Size(99, 13);
            this.lblNumeroDoCartao.TabIndex = 18;
            this.lblNumeroDoCartao.Text = "Digite N. Do Cartão";
            // 
            // lblMostrarDoc
            // 
            this.lblMostrarDoc.AutoSize = true;
            this.lblMostrarDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMostrarDoc.Location = new System.Drawing.Point(281, 232);
            this.lblMostrarDoc.Name = "lblMostrarDoc";
            this.lblMostrarDoc.Size = new System.Drawing.Size(0, 20);
            this.lblMostrarDoc.TabIndex = 19;
            this.lblMostrarDoc.Tag = "";
            // 
            // lblMostrarCar
            // 
            this.lblMostrarCar.AutoSize = true;
            this.lblMostrarCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMostrarCar.Location = new System.Drawing.Point(281, 277);
            this.lblMostrarCar.Name = "lblMostrarCar";
            this.lblMostrarCar.Size = new System.Drawing.Size(0, 20);
            this.lblMostrarCar.TabIndex = 20;
            this.lblMostrarCar.Tag = "";
            // 
            // mkdNumeroDoCartao
            // 
            this.mkdNumeroDoCartao.Location = new System.Drawing.Point(162, 386);
            this.mkdNumeroDoCartao.Mask = "000,0000,000,000-00";
            this.mkdNumeroDoCartao.Name = "mkdNumeroDoCartao";
            this.mkdNumeroDoCartao.Size = new System.Drawing.Size(127, 20);
            this.mkdNumeroDoCartao.TabIndex = 21;
            // 
            // btnTestaLogin
            // 
            this.btnTestaLogin.Location = new System.Drawing.Point(29, 123);
            this.btnTestaLogin.Name = "btnTestaLogin";
            this.btnTestaLogin.Size = new System.Drawing.Size(75, 23);
            this.btnTestaLogin.TabIndex = 22;
            this.btnTestaLogin.Text = "Testar Login";
            this.btnTestaLogin.UseVisualStyleBackColor = true;
            this.btnTestaLogin.Click += new System.EventHandler(this.btnTestaLogin_Click);
            // 
            // txtTestaLogin
            // 
            this.txtTestaLogin.Location = new System.Drawing.Point(205, 123);
            this.txtTestaLogin.Name = "txtTestaLogin";
            this.txtTestaLogin.Size = new System.Drawing.Size(100, 20);
            this.txtTestaLogin.TabIndex = 23;
            // 
            // frmListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTestaLogin);
            this.Controls.Add(this.btnTestaLogin);
            this.Controls.Add(this.mkdNumeroDoCartao);
            this.Controls.Add(this.lblMostrarCar);
            this.Controls.Add(this.lblMostrarDoc);
            this.Controls.Add(this.lblNumeroDoCartao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.lblDigiteSeuNome);
            this.Controls.Add(this.txtDigitaNome);
            this.Controls.Add(this.lblTestaPessoa);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnTestarPessoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbListarItens);
            this.Controls.Add(this.lblListaProdutos);
            this.Controls.Add(this.lbLProdutos);
            this.Controls.Add(this.cbbProdutos);
            this.Controls.Add(this.ltbListaProdutos);
            this.Controls.Add(this.btnCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarProdutos";
            this.Load += new System.EventHandler(this.cbbListarItens_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ListBox ltbListaProdutos;
        private System.Windows.Forms.ComboBox cbbProdutos;
        private System.Windows.Forms.Label lbLProdutos;
        private System.Windows.Forms.Label lblListaProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbListarItens;
        private System.Windows.Forms.Button btnTestarPessoa;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTestaPessoa;
        private System.Windows.Forms.TextBox txtDigitaNome;
        private System.Windows.Forms.Label lblDigiteSeuNome;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeroDoCartao;
        private System.Windows.Forms.Label lblMostrarDoc;
        private System.Windows.Forms.Label lblMostrarCar;
        private System.Windows.Forms.MaskedTextBox mkdNumeroDoCartao;
        private System.Windows.Forms.Button btnTestaLogin;
        private System.Windows.Forms.TextBox txtTestaLogin;
    }
}