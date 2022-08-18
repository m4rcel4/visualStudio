using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1;
        double n2;
        double d;
        double m;
        double soma;
        double sub;



        private void btnResultado_Click(object sender, EventArgs e)
        {

            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);

            d = n1 / n2;
            m = n2 * n2;
            soma = n1 + n2;
            sub = n1 - n2;

            txtSoma.Text=soma.ToString();
            txtDivisao.Text = d.ToString();
            txtMultiplicacao.Text = m.ToString();
            txtSubtracao.Text = sub.ToString();




        }
    }
}
