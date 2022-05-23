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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            char[] palavra;
    
            string str1, str2 = "";

            if (txtTexto1.Text == "")
                MessageBox.Show("Digite um palavra de até 50 letras");
            else
            {
                str1 = txtTexto1.Text.ToUpper();
                str1 = str1.Trim();

                for (int x = 0; x < str1.Length; x++)
                {
                    if (char.IsWhiteSpace(str1[x]))
                    {
                        str1 = str1.Remove(x, 1);
                    }
                }

                palavra = str1.ToCharArray();
                Array.Reverse(palavra);

                foreach (char c in palavra)
                {
                    str2 += c;
                }

                txtTexto2.Text = str2;

                if (string.Compare(str1, str2, true) == 0)
                    MessageBox.Show("O texto 1 é um palindromo.");
                else
                    MessageBox.Show("O texto 1 não é um palindromo.");
            }
        }
    }
}
