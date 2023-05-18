namespace pryMiPrimerApp
{
    partial class frmFinanzas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanzas));
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.mrcGastoFijo = new System.Windows.Forms.GroupBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.mrcGastosVarios = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.mrcGastoFijo.SuspendLayout();
            this.mrcGastosVarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(12, 13);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblIngreso.TabIndex = 0;
            this.lblIngreso.Text = "Ingreso";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(86, 10);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(54, 20);
            this.txtIngreso.TabIndex = 1;
            // 
            // mrcGastoFijo
            // 
            this.mrcGastoFijo.Controls.Add(this.txtComida);
            this.mrcGastoFijo.Controls.Add(this.txtImpuesto);
            this.mrcGastoFijo.Controls.Add(this.txtAlquiler);
            this.mrcGastoFijo.Controls.Add(this.lblComida);
            this.mrcGastoFijo.Controls.Add(this.lblImpuesto);
            this.mrcGastoFijo.Controls.Add(this.lblAlquiler);
            this.mrcGastoFijo.Location = new System.Drawing.Point(4, 44);
            this.mrcGastoFijo.Name = "mrcGastoFijo";
            this.mrcGastoFijo.Size = new System.Drawing.Size(151, 102);
            this.mrcGastoFijo.TabIndex = 2;
            this.mrcGastoFijo.TabStop = false;
            this.mrcGastoFijo.Text = "Gasto Fijo";
            this.mrcGastoFijo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(82, 70);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(54, 20);
            this.txtComida.TabIndex = 5;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(83, 48);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(53, 20);
            this.txtImpuesto.TabIndex = 4;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(83, 26);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(53, 20);
            this.txtAlquiler.TabIndex = 3;
            this.txtAlquiler.TextChanged += new System.EventHandler(this.txtalquiler_TextChanged);
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(22, 70);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(42, 13);
            this.lblComida.TabIndex = 2;
            this.lblComida.Text = "Comida";
            this.lblComida.Click += new System.EventHandler(this.iblcomida_Click);
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(23, 48);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(50, 13);
            this.lblImpuesto.TabIndex = 1;
            this.lblImpuesto.Text = "Impuesto";
            this.lblImpuesto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Location = new System.Drawing.Point(23, 26);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(41, 13);
            this.lblAlquiler.TabIndex = 0;
            this.lblAlquiler.Text = "Alquiler";
            this.lblAlquiler.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // mrcGastosVarios
            // 
            this.mrcGastosVarios.Controls.Add(this.txtMonto);
            this.mrcGastosVarios.Controls.Add(this.lblMonto);
            this.mrcGastosVarios.Location = new System.Drawing.Point(4, 152);
            this.mrcGastosVarios.Name = "mrcGastosVarios";
            this.mrcGastosVarios.Size = new System.Drawing.Size(151, 61);
            this.mrcGastosVarios.TabIndex = 3;
            this.mrcGastosVarios.TabStop = false;
            this.mrcGastosVarios.Text = "Gastos Varios";
            this.mrcGastosVarios.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(82, 26);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(53, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(22, 29);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(9, 219);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(68, 26);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(86, 219);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(66, 25);
            this.cmdGrabar.TabIndex = 5;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // frmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 256);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.mrcGastosVarios);
            this.Controls.Add(this.mrcGastoFijo);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.lblIngreso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinanzas";
            this.Text = "Gestión de Gastos Mensuales";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mrcGastoFijo.ResumeLayout(false);
            this.mrcGastoFijo.PerformLayout();
            this.mrcGastosVarios.ResumeLayout(false);
            this.mrcGastosVarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.GroupBox mrcGastoFijo;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.GroupBox mrcGastosVarios;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGrabar;
    }
}

