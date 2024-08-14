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
    public partial class frmListarProdutos : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmListarProdutos()
        {
            InitializeComponent();
        }

        private void frmListarProdutos_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            // criar um vetor
            string [] produtos = new string [10];
            //inserindo valor no array
            produtos[0] = "banana";
            produtos[1] = "maça";
            produtos[2] = "morango";
            produtos[3] = "limão";
            produtos[4] = "abacaxi";
            produtos[5] = "tomate";

            MessageBox.Show("produtos", produtos[0]); 
            MessageBox.Show("produtos", produtos[5]);
        }
    }
}
