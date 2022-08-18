using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float distancia;
        float combustivel;
        float consumo;

        private void btnResultado_Click(object sender, EventArgs e)
        {
            distancia= float.Parse(txtDistancia.Text);
            combustivel = float.Parse(txtCombustivel.Text);

            consumo = distancia / combustivel;

            txtConsumoMedio.Text=consumo.ToString();


            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
