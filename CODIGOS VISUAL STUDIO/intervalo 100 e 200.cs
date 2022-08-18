using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n;

        private void btnResultado_Click(object sender, EventArgs e)
        {

            n=double.Parse(txtNumero.Text);

            if (n > 100 && n < 200)
            {
                txtResultado.Text = "Está entre 100 e 200";

            }

            else
            {
                txtResultado.Text = "NÂO está entre 100 e 200";
            }

        }
    }
}
