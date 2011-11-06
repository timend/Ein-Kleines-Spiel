namespace Ein_Kleines_Spiel
{
    partial class Spieler
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
            this.txtRasse1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnElf = new System.Windows.Forms.Button();
            this.btnSteingolem = new System.Windows.Forms.Button();
            this.btnOger = new System.Windows.Forms.Button();
            this.btnBlitzelement = new System.Windows.Forms.Button();
            this.btnMensch = new System.Windows.Forms.Button();
            this.btnFeuerteufel = new System.Windows.Forms.Button();
            this.txtRasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeben = new System.Windows.Forms.TextBox();
            this.txtGeschick = new System.Windows.Forms.TextBox();
            this.btnSpezial = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnAngriff = new System.Windows.Forms.Button();
            this.txtAngriff = new System.Windows.Forms.TextBox();
            this.txtRüstung = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picEreignis = new System.Windows.Forms.PictureBox();
            this.labName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEreignis)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRasse1
            // 
            this.txtRasse1.Location = new System.Drawing.Point(109, -44);
            this.txtRasse1.Name = "txtRasse1";
            this.txtRasse1.ReadOnly = true;
            this.txtRasse1.Size = new System.Drawing.Size(100, 20);
            this.txtRasse1.TabIndex = 87;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, -41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 86;
            this.label17.Text = "Rasse";
            // 
            // btnElf
            // 
            this.btnElf.Location = new System.Drawing.Point(216, 396);
            this.btnElf.Name = "btnElf";
            this.btnElf.Size = new System.Drawing.Size(75, 23);
            this.btnElf.TabIndex = 106;
            this.btnElf.Text = "Elf";
            this.btnElf.UseVisualStyleBackColor = true;
            this.btnElf.Click += new System.EventHandler(this.btnElf_Click);
            // 
            // btnSteingolem
            // 
            this.btnSteingolem.Location = new System.Drawing.Point(135, 396);
            this.btnSteingolem.Name = "btnSteingolem";
            this.btnSteingolem.Size = new System.Drawing.Size(75, 23);
            this.btnSteingolem.TabIndex = 105;
            this.btnSteingolem.Text = "Steingolem";
            this.btnSteingolem.UseVisualStyleBackColor = true;
            this.btnSteingolem.Click += new System.EventHandler(this.btnSteingolem_Click);
            // 
            // btnOger
            // 
            this.btnOger.Location = new System.Drawing.Point(52, 396);
            this.btnOger.Name = "btnOger";
            this.btnOger.Size = new System.Drawing.Size(75, 23);
            this.btnOger.TabIndex = 104;
            this.btnOger.Text = "Oger";
            this.btnOger.UseVisualStyleBackColor = true;
            this.btnOger.Click += new System.EventHandler(this.btnOger_Click);
            // 
            // btnBlitzelement
            // 
            this.btnBlitzelement.Location = new System.Drawing.Point(216, 425);
            this.btnBlitzelement.Name = "btnBlitzelement";
            this.btnBlitzelement.Size = new System.Drawing.Size(75, 23);
            this.btnBlitzelement.TabIndex = 103;
            this.btnBlitzelement.Text = "Blitz-Element";
            this.btnBlitzelement.UseVisualStyleBackColor = true;
            this.btnBlitzelement.Click += new System.EventHandler(this.btnBlitzelement_Click);
            // 
            // btnMensch
            // 
            this.btnMensch.Location = new System.Drawing.Point(135, 425);
            this.btnMensch.Name = "btnMensch";
            this.btnMensch.Size = new System.Drawing.Size(75, 23);
            this.btnMensch.TabIndex = 102;
            this.btnMensch.Text = "Mensch";
            this.btnMensch.UseVisualStyleBackColor = true;
            this.btnMensch.Click += new System.EventHandler(this.btnMensch_Click);
            // 
            // btnFeuerteufel
            // 
            this.btnFeuerteufel.Location = new System.Drawing.Point(52, 425);
            this.btnFeuerteufel.Name = "btnFeuerteufel";
            this.btnFeuerteufel.Size = new System.Drawing.Size(75, 23);
            this.btnFeuerteufel.TabIndex = 101;
            this.btnFeuerteufel.Text = "Feuerteufel";
            this.btnFeuerteufel.UseVisualStyleBackColor = true;
            this.btnFeuerteufel.Click += new System.EventHandler(this.btnFeuerteufel_Click);
            // 
            // txtRasse
            // 
            this.txtRasse.Location = new System.Drawing.Point(158, 55);
            this.txtRasse.Name = "txtRasse";
            this.txtRasse.ReadOnly = true;
            this.txtRasse.Size = new System.Drawing.Size(100, 20);
            this.txtRasse.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Rasse";
            // 
            // txtLeben
            // 
            this.txtLeben.Location = new System.Drawing.Point(158, 182);
            this.txtLeben.Name = "txtLeben";
            this.txtLeben.ReadOnly = true;
            this.txtLeben.Size = new System.Drawing.Size(100, 20);
            this.txtLeben.TabIndex = 98;
            // 
            // txtGeschick
            // 
            this.txtGeschick.Location = new System.Drawing.Point(158, 152);
            this.txtGeschick.Name = "txtGeschick";
            this.txtGeschick.ReadOnly = true;
            this.txtGeschick.Size = new System.Drawing.Size(100, 20);
            this.txtGeschick.TabIndex = 97;
            // 
            // btnSpezial
            // 
            this.btnSpezial.Location = new System.Drawing.Point(135, 229);
            this.btnSpezial.Name = "btnSpezial";
            this.btnSpezial.Size = new System.Drawing.Size(75, 23);
            this.btnSpezial.TabIndex = 96;
            this.btnSpezial.Text = "Special";
            this.btnSpezial.UseVisualStyleBackColor = true;
            this.btnSpezial.Click += new System.EventHandler(this.btnSpezial_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(216, 229);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 23);
            this.btnBlock.TabIndex = 95;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnAngriff
            // 
            this.btnAngriff.Location = new System.Drawing.Point(52, 229);
            this.btnAngriff.Name = "btnAngriff";
            this.btnAngriff.Size = new System.Drawing.Size(75, 23);
            this.btnAngriff.TabIndex = 94;
            this.btnAngriff.Text = "Angriff";
            this.btnAngriff.UseVisualStyleBackColor = true;
            this.btnAngriff.Click += new System.EventHandler(this.btnAngriff_Click);
            // 
            // txtAngriff
            // 
            this.txtAngriff.Location = new System.Drawing.Point(158, 120);
            this.txtAngriff.Name = "txtAngriff";
            this.txtAngriff.ReadOnly = true;
            this.txtAngriff.Size = new System.Drawing.Size(100, 20);
            this.txtAngriff.TabIndex = 93;
            // 
            // txtRüstung
            // 
            this.txtRüstung.Location = new System.Drawing.Point(158, 88);
            this.txtRüstung.Name = "txtRüstung";
            this.txtRüstung.ReadOnly = true;
            this.txtRüstung.Size = new System.Drawing.Size(100, 20);
            this.txtRüstung.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Leben";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "Geschick";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Angriff";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Rüstung";
            // 
            // picEreignis
            // 
            this.picEreignis.Location = new System.Drawing.Point(78, 258);
            this.picEreignis.Name = "picEreignis";
            this.picEreignis.Size = new System.Drawing.Size(157, 132);
            this.picEreignis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEreignis.TabIndex = 107;
            this.picEreignis.TabStop = false;
            // 
            // labName
            // 
            this.labName.Location = new System.Drawing.Point(139, 17);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(49, 18);
            this.labName.TabIndex = 108;
            this.labName.Text = "Name";
            // 
            // Spieler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labName);
            this.Controls.Add(this.picEreignis);
            this.Controls.Add(this.btnElf);
            this.Controls.Add(this.btnSteingolem);
            this.Controls.Add(this.btnOger);
            this.Controls.Add(this.btnBlitzelement);
            this.Controls.Add(this.btnMensch);
            this.Controls.Add(this.btnFeuerteufel);
            this.Controls.Add(this.txtRasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLeben);
            this.Controls.Add(this.txtGeschick);
            this.Controls.Add(this.btnSpezial);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnAngriff);
            this.Controls.Add(this.txtAngriff);
            this.Controls.Add(this.txtRüstung);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRasse1);
            this.Controls.Add(this.label17);
            this.Name = "Spieler";
            this.Size = new System.Drawing.Size(312, 451);
            this.Load += new System.EventHandler(this.Spieler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEreignis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRasse1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnElf;
        private System.Windows.Forms.Button btnSteingolem;
        private System.Windows.Forms.Button btnOger;
        private System.Windows.Forms.Button btnBlitzelement;
        private System.Windows.Forms.Button btnMensch;
        private System.Windows.Forms.Button btnFeuerteufel;
        private System.Windows.Forms.TextBox txtRasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeben;
        private System.Windows.Forms.TextBox txtGeschick;
        private System.Windows.Forms.Button btnSpezial;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnAngriff;
        private System.Windows.Forms.TextBox txtAngriff;
        private System.Windows.Forms.TextBox txtRüstung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picEreignis;
        private System.Windows.Forms.Label labName;
    }
}
