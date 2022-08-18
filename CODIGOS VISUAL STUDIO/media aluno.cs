using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            double n1;
            double n2;
            double n3;
            double m;
        

        private void btnResultado_Click(object sender, EventArgs e)
        {
            n1= double.Parse(txtN1.Text);
            n2= double.Parse(txtN2.Text);
            n3= double.Parse(txtN3.Text);

            m = (n1 + n2 + n3) / 3;

            txtMedia.Text = m.ToString();

        }
    }
}
