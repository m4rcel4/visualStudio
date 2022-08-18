using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double rendimento;
        double deposito;
        double total;

        private void btnResultado_Click(object sender, EventArgs e)
        {
            deposito = double.Parse(txtDeposito.Text);

            rendimento =(deposito * 70) / 1000;

            total = deposito + rendimento;

            txtRendimento.Text=rendimento.ToString();   
            txtTotal.Text=total.ToString();

        }
    }
}
