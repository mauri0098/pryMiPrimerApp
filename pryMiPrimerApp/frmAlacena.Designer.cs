namespace pryMiPrimerApp
{
    partial class frmAlacena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcHeladera = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.itsMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCantida = new System.Windows.Forms.Label();
            this.lblProductoslacteos = new System.Windows.Forms.Label();
            this.istProductos = new System.Windows.Forms.ComboBox();
            this.mrcAlacena = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboMarca2 = new System.Windows.Forms.ComboBox();
            this.iblMarca = new System.Windows.Forms.Label();
            this.iblCantidad = new System.Windows.Forms.Label();
            this.iblProductos = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.istAlacena = new System.Windows.Forms.ListBox();
            this.mrcHeladera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.mrcAlacena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcHeladera
            // 
            this.mrcHeladera.Controls.Add(this.numericUpDown1);
            this.mrcHeladera.Controls.Add(this.itsMarca);
            this.mrcHeladera.Controls.Add(this.lblMarca);
            this.mrcHeladera.Controls.Add(this.lblCantida);
            this.mrcHeladera.Controls.Add(this.lblProductoslacteos);
            this.mrcHeladera.Controls.Add(this.istProductos);
            this.mrcHeladera.Location = new System.Drawing.Point(2, 12);
            this.mrcHeladera.Name = "mrcHeladera";
            this.mrcHeladera.Size = new System.Drawing.Size(241, 119);
            this.mrcHeladera.TabIndex = 0;
            this.mrcHeladera.TabStop = false;
            this.mrcHeladera.Text = "Heladera";
            this.mrcHeladera.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(120, 52);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // itsMarca
            // 
            this.itsMarca.FormattingEnabled = true;
            this.itsMarca.Items.AddRange(new object[] {
            "Finlandia ",
            "Casamcrem",
            "serenisiam",
            "baggio"});
            this.itsMarca.Location = new System.Drawing.Point(120, 79);
            this.itsMarca.Name = "itsMarca";
            this.itsMarca.Size = new System.Drawing.Size(95, 21);
            this.itsMarca.TabIndex = 6;
            this.itsMarca.SelectedIndexChanged += new System.EventHandler(this.itsMarca_SelectedIndexChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(43, 87);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca ";
            // 
            // lblCantida
            // 
            this.lblCantida.AutoSize = true;
            this.lblCantida.Location = new System.Drawing.Point(40, 54);
            this.lblCantida.Name = "lblCantida";
            this.lblCantida.Size = new System.Drawing.Size(49, 13);
            this.lblCantida.TabIndex = 3;
            this.lblCantida.Text = "Cantidad";
            this.lblCantida.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblProductoslacteos
            // 
            this.lblProductoslacteos.AutoSize = true;
            this.lblProductoslacteos.Location = new System.Drawing.Point(10, 24);
            this.lblProductoslacteos.Name = "lblProductoslacteos";
            this.lblProductoslacteos.Size = new System.Drawing.Size(96, 13);
            this.lblProductoslacteos.TabIndex = 2;
            this.lblProductoslacteos.Text = "Productos Lacteos";
            this.lblProductoslacteos.Click += new System.EventHandler(this.label1_Click);
            // 
            // istProductos
            // 
            this.istProductos.FormattingEnabled = true;
            this.istProductos.Items.AddRange(new object[] {
            "Leche ",
            "Huevo",
            "Manteca ",
            "Queso",
            "Jugo"});
            this.istProductos.Location = new System.Drawing.Point(120, 21);
            this.istProductos.Name = "istProductos";
            this.istProductos.Size = new System.Drawing.Size(95, 21);
            this.istProductos.TabIndex = 0;
            this.istProductos.SelectedIndexChanged += new System.EventHandler(this.istProductos_SelectedIndexChanged);
            // 
            // mrcAlacena
            // 
            this.mrcAlacena.Controls.Add(this.nudCantidad);
            this.mrcAlacena.Controls.Add(this.cboMarca2);
            this.mrcAlacena.Controls.Add(this.iblMarca);
            this.mrcAlacena.Controls.Add(this.iblCantidad);
            this.mrcAlacena.Controls.Add(this.iblProductos);
            this.mrcAlacena.Controls.Add(this.cboProducto);
            this.mrcAlacena.Location = new System.Drawing.Point(2, 137);
            this.mrcAlacena.Name = "mrcAlacena";
            this.mrcAlacena.Size = new System.Drawing.Size(241, 123);
            this.mrcAlacena.TabIndex = 1;
            this.mrcAlacena.TabStop = false;
            this.mrcAlacena.Text = "Alacena";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(120, 53);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(95, 20);
            this.nudCantidad.TabIndex = 7;
            // 
            // cboMarca2
            // 
            this.cboMarca2.FormattingEnabled = true;
            this.cboMarca2.Items.AddRange(new object[] {
            "Rosamonte",
            "Dos Hermanos",
            "Don felipe"});
            this.cboMarca2.Location = new System.Drawing.Point(120, 79);
            this.cboMarca2.Name = "cboMarca2";
            this.cboMarca2.Size = new System.Drawing.Size(95, 21);
            this.cboMarca2.TabIndex = 6;
            // 
            // iblMarca
            // 
            this.iblMarca.AutoSize = true;
            this.iblMarca.Location = new System.Drawing.Point(51, 87);
            this.iblMarca.Name = "iblMarca";
            this.iblMarca.Size = new System.Drawing.Size(43, 13);
            this.iblMarca.TabIndex = 4;
            this.iblMarca.Text = "Marca2";
            this.iblMarca.Click += new System.EventHandler(this.iblMarca_Click);
            // 
            // iblCantidad
            // 
            this.iblCantidad.AutoSize = true;
            this.iblCantidad.Location = new System.Drawing.Point(48, 59);
            this.iblCantidad.Name = "iblCantidad";
            this.iblCantidad.Size = new System.Drawing.Size(55, 13);
            this.iblCantidad.TabIndex = 3;
            this.iblCantidad.Text = "Cantidad2";
            this.iblCantidad.Click += new System.EventHandler(this.iblCantidad_Click);
            // 
            // iblProductos
            // 
            this.iblProductos.AutoSize = true;
            this.iblProductos.Location = new System.Drawing.Point(48, 29);
            this.iblProductos.Name = "iblProductos";
            this.iblProductos.Size = new System.Drawing.Size(58, 13);
            this.iblProductos.TabIndex = 2;
            this.iblProductos.Text = "Productos ";
            this.iblProductos.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Items.AddRange(new object[] {
            "Fideos",
            "Arroz",
            "Azucar",
            "Yerba"});
            this.cboProducto.Location = new System.Drawing.Point(120, 21);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(95, 21);
            this.cboProducto.TabIndex = 0;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(33, 467);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 2;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(122, 467);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // istAlacena
            // 
            this.istAlacena.FormattingEnabled = true;
            this.istAlacena.Location = new System.Drawing.Point(2, 272);
            this.istAlacena.Name = "istAlacena";
            this.istAlacena.Size = new System.Drawing.Size(241, 186);
            this.istAlacena.TabIndex = 4;
            this.istAlacena.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 502);
            this.Controls.Add(this.istAlacena);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mrcAlacena);
            this.Controls.Add(this.mrcHeladera);
            this.Name = "frmAlacena";
            this.Text = "Alacena";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            this.mrcHeladera.ResumeLayout(false);
            this.mrcHeladera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.mrcAlacena.ResumeLayout(false);
            this.mrcAlacena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcHeladera;
        private System.Windows.Forms.ComboBox istProductos;
        private System.Windows.Forms.Label lblProductoslacteos;
        private System.Windows.Forms.Label lblCantida;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox itsMarca;
        private System.Windows.Forms.GroupBox mrcAlacena;
        private System.Windows.Forms.ComboBox cboMarca2;
        private System.Windows.Forms.Label iblMarca;
        private System.Windows.Forms.Label iblCantidad;
        private System.Windows.Forms.Label iblProductos;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ListBox istAlacena;
    }
}