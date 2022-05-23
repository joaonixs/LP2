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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double[,] notasTurma = new double[20, 3];
            double[] mediaTurma = new double[20];
            double nota, media = 0;
            string auxiliar, medialunos="";

            for (int i = 0; i < notasTurma.GetLength(0); i++)
            {
                for (int j = 0; j < notasTurma.GetLength(1); j++)
                {
                    do
                    {
                        auxiliar = Interaction.InputBox("Digite a nota " + (j + 1) + " do aluno " + (i + 1), "Registro de notas");
                        if (!double.TryParse(auxiliar, out nota))
                            MessageBox.Show("Nota inválida");
                    }
                    while (!double.TryParse(auxiliar, out nota));

                    media += nota;
                }
                mediaTurma[i] = media / 3;
                media = 0;
                medialunos = medialunos + "Aluno " + (i+1) + ": Media: " + mediaTurma[i].ToString("N2") + "\n";
            }
            MessageBox.Show("MEDIA DA TURMA:\n----------------------------------\n"+medialunos);
        }
    }
}
