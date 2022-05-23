using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PAtividade9
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            ArrayList nomes = new ArrayList();
            //Adicionando os nomes
            nomes.Add("Ana");
            nomes.Add("André");
            nomes.Add("Débora");
            nomes.Add("Fátima");
            nomes.Add("João");
            nomes.Add("Janete");
            nomes.Add("Otávio");
            nomes.Add("Marcelo");
            nomes.Add("Pedro");
            nomes.Add("Thais");

            //Remvendo o nome Otávio
            nomes.Remove("Otávio");

            //Imprimindo O ArrayList
            foreach(string nome in nomes)
            {
                MessageBox.Show(nome);
            }


        }
    }
}
