using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoMosquitoVelho
{
    public partial class frmMenuPrincipal : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
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

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos abrir = new frmProdutos();
            abrir.ShowDialog();
            this.Hide();
        }
    }
}
