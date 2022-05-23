using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcSal_Click(object sender, EventArgs e)
        {
            double salarioBase, gratificacao, salarioBruto;
            int producao, B = 0, C = 0, D = 0;

            if (txtSalario.Text == "" || txtProducao.Text == "" || txtGratificacao.Text == "")
                MessageBox.Show("Digite valores para Salário, Produção e Gratificação");
            else
            {
                if (!double.TryParse(txtSalario.Text, out salarioBase) || salarioBase <= 0)
                {
                    MessageBox.Show("Valor inválido para Salário! Digite um valor maior que zero");
                    txtSalario.Text = "";
                    txtSalario.Focus();
                }
                else if(!int.TryParse(txtProducao.Text, out producao) || producao < 0)
                {
                    MessageBox.Show("Valor inválido para Produção! Digite um valor inteiro maior ou igual a zero.");
                    txtProducao.Text = "";
                    txtProducao.Focus();
                }
                else if (!double.TryParse(txtGratificacao.Text, out gratificacao) || gratificacao < 0)
                {
                    MessageBox.Show("Valor inválido para Gratificação! Digite um valor maior ou igual a zero.");
                    txtGratificacao.Text = "";
                    txtGratificacao.Focus();
                }
                else
                {
                    if (producao >= 100)
                        B = 1;
                    if (producao >= 120)
                        C = 1;
                    if (producao >= 150)
                        D = 1;

                    salarioBruto = salarioBase + salarioBase * (0.05 * B + 0.10 * C + 0.1 * D) + gratificacao;
                    if (salarioBruto > 7000)
                        if(producao < 150 || gratificacao == 0)
                            salarioBruto = 7000;

                    txtSalBruto.Text = salarioBruto.ToString("N2");

                }
            }
        }
    }
}
