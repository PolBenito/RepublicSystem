namespace UserControls
{
    partial class CompteEnrereUC
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbMinuts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSegons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbMinuts
            // 
            this.lbMinuts.AutoSize = true;
            this.lbMinuts.BackColor = System.Drawing.Color.Black;
            this.lbMinuts.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinuts.ForeColor = System.Drawing.Color.White;
            this.lbMinuts.Location = new System.Drawing.Point(16, 11);
            this.lbMinuts.Name = "lbMinuts";
            this.lbMinuts.Size = new System.Drawing.Size(0, 48);
            this.lbMinuts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // lbSegons
            // 
            this.lbSegons.AutoSize = true;
            this.lbSegons.BackColor = System.Drawing.Color.Black;
            this.lbSegons.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegons.ForeColor = System.Drawing.Color.White;
            this.lbSegons.Location = new System.Drawing.Point(104, 11);
            this.lbSegons.Name = "lbSegons";
            this.lbSegons.Size = new System.Drawing.Size(0, 48);
            this.lbSegons.TabIndex = 2;
            // 
            // CompteEnrereUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbSegons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMinuts);
            this.Name = "CompteEnrereUC";
            this.Size = new System.Drawing.Size(179, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMinuts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSegons;
        public System.Windows.Forms.Timer timer;
    }
}
