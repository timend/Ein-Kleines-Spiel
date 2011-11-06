namespace Ein_Kleines_Spiel
{
    partial class NeuerCharakter
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnElf = new System.Windows.Forms.Button();
            this.btnSteingolem = new System.Windows.Forms.Button();
            this.btnOger = new System.Windows.Forms.Button();
            this.btnBlitzelement = new System.Windows.Forms.Button();
            this.btnMensch = new System.Windows.Forms.Button();
            this.btnFeuerteufel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welche Rasse sind sie?";
            // 
            // btnElf
            // 
            this.btnElf.Location = new System.Drawing.Point(173, 187);
            this.btnElf.Name = "btnElf";
            this.btnElf.Size = new System.Drawing.Size(75, 23);
            this.btnElf.TabIndex = 112;
            this.btnElf.Text = "Elf";
            this.btnElf.UseVisualStyleBackColor = true;
            this.btnElf.Click += new System.EventHandler(this.btnElf_Click);
            // 
            // btnSteingolem
            // 
            this.btnSteingolem.Location = new System.Drawing.Point(92, 187);
            this.btnSteingolem.Name = "btnSteingolem";
            this.btnSteingolem.Size = new System.Drawing.Size(75, 23);
            this.btnSteingolem.TabIndex = 111;
            this.btnSteingolem.Text = "Steingolem";
            this.btnSteingolem.UseVisualStyleBackColor = true;
            this.btnSteingolem.Click += new System.EventHandler(this.btnSteingolem_Click);
            // 
            // btnOger
            // 
            this.btnOger.Location = new System.Drawing.Point(9, 187);
            this.btnOger.Name = "btnOger";
            this.btnOger.Size = new System.Drawing.Size(75, 23);
            this.btnOger.TabIndex = 110;
            this.btnOger.Text = "Oger";
            this.btnOger.UseVisualStyleBackColor = true;
            this.btnOger.Click += new System.EventHandler(this.btnOger_Click);
            // 
            // btnBlitzelement
            // 
            this.btnBlitzelement.Location = new System.Drawing.Point(173, 216);
            this.btnBlitzelement.Name = "btnBlitzelement";
            this.btnBlitzelement.Size = new System.Drawing.Size(75, 23);
            this.btnBlitzelement.TabIndex = 109;
            this.btnBlitzelement.Text = "Blitz-Element";
            this.btnBlitzelement.UseVisualStyleBackColor = true;
            this.btnBlitzelement.Click += new System.EventHandler(this.btnBlitzelement_Click);
            // 
            // btnMensch
            // 
            this.btnMensch.Location = new System.Drawing.Point(92, 216);
            this.btnMensch.Name = "btnMensch";
            this.btnMensch.Size = new System.Drawing.Size(75, 23);
            this.btnMensch.TabIndex = 108;
            this.btnMensch.Text = "Mensch";
            this.btnMensch.UseVisualStyleBackColor = true;
            this.btnMensch.Click += new System.EventHandler(this.btnMensch_Click);
            // 
            // btnFeuerteufel
            // 
            this.btnFeuerteufel.Location = new System.Drawing.Point(9, 216);
            this.btnFeuerteufel.Name = "btnFeuerteufel";
            this.btnFeuerteufel.Size = new System.Drawing.Size(75, 23);
            this.btnFeuerteufel.TabIndex = 107;
            this.btnFeuerteufel.Text = "Feuerteufel";
            this.btnFeuerteufel.UseVisualStyleBackColor = true;
            this.btnFeuerteufel.Click += new System.EventHandler(this.btnFeuerteufel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Welchen Namen tragen sie?";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 114;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 262);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnElf);
            this.Controls.Add(this.btnSteingolem);
            this.Controls.Add(this.btnOger);
            this.Controls.Add(this.btnBlitzelement);
            this.Controls.Add(this.btnMensch);
            this.Controls.Add(this.btnFeuerteufel);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Welche Rasse?";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnElf;
        private System.Windows.Forms.Button btnSteingolem;
        private System.Windows.Forms.Button btnOger;
        private System.Windows.Forms.Button btnBlitzelement;
        private System.Windows.Forms.Button btnMensch;
        private System.Windows.Forms.Button btnFeuerteufel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
    }
}