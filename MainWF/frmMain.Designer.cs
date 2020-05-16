namespace MainWF
{
    partial class frmMain
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
            this.btImgMF = new System.Windows.Forms.PictureBox();
            this.btImgDS = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btImgMF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btImgDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btImgMF
            // 
            this.btImgMF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImgMF.Image = global::MainWF.Properties.Resources.iconMillenniumFalconWhite;
            this.btImgMF.Location = new System.Drawing.Point(449, 336);
            this.btImgMF.Name = "btImgMF";
            this.btImgMF.Size = new System.Drawing.Size(150, 150);
            this.btImgMF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btImgMF.TabIndex = 4;
            this.btImgMF.TabStop = false;
            this.btImgMF.Click += new System.EventHandler(this.btImgMF_Click);
            // 
            // btImgDS
            // 
            this.btImgDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImgDS.Image = global::MainWF.Properties.Resources.iconDeathStarWhite;
            this.btImgDS.Location = new System.Drawing.Point(997, 336);
            this.btImgDS.Name = "btImgDS";
            this.btImgDS.Size = new System.Drawing.Size(150, 150);
            this.btImgDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btImgDS.TabIndex = 5;
            this.btImgDS.TabStop = false;
            this.btImgDS.Click += new System.EventHandler(this.btImgDS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(447, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inner Ring";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(995, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Outer Ring";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btImgDS);
            this.Controls.Add(this.btImgMF);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Controls.SetChildIndex(this.btImgMF, 0);
            this.Controls.SetChildIndex(this.btImgDS, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btImgMF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btImgDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btImgMF;
        private System.Windows.Forms.PictureBox btImgDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}