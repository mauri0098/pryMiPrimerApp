using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMiPrimerApp
{
    public partial class frmFinanzas : Form
    {
   
        //decalracion de variables 
        decimal varingreso, varalquiler, varcomida, varmonto;


        public frmFinanzas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ingreso_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void cmdgrabar_Click(object sender, EventArgs e)
        {
            varalquiler = Convert.ToDecimal(txtAlquiler.Text);
            varingreso = Convert.ToDecimal(txtDepocito.Text);
            varmonto = Convert.ToDecimal(txtMonto.Text);
            varcomida = Convert.ToDecimal(txtComida.Text);

            varmonto = varingreso - (varalquiler - varcomida);
            txtMonto.Text = varmonto.ToString();
        }

        private void txtalquiler_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComida_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void txtIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void iblcomida_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //inicialiazar variables - buena practica 
            varalquiler = 0;
            varcomida = 0;
            varingreso = 0;
            varmonto = 0;

          
        }
    }
}
