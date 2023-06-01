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
            this.txtDepocito = new System.Windows.Forms.TextBox();
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
            this.mrcIngresos = new System.Windows.Forms.GroupBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.mrcGastoFijo.SuspendLayout();
            this.mrcGastosVarios.SuspendLayout();
            this.mrcIngresos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDepocito
            // 
            this.txtDepocito.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepocito.Location = new System.Drawing.Point(84, 36);
            this.txtDepocito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDepocito.Name = "txtDepocito";
            this.txtDepocito.Size = new System.Drawing.Size(86, 21);
            this.txtDepocito.TabIndex = 1;
            this.txtDepocito.TextChanged += new System.EventHandler(this.txtIngreso_TextChanged);
            // 
            // mrcGastoFijo
            // 
            this.mrcGastoFijo.Controls.Add(this.txtComida);
            this.mrcGastoFijo.Controls.Add(this.txtImpuesto);
            this.mrcGastoFijo.Controls.Add(this.txtAlquiler);
            this.mrcGastoFijo.Controls.Add(this.lblComida);
            this.mrcGastoFijo.Controls.Add(this.lblImpuesto);
            this.mrcGastoFijo.Controls.Add(this.lblAlquiler);
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
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlquiler.Location = new System.Drawing.Point(84, 23);
            this.txtAlquiler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(86, 21);
            this.txtAlquiler.TabIndex = 3;
            this.txtAlquiler.TextChanged += new System.EventHandler(this.txtalquiler_TextChanged);
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComida.Location = new System.Drawing.Point(3, 79);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(61, 19);
            this.lblComida.TabIndex = 2;
            this.lblComida.Text = "Comida";
            this.lblComida.Click += new System.EventHandler(this.iblcomida_Click);
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.Location = new System.Drawing.Point(3, 52);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(71, 19);
            this.lblImpuesto.TabIndex = 1;
            this.lblImpuesto.Text = "Impuesto";
            this.lblImpuesto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquiler.Location = new System.Drawing.Point(4, 26);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(62, 19);
            this.lblAlquiler.TabIndex = 0;
            this.lblAlquiler.Text = "Alquiler";
            this.lblAlquiler.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // mrcGastosVarios
            // 
            this.mrcGastosVarios.Controls.Add(this.txtMonto);
            this.mrcGastosVarios.Controls.Add(this.lblMonto);
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
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(12, 28);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(53, 19);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.Black;
            this.cmdCancelar.Location = new System.Drawing.Point(128, 306);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(76, 36);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.ForeColor = System.Drawing.Color.Black;
            this.cmdGrabar.Location = new System.Drawing.Point(19, 306);
            this.cmdGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(77, 36);
            this.cmdGrabar.TabIndex = 5;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // mrcIngresos
            // 
            this.mrcIngresos.Controls.Add(this.lblDeposito);
            this.mrcIngresos.Controls.Add(this.txtDepocito);
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
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(4, 36);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(69, 19);
            this.lblDeposito.TabIndex = 2;
            this.lblDeposito.Text = "Deposito";
            // 
            // frmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(276, 345);
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
            this.Text = "Gestion de Finanzas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mrcGastoFijo.ResumeLayout(false);
            this.mrcGastoFijo.PerformLayout();
            this.mrcGastosVarios.ResumeLayout(false);
            this.mrcGastosVarios.PerformLayout();
            this.mrcIngresos.ResumeLayout(false);
            this.mrcIngresos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDepocito;
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
        private System.Windows.Forms.GroupBox mrcIngresos;
        private System.Windows.Forms.Label lblDeposito;
    }
}

