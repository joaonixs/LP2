using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PAtividade9
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double[] quantidade = new double[10];
            double[] valor = new double[10];
            double total = 0;
            string auxiliar = "", relatorio = "";

            for (var i = 0; i < 10; i++)
            {
                do
                {
                    auxiliar = Interaction.InputBox("Digite a quantidade do item "+(i+1), "Caixa Registradora");

                    if (!double.TryParse(auxiliar, out quantidade[i]))
                        MessageBox.Show("Quantidade inválida!");
                }
                while (double.TryParse(auxiliar, out quantidade[i]) == false);
                do
                {
                    auxiliar = Interaction.InputBox("Digite o valor do item "+(i+1), "Caixa Registradora");

                    if (!double.TryParse(auxiliar, out valor[i]))
                        MessageBox.Show("Valor inválido!");
                }
                while (double.TryParse(auxiliar, out valor[i]) == false);

                relatorio = relatorio + "Item " + (i+1) + ":    Qtde: " + quantidade[i] + "   Valor: " + valor[i] + "\n";
                total = total + quantidade[i] * valor[i];
            }

            MessageBox.Show(relatorio + "\n\nTotal de vendas do mês: " + total, "Relatório Mensal");
        }
    }
}
