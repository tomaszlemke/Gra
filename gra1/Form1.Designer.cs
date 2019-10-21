namespace gra1
{
    partial class gra
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
            this.components = new System.ComponentModel.Container();
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrStoper = new System.Windows.Forms.Timer(this.components);
            this.tmrPomiarCzasuRozgrywki = new System.Windows.Forms.Timer(this.components);
            this.lblCzas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlPanel
            // 
            this.pnlPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlPanel.Location = new System.Drawing.Point(18, 18);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(390, 371);
            this.pnlPanel.TabIndex = 0;
            this.pnlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPanel_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 426);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tmrStoper
            // 
            this.tmrStoper.Interval = 1000;
            this.tmrStoper.Tick += new System.EventHandler(this.TmrStoper_Tick);
            // 
            // tmrPomiarCzasuRozgrywki
            // 
            this.tmrPomiarCzasuRozgrywki.Interval = 25;
            this.tmrPomiarCzasuRozgrywki.Tick += new System.EventHandler(this.TmrPomiarCzasuRozgrywki_Tick);
            // 
            // lblCzas
            // 
            this.lblCzas.AutoSize = true;
            this.lblCzas.Location = new System.Drawing.Point(185, 439);
            this.lblCzas.Name = "lblCzas";
            this.lblCzas.Size = new System.Drawing.Size(80, 13);
            this.lblCzas.TabIndex = 2;
            this.lblCzas.Text = "Czas rozgrywki:";
            // 
            // gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 477);
            this.Controls.Add(this.lblCzas);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlPanel);
            this.Name = "gra";
            this.Text = "gra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gra_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPanel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrStoper;
        private System.Windows.Forms.Timer tmrPomiarCzasuRozgrywki;
        private System.Windows.Forms.Label lblCzas;
    }
}

