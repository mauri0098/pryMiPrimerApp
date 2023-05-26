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
    public partial class frmAlacena : Form
    {
        //decalracion de variables
        string varProductosLacteos, varProducto, varMarca, varMarca2, varproducto2, varmarca, varcantidad2;

        int varCantidad;
          




        public frmAlacena()
        {

            InitializeComponent();
                        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void istProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itsMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            varproducto2 = cboProducto2.Text;
            varMarca = cboMarca.Text;
            
            varProducto = cboProducto.Text;
            varMarca2 = cboMarca2.Text;
            varCantidad = Convert.ToInt32(nudCantidad.Value);
            //varCantidad = int.Parse(nudCantidad.value);
            lstHeladera.Items.Add(varproducto2 + " " + varMarca + " " + varcantidad2);
            lstAlacena.Items.Add(varProducto + " " + varMarca2 + " " + varCantidad);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void iblMarca_Click(object sender, EventArgs e)
        {

        }

        private void frmAlacena_Load(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
