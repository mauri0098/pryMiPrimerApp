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
        decimal varDeposito, varalquiler, varcomida, vargasto, varimpuesto;


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
            varDeposito = Convert.ToDecimal(txtDeposito.Text);
            vargasto = Convert.ToDecimal(txtMonto.Text);
            varcomida = Convert.ToDecimal(txtComida.Text);
            varimpuesto = Convert.ToDecimal(txtImpuesto.Text);
            decimal total = varDeposito - (varalquiler + varcomida + vargasto + varcomida + varimpuesto);
            lblTotal.Text = total.ToString();  
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
            varDeposito = 0;
            vargasto = 0;
            varimpuesto = 0;
            
          
        }
    }
}
