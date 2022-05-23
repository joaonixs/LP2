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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcularH_Click(object sender, EventArgs e)
        {
            int termos;
            double h = 0f, n;

            if(!int.TryParse(txtNumeroN.Text, out termos))
            {
                MessageBox.Show("Número inválido! Digite um número inteiro maior que zero.");
            }
            else if(termos <= 0)
            {
                MessageBox.Show("Digite um número maior que zero");
            }
            else
            {
                for(int x = 1; x <= termos; x++ )
                {
                    n = Convert.ToDouble(x);
                    h += 1 / n;
                }

                txtNumeroH.Text = h.ToString("N4");
            }
        }
    }
}
