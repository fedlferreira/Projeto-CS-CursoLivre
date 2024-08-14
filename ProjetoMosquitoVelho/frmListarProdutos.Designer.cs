
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
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCarregar.Location = new System.Drawing.Point(12, 321);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(92, 37);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
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
            // frmListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}