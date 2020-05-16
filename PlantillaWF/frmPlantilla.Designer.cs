namespace PlantillaWF
{
    partial class frmPlantilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlantilla));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMinimitzar = new System.Windows.Forms.PictureBox();
            this.btTancar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimitzar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btTancar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btTancar);
            this.panel1.Controls.Add(this.btMinimitzar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btMinimitzar
            // 
            this.btMinimitzar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btMinimitzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimitzar.Image = global::PlantillaWF.Properties.Resources.iconMinimitzar;
            this.btMinimitzar.Location = new System.Drawing.Point(726, 8);
            this.btMinimitzar.Name = "btMinimitzar";
            this.btMinimitzar.Size = new System.Drawing.Size(27, 27);
            this.btMinimitzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btMinimitzar.TabIndex = 4;
            this.btMinimitzar.TabStop = false;
            this.btMinimitzar.Click += new System.EventHandler(this.btMinimitzar_Click);
            // 
            // btTancar
            // 
            this.btTancar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btTancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTancar.Image = global::PlantillaWF.Properties.Resources.iconTancar;
            this.btTancar.Location = new System.Drawing.Point(760, 7);
            this.btTancar.Name = "btTancar";
            this.btTancar.Size = new System.Drawing.Size(25, 25);
            this.btTancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btTancar.TabIndex = 3;
            this.btTancar.TabStop = false;
            this.btTancar.Click += new System.EventHandler(this.btTancar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PlantillaWF.Properties.Resources.iconBluePACS;
            this.pictureBox1.Location = new System.Drawing.Point(650, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(2, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 40);
            this.panel2.TabIndex = 3;
            // 
            // frmPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlantilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantilla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btMinimitzar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btTancar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btTancar;
        private System.Windows.Forms.PictureBox btMinimitzar;
        private System.Windows.Forms.Panel panel2;
    }
}

