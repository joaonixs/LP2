using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade9
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            frmExercicio1 frm1 = new frmExercicio1();
            frm1.Show();
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            frmExercicio2 frm2 = new frmExercicio2();
            frm2.Show();
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            frmExercicio3 frm3 = new frmExercicio3();
            frm3.Show();
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            frmExercicio4 frm4 = new frmExercicio4();
            frm4.Show();
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            frmExercicio5 frm5 = new frmExercicio5();
            frm5.Show();
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            frmExercicio6 frm6 = new frmExercicio6();
            frm6.Show();
        }
    }
}
