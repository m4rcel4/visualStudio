using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double C;
        double F;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConversao_Click(object sender, EventArgs e)
        {
            C = double.Parse(txtCelsius.Text);

            F = (9 * C + 160) / 5;

            txtFahrenheit.Text=F.ToString();

        }
    }
}
