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

            carregaCombo();

        }


        public void carregaCombo(){
            produtos[0] = "banana";
            produtos[1] = "maça";
            produtos[2] = "morango";
            produtos[3] = "limão";
            produtos[4] = "abacaxi";
            produtos[5] = "tomate";
            produtos[6] = "pera";
            produtos[7] = "laranja";
            produtos[8] = "melancia";
            produtos[9] = "manga";

            for (int i = 0; i < produtos.Length; i++)
            {
                cbbProdutos.Items.Add(produtos[i]);
            }
        }


        // criar um vetor
        string[] produtos = new string[10];

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            /*inserindo valor no array
            produtos[0] = "banana";
            produtos[1] = "maça";
            produtos[2] = "morango";
            produtos[3] = "limão";
            produtos[4] = "abacaxi";
            produtos[5] = "tomate";

            MessageBox.Show("produto " + produtos[0]); 
            MessageBox.Show("produto " + produtos[5]);*/

            produtos[0] = "banana";
            produtos[1] = "maça";
            produtos[2] = "morango";
            produtos[3] = "limão";
            produtos[4] = "abacaxi";
            produtos[5] = "tomate";
            produtos[6] = "pera";
            produtos[7] = "laranja";
            produtos[8] = "melancia";
            produtos[9] = "manga";

            //limpando itens da lista
            ltbListaProdutos.Items.Clear();

            //percorrendo valores
            for (int i = 0; i < produtos.Length; i++)
            { 
                ltbListaProdutos.Items.Add(produtos[i]);
            }
                       

        }

        private void cbbListarItens_MouseHover(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    

        private void cbbListarItens_MouseClick(object sender, MouseEventArgs e)
        {
            produtos[0] = "banana";
            produtos[1] = "maça";
            produtos[2] = "morango";
            produtos[3] = "limão";
            produtos[4] = "abacaxi";
            produtos[5] = "tomate";
            produtos[6] = "pera";
            produtos[7] = "laranja";
            produtos[8] = "melancia";
            produtos[9] = "manga";

            //limpando itens da lista 
            cbbListarItens.Items.Clear();

            for (int i = 0; i < produtos.Length; i++)
            {
                cbbListarItens.Items.Add(produtos[i]);
            }
        

    }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.ShowDialog();
            this.Hide();
        }

        private void btnTestarPessoa_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.Nome = "SENAC";

            lblTestaPessoa.Text = p.Nome;
        }
    }
}
