using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double compra;
        double prestacao;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrestacao_Click(object sender, EventArgs e)
        {

            compra = double.Parse(txtCompra.Text);

            prestacao = compra / 5;

            txtPrestacao.Text=prestacao.ToString();


        }
    }
}
