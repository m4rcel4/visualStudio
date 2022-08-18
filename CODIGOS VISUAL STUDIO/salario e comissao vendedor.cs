using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double fixo;
        double vendas;
        double final;
        double comissao;

        private void btnResultado_Click(object sender, EventArgs e)
        {

            fixo = double.Parse(txtSalFixo.Text);
            vendas= double.Parse(txtVendas.Text);
            comissao = (vendas* 15) / 100;

            final = fixo + comissao;

            txtComissao.Text = comissao.ToString();

            txtSalFinal.Text=final.ToString();  

        }
    }
}
