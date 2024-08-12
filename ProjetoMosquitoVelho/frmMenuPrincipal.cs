using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMosquitoVelho
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin voltar = new frmLogin(); //instanciar formulario login para voltar.
            voltar.ShowDialog(); // show dialog para a janela ficar como principal e não entrar em segundo plano.
            this.Hide(); // esconder janela - a unica que fecha é o login com sair.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin voltar = new frmLogin();
            voltar.ShowDialog();
            this.Hide();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios abrir = new frmFuncionarios();
            abrir.ShowDialog();
            this.Hide();
        }
    }
}
