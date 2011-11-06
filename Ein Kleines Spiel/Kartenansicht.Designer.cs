namespace Ein_Kleines_Spiel
{
    partial class Kartenansicht
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kartenansicht));
            this.elementBilder = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // elementBilder
            // 
            this.elementBilder.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("elementBilder.ImageStream")));
            this.elementBilder.TransparentColor = System.Drawing.Color.Transparent;
            this.elementBilder.Images.SetKeyName(0, "Wand.png");
            this.elementBilder.Images.SetKeyName(1, "Ebene.png");
            this.elementBilder.Images.SetKeyName(2, "Fluss.png");
            this.elementBilder.Images.SetKeyName(3, "Schatztruhe.png");
            this.elementBilder.Images.SetKeyName(4, "Dach.png");
            this.elementBilder.Images.SetKeyName(5, "Spieler.png");
            // 
            // Kartenansicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Name = "Kartenansicht";
            this.Size = new System.Drawing.Size(534, 302);
            this.Load += new System.EventHandler(this.Kartenansicht_Load);
            this.Click += new System.EventHandler(this.Kartenansicht_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Kartenansicht_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList elementBilder;
    }
}
