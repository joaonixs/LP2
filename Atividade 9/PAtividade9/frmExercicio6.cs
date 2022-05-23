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
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] vetor = new string[1];
            string auxiliar;
            int[] cont = new int[1];

            for(int i=0; i<vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o nome " + (i + 1), "Entrada de Nomes");
                auxiliar.Trim();
                vetor[i] = auxiliar;
                cont[i] = 0;
                foreach (char c in vetor[i])
                {
                    if (!Char.IsWhiteSpace(c))
                        cont[i]++;
                }
            }
            lstbxNomes.Items.Add("LISTA DE NOMES:");
            lstbxNomes.Items.Add("------------------------------------------");
            for (int i=0; i<vetor.Length; i++)
            {
                lstbxNomes.Items.Add("Nome: " + vetor[i] + " tem " + cont[i] + " caracteres");
            }
            lstbxNomes.Items.Add("------------------------------------------");
        }
    }
}
