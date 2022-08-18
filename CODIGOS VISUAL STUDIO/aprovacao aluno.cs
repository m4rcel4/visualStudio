using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double N1;
        double N2;
        double N3;
        double media; 


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            N1 = double.Parse(txtN1.Text);
            N2 = double.Parse(txtN2.Text);
            N3 = double.Parse(txtN3.Text);

            media = (N1 + N2 + N3) / 3;
            
            txtMediaFinal.Text=media.ToString();    

            if (media >= 7)
            {
                txtSituacao.Text = "APROVADO!!";

            }
            else
            {
                if (media<=5)
                {
                    txtSituacao.Text = "REPROVADO!!";
                }
                else 
                {
                    txtSituacao.Text = "RECUPERAÇÃO";
                }
            }


        }
    }
}
