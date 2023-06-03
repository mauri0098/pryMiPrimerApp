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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmancen));
            this.mrcAlacena = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lstMarca2 = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.IblCantidad = new System.Windows.Forms.Label();
            this.IblProductos = new System.Windows.Forms.Label();
            this.lstProducto = new System.Windows.Forms.ComboBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.lstAlacena = new System.Windows.Forms.ListBox();
            this.mrcHeladera = new System.Windows.Forms.GroupBox();
            this.nudCantidad2 = new System.Windows.Forms.NumericUpDown();
            this.lstMarca = new System.Windows.Forms.ComboBox();
            this.IblMarca2 = new System.Windows.Forms.Label();
            this.IblCantidad2 = new System.Windows.Forms.Label();
            this.IblProductos2 = new System.Windows.Forms.Label();
            this.lstProducto2 = new System.Windows.Forms.ComboBox();
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
            this.mrcAlacena.Controls.Add(this.lstMarca2);
            this.mrcAlacena.Controls.Add(this.lblMarca);
            this.mrcAlacena.Controls.Add(this.IblCantidad);
            this.mrcAlacena.Controls.Add(this.IblProductos);
            this.mrcAlacena.Controls.Add(this.lstProducto);
            this.mrcAlacena.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcAlacena.ForeColor = System.Drawing.Color.Black;
            this.mrcAlacena.Location = new System.Drawing.Point(3, 219);
            this.mrcAlacena.Name = "mrcAlacena";
            this.mrcAlacena.Size = new System.Drawing.Size(231, 140);
            this.mrcAlacena.TabIndex = 1;
            this.mrcAlacena.TabStop = false;
            this.mrcAlacena.Text = "Alacena";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(86, 63);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(106, 23);
            this.nudCantidad.TabIndex = 7;
            // 
            // lstMarca2
            // 
            this.lstMarca2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMarca2.FormattingEnabled = true;
            this.lstMarca2.Items.AddRange(new object[] {
            "Rosamonte",
            "Dos Hermanos",
            "Don felipe",
            "Zulka",
            "Arcor",
            "La Virginia",
            "Litorial"});
            this.lstMarca2.Location = new System.Drawing.Point(86, 96);
            this.lstMarca2.Name = "lstMarca2";
            this.lstMarca2.Size = new System.Drawing.Size(106, 25);
            this.lstMarca2.TabIndex = 6;
            this.lstMarca2.SelectedIndexChanged += new System.EventHandler(this.lstMarca2_SelectedIndexChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Black;
            this.lblMarca.Location = new System.Drawing.Point(9, 104);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 17);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.iblMarca_Click);
            // 
            // IblCantidad
            // 
            this.IblCantidad.AutoSize = true;
            this.IblCantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblCantidad.ForeColor = System.Drawing.Color.Black;
            this.IblCantidad.Location = new System.Drawing.Point(6, 69);
            this.IblCantidad.Name = "IblCantidad";
            this.IblCantidad.Size = new System.Drawing.Size(63, 17);
            this.IblCantidad.TabIndex = 3;
            this.IblCantidad.Text = "Cantidad";
            this.IblCantidad.Click += new System.EventHandler(this.iblCantidad_Click);
            // 
            // IblProductos
            // 
            this.IblProductos.AutoSize = true;
            this.IblProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblProductos.ForeColor = System.Drawing.Color.Black;
            this.IblProductos.Location = new System.Drawing.Point(6, 35);
            this.IblProductos.Name = "IblProductos";
            this.IblProductos.Size = new System.Drawing.Size(74, 17);
            this.IblProductos.TabIndex = 2;
            this.IblProductos.Text = "Productos ";
            this.IblProductos.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstProducto
            // 
            this.lstProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Items.AddRange(new object[] {
            "Fideos",
            "Arroz",
            "Azucar",
            "Yerba",
            "Polenta ",
            "Te",
            "Mate Cocido"});
            this.lstProducto.Location = new System.Drawing.Point(86, 32);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(106, 25);
            this.lstProducto.TabIndex = 0;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.ForeColor = System.Drawing.Color.Black;
            this.cmdGuardar.Location = new System.Drawing.Point(15, 428);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 27);
            this.cmdGuardar.TabIndex = 2;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.Black;
            this.cmdCancelar.Location = new System.Drawing.Point(120, 428);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 27);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // lstAlacena
            // 
            this.lstAlacena.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAlacena.FormattingEnabled = true;
            this.lstAlacena.ItemHeight = 17;
            this.lstAlacena.Location = new System.Drawing.Point(3, 365);
            this.lstAlacena.Name = "lstAlacena";
            this.lstAlacena.Size = new System.Drawing.Size(231, 55);
            this.lstAlacena.TabIndex = 4;
            this.lstAlacena.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // mrcHeladera
            // 
            this.mrcHeladera.Controls.Add(this.nudCantidad2);
            this.mrcHeladera.Controls.Add(this.lstMarca);
            this.mrcHeladera.Controls.Add(this.IblMarca2);
            this.mrcHeladera.Controls.Add(this.IblCantidad2);
            this.mrcHeladera.Controls.Add(this.IblProductos2);
            this.mrcHeladera.Controls.Add(this.lstProducto2);
            this.mrcHeladera.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcHeladera.ForeColor = System.Drawing.Color.Black;
            this.mrcHeladera.Location = new System.Drawing.Point(3, 12);
            this.mrcHeladera.Name = "mrcHeladera";
            this.mrcHeladera.Size = new System.Drawing.Size(231, 140);
            this.mrcHeladera.TabIndex = 5;
            this.mrcHeladera.TabStop = false;
            this.mrcHeladera.Text = "Heladera";
            this.mrcHeladera.Enter += new System.EventHandler(this.mrcHeladera_Enter);
            // 
            // nudCantidad2
            // 
            this.nudCantidad2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad2.Location = new System.Drawing.Point(86, 65);
            this.nudCantidad2.Name = "nudCantidad2";
            this.nudCantidad2.Size = new System.Drawing.Size(106, 23);
            this.nudCantidad2.TabIndex = 7;
            // 
            // lstMarca
            // 
            this.lstMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMarca.FormattingEnabled = true;
            this.lstMarca.Items.AddRange(new object[] {
            "Huevo San Juan",
            "La Serenisima",
            "CoCa Cola",
            "Pepsi",
            "Finlandia ",
            "Super Cerdo",
            "Hellmann\'s",
            "La Paulina"});
            this.lstMarca.Location = new System.Drawing.Point(86, 99);
            this.lstMarca.Name = "lstMarca";
            this.lstMarca.Size = new System.Drawing.Size(106, 25);
            this.lstMarca.TabIndex = 6;
            this.lstMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // IblMarca2
            // 
            this.IblMarca2.AutoSize = true;
            this.IblMarca2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblMarca2.ForeColor = System.Drawing.Color.Black;
            this.IblMarca2.Location = new System.Drawing.Point(9, 102);
            this.IblMarca2.Name = "IblMarca2";
            this.IblMarca2.Size = new System.Drawing.Size(45, 17);
            this.IblMarca2.TabIndex = 4;
            this.IblMarca2.Text = "Marca";
            this.IblMarca2.Click += new System.EventHandler(this.lblMarca2_Click);
            // 
            // IblCantidad2
            // 
            this.IblCantidad2.AutoSize = true;
            this.IblCantidad2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblCantidad2.ForeColor = System.Drawing.Color.Black;
            this.IblCantidad2.Location = new System.Drawing.Point(6, 68);
            this.IblCantidad2.Name = "IblCantidad2";
            this.IblCantidad2.Size = new System.Drawing.Size(63, 17);
            this.IblCantidad2.TabIndex = 3;
            this.IblCantidad2.Text = "Cantidad";
            // 
            // IblProductos2
            // 
            this.IblProductos2.AutoSize = true;
            this.IblProductos2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblProductos2.ForeColor = System.Drawing.Color.Black;
            this.IblProductos2.Location = new System.Drawing.Point(6, 34);
            this.IblProductos2.Name = "IblProductos2";
            this.IblProductos2.Size = new System.Drawing.Size(74, 17);
            this.IblProductos2.TabIndex = 2;
            this.IblProductos2.Text = "Productos ";
            // 
            // lstProducto2
            // 
            this.lstProducto2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducto2.FormattingEnabled = true;
            this.lstProducto2.Items.AddRange(new object[] {
            "Huevo",
            "Leche",
            "Yogur",
            "Queso",
            "Bebidas",
            "Jamon",
            "Mayonesa",
            "Crema"});
            this.lstProducto2.Location = new System.Drawing.Point(86, 31);
            this.lstProducto2.Name = "lstProducto2";
            this.lstProducto2.Size = new System.Drawing.Size(106, 25);
            this.lstProducto2.TabIndex = 0;
            this.lstProducto2.SelectedIndexChanged += new System.EventHandler(this.cboProducto2_SelectedIndexChanged);
            // 
            // lstHeladera
            // 
            this.lstHeladera.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHeladera.ForeColor = System.Drawing.Color.Black;
            this.lstHeladera.FormattingEnabled = true;
            this.lstHeladera.ItemHeight = 17;
            this.lstHeladera.Location = new System.Drawing.Point(3, 158);
            this.lstHeladera.Name = "lstHeladera";
            this.lstHeladera.Size = new System.Drawing.Size(231, 55);
            this.lstHeladera.TabIndex = 6;
            // 
            // frmAlmancen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(238, 488);
            this.Controls.Add(this.lstHeladera);
            this.Controls.Add(this.mrcHeladera);
            this.Controls.Add(this.lstAlacena);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mrcAlacena);
            this.ForeColor = System.Drawing.Color.Peru;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ComboBox lstMarca2;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label IblCantidad;
        private System.Windows.Forms.Label IblProductos;
        private System.Windows.Forms.ComboBox lstProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ListBox lstAlacena;
        private System.Windows.Forms.GroupBox mrcHeladera;
        private System.Windows.Forms.NumericUpDown nudCantidad2;
        private System.Windows.Forms.ComboBox lstMarca;
        private System.Windows.Forms.Label IblMarca2;
        private System.Windows.Forms.Label IblCantidad2;
        private System.Windows.Forms.Label IblProductos2;
        private System.Windows.Forms.ComboBox lstProducto2;
        private System.Windows.Forms.ListBox lstHeladera;
    }
}