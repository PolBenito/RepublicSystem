namespace NauWF
{
    partial class frmNau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNau));
            this.btPanelEM = new System.Windows.Forms.Panel();
            this.btLabelEM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btImgEM = new System.Windows.Forms.PictureBox();
            this.btPanelAS = new System.Windows.Forms.Panel();
            this.btLabelAS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btImgAS = new System.Windows.Forms.PictureBox();
            this.btPanelDR = new System.Windows.Forms.Panel();
            this.btLabelDR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btImgDR = new System.Windows.Forms.PictureBox();
            this.PnlTimer = new System.Windows.Forms.Panel();
            this.lbASFinal = new System.Windows.Forms.Label();
            this.lbMissatgeFinal = new System.Windows.Forms.Label();
            this.lbDFinal = new System.Windows.Forms.Label();
            this.btPanelRb = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btImgRb = new System.Windows.Forms.PictureBox();
            this.btLabelRb = new System.Windows.Forms.Label();
            this.btImgAccess = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBloqMsg = new System.Windows.Forms.Panel();
            this.menuPrincipal1 = new UserControls.MenuPrincipal();
            this.ping1 = new UserControls.Ping();
            this.btPanelEM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgEM)).BeginInit();
            this.btPanelAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgAS)).BeginInit();
            this.btPanelDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgDR)).BeginInit();
            this.btPanelRb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgRb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btImgAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // btPanelEM
            // 
            this.btPanelEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btPanelEM.Controls.Add(this.btLabelEM);
            this.btPanelEM.Controls.Add(this.label2);
            this.btPanelEM.Controls.Add(this.btImgEM);
            this.btPanelEM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPanelEM.Location = new System.Drawing.Point(250, 155);
            this.btPanelEM.Name = "btPanelEM";
            this.btPanelEM.Size = new System.Drawing.Size(300, 140);
            this.btPanelEM.TabIndex = 8;
            this.btPanelEM.Click += new System.EventHandler(this.btPanelEM_Click);
            // 
            // btLabelEM
            // 
            this.btLabelEM.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btLabelEM.ForeColor = System.Drawing.Color.White;
            this.btLabelEM.Location = new System.Drawing.Point(139, 42);
            this.btLabelEM.Name = "btLabelEM";
            this.btLabelEM.Size = new System.Drawing.Size(160, 50);
            this.btLabelEM.TabIndex = 5;
            this.btLabelEM.Text = "Enviar missatge";
            this.btLabelEM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLabelEM.Click += new System.EventHandler(this.btLabelEM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 14;
            this.label2.Visible = false;
            // 
            // btImgEM
            // 
            this.btImgEM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImgEM.Image = global::NauWF.Properties.Resources.iconSendMessage;
            this.btImgEM.Location = new System.Drawing.Point(16, 21);
            this.btImgEM.Name = "btImgEM";
            this.btImgEM.Size = new System.Drawing.Size(100, 100);
            this.btImgEM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btImgEM.TabIndex = 7;
            this.btImgEM.TabStop = false;
            this.btImgEM.Click += new System.EventHandler(this.btImgEM_Click);
            // 
            // btPanelAS
            // 
            this.btPanelAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btPanelAS.Controls.Add(this.btLabelAS);
            this.btPanelAS.Controls.Add(this.label1);
            this.btPanelAS.Controls.Add(this.btImgAS);
            this.btPanelAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPanelAS.Location = new System.Drawing.Point(999, 155);
            this.btPanelAS.Name = "btPanelAS";
            this.btPanelAS.Size = new System.Drawing.Size(300, 140);
            this.btPanelAS.TabIndex = 9;
            this.btPanelAS.Click += new System.EventHandler(this.btPanelAS_Click);
            // 
            // btLabelAS
            // 
            this.btLabelAS.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btLabelAS.ForeColor = System.Drawing.Color.White;
            this.btLabelAS.Location = new System.Drawing.Point(135, 42);
            this.btLabelAS.Name = "btLabelAS";
            this.btLabelAS.Size = new System.Drawing.Size(160, 50);
            this.btLabelAS.TabIndex = 5;
            this.btLabelAS.Text = "Aixecar servidor";
            this.btLabelAS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLabelAS.Click += new System.EventHandler(this.btLabelAS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 14;
            this.label1.Visible = false;
            // 
            // btImgAS
            // 
            this.btImgAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImgAS.Image = global::NauWF.Properties.Resources.iconWifiWhite;
            this.btImgAS.Location = new System.Drawing.Point(16, 21);
            this.btImgAS.Name = "btImgAS";
            this.btImgAS.Size = new System.Drawing.Size(100, 100);
            this.btImgAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btImgAS.TabIndex = 7;
            this.btImgAS.TabStop = false;
            this.btImgAS.Click += new System.EventHandler(this.btImgAS_Click);
            // 
            // btPanelDR
            // 
            this.btPanelDR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btPanelDR.Controls.Add(this.btLabelDR);
            this.btPanelDR.Controls.Add(this.label4);
            this.btPanelDR.Controls.Add(this.btImgDR);
            this.btPanelDR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPanelDR.Location = new System.Drawing.Point(250, 467);
            this.btPanelDR.Name = "btPanelDR";
            this.btPanelDR.Size = new System.Drawing.Size(300, 140);
            this.btPanelDR.TabIndex = 15;
            this.btPanelDR.Click += new System.EventHandler(this.btPanelDR_Click);
            // 
            // btLabelDR
            // 
            this.btLabelDR.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btLabelDR.ForeColor = System.Drawing.Color.White;
            this.btLabelDR.Location = new System.Drawing.Point(135, 42);
            this.btLabelDR.Name = "btLabelDR";
            this.btLabelDR.Size = new System.Drawing.Size(160, 50);
            this.btLabelDR.TabIndex = 5;
            this.btLabelDR.Text = "Desencriptar i reenviar PACS";
            this.btLabelDR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLabelDR.Click += new System.EventHandler(this.btLabelDR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(143, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 14;
            this.label4.Visible = false;
            // 
            // btImgDR
            // 
            this.btImgDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImgDR.Image = global::NauWF.Properties.Resources.iconMailWhite;
            this.btImgDR.Location = new System.Drawing.Point(16, 21);
            this.btImgDR.Name = "btImgDR";
            this.btImgDR.Size = new System.Drawing.Size(100, 100);
            this.btImgDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btImgDR.TabIndex = 7;
            this.btImgDR.TabStop = false;
            this.btImgDR.Click += new System.EventHandler(this.btImgDR_Click);
            // 
            // PnlTimer
            // 
            this.PnlTimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PnlTimer.Location = new System.Drawing.Point(302, 338);
            this.PnlTimer.Name = "PnlTimer";
            this.PnlTimer.Size = new System.Drawing.Size(200, 100);
            this.PnlTimer.TabIndex = 16;
            // 
            // lbASFinal
            // 
            this.lbASFinal.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbASFinal.ForeColor = System.Drawing.Color.Red;
            this.lbASFinal.Location = new System.Drawing.Point(1009, 531);
            this.lbASFinal.Name = "lbASFinal";
            this.lbASFinal.Size = new System.Drawing.Size(600, 50);
            this.lbASFinal.TabIndex = 15;
            this.lbASFinal.Text = "Servidor no aixecat.";
            this.lbASFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMissatgeFinal
            // 
            this.lbMissatgeFinal.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMissatgeFinal.ForeColor = System.Drawing.Color.Red;
            this.lbMissatgeFinal.Location = new System.Drawing.Point(1011, 467);
            this.lbMissatgeFinal.Name = "lbMissatgeFinal";
            this.lbMissatgeFinal.Size = new System.Drawing.Size(350, 50);
            this.lbMissatgeFinal.TabIndex = 17;
            this.lbMissatgeFinal.Text = "Missatge no enviat.";
            this.lbMissatgeFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDFinal
            // 
            this.lbDFinal.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDFinal.ForeColor = System.Drawing.Color.Red;
            this.lbDFinal.Location = new System.Drawing.Point(1009, 598);
            this.lbDFinal.Name = "lbDFinal";
            this.lbDFinal.Size = new System.Drawing.Size(350, 50);
            this.lbDFinal.TabIndex = 18;
            this.lbDFinal.Text = "Fitxer no desencriptat.";
            this.lbDFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btPanelRb
            // 
            this.btPanelRb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPanelRb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btPanelRb.Controls.Add(this.label6);
            this.btPanelRb.Controls.Add(this.btImgRb);
            this.btPanelRb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPanelRb.Location = new System.Drawing.Point(668, 99);
            this.btPanelRb.Name = "btPanelRb";
            this.btPanelRb.Size = new System.Drawing.Size(120, 50);
            this.btPanelRb.TabIndex = 24;
            this.btPanelRb.Click += new System.EventHandler(this.btPanelRb_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(143, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 14;
            this.label6.Visible = false;
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
            // btLabelRb
            // 
            this.btLabelRb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLabelRb.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLabelRb.ForeColor = System.Drawing.Color.White;
            this.btLabelRb.Location = new System.Drawing.Point(710, 102);
            this.btLabelRb.Name = "btLabelRb";
            this.btLabelRb.Size = new System.Drawing.Size(70, 45);
            this.btLabelRb.TabIndex = 5;
            this.btLabelRb.Text = "Reiniciar programa";
            this.btLabelRb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLabelRb.Click += new System.EventHandler(this.btLabelRb_Click);
            // 
            // btImgAccess
            // 
            this.btImgAccess.Location = new System.Drawing.Point(674, 300);
            this.btImgAccess.Name = "btImgAccess";
            this.btImgAccess.Size = new System.Drawing.Size(200, 200);
            this.btImgAccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btImgAccess.TabIndex = 33;
            this.btImgAccess.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(727, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nau";
            // 
            // panelBloqMsg
            // 
            this.panelBloqMsg.Location = new System.Drawing.Point(999, 510);
            this.panelBloqMsg.Name = "panelBloqMsg";
            this.panelBloqMsg.Size = new System.Drawing.Size(300, 300);
            this.panelBloqMsg.TabIndex = 35;
            this.panelBloqMsg.Visible = false;
            // 
            // menuPrincipal1
            // 
            this.menuPrincipal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.menuPrincipal1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.menuPrincipal1.Location = new System.Drawing.Point(27, 43);
            this.menuPrincipal1.Name = "menuPrincipal1";
            this.menuPrincipal1.Size = new System.Drawing.Size(40, 38);
            this.menuPrincipal1.TabIndex = 0;
            // 
            // ping1
            // 
            this.ping1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ping1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ping1.Desti = UserControls.Ping.SeleccionaDesti.Planeta;
            this.ping1.Location = new System.Drawing.Point(12, 372);
            this.ping1.Name = "ping1";
            this.ping1.Size = new System.Drawing.Size(335, 66);
            this.ping1.TabIndex = 4;
            // 
            // frmNau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBloqMsg);
            this.Controls.Add(this.menuPrincipal1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btImgAccess);
            this.Controls.Add(this.btLabelRb);
            this.Controls.Add(this.btPanelRb);
            this.Controls.Add(this.lbDFinal);
            this.Controls.Add(this.lbMissatgeFinal);
            this.Controls.Add(this.lbASFinal);
            this.Controls.Add(this.PnlTimer);
            this.Controls.Add(this.btPanelDR);
            this.Controls.Add(this.btPanelAS);
            this.Controls.Add(this.btPanelEM);
            this.Controls.Add(this.ping1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmNau";
            this.Text = "  ";
            this.Controls.SetChildIndex(this.ping1, 0);
            this.Controls.SetChildIndex(this.btPanelEM, 0);
            this.Controls.SetChildIndex(this.btPanelAS, 0);
            this.Controls.SetChildIndex(this.btPanelDR, 0);
            this.Controls.SetChildIndex(this.PnlTimer, 0);
            this.Controls.SetChildIndex(this.lbASFinal, 0);
            this.Controls.SetChildIndex(this.lbMissatgeFinal, 0);
            this.Controls.SetChildIndex(this.lbDFinal, 0);
            this.Controls.SetChildIndex(this.btPanelRb, 0);
            this.Controls.SetChildIndex(this.btLabelRb, 0);
            this.Controls.SetChildIndex(this.btImgAccess, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.menuPrincipal1, 0);
            this.Controls.SetChildIndex(this.panelBloqMsg, 0);
            this.btPanelEM.ResumeLayout(false);
            this.btPanelEM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgEM)).EndInit();
            this.btPanelAS.ResumeLayout(false);
            this.btPanelAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgAS)).EndInit();
            this.btPanelDR.ResumeLayout(false);
            this.btPanelDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgDR)).EndInit();
            this.btPanelRb.ResumeLayout(false);
            this.btPanelRb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btImgRb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btImgAccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.Ping ping1;
        private System.Windows.Forms.Panel btPanelEM;
        private System.Windows.Forms.Label btLabelEM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btImgEM;
        private System.Windows.Forms.Panel btPanelAS;
        private System.Windows.Forms.Label btLabelAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btImgAS;
        private System.Windows.Forms.Panel btPanelDR;
        private System.Windows.Forms.Label btLabelDR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btImgDR;
        private System.Windows.Forms.Panel PnlTimer;
        private System.Windows.Forms.Label lbASFinal;
        private System.Windows.Forms.Label lbMissatgeFinal;
        private System.Windows.Forms.Label lbDFinal;
        private System.Windows.Forms.Panel btPanelRb;
        private System.Windows.Forms.Label btLabelRb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btImgRb;
        private System.Windows.Forms.PictureBox btImgAccess;
        private System.Windows.Forms.Label label3;
        private UserControls.MenuPrincipal menuPrincipal1;
        private System.Windows.Forms.Panel panelBloqMsg;
    }
}

