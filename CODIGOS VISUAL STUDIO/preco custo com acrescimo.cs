using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double custo;
        double porcentagem;
        double venda;
        double acrescimo;



        private void btnResultado_Click(object sender, EventArgs e)
        {
            custo = double.Parse(txtCusto.Text);
            porcentagem = double.Parse(txtPorcentagem.Text);

            acrescimo = (custo * porcentagem) / 100;


            venda = custo + acrescimo;

            txtVenda.Text=venda.ToString();


        }
    }
}
