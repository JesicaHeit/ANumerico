namespace WindowsFormsApp1
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uNIDADN1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bISECCIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGLAFALSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWTONRAPHSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sECANTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNIDADN2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoGaussJordanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoGaussSeidelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNIDADN3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNIDADN4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regresionLinealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNIDADN1ToolStripMenuItem,
            this.uNIDADN2ToolStripMenuItem,
            this.uNIDADN3ToolStripMenuItem,
            this.uNIDADN4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uNIDADN1ToolStripMenuItem
            // 
            this.uNIDADN1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bISECCIONToolStripMenuItem,
            this.rEGLAFALSAToolStripMenuItem,
            this.nEWTONRAPHSONToolStripMenuItem,
            this.sECANTEToolStripMenuItem});
            this.uNIDADN1ToolStripMenuItem.Name = "uNIDADN1ToolStripMenuItem";
            this.uNIDADN1ToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.uNIDADN1ToolStripMenuItem.Text = "UNIDAD N° 1";
            this.uNIDADN1ToolStripMenuItem.Click += new System.EventHandler(this.UNIDADN1ToolStripMenuItem_Click);
            // 
            // bISECCIONToolStripMenuItem
            // 
            this.bISECCIONToolStripMenuItem.Name = "bISECCIONToolStripMenuItem";
            this.bISECCIONToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.bISECCIONToolStripMenuItem.Text = "Método de Bisección";
            this.bISECCIONToolStripMenuItem.Click += new System.EventHandler(this.BISECCIONToolStripMenuItem_Click);
            // 
            // rEGLAFALSAToolStripMenuItem
            // 
            this.rEGLAFALSAToolStripMenuItem.Name = "rEGLAFALSAToolStripMenuItem";
            this.rEGLAFALSAToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.rEGLAFALSAToolStripMenuItem.Text = "Método de Regla Falsa";
            this.rEGLAFALSAToolStripMenuItem.Click += new System.EventHandler(this.REGLAFALSAToolStripMenuItem_Click);
            // 
            // nEWTONRAPHSONToolStripMenuItem
            // 
            this.nEWTONRAPHSONToolStripMenuItem.Name = "nEWTONRAPHSONToolStripMenuItem";
            this.nEWTONRAPHSONToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.nEWTONRAPHSONToolStripMenuItem.Text = "Método de Newton Raphson";
            this.nEWTONRAPHSONToolStripMenuItem.Click += new System.EventHandler(this.NEWTONRAPHSONToolStripMenuItem_Click);
            // 
            // sECANTEToolStripMenuItem
            // 
            this.sECANTEToolStripMenuItem.Name = "sECANTEToolStripMenuItem";
            this.sECANTEToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.sECANTEToolStripMenuItem.Text = "Método de la Secante";
            this.sECANTEToolStripMenuItem.Click += new System.EventHandler(this.SECANTEToolStripMenuItem_Click);
            // 
            // uNIDADN2ToolStripMenuItem
            // 
            this.uNIDADN2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodoGaussJordanToolStripMenuItem,
            this.metodoGaussSeidelToolStripMenuItem});
            this.uNIDADN2ToolStripMenuItem.Name = "uNIDADN2ToolStripMenuItem";
            this.uNIDADN2ToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.uNIDADN2ToolStripMenuItem.Text = "UNIDAD N° 2";
            this.uNIDADN2ToolStripMenuItem.Click += new System.EventHandler(this.uNIDADN2ToolStripMenuItem_Click);
            // 
            // metodoGaussJordanToolStripMenuItem
            // 
            this.metodoGaussJordanToolStripMenuItem.Name = "metodoGaussJordanToolStripMenuItem";
            this.metodoGaussJordanToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.metodoGaussJordanToolStripMenuItem.Text = "Metodo Gauss Jordan";
            this.metodoGaussJordanToolStripMenuItem.Click += new System.EventHandler(this.MetodoGaussJordanToolStripMenuItem_Click);
            // 
            // metodoGaussSeidelToolStripMenuItem
            // 
            this.metodoGaussSeidelToolStripMenuItem.Name = "metodoGaussSeidelToolStripMenuItem";
            this.metodoGaussSeidelToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.metodoGaussSeidelToolStripMenuItem.Text = "Metodo Gauss Seidel";
            this.metodoGaussSeidelToolStripMenuItem.Click += new System.EventHandler(this.metodoGaussSeidelToolStripMenuItem_Click);
            // 
            // uNIDADN3ToolStripMenuItem
            // 
            this.uNIDADN3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresionLinealToolStripMenuItem});
            this.uNIDADN3ToolStripMenuItem.Name = "uNIDADN3ToolStripMenuItem";
            this.uNIDADN3ToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.uNIDADN3ToolStripMenuItem.Text = "UNIDAD N° 3";
            // 
            // uNIDADN4ToolStripMenuItem
            // 
            this.uNIDADN4ToolStripMenuItem.Name = "uNIDADN4ToolStripMenuItem";
            this.uNIDADN4ToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.uNIDADN4ToolStripMenuItem.Text = "UNIDAD N° 4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "ANÁLISIS NUMÉRICO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 427);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Albrecht Eugenia - Heit Jesica";
            // 
            // regresionLinealToolStripMenuItem
            // 
            this.regresionLinealToolStripMenuItem.Name = "regresionLinealToolStripMenuItem";
            this.regresionLinealToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regresionLinealToolStripMenuItem.Text = "Regresion Lineal";
            this.regresionLinealToolStripMenuItem.Click += new System.EventHandler(this.RegresionLinealToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uNIDADN1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bISECCIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGLAFALSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWTONRAPHSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sECANTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNIDADN2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNIDADN3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNIDADN4ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem metodoGaussJordanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoGaussSeidelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresionLinealToolStripMenuItem;
    }
}

