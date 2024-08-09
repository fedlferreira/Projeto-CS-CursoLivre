
namespace ProjetoMosquitoVelho
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.gpbOperacao = new System.Windows.Forms.GroupBox();
            this.rbtnSoma = new System.Windows.Forms.RadioButton();
            this.rbtnSub = new System.Windows.Forms.RadioButton();
            this.rbtnMult = new System.Windows.Forms.RadioButton();
            this.rbtnDiv = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbOperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValor1.Location = new System.Drawing.Point(17, 38);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(59, 20);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValor2.Location = new System.Drawing.Point(261, 38);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(59, 20);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Valor 2";
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValor1.Location = new System.Drawing.Point(12, 69);
            this.txtValor1.MaxLength = 7;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 26);
            this.txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValor2.Location = new System.Drawing.Point(261, 69);
            this.txtValor2.MaxLength = 7;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 26);
            this.txtValor2.TabIndex = 6;
            // 
            // gpbOperacao
            // 
            this.gpbOperacao.Controls.Add(this.rbtnDiv);
            this.gpbOperacao.Controls.Add(this.rbtnMult);
            this.gpbOperacao.Controls.Add(this.rbtnSub);
            this.gpbOperacao.Controls.Add(this.rbtnSoma);
            this.gpbOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbOperacao.Location = new System.Drawing.Point(127, 25);
            this.gpbOperacao.Name = "gpbOperacao";
            this.gpbOperacao.Size = new System.Drawing.Size(119, 148);
            this.gpbOperacao.TabIndex = 1;
            this.gpbOperacao.TabStop = false;
            this.gpbOperacao.Text = "Operações";
            // 
            // rbtnSoma
            // 
            this.rbtnSoma.AutoSize = true;
            this.rbtnSoma.Location = new System.Drawing.Point(6, 25);
            this.rbtnSoma.Name = "rbtnSoma";
            this.rbtnSoma.Size = new System.Drawing.Size(74, 24);
            this.rbtnSoma.TabIndex = 2;
            this.rbtnSoma.TabStop = true;
            this.rbtnSoma.Text = "&Somar";
            this.rbtnSoma.UseVisualStyleBackColor = true;
            // 
            // rbtnSub
            // 
            this.rbtnSub.AutoSize = true;
            this.rbtnSub.Location = new System.Drawing.Point(6, 55);
            this.rbtnSub.Name = "rbtnSub";
            this.rbtnSub.Size = new System.Drawing.Size(83, 24);
            this.rbtnSub.TabIndex = 3;
            this.rbtnSub.TabStop = true;
            this.rbtnSub.Text = "Su&btrair";
            this.rbtnSub.UseVisualStyleBackColor = true;
            // 
            // rbtnMult
            // 
            this.rbtnMult.AutoSize = true;
            this.rbtnMult.Location = new System.Drawing.Point(6, 85);
            this.rbtnMult.Name = "rbtnMult";
            this.rbtnMult.Size = new System.Drawing.Size(97, 24);
            this.rbtnMult.TabIndex = 4;
            this.rbtnMult.TabStop = true;
            this.rbtnMult.Text = "&Multiplicar";
            this.rbtnMult.UseVisualStyleBackColor = true;
            // 
            // rbtnDiv
            // 
            this.rbtnDiv.AutoSize = true;
            this.rbtnDiv.Location = new System.Drawing.Point(6, 115);
            this.rbtnDiv.Name = "rbtnDiv";
            this.rbtnDiv.Size = new System.Drawing.Size(69, 24);
            this.rbtnDiv.TabIndex = 5;
            this.rbtnDiv.TabStop = true;
            this.rbtnDiv.Text = "&Dividir";
            this.rbtnDiv.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResultado.Location = new System.Drawing.Point(252, 152);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(86, 20);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblResp
            // 
            this.lblResp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResp.Location = new System.Drawing.Point(333, 151);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(142, 20);
            this.lblResp.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Window;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(333, 98);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(61, 49);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(421, 98);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(54, 51);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Window;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(421, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 51);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sai&r";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(487, 218);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gpbOperacao);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.gpbOperacao.ResumeLayout(false);
            this.gpbOperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.GroupBox gpbOperacao;
        private System.Windows.Forms.RadioButton rbtnDiv;
        private System.Windows.Forms.RadioButton rbtnMult;
        private System.Windows.Forms.RadioButton rbtnSub;
        private System.Windows.Forms.RadioButton rbtnSoma;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}