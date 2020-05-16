namespace PlanetaWF
{
    partial class frmPlaneta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaneta));
            this.btImgCGF = new System.Windows.Forms.PictureBox();
            this.btPanelCGF = new System.Windows.Forms.Panel();
            this.btLabelCGF = new System.Windows.Forms.Label();
            this.btImgAS = new System.Windows.Forms.PictureBox();
            this.btPanelAS = new System.Windows.Forms.Panel();
            this.btLabelAS = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btTancarPlaneta = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btPanelCF = new System.Windows.Forms.Panel();
            this.btLabelCF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btImgCF = new System.Windows.Forms.PictureBox();
            this.PnlTimer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ping1 = new UserControls.Ping();
            this.btLabelRb = new System.Windows.Forms.Label();
            this.btPanelRb = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btImgRb = new System.Windows.Forms.PictureBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblCodificacio = new System.Windows.Forms.Label();
            this.lblPACS = new System.Windows.Forms.Label();
            this.lblHash = new System.Windows.Forms.Label();
            this.TaparMssg = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btImgCGF)).BeginInit();
            this.btPanelCGF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgAS)).BeginInit();
            this.btPanelAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btTancarPlaneta)).BeginInit();
            this.btPanelCF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgCF)).BeginInit();
            this.btPanelRb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgRb)).BeginInit();
            this.SuspendLayout();
            // 
            // btImgCGF
            // 
            this.btImgCGF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImgCGF.Image = global::PlanetaWF.Properties.Resources.iconEncryptionWhite;
            this.btImgCGF.Location = new System.Drawing.Point(21, 16);
            this.btImgCGF.Name = "btImgCGF";
            this.btImgCGF.Size = new System.Drawing.Size(100, 100);
            this.btImgCGF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btImgCGF.TabIndex = 5;
            this.btImgCGF.TabStop = false;
            this.btImgCGF.Click += new System.EventHandler(this.btImgCGF_Click);
            // 
            // btPanelCGF
            // 
            this.btPanelCGF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btPanelCGF.Controls.Add(this.btLabelCGF);
            this.btPanelCGF.Controls.Add(this.btImgCGF);
            this.btPanelCGF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPanelCGF.Location = new System.Drawing.Point(966, 148);
            this.btPanelCGF.Name = "btPanelCGF";
            this.btPanelCGF.Size = new System.Drawing.Size(300, 140);
            this.btPanelCGF.TabIndex = 6;
            this.btPanelCGF.Click += new System.EventHandler(this.btPanelCGF_Click);
            // 
            // btLabelCGF
            // 
            this.btLabelCGF.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btLabelCGF.ForeColor = System.Drawing.Color.White;
            this.btLabelCGF.Location = new System.Drawing.Point(139, 42);
            this.btLabelCGF.Name = "btLabelCGF";
            this.btLabelCGF.Size = new System.Drawing.Size(160, 50);
            this.btLabelCGF.TabIndex = 5;
            this.btLabelCGF.Text = "Codificació i generació de fitxers";
            this.btLabelCGF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLabelCGF.Click += new System.EventHandler(this.btLabelCGF_Click);
            // 
            // btImgAS
            // 
            this.btImgAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImgAS.Image = global::PlanetaWF.Properties.Resources.iconServerWhite;
            this.btImgAS.Location = new System.Drawing.Point(16, 21);
            this.btImgAS.Name = "btImgAS";
            this.btImgAS.Size = new System.Drawing.Size(100, 100);
            this.btImgAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btImgAS.TabIndex = 7;
            this.btImgAS.TabStop = false;
            this.btImgAS.Click += new System.EventHandler(this.btImgAS_Click);
            // 
            // btPanelAS
            // 
            this.btPanelAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btPanelAS.Controls.Add(this.btLabelAS);
            this.btPanelAS.Controls.Add(this.btImgAS);
            this.btPanelAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPanelAS.Location = new System.Drawing.Point(308, 150);
            this.btPanelAS.Name = "btPanelAS";
            this.btPanelAS.Size = new System.Drawing.Size(300, 140);
            this.btPanelAS.TabIndex = 7;
            this.btPanelAS.Click += new System.EventHandler(this.btPanelAS_Click);
            // 
            // btLabelAS
            // 
            this.btLabelAS.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btLabelAS.ForeColor = System.Drawing.Color.White;
            this.btLabelAS.Location = new System.Drawing.Point(139, 42);
            this.btLabelAS.Name = "btLabelAS";
            this.btLabelAS.Size = new System.Drawing.Size(160, 50);
            this.btLabelAS.TabIndex = 5;
            this.btLabelAS.Text = "Aixecar el servidor";
            this.btLabelAS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLabelAS.Click += new System.EventHandler(this.btLabelAS_Click);
            // 
            // btTancarPlaneta
            // 
            this.btTancarPlaneta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTancarPlaneta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTancarPlaneta.Image = global::PlanetaWF.Properties.Resources.iconTancar;
            this.btTancarPlaneta.Location = new System.Drawing.Point(1447, 7);
            this.btTancarPlaneta.Name = "btTancarPlaneta";
            this.btTancarPlaneta.Size = new System.Drawing.Size(25, 25);
            this.btTancarPlaneta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btTancarPlaneta.TabIndex = 17;
            this.btTancarPlaneta.TabStop = false;
            this.btTancarPlaneta.Click += new System.EventHandler(this.btTancarPlaneta_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 19;
            // 
            // btPanelCF
            // 
            this.btPanelCF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btPanelCF.Controls.Add(this.btLabelCF);
            this.btPanelCF.Controls.Add(this.label3);
            this.btPanelCF.Controls.Add(this.btImgCF);
            this.btPanelCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPanelCF.Location = new System.Drawing.Point(308, 518);
            this.btPanelCF.Name = "btPanelCF";
            this.btPanelCF.Size = new System.Drawing.Size(300, 140);
            this.btPanelCF.TabIndex = 15;
            this.btPanelCF.Click += new System.EventHandler(this.btPanelCF_Click);
            // 
            // btLabelCF
            // 
            this.btLabelCF.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btLabelCF.ForeColor = System.Drawing.Color.White;
            this.btLabelCF.Location = new System.Drawing.Point(139, 42);
            this.btLabelCF.Name = "btLabelCF";
            this.btLabelCF.Size = new System.Drawing.Size(160, 50);
            this.btLabelCF.TabIndex = 5;
            this.btLabelCF.Text = "Comparar fitxers";
            this.btLabelCF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLabelCF.Click += new System.EventHandler(this.btLabelCF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 14;
            this.label3.Visible = false;
            // 
            // btImgCF
            // 
            this.btImgCF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImgCF.Image = global::PlanetaWF.Properties.Resources.iconCompareWhite;
            this.btImgCF.Location = new System.Drawing.Point(16, 21);
            this.btImgCF.Name = "btImgCF";
            this.btImgCF.Size = new System.Drawing.Size(100, 100);
            this.btImgCF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btImgCF.TabIndex = 7;
            this.btImgCF.TabStop = false;
            this.btImgCF.Click += new System.EventHandler(this.btImgCF_Click);
            // 
            // PnlTimer
            // 
            this.PnlTimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PnlTimer.Location = new System.Drawing.Point(634, 596);
            this.PnlTimer.Name = "PnlTimer";
            this.PnlTimer.Size = new System.Drawing.Size(200, 100);
            this.PnlTimer.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(729, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planeta";
            // 
            // ping1
            // 
            this.ping1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ping1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ping1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ping1.Desti = UserControls.Ping.SeleccionaDesti.Nau;
            this.ping1.Location = new System.Drawing.Point(12, 629);
            this.ping1.Name = "ping1";
            this.ping1.Size = new System.Drawing.Size(320, 66);
            this.ping1.TabIndex = 22;
            // 
            // btLabelRb
            // 
            this.btLabelRb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLabelRb.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLabelRb.ForeColor = System.Drawing.Color.White;
            this.btLabelRb.Location = new System.Drawing.Point(1401, 99);
            this.btLabelRb.Name = "btLabelRb";
            this.btLabelRb.Size = new System.Drawing.Size(70, 45);
            this.btLabelRb.TabIndex = 25;
            this.btLabelRb.Text = "Reiniciar programa";
            this.btLabelRb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLabelRb.Click += new System.EventHandler(this.btLabelRb_Click);
            // 
            // btPanelRb
            // 
            this.btPanelRb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPanelRb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btPanelRb.Controls.Add(this.label7);
            this.btPanelRb.Controls.Add(this.btImgRb);
            this.btPanelRb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPanelRb.Location = new System.Drawing.Point(1355, 97);
            this.btPanelRb.Name = "btPanelRb";
            this.btPanelRb.Size = new System.Drawing.Size(120, 50);
            this.btPanelRb.TabIndex = 26;
            this.btPanelRb.Click += new System.EventHandler(this.btPanelRb_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(143, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 14;
            this.label7.Visible = false;
            // 
            // btImgRb
            // 
            this.btImgRb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImgRb.Image = ((System.Drawing.Image)(resources.GetObject("btImgRb.Image")));
            this.btImgRb.Location = new System.Drawing.Point(5, 9);
            this.btImgRb.Name = "btImgRb";
            this.btImgRb.Size = new System.Drawing.Size(30, 30);
            this.btImgRb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btImgRb.TabIndex = 7;
            this.btImgRb.TabStop = false;
            this.btImgRb.Click += new System.EventHandler(this.btImgRb_Click);
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidor.ForeColor = System.Drawing.Color.Red;
            this.lblServidor.Location = new System.Drawing.Point(983, 518);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(197, 26);
            this.lblServidor.TabIndex = 27;
            this.lblServidor.Text = "Servidor no aixecat.";
            // 
            // lblCodificacio
            // 
            this.lblCodificacio.AutoSize = true;
            this.lblCodificacio.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodificacio.ForeColor = System.Drawing.Color.Red;
            this.lblCodificacio.Location = new System.Drawing.Point(983, 557);
            this.lblCodificacio.Name = "lblCodificacio";
            this.lblCodificacio.Size = new System.Drawing.Size(223, 26);
            this.lblCodificacio.TabIndex = 28;
            this.lblCodificacio.Text = "Codificació no creada.";
            // 
            // lblPACS
            // 
            this.lblPACS.AutoSize = true;
            this.lblPACS.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPACS.ForeColor = System.Drawing.Color.Red;
            this.lblPACS.Location = new System.Drawing.Point(983, 596);
            this.lblPACS.Name = "lblPACS";
            this.lblPACS.Size = new System.Drawing.Size(162, 26);
            this.lblPACS.TabIndex = 30;
            this.lblPACS.Text = "PACS no enviat.";
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHash.ForeColor = System.Drawing.Color.Red;
            this.lblHash.Location = new System.Drawing.Point(983, 633);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(213, 26);
            this.lblHash.TabIndex = 31;
            this.lblHash.Text = "Arxius no comparats.";
            // 
            // TaparMssg
            // 
            this.TaparMssg.Location = new System.Drawing.Point(978, 547);
            this.TaparMssg.Name = "TaparMssg";
            this.TaparMssg.Size = new System.Drawing.Size(300, 500);
            this.TaparMssg.TabIndex = 32;
            this.TaparMssg.Visible = false;
            // 
            // frmPlaneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 707);
            this.Controls.Add(this.TaparMssg);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.lblPACS);
            this.Controls.Add(this.lblCodificacio);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.btLabelRb);
            this.Controls.Add(this.btPanelRb);
            this.Controls.Add(this.ping1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlTimer);
            this.Controls.Add(this.btPanelCF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btTancarPlaneta);
            this.Controls.Add(this.btPanelAS);
            this.Controls.Add(this.btPanelCGF);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmPlaneta";
            this.Text = "Planeta";
            this.Controls.SetChildIndex(this.btPanelCGF, 0);
            this.Controls.SetChildIndex(this.btPanelAS, 0);
            this.Controls.SetChildIndex(this.btTancarPlaneta, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btPanelCF, 0);
            this.Controls.SetChildIndex(this.PnlTimer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ping1, 0);
            this.Controls.SetChildIndex(this.btPanelRb, 0);
            this.Controls.SetChildIndex(this.btLabelRb, 0);
            this.Controls.SetChildIndex(this.lblServidor, 0);
            this.Controls.SetChildIndex(this.lblCodificacio, 0);
            this.Controls.SetChildIndex(this.lblPACS, 0);
            this.Controls.SetChildIndex(this.lblHash, 0);
            this.Controls.SetChildIndex(this.TaparMssg, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btImgCGF)).EndInit();
            this.btPanelCGF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btImgAS)).EndInit();
            this.btPanelAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btTancarPlaneta)).EndInit();
            this.btPanelCF.ResumeLayout(false);
            this.btPanelCF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgCF)).EndInit();
            this.btPanelRb.ResumeLayout(false);
            this.btPanelRb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgRb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btImgCGF;
        private System.Windows.Forms.Panel btPanelCGF;
        private System.Windows.Forms.PictureBox btImgAS;
        private System.Windows.Forms.Label btLabelCGF;
        private System.Windows.Forms.Panel btPanelAS;
        private System.Windows.Forms.Label btLabelAS;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox btTancarPlaneta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel btPanelCF;
        private System.Windows.Forms.Label btLabelCF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btImgCF;
        private System.Windows.Forms.Panel PnlTimer;
        private System.Windows.Forms.Label label1;
        private UserControls.Ping ping1;
        private System.Windows.Forms.Label btLabelRb;
        private System.Windows.Forms.Panel btPanelRb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btImgRb;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblCodificacio;
        private System.Windows.Forms.Label lblPACS;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.Panel TaparMssg;
        //private System.Windows.Forms.Label label3;
    }
}

