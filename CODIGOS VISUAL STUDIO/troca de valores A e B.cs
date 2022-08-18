using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double A;
        double B;
        double troca;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
            A = double.Parse(txtA.Text);
            B = double.Parse(txtB.Text);

            troca = A;
            A = B;
            B = troca;

            txtAA.Text=A.ToString();
            txtBB.Text=B.ToString();



        }
    }
}
