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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            
            InitializeComponent();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Close();
            //this.Close();
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("admin") && txtSenha.Text.Equals("123"))
            {
                //MessageBox.Show("Bem Vindo ao Sistema!");
                frmMenuPrincipal abrir = new frmMenuPrincipal(); // instanciar o formulario para abri-lo
                abrir.ShowDialog(); // show dialog abre a janela de modo que ela não feche.
                this.Hide(); //esconde a janela que está
            } 
            else
            {
                //MessageBox.Show("Usuário e senhas inválidos.");
                limparCampos();
            }
        }
        public void limparCampos()
        {
            txtSenha.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }
    }
}
