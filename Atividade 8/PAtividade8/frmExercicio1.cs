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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int quantidade = 0;
            char[] vetor = rtxtTexto.Text.ToCharArray();

            foreach(char c in vetor)
            {
                if (char.IsWhiteSpace(c))
                {
                    quantidade += 1;
                }
            }

            MessageBox.Show("O número de epaços em branco no texto: " + quantidade.ToString());
        }

        private void btnQuantidadeR_Click(object sender, EventArgs e)
        {
            int quantidade = 0;
            char[] vetor = rtxtTexto.Text.ToCharArray();

            for (var c = 0; c < rtxtTexto.Text.Length; c++)
            {
                if (vetor[c] == 'R' || vetor[c] == 'r')
                {
                    quantidade += 1;
                }
            }

            MessageBox.Show("A quantidade de letras R no texto: " + quantidade.ToString());
        }

        private void btnQuatidadePares_Click(object sender, EventArgs e)
        {
            int quantidade = 0, pos = 1;
            char[] vetor = rtxtTexto.Text.ToCharArray();

            while(pos < rtxtTexto.Text.Length)
            {
                if (vetor[pos] == vetor[pos - 1])
                {
                    quantidade += 1;
                }
                pos++;
            }

            MessageBox.Show("A quantidade de pares de letras iguas é: " + quantidade.ToString());
        }
    }
}
