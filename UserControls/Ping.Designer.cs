namespace UserControls
{
    partial class Ping
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
            this.btPing = new System.Windows.Forms.PictureBox();
            this.lbMissatge = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btPing)).BeginInit();
            this.SuspendLayout();
            // 
            // btPing
            // 
            this.btPing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPing.Image = global::UserControls.Properties.Resources.iconPingWhite;
            this.btPing.Location = new System.Drawing.Point(3, 3);
            this.btPing.Name = "btPing";
            this.btPing.Size = new System.Drawing.Size(60, 60);
            this.btPing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btPing.TabIndex = 0;
            this.btPing.TabStop = false;
            this.btPing.Click += new System.EventHandler(this.btPing_Click);
            // 
            // lbMissatge
            // 
            this.lbMissatge.AutoSize = true;
            this.lbMissatge.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMissatge.ForeColor = System.Drawing.Color.White;
            this.lbMissatge.Location = new System.Drawing.Point(78, 21);
            this.lbMissatge.Name = "lbMissatge";
            this.lbMissatge.Size = new System.Drawing.Size(0, 22);
            this.lbMissatge.TabIndex = 1;
            // 
            // Ping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lbMissatge);
            this.Controls.Add(this.btPing);
            this.Name = "Ping";
            this.Size = new System.Drawing.Size(335, 66);
            ((System.ComponentModel.ISupportInitialize)(this.btPing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btPing;
        private System.Windows.Forms.Label lbMissatge;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
