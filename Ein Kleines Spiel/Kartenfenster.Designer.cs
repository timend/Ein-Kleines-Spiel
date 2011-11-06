namespace Ein_Kleines_Spiel
{
    partial class Kartenfenster
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
            this.useSeed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.randomize = new System.Windows.Forms.Button();
            this.kartenansicht = new Ein_Kleines_Spiel.Kartenansicht();
            this.SuspendLayout();
            // 
            // useSeed
            // 
            this.useSeed.Location = new System.Drawing.Point(158, 1);
            this.useSeed.Name = "useSeed";
            this.useSeed.Size = new System.Drawing.Size(105, 28);
            this.useSeed.TabIndex = 6;
            this.useSeed.Text = "Erzeugen";
            this.useSeed.UseVisualStyleBackColor = true;
            this.useSeed.Click += new System.EventHandler(this.useSeed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seed:";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(55, 4);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(93, 20);
            this.txtSeed.TabIndex = 4;
            // 
            // randomize
            // 
            this.randomize.Location = new System.Drawing.Point(269, 1);
            this.randomize.Name = "randomize";
            this.randomize.Size = new System.Drawing.Size(123, 28);
            this.randomize.TabIndex = 7;
            this.randomize.Text = "Zufallskarte";
            this.randomize.UseVisualStyleBackColor = true;
            this.randomize.Click += new System.EventHandler(this.randomize_Click);
            // 
            // kartenansicht
            // 
            this.kartenansicht.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kartenansicht.Location = new System.Drawing.Point(10, 36);
            this.kartenansicht.Name = "kartenansicht";
            this.kartenansicht.Size = new System.Drawing.Size(787, 406);
            this.kartenansicht.TabIndex = 0;
            this.kartenansicht.Load += new System.EventHandler(this.kartenansicht_Load);
            // 
            // Kartenfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 435);
            this.Controls.Add(this.randomize);
            this.Controls.Add(this.useSeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.kartenansicht);
            this.Name = "Kartenfenster";
            this.Text = "Kartenfenster";
            this.Load += new System.EventHandler(this.Kartenfenster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Kartenfenster_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button useSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Button randomize;
        public Kartenansicht kartenansicht;
    }
}