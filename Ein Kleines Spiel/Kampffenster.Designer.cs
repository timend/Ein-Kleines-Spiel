namespace Ein_Kleines_Spiel
{
    partial class Kampffenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctnGegner = new Ein_Kleines_Spiel.Kampfsteuerung();
            this.ctnSpieler = new Ein_Kleines_Spiel.Kampfsteuerung();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ctnGegner
            // 
            this.ctnGegner.Location = new System.Drawing.Point(551, 26);
            this.ctnGegner.Name = "ctnGegner";
            this.ctnGegner.Size = new System.Drawing.Size(312, 459);
            this.ctnGegner.TabIndex = 1;
            // 
            // ctnSpieler
            // 
            this.ctnSpieler.Location = new System.Drawing.Point(12, 3);
            this.ctnSpieler.Name = "ctnSpieler";
            this.ctnSpieler.Size = new System.Drawing.Size(310, 459);
            this.ctnSpieler.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(317, 57);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(228, 376);
            this.txtLog.TabIndex = 65;
            // 
            // Kampffenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 509);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.ctnGegner);
            this.Controls.Add(this.ctnSpieler);
            this.Name = "Kampffenster";
            this.Text = "Hauptfenster";
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Kampfsteuerung ctnGegner;
        private System.Windows.Forms.TextBox txtLog;
        public Kampfsteuerung ctnSpieler;
    }
}