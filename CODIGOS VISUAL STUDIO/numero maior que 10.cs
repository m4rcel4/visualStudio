using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double numero;

        private void btnResultado_Click(object sender, EventArgs e)
        {
           numero=double.Parse(txtNumero.Text);

            if (numero>10)
            {

                txtSituacao.Text = "Maior que 10";
            }
            else
            {
                txtSituacao.Text = "Menor que 10";
            }

        }
    }
}
