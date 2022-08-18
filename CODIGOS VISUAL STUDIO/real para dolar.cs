using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double dolar;
        double reais;
        double cotacao;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConversao_Click(object sender, EventArgs e)
        {

            reais = double.Parse(txtReal.Text);
            cotacao= double.Parse(txtCotacao.Text);

            dolar = reais / cotacao;

                txtDolar.Text=dolar.ToString();
        }
    }
}
