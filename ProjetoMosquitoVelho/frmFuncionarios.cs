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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.ShowDialog();
            this.Hide();
        }

        //metodo busca cep
        public void buscaCEP(string cep, string usuario, string senha)
        {
            WsCorreios.AtendeClienteClient ws = new WsCorreios.AtendeClienteClient();
            try
            {
                WsCorreios.enderecoERP endereço = ws.consultaCEP(cep, usuario, senha);
                txtRua.Text = endereço.end;
                txtBairro.Text = endereço.bairro;
                txtCidade.Text = endereço.cidade;
                cbbEstado.Text = endereço.uf;
                
            }
            catch (Exception)
            {

                MessageBox.Show("Favor, Inserir CEP válido");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            buscaCEP(mskCep2.Text, "felipeffylepe", "felipepe2011");
        }
    }
}
