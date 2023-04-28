namespace pryMiPrimerApp
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.mrcgastofijo = new System.Windows.Forms.GroupBox();
            this.txtcomida = new System.Windows.Forms.TextBox();
            this.txtimpuesto = new System.Windows.Forms.TextBox();
            this.txtalquiler = new System.Windows.Forms.TextBox();
            this.lblcomida = new System.Windows.Forms.Label();
            this.lblimpuesto = new System.Windows.Forms.Label();
            this.lblalquiler = new System.Windows.Forms.Label();
            this.mrcgastosvarios = new System.Windows.Forms.GroupBox();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.lblmonto = new System.Windows.Forms.Label();
            this.cmdcancelar = new System.Windows.Forms.Button();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.mrcgastofijo.SuspendLayout();
            this.mrcgastosvarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(12, 9);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblIngreso.TabIndex = 0;
            this.lblIngreso.Text = "Ingreso";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(86, 6);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(54, 20);
            this.txtIngreso.TabIndex = 1;
            // 
            // mrcgastofijo
            // 
            this.mrcgastofijo.Controls.Add(this.txtcomida);
            this.mrcgastofijo.Controls.Add(this.txtimpuesto);
            this.mrcgastofijo.Controls.Add(this.txtalquiler);
            this.mrcgastofijo.Controls.Add(this.lblcomida);
            this.mrcgastofijo.Controls.Add(this.lblimpuesto);
            this.mrcgastofijo.Controls.Add(this.lblalquiler);
            this.mrcgastofijo.Location = new System.Drawing.Point(4, 44);
            this.mrcgastofijo.Name = "mrcgastofijo";
            this.mrcgastofijo.Size = new System.Drawing.Size(151, 102);
            this.mrcgastofijo.TabIndex = 2;
            this.mrcgastofijo.TabStop = false;
            this.mrcgastofijo.Text = "Gasto Fijo";
            this.mrcgastofijo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtcomida
            // 
            this.txtcomida.Location = new System.Drawing.Point(82, 70);
            this.txtcomida.Name = "txtcomida";
            this.txtcomida.Size = new System.Drawing.Size(54, 20);
            this.txtcomida.TabIndex = 5;
            // 
            // txtimpuesto
            // 
            this.txtimpuesto.Location = new System.Drawing.Point(83, 48);
            this.txtimpuesto.Name = "txtimpuesto";
            this.txtimpuesto.Size = new System.Drawing.Size(53, 20);
            this.txtimpuesto.TabIndex = 4;
            // 
            // txtalquiler
            // 
            this.txtalquiler.Location = new System.Drawing.Point(83, 26);
            this.txtalquiler.Name = "txtalquiler";
            this.txtalquiler.Size = new System.Drawing.Size(53, 20);
            this.txtalquiler.TabIndex = 3;
            // 
            // lblcomida
            // 
            this.lblcomida.AutoSize = true;
            this.lblcomida.Location = new System.Drawing.Point(22, 70);
            this.lblcomida.Name = "lblcomida";
            this.lblcomida.Size = new System.Drawing.Size(42, 13);
            this.lblcomida.TabIndex = 2;
            this.lblcomida.Text = "Comida";
            this.lblcomida.Click += new System.EventHandler(this.iblcomida_Click);
            // 
            // lblimpuesto
            // 
            this.lblimpuesto.AutoSize = true;
            this.lblimpuesto.Location = new System.Drawing.Point(23, 48);
            this.lblimpuesto.Name = "lblimpuesto";
            this.lblimpuesto.Size = new System.Drawing.Size(50, 13);
            this.lblimpuesto.TabIndex = 1;
            this.lblimpuesto.Text = "Impuesto";
            this.lblimpuesto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblalquiler
            // 
            this.lblalquiler.AutoSize = true;
            this.lblalquiler.Location = new System.Drawing.Point(23, 26);
            this.lblalquiler.Name = "lblalquiler";
            this.lblalquiler.Size = new System.Drawing.Size(41, 13);
            this.lblalquiler.TabIndex = 0;
            this.lblalquiler.Text = "Alquiler";
            this.lblalquiler.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // mrcgastosvarios
            // 
            this.mrcgastosvarios.Controls.Add(this.txtmonto);
            this.mrcgastosvarios.Controls.Add(this.lblmonto);
            this.mrcgastosvarios.Location = new System.Drawing.Point(4, 152);
            this.mrcgastosvarios.Name = "mrcgastosvarios";
            this.mrcgastosvarios.Size = new System.Drawing.Size(151, 61);
            this.mrcgastosvarios.TabIndex = 3;
            this.mrcgastosvarios.TabStop = false;
            this.mrcgastosvarios.Text = "Gastos Varios";
            this.mrcgastosvarios.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(82, 26);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(53, 20);
            this.txtmonto.TabIndex = 1;
            // 
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.Location = new System.Drawing.Point(22, 29);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(37, 13);
            this.lblmonto.TabIndex = 0;
            this.lblmonto.Text = "Monto";
            // 
            // cmdcancelar
            // 
            this.cmdcancelar.Location = new System.Drawing.Point(15, 231);
            this.cmdcancelar.Name = "cmdcancelar";
            this.cmdcancelar.Size = new System.Drawing.Size(68, 26);
            this.cmdcancelar.TabIndex = 4;
            this.cmdcancelar.Text = "Cancelar";
            this.cmdcancelar.UseVisualStyleBackColor = true;
            this.cmdcancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.Location = new System.Drawing.Point(89, 232);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(66, 25);
            this.cmdgrabar.TabIndex = 5;
            this.cmdgrabar.Text = "Grabar";
            this.cmdgrabar.UseVisualStyleBackColor = true;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 273);
            this.Controls.Add(this.cmdgrabar);
            this.Controls.Add(this.cmdcancelar);
            this.Controls.Add(this.mrcgastosvarios);
            this.Controls.Add(this.mrcgastofijo);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.lblIngreso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Gestión de Gastos Mensuales";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mrcgastofijo.ResumeLayout(false);
            this.mrcgastofijo.PerformLayout();
            this.mrcgastosvarios.ResumeLayout(false);
            this.mrcgastosvarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.GroupBox mrcgastofijo;
        private System.Windows.Forms.Label lblalquiler;
        private System.Windows.Forms.Label lblimpuesto;
        private System.Windows.Forms.Label lblcomida;
        private System.Windows.Forms.GroupBox mrcgastosvarios;
        private System.Windows.Forms.Label lblmonto;
        private System.Windows.Forms.TextBox txtcomida;
        private System.Windows.Forms.TextBox txtimpuesto;
        private System.Windows.Forms.TextBox txtalquiler;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Button cmdcancelar;
        private System.Windows.Forms.Button cmdgrabar;
    }
}

