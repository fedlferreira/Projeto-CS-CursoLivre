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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        //metodo limpar campos
        public void limparCampos()
        {
            txtValor1.Text = "";
            txtValor2.Clear();
            lblResp.Text = "";
            rbtnSoma.Checked = false;
            rbtnSub.Checked = false;
            rbtnMult.Checked = false;
            rbtnDiv.Checked = false;
            txtValor1.Focus();

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;

            /* if (txtValor1.Equals("") && txtValor2.Equals(""))
             {
                 MessageBox.Show("coloque um valor numérico");
             } else {    transferir essa chave pro final}     */
            try
            {
                num1 = Convert.ToDouble(txtValor1.Text);
                num2 = Convert.ToDouble(txtValor2.Text);

                //resp = num1 + num2; *ex de calculo sem classe de operações*


                //caso objetivo não esteja publico é necessairo estanciar o objetivo
                //(ex: resp = operacoes.*não achou, necessario estanciar objetivo/classe*
                //cria uma variável.
                //tipo da variáveis - nome da variavels = instânciar - método
                Operacoes op = new Operacoes();

                if (rbtnSoma.Checked)
                {
                    resp = op.somar(num1, num2);
                }
                if (rbtnSub.Checked)
                {
                    resp = op.subtrair(num1, num2);
                }
                if (rbtnMult.Checked)
                {
                    resp = op.multiplicar(num1, num2);
                }
                if (rbtnDiv.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("impossivel divisão por " + num2, "SistemaABC", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        //executar o metodo limpar campos

                        limparCampos();

                        //exemplo:
                        //MessageBox.Show("impossivel divisão por 0", "SistemaABC", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);

                    }
                    else
                    {
                        resp = op.dividir(num1, num2);
                    }

                }


                lblResp.Text = resp.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("coloque um valor numérico");
                limparCampos();
               
            }


            }
        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // testando git em casa

    }
}
