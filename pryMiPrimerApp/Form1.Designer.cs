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
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.mrcGastoFijo = new System.Windows.Forms.GroupBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.IblComida = new System.Windows.Forms.Label();
            this.IblImpuesto = new System.Windows.Forms.Label();
            this.IblAlquiler = new System.Windows.Forms.Label();
            this.mrcGastosVarios = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.IblMonto = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.mrcIngresos = new System.Windows.Forms.GroupBox();
            this.IblDeposito = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.mrcGastoFijo.SuspendLayout();
            this.mrcGastosVarios.SuspendLayout();
            this.mrcIngresos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDeposito
            // 
            this.txtDeposito.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposito.Location = new System.Drawing.Point(84, 36);
            this.txtDeposito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(86, 21);
            this.txtDeposito.TabIndex = 1;
            this.txtDeposito.Text = "0";
            this.txtDeposito.TextChanged += new System.EventHandler(this.txtIngreso_TextChanged);
            // 
            // mrcGastoFijo
            // 
            this.mrcGastoFijo.Controls.Add(this.txtComida);
            this.mrcGastoFijo.Controls.Add(this.txtImpuesto);
            this.mrcGastoFijo.Controls.Add(this.txtAlquiler);
            this.mrcGastoFijo.Controls.Add(this.IblComida);
            this.mrcGastoFijo.Controls.Add(this.IblImpuesto);
            this.mrcGastoFijo.Controls.Add(this.IblAlquiler);
            this.mrcGastoFijo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastoFijo.Location = new System.Drawing.Point(3, 98);
            this.mrcGastoFijo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mrcGastoFijo.Name = "mrcGastoFijo";
            this.mrcGastoFijo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mrcGastoFijo.Size = new System.Drawing.Size(239, 110);
            this.mrcGastoFijo.TabIndex = 2;
            this.mrcGastoFijo.TabStop = false;
            this.mrcGastoFijo.Text = "Gasto Fijo";
            this.mrcGastoFijo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtComida
            // 
            this.txtComida.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComida.Location = new System.Drawing.Point(84, 79);
            this.txtComida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(86, 21);
            this.txtComida.TabIndex = 5;
            this.txtComida.Text = "0";
            this.txtComida.TextChanged += new System.EventHandler(this.txtComida_TextChanged);
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Location = new System.Drawing.Point(84, 52);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(86, 21);
            this.txtImpuesto.TabIndex = 4;
            this.txtImpuesto.Text = "0";
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlquiler.Location = new System.Drawing.Point(84, 26);
            this.txtAlquiler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(86, 21);
            this.txtAlquiler.TabIndex = 3;
            this.txtAlquiler.Text = "0";
            this.txtAlquiler.TextChanged += new System.EventHandler(this.txtalquiler_TextChanged);
            // 
            // IblComida
            // 
            this.IblComida.AutoSize = true;
            this.IblComida.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblComida.Location = new System.Drawing.Point(3, 79);
            this.IblComida.Name = "IblComida";
            this.IblComida.Size = new System.Drawing.Size(61, 19);
            this.IblComida.TabIndex = 2;
            this.IblComida.Text = "Comida";
            this.IblComida.Click += new System.EventHandler(this.iblcomida_Click);
            // 
            // IblImpuesto
            // 
            this.IblImpuesto.AutoSize = true;
            this.IblImpuesto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblImpuesto.Location = new System.Drawing.Point(3, 52);
            this.IblImpuesto.Name = "IblImpuesto";
            this.IblImpuesto.Size = new System.Drawing.Size(71, 19);
            this.IblImpuesto.TabIndex = 1;
            this.IblImpuesto.Text = "Impuesto";
            this.IblImpuesto.Click += new System.EventHandler(this.label2_Click);
            // 
            // IblAlquiler
            // 
            this.IblAlquiler.AutoSize = true;
            this.IblAlquiler.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblAlquiler.Location = new System.Drawing.Point(4, 26);
            this.IblAlquiler.Name = "IblAlquiler";
            this.IblAlquiler.Size = new System.Drawing.Size(62, 19);
            this.IblAlquiler.TabIndex = 0;
            this.IblAlquiler.Text = "Alquiler";
            this.IblAlquiler.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // mrcGastosVarios
            // 
            this.mrcGastosVarios.Controls.Add(this.txtMonto);
            this.mrcGastosVarios.Controls.Add(this.IblMonto);
            this.mrcGastosVarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosVarios.Location = new System.Drawing.Point(3, 216);
            this.mrcGastosVarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mrcGastosVarios.Name = "mrcGastosVarios";
            this.mrcGastosVarios.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mrcGastosVarios.Size = new System.Drawing.Size(239, 82);
            this.mrcGastosVarios.TabIndex = 3;
            this.mrcGastosVarios.TabStop = false;
            this.mrcGastosVarios.Text = "Gastos Varios";
            this.mrcGastosVarios.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(84, 28);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(86, 21);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.Text = "0";
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // IblMonto
            // 
            this.IblMonto.AutoSize = true;
            this.IblMonto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblMonto.Location = new System.Drawing.Point(12, 28);
            this.IblMonto.Name = "IblMonto";
            this.IblMonto.Size = new System.Drawing.Size(53, 19);
            this.IblMonto.TabIndex = 0;
            this.IblMonto.Text = "Monto";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.Black;
            this.cmdCancelar.Location = new System.Drawing.Point(143, 366);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(76, 30);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.ForeColor = System.Drawing.Color.Black;
            this.cmdGrabar.Location = new System.Drawing.Point(21, 366);
            this.cmdGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(77, 30);
            this.cmdGrabar.TabIndex = 5;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // mrcIngresos
            // 
            this.mrcIngresos.Controls.Add(this.IblDeposito);
            this.mrcIngresos.Controls.Add(this.txtDeposito);
            this.mrcIngresos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngresos.Location = new System.Drawing.Point(3, 1);
            this.mrcIngresos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mrcIngresos.Name = "mrcIngresos";
            this.mrcIngresos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mrcIngresos.Size = new System.Drawing.Size(239, 89);
            this.mrcIngresos.TabIndex = 2;
            this.mrcIngresos.TabStop = false;
            this.mrcIngresos.Text = "Ingresos";
            // 
            // IblDeposito
            // 
            this.IblDeposito.AutoSize = true;
            this.IblDeposito.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblDeposito.Location = new System.Drawing.Point(4, 36);
            this.IblDeposito.Name = "IblDeposito";
            this.IblDeposito.Size = new System.Drawing.Size(69, 19);
            this.IblDeposito.TabIndex = 2;
            this.IblDeposito.Text = "Deposito";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(16, 318);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 26);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(87, 321);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(86, 23);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "0";
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // frmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(276, 409);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.mrcIngresos);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.mrcGastoFijo);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.mrcGastosVarios);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Orange;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFinanzas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Finanzas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mrcGastoFijo.ResumeLayout(false);
            this.mrcGastoFijo.PerformLayout();
            this.mrcGastosVarios.ResumeLayout(false);
            this.mrcGastosVarios.PerformLayout();
            this.mrcIngresos.ResumeLayout(false);
            this.mrcIngresos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.GroupBox mrcGastoFijo;
        private System.Windows.Forms.Label IblAlquiler;
        private System.Windows.Forms.Label IblImpuesto;
        private System.Windows.Forms.Label IblComida;
        private System.Windows.Forms.GroupBox mrcGastosVarios;
        private System.Windows.Forms.Label IblMonto;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.GroupBox mrcIngresos;
        private System.Windows.Forms.Label IblDeposito;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

