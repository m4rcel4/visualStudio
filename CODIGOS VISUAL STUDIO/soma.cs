using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercício_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float n1;
        float n2;


        private void btnSoma_Click(object sender, EventArgs e)
        {
           
            n1 = float.Parse(txtN1.Text);
            n2 = float.Parse(txtN2.Text);

            n1 = n1 + n2;
            txtResultado.Text = n1.ToString();

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
