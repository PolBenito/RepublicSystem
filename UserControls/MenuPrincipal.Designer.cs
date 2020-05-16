namespace UserControls
{
    partial class MenuPrincipal
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btImgMain = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btImgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btImgMain
            // 
            this.btImgMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImgMain.Image = global::UserControls.Properties.Resources.iconGalacticRepublicBlack;
            this.btImgMain.Location = new System.Drawing.Point(3, 3);
            this.btImgMain.Name = "btImgMain";
            this.btImgMain.Size = new System.Drawing.Size(32, 32);
            this.btImgMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btImgMain.TabIndex = 0;
            this.btImgMain.TabStop = false;
            this.btImgMain.Click += new System.EventHandler(this.btImgMain_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btImgMain);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "MenuPrincipal";
            this.Size = new System.Drawing.Size(40, 38);
            ((System.ComponentModel.ISupportInitialize)(this.btImgMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btImgMain;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
