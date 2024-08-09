
namespace ProjetoMosquitoVelho
{
    partial class frmComponentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.chbLivro = new System.Windows.Forms.CheckBox();
            this.chbPescar = new System.Windows.Forms.CheckBox();
            this.chbDormir = new System.Windows.Forms.CheckBox();
            this.chbCafe = new System.Windows.Forms.CheckBox();
            this.rbtnViajar = new System.Windows.Forms.RadioButton();
            this.rbtnComer = new System.Windows.Forms.RadioButton();
            this.rbtnMega = new System.Windows.Forms.RadioButton();
            this.rbtnAviao = new System.Windows.Forms.RadioButton();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbLivro
            // 
            this.chbLivro.AutoSize = true;
            this.chbLivro.Location = new System.Drawing.Point(0, 25);
            this.chbLivro.Name = "chbLivro";
            this.chbLivro.Size = new System.Drawing.Size(61, 24);
            this.chbLivro.TabIndex = 0;
            this.chbLivro.Text = "Livro";
            this.chbLivro.UseVisualStyleBackColor = true;
            // 
            // chbPescar
            // 
            this.chbPescar.AutoSize = true;
            this.chbPescar.Location = new System.Drawing.Point(0, 71);
            this.chbPescar.Name = "chbPescar";
            this.chbPescar.Size = new System.Drawing.Size(77, 24);
            this.chbPescar.TabIndex = 1;
            this.chbPescar.Text = "Pescar";
            this.chbPescar.UseVisualStyleBackColor = true;
            // 
            // chbDormir
            // 
            this.chbDormir.AutoSize = true;
            this.chbDormir.Location = new System.Drawing.Point(0, 125);
            this.chbDormir.Name = "chbDormir";
            this.chbDormir.Size = new System.Drawing.Size(75, 24);
            this.chbDormir.TabIndex = 2;
            this.chbDormir.Text = "Dormir";
            this.chbDormir.UseVisualStyleBackColor = true;
            // 
            // chbCafe
            // 
            this.chbCafe.AutoSize = true;
            this.chbCafe.Location = new System.Drawing.Point(0, 170);
            this.chbCafe.Name = "chbCafe";
            this.chbCafe.Size = new System.Drawing.Size(62, 24);
            this.chbCafe.TabIndex = 3;
            this.chbCafe.Text = "Café";
            this.chbCafe.UseVisualStyleBackColor = true;
            // 
            // rbtnViajar
            // 
            this.rbtnViajar.AutoSize = true;
            this.rbtnViajar.Location = new System.Drawing.Point(6, 25);
            this.rbtnViajar.Name = "rbtnViajar";
            this.rbtnViajar.Size = new System.Drawing.Size(67, 24);
            this.rbtnViajar.TabIndex = 4;
            this.rbtnViajar.TabStop = true;
            this.rbtnViajar.Text = "Viajar";
            this.rbtnViajar.UseVisualStyleBackColor = true;
            // 
            // rbtnComer
            // 
            this.rbtnComer.AutoSize = true;
            this.rbtnComer.Location = new System.Drawing.Point(6, 70);
            this.rbtnComer.Name = "rbtnComer";
            this.rbtnComer.Size = new System.Drawing.Size(74, 24);
            this.rbtnComer.TabIndex = 5;
            this.rbtnComer.TabStop = true;
            this.rbtnComer.Text = "Comer";
            this.rbtnComer.UseVisualStyleBackColor = true;
            // 
            // rbtnMega
            // 
            this.rbtnMega.AutoSize = true;
            this.rbtnMega.Location = new System.Drawing.Point(5, 114);
            this.rbtnMega.Name = "rbtnMega";
            this.rbtnMega.Size = new System.Drawing.Size(67, 24);
            this.rbtnMega.TabIndex = 6;
            this.rbtnMega.TabStop = true;
            this.rbtnMega.Text = "Mega";
            this.rbtnMega.UseVisualStyleBackColor = true;
            // 
            // rbtnAviao
            // 
            this.rbtnAviao.AutoSize = true;
            this.rbtnAviao.Location = new System.Drawing.Point(6, 160);
            this.rbtnAviao.Name = "rbtnAviao";
            this.rbtnAviao.Size = new System.Drawing.Size(66, 24);
            this.rbtnAviao.TabIndex = 7;
            this.rbtnAviao.TabStop = true;
            this.rbtnAviao.Text = "Avião";
            this.rbtnAviao.UseVisualStyleBackColor = true;
            // 
            // lstBox
            // 
            this.lstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 20;
            this.lstBox.Items.AddRange(new object[] {
            "Correr",
            "Andar",
            "Pular",
            "Sentar",
            "Levantar",
            "Treinar"});
            this.lstBox.Location = new System.Drawing.Point(26, 235);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(193, 124);
            this.lstBox.TabIndex = 8;
            // 
            // cmbBox
            // 
            this.cmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Items.AddRange(new object[] {
            "Futebol",
            "Basquete",
            "Volei",
            "Golf",
            "Truco",
            "Uno",
            "Sinuca",
            "Dominó"});
            this.cmbBox.Location = new System.Drawing.Point(26, 365);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(193, 28);
            this.cmbBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbLivro);
            this.groupBox1.Controls.Add(this.chbPescar);
            this.groupBox1.Controls.Add(this.chbDormir);
            this.groupBox1.Controls.Add(this.chbCafe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 207);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnViajar);
            this.groupBox2.Controls.Add(this.rbtnComer);
            this.groupBox2.Controls.Add(this.rbtnMega);
            this.groupBox2.Controls.Add(this.rbtnAviao);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(384, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 207);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Você Prefere";
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.lstBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SistemaABC_Componentes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chbLivro;
        private System.Windows.Forms.CheckBox chbPescar;
        private System.Windows.Forms.CheckBox chbDormir;
        private System.Windows.Forms.CheckBox chbCafe;
        private System.Windows.Forms.RadioButton rbtnViajar;
        private System.Windows.Forms.RadioButton rbtnComer;
        private System.Windows.Forms.RadioButton rbtnMega;
        private System.Windows.Forms.RadioButton rbtnAviao;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}