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
            this.mrcAlacena = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboMarca2 = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.lstAlacena = new System.Windows.Forms.ListBox();
            this.mrcHeladera = new System.Windows.Forms.GroupBox();
            this.nudCantidad2 = new System.Windows.Forms.NumericUpDown();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.lblCantidad2 = new System.Windows.Forms.Label();
            this.lblProductos2 = new System.Windows.Forms.Label();
            this.cboProducto2 = new System.Windows.Forms.ComboBox();
            this.lstHeladera = new System.Windows.Forms.ListBox();
            this.mrcAlacena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.mrcHeladera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad2)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcAlacena
            // 
            this.mrcAlacena.Controls.Add(this.nudCantidad);
            this.mrcAlacena.Controls.Add(this.cboMarca2);
            this.mrcAlacena.Controls.Add(this.lblMarca);
            this.mrcAlacena.Controls.Add(this.lblCantidad);
            this.mrcAlacena.Controls.Add(this.lblProductos);
            this.mrcAlacena.Controls.Add(this.cboProducto);
            this.mrcAlacena.Location = new System.Drawing.Point(12, 163);
            this.mrcAlacena.Name = "mrcAlacena";
            this.mrcAlacena.Size = new System.Drawing.Size(241, 140);
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
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(51, 87);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.iblMarca_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(48, 59);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.iblCantidad_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(48, 29);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(58, 13);
            this.lblProductos.TabIndex = 2;
            this.lblProductos.Text = "Productos ";
            this.lblProductos.Click += new System.EventHandler(this.label3_Click);
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
            this.cmdGuardar.Location = new System.Drawing.Point(34, 548);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 2;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(150, 548);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // lstAlacena
            // 
            this.lstAlacena.FormattingEnabled = true;
            this.lstAlacena.Location = new System.Drawing.Point(10, 434);
            this.lstAlacena.Name = "lstAlacena";
            this.lstAlacena.Size = new System.Drawing.Size(215, 108);
            this.lstAlacena.TabIndex = 4;
            this.lstAlacena.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // mrcHeladera
            // 
            this.mrcHeladera.Controls.Add(this.nudCantidad2);
            this.mrcHeladera.Controls.Add(this.cboMarca);
            this.mrcHeladera.Controls.Add(this.lblMarca2);
            this.mrcHeladera.Controls.Add(this.lblCantidad2);
            this.mrcHeladera.Controls.Add(this.lblProductos2);
            this.mrcHeladera.Controls.Add(this.cboProducto2);
            this.mrcHeladera.Location = new System.Drawing.Point(12, 12);
            this.mrcHeladera.Name = "mrcHeladera";
            this.mrcHeladera.Size = new System.Drawing.Size(241, 140);
            this.mrcHeladera.TabIndex = 5;
            this.mrcHeladera.TabStop = false;
            this.mrcHeladera.Text = "Heladera";
            // 
            // nudCantidad2
            // 
            this.nudCantidad2.Location = new System.Drawing.Point(120, 53);
            this.nudCantidad2.Name = "nudCantidad2";
            this.nudCantidad2.Size = new System.Drawing.Size(95, 20);
            this.nudCantidad2.TabIndex = 7;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Items.AddRange(new object[] {
            "Rosamonte",
            "Dos Hermanos",
            "Don felipe"});
            this.cboMarca.Location = new System.Drawing.Point(118, 84);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(95, 21);
            this.cboMarca.TabIndex = 6;
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Location = new System.Drawing.Point(51, 87);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(37, 13);
            this.lblMarca2.TabIndex = 4;
            this.lblMarca2.Text = "Marca";
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.AutoSize = true;
            this.lblCantidad2.Location = new System.Drawing.Point(48, 59);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad2.TabIndex = 3;
            this.lblCantidad2.Text = "Cantidad";
            // 
            // lblProductos2
            // 
            this.lblProductos2.AutoSize = true;
            this.lblProductos2.Location = new System.Drawing.Point(48, 29);
            this.lblProductos2.Name = "lblProductos2";
            this.lblProductos2.Size = new System.Drawing.Size(58, 13);
            this.lblProductos2.TabIndex = 2;
            this.lblProductos2.Text = "Productos ";
            // 
            // cboProducto2
            // 
            this.cboProducto2.FormattingEnabled = true;
            this.cboProducto2.Items.AddRange(new object[] {
            "Fideos",
            "Arroz",
            "Azucar",
            "Yerba"});
            this.cboProducto2.Location = new System.Drawing.Point(120, 26);
            this.cboProducto2.Name = "cboProducto2";
            this.cboProducto2.Size = new System.Drawing.Size(95, 21);
            this.cboProducto2.TabIndex = 0;
            // 
            // lstHeladera
            // 
            this.lstHeladera.FormattingEnabled = true;
            this.lstHeladera.Location = new System.Drawing.Point(10, 320);
            this.lstHeladera.Name = "lstHeladera";
            this.lstHeladera.Size = new System.Drawing.Size(215, 108);
            this.lstHeladera.TabIndex = 6;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 637);
            this.Controls.Add(this.lstHeladera);
            this.Controls.Add(this.mrcHeladera);
            this.Controls.Add(this.lstAlacena);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mrcAlacena);
            this.Name = "frmAlacena";
            this.Text = "Alacena";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            this.mrcAlacena.ResumeLayout(false);
            this.mrcAlacena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.mrcHeladera.ResumeLayout(false);
            this.mrcHeladera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox mrcAlacena;
        private System.Windows.Forms.ComboBox cboMarca2;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ListBox lstAlacena;
        private System.Windows.Forms.GroupBox mrcHeladera;
        private System.Windows.Forms.NumericUpDown nudCantidad2;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.Label lblCantidad2;
        private System.Windows.Forms.Label lblProductos2;
        private System.Windows.Forms.ComboBox cboProducto2;
        private System.Windows.Forms.ListBox lstHeladera;
    }
}