using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroCodigo
{
    
    public partial class Form1 : Form
    {
        int numero1, numero2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void btnSoma(object sender, EventArgs e)
        {
            
            int.Parse(txtNumero1.Text);
            int.Parse(txtNumero2.Text);
            MessageBox.Show($"{numero1 + numero2}");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
           
            int.Parse(txtNumero1.Text);
            int.Parse(txtNumero2.Text);
            MessageBox.Show($"{numero1 - numero2}");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            
            int.Parse(txtNumero1.Text);
            int.Parse(txtNumero2.Text);
            MessageBox.Show($"{numero1 * numero2}");
        }

        private void bntDivisao_Click(object sender, EventArgs e)
        {
           
            int.Parse(txtNumero1.Text);
            int.Parse(txtNumero2.Text);
            MessageBox.Show($"{numero1 / numero2}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
