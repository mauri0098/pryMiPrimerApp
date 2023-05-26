namespace pryMiPrimerApp
{
    partial class frmAlmancen
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
            this.mrcAlacena.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcAlacena.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.mrcAlacena.Location = new System.Drawing.Point(12, 163);
            this.mrcAlacena.Name = "mrcAlacena";
            this.mrcAlacena.Size = new System.Drawing.Size(222, 140);
            this.mrcAlacena.TabIndex = 1;
            this.mrcAlacena.TabStop = false;
            this.mrcAlacena.Text = "Alacena";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(86, 57);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(95, 23);
            this.nudCantidad.TabIndex = 7;
            // 
            // cboMarca2
            // 
            this.cboMarca2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca2.FormattingEnabled = true;
            this.cboMarca2.Items.AddRange(new object[] {
            "Rosamonte",
            "Dos Hermanos",
            "Don felipe"});
            this.cboMarca2.Location = new System.Drawing.Point(86, 85);
            this.cboMarca2.Name = "cboMarca2";
            this.cboMarca2.Size = new System.Drawing.Size(95, 24);
            this.cboMarca2.TabIndex = 6;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMarca.Location = new System.Drawing.Point(7, 87);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 17);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.iblMarca_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCantidad.Location = new System.Drawing.Point(6, 59);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(63, 17);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.iblCantidad_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblProductos.Location = new System.Drawing.Point(6, 34);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(74, 17);
            this.lblProductos.TabIndex = 2;
            this.lblProductos.Text = "Productos ";
            this.lblProductos.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboProducto
            // 
            this.cboProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Items.AddRange(new object[] {
            "Fideos",
            "Arroz",
            "Azucar",
            "Yerba"});
            this.cboProducto.Location = new System.Drawing.Point(86, 27);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(95, 24);
            this.cboProducto.TabIndex = 0;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.ForeColor = System.Drawing.Color.Black;
            this.cmdGuardar.Location = new System.Drawing.Point(22, 463);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 43);
            this.cmdGuardar.TabIndex = 2;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.Black;
            this.cmdCancelar.Location = new System.Drawing.Point(143, 463);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 43);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // lstAlacena
            // 
            this.lstAlacena.FormattingEnabled = true;
            this.lstAlacena.Location = new System.Drawing.Point(12, 384);
            this.lstAlacena.Name = "lstAlacena";
            this.lstAlacena.Size = new System.Drawing.Size(222, 69);
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
            this.mrcHeladera.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcHeladera.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.mrcHeladera.Location = new System.Drawing.Point(12, 12);
            this.mrcHeladera.Name = "mrcHeladera";
            this.mrcHeladera.Size = new System.Drawing.Size(222, 140);
            this.mrcHeladera.TabIndex = 5;
            this.mrcHeladera.TabStop = false;
            this.mrcHeladera.Text = "Heladera";
            // 
            // nudCantidad2
            // 
            this.nudCantidad2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad2.Location = new System.Drawing.Point(86, 59);
            this.nudCantidad2.Name = "nudCantidad2";
            this.nudCantidad2.Size = new System.Drawing.Size(95, 23);
            this.nudCantidad2.TabIndex = 7;
            // 
            // cboMarca
            // 
            this.cboMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Items.AddRange(new object[] {
            "Serenisima",
            "Huevo San Juan",
            "CoCa Cola",
            "Pepsi",
            "Finlandia "});
            this.cboMarca.Location = new System.Drawing.Point(86, 89);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(97, 24);
            this.cboMarca.TabIndex = 6;
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMarca2.Location = new System.Drawing.Point(6, 94);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(51, 19);
            this.lblMarca2.TabIndex = 4;
            this.lblMarca2.Text = "Marca";
            this.lblMarca2.Click += new System.EventHandler(this.lblMarca2_Click);
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.AutoSize = true;
            this.lblCantidad2.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCantidad2.Location = new System.Drawing.Point(6, 59);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(69, 19);
            this.lblCantidad2.TabIndex = 3;
            this.lblCantidad2.Text = "Cantidad";
            // 
            // lblProductos2
            // 
            this.lblProductos2.AutoSize = true;
            this.lblProductos2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos2.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblProductos2.Location = new System.Drawing.Point(7, 36);
            this.lblProductos2.Name = "lblProductos2";
            this.lblProductos2.Size = new System.Drawing.Size(74, 17);
            this.lblProductos2.TabIndex = 2;
            this.lblProductos2.Text = "Productos ";
            // 
            // cboProducto2
            // 
            this.cboProducto2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProducto2.FormattingEnabled = true;
            this.cboProducto2.Items.AddRange(new object[] {
            "Huevo",
            "Leche",
            "Yogur",
            "Queso",
            "Bebidas"});
            this.cboProducto2.Location = new System.Drawing.Point(87, 29);
            this.cboProducto2.Name = "cboProducto2";
            this.cboProducto2.Size = new System.Drawing.Size(95, 24);
            this.cboProducto2.TabIndex = 0;
            // 
            // lstHeladera
            // 
            this.lstHeladera.ForeColor = System.Drawing.Color.Black;
            this.lstHeladera.FormattingEnabled = true;
            this.lstHeladera.Location = new System.Drawing.Point(12, 309);
            this.lstHeladera.Name = "lstHeladera";
            this.lstHeladera.Size = new System.Drawing.Size(222, 69);
            this.lstHeladera.TabIndex = 6;
            // 
            // frmAlmancen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(251, 529);
            this.Controls.Add(this.lstHeladera);
            this.Controls.Add(this.mrcHeladera);
            this.Controls.Add(this.lstAlacena);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mrcAlacena);
            this.ForeColor = System.Drawing.Color.Peru;
            this.Name = "frmAlmancen";
            this.Text = "Almacen";
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