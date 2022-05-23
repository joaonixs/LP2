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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "", invertido = "";

            for(var i=0; i<vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o elemento " + (i + 1) + 
                    " do vetor:", "Entrada de dados");

                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Número inválido!");
                    i--;
                }
                else
                    invertido = vetor[i] + "\n" + invertido;
            }

            MessageBox.Show("Vetor Invertido:\n" + invertido);
        }
    }
}
