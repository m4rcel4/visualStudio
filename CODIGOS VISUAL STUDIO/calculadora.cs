using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         double n1;
        double n2;
        string opcao;
        double teste;
        

        private void btn0_Click(object sender, EventArgs e)
        {
            if (teste==1)
            {
                // teste é igual a zero pois precisa dar um comando para limpar tela
                teste=0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "0";
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = ""; 
            }
            txtVisor.Text = txtVisor.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
                txtVisor.Text = txtVisor.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (teste == 1)
            {
                teste = 0;
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "9";

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                if (n1 != 0)
                {
                    n2 = double.Parse(txtVisor.Text);
                    n1 = n1 + n2;
                    txtVisor.Text = "";
                    txtVisor.Text = n1.ToString();
                    teste = 1;
                }

                // "else" faz a operação normal com somente dois números (n1+n2)
                //lembrando que "n1" pode ter mais de 2 valores dentro dele!!!
                else
                {
                    opcao = "soma";
                    n1 = double.Parse(txtVisor.Text);
                    txtVisor.Text = "";
                }
            }
   
        }

        private void bntSubtracao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                if (n1 != 0)
                {
                    n2 = double.Parse(txtVisor.Text);
                    n1 = n1 - n2;
                    txtVisor.Text = "";
                    txtVisor.Text = n1.ToString();
                    teste = 1;
                }
                else
                {
                    opcao = "subtracao";
                    n1 = double.Parse(txtVisor.Text);
                    txtVisor.Text = "";
                }
            }

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                if (n1 != 0)
                {
                    n2 = double.Parse(txtVisor.Text);
                    n1 = n1 / n2;
                    txtVisor.Text = "";
                    txtVisor.Text = n1.ToString();
                   
                    teste = 1;
                }
                else
                {
                    opcao = "divisao";
                    n1 = double.Parse(txtVisor.Text);
                    txtVisor.Text = "";
                }
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                if (n1 != 0)
                {
                    n2 = double.Parse(txtVisor.Text);
                    n1 = n1 * n2;
                    txtVisor.Text = "";
                    txtVisor.Text = n1.ToString();
                   
                    teste = 1;
                }

                else
                {
                    opcao = "multiplicacao";
                    n1 = double.Parse(txtVisor.Text);
                    txtVisor.Text = "";
                }
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            
            n2 = double.Parse(txtVisor.Text);


            switch (opcao)
            {
                case "soma":
                    n1 = n1 + n2;
                        break;

                case "subtracao":
                    n1 = n1 - n2;
                        break;

                case "divisao":
                    n1= n1 / n2;
                    break;

                case "multiplicacao":
                    n1 = n1 * n2;
                    break;

                default:
                    break;

            }
                
            
            txtVisor.Text= n1.ToString();
            
             
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + ",";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            txtVisor.Text = "";
        }

        private void btnNegativo_Click(object sender, EventArgs e)
            // criado para definir o primeiro número como negativo
            // esse traço,definido como string, vai passar a ser um sinal de subtração.
            // passa a ser sinal negativo pois,lá em cima, defini que qualquer "txtVisor" vire "double"
        {
            txtVisor.Text = txtVisor.Text + "-";

        }
    }
}
