using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double fabrica;
        double venda;


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            fabrica = double.Parse(txtCusto.Text);

            fabrica = fabrica + (fabrica * 45) / 100;

            venda= fabrica+(fabrica * 28) / 100;

            txtConsumidor.Text=venda.ToString();


        }
    }
}
