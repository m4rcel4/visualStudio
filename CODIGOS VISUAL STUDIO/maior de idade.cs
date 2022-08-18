using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double idade;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            idade=double.Parse(txtIdade.Text);  

            if (idade>=18)
            {
                txtResultado.Text = "MAIOR de idade";
            }
            else
            {
                txtResultado.Text = "MENOR  de idade";


            }


        }
    }
}
