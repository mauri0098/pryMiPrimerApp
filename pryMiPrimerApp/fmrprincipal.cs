﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAlmancen ventanaAlacena = new frmAlmancen();

            ventanaAlacena.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFinanzas principal = new frmFinanzas();
            principal.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
