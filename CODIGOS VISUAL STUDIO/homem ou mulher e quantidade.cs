using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_19._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        int totalH, totalM;
       

        private void btnResultado_Click(object sender, EventArgs e)
        {
           
            
            if (txtSexo.Text=="homem")
            {

                totalH = totalH + 1;
              
            } 
            else
            {
                totalM = totalM+1;
                
                    
            }
            txtHomem.Text=totalH.ToString();
            txtMulher.Text=totalM.ToString();
           



        }
    }
}
