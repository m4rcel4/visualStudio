using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_dos_números
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ordem;
        string sequencia;

        private void btnAcrescentar_Click(object sender, EventArgs e)
        {
           
            ordem = ordem +txtNumero.Text + "-";
            
            txtNumero.Text = "";
            
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            
            
            sequencia = txtSequenciaNova.Text+"-";

            if (sequencia==ordem)
            {
                txtSituacao.Text = "ACERTOU!!";
                
                txtSequenciaNova.Text ="";
            }

            else
            {
                txtSituacao.Text = "ERROU!!";
                txtSequenciaNova.Text = "";
                txtOrdem.Text = "";
                txtOrdem.Text = ordem;




            }
        }
    }
}
