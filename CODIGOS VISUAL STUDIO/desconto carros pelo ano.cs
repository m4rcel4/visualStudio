using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ano;
        double valor;
        double desconto;
        double carros2000;
        double totalcarros;

        private void btnResultado_Click(object sender, EventArgs e)
        {

            valor = double.Parse(txtValor.Text);

            if (ano <= 2000) 
            {

                desconto = (valor * 12) / 100;
                valor = valor - desconto;
               

                txtDesconto.Text = desconto.ToString();
                txtValorFinal.Text = valor.ToString();

                carros2000 = carros2000 + 1;

                txt2000.Text = carros2000.ToString();



            }
            else 
            {
                desconto = (valor * 7) / 1000;
                valor = valor - desconto;
                

                txtDesconto.Text = desconto.ToString();
                txtValorFinal.Text = valor.ToString();


            }

            totalcarros = totalcarros + 1;
            txtGeral.Text= totalcarros.ToString();  




        }
    }
}
