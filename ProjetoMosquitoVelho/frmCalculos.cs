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
    public partial class frmCalculos : Form
    {
        public frmCalculos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Clear();
            lblRespota.Text = "";
            txtNumero1.Focus();
        }

        // criando metodo somas

        public double somaValor(double num1, double num2)
        {
            return (num1 + num2);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //declarando variaveis:
            double num1, num2, resp;

            //atribuir valores as variaveis:
            num1 = Convert.ToDouble(txtNumero1.Text);
            num2 = Convert.ToDouble(txtNumero2.Text);

            //calculando
            //resp = num1 + num2;
            //ou

            resp = somaValor(num1, num2);

            //enviando valor para a resposta

            lblRespota.Text = resp.ToString();
        }
    }
}
