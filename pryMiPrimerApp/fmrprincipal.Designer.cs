namespace pryMiPrimerApp
{
    partial class fmrPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrPrincipal));
            this.cmdAlmacen = new System.Windows.Forms.Button();
            this.cmdFinanzas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAlmacen
            // 
            this.cmdAlmacen.BackColor = System.Drawing.Color.PeachPuff;
            this.cmdAlmacen.Location = new System.Drawing.Point(228, 29);
            this.cmdAlmacen.Name = "cmdAlmacen";
            this.cmdAlmacen.Size = new System.Drawing.Size(222, 268);
            this.cmdAlmacen.TabIndex = 0;
            this.cmdAlmacen.Text = "Almacen";
            this.cmdAlmacen.UseVisualStyleBackColor = false;
            this.cmdAlmacen.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdFinanzas
            // 
            this.cmdFinanzas.BackColor = System.Drawing.Color.LightYellow;
            this.cmdFinanzas.Location = new System.Drawing.Point(12, 29);
            this.cmdFinanzas.Name = "cmdFinanzas";
            this.cmdFinanzas.Size = new System.Drawing.Size(210, 268);
            this.cmdFinanzas.TabIndex = 1;
            this.cmdFinanzas.Text = "Finanzas";
            this.cmdFinanzas.UseVisualStyleBackColor = false;
            this.cmdFinanzas.Click += new System.EventHandler(this.button2_Click);
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(460, 304);
            this.Controls.Add(this.cmdFinanzas);
            this.Controls.Add(this.cmdAlmacen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAlmacen;
        private System.Windows.Forms.Button cmdFinanzas;
    }
}