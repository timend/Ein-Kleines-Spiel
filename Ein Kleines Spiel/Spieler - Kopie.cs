using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ein_Kleines_Spiel
{
    public partial class Spieler : UserControl
    {

        public int Kraft, Schild, Geschick, Leben;
        public enum Rassen { Mensch, Steingolem, Elf, Oger, Feuerteufel, Blitzelement };
        public Rassen Rasse;
        public enum Ereignisse {Angriff, Verteidigung, Spezial, Unbekannt};
        public Ereignisse Ereignis;
        public String Spielername;
        public Hauptfenster Spiel;
        public bool ZugGemacht;
        public int MeinSchaden;


        public Spieler()
        {
            InitializeComponent();
            ZugGemacht = false;
        }

        private void Spieler_Load(object sender, EventArgs e)
        {
            SetzeEreignisseEnabled(false);
            picEreignis.Image=Image.FromFile("none.png");
        }

        public void setzeName(String Spielername)
        {
            this.Spielername = Spielername;
            labName.Text = Spielername;
        }
        public void neuerRunde()
        {
            picEreignis.Image = Image.FromFile("none.png");
            ZugGemacht = false;
        }

        public void setzeRasse(int Leben, int Kraft, int Schild, int Geschick, Rassen Rasse)
        {
            this.Leben = Leben;
            this.Kraft = Kraft;
            this.Geschick = Geschick;
            this.Rasse = Rasse;
            this.Schild = Schild;
            txtAngriff.Text = Convert.ToString(Kraft);
            txtGeschick.Text = Convert.ToString(Geschick);
            txtLeben.Text = Convert.ToString(Leben);
            txtRüstung.Text = Convert.ToString(Schild);
            txtRasse.Text = Rasse.ToString();

            btnOger.Enabled = btnMensch.Enabled = btnFeuerteufel.Enabled = btnElf.Enabled = btnSteingolem.Enabled
                = btnBlitzelement.Enabled = false;
        }

        private void btnOger_Click(object sender, EventArgs e)
        {
            setzeRasse(60, 6, 2, 15, Rassen.Oger);
        }

        private void btnSteingolem_Click(object sender, EventArgs e)
        {
            setzeRasse(75, 7, 4, 0, Rassen.Steingolem);
        }

        private void btnElf_Click(object sender, EventArgs e)
        {
            setzeRasse(60, 5, 5, 45, Rassen.Elf);
        }

        private void btnFeuerteufel_Click(object sender, EventArgs e)
        {
            setzeRasse(40, 8, 70, 2, Rassen.Feuerteufel);
        }

        private void btnMensch_Click(object sender, EventArgs e)
        {
            setzeRasse(60, 6, 30, 3, Rassen.Mensch);
        }

        private void btnBlitzelement_Click(object sender, EventArgs e)
        {
            setzeRasse(30, 9, 0, 80, Rassen.Blitzelement);
        }

        

        public void Zug(Ereignisse Ereignis)
        {
            this.Ereignis = Ereignis;

            //Bild setzen

            ZugGemacht = true;
            SetzeEreignisseEnabled(false);
            Spiel.RundenEnde();
        }

        public void duWirstAngegriffen(Spieler Gegner)
        {
            int GegnerKraft = 0, MeinSchild = 0;

            if (Gegner.Ereignis == Ereignisse.Angriff)
            {
                GegnerKraft = Gegner.Kraft;                
            }

            if (Gegner.Ereignis == Ereignisse.Verteidigung)
            {
                GegnerKraft = 0;                
            }

            if (Gegner.Ereignis == Ereignisse.Spezial)
            {
                Random r = new Random();
                int Zufall = r.Next(100);               
                if (Zufall < Gegner.Geschick)
                {
                    GegnerKraft = Gegner.Kraft * 2;
                }
            }

            if (Ereignis == Ereignisse.Angriff)
            {
                MeinSchild = Schild;
            }

            if (Ereignis == Ereignisse.Verteidigung)
            {                
                MeinSchild = Schild * 2;
            }

            if (Ereignis == Ereignisse.Spezial)
            {
                MeinSchild = Schild / 2;                
            }

            MeinSchaden = (GegnerKraft - MeinSchild);

            if (MeinSchaden < 0)
            {
                MeinSchaden = 0;
            }

            Leben = Leben - MeinSchaden;

            if (Leben < 1)
            {
                Spiel.SchreibeLogEintrag(Spielername + " HAT VERLOREN" + Environment.NewLine);
            }

           
            if (MeinSchaden > 0 )
            {                
                Spiel.SchreibeLogEintrag(Spielername + " verliert " + MeinSchaden + " Leben.");
            }
            else
            {
                Spiel.SchreibeLogEintrag(Spielername + " nimmt keinen Schaden");
            }
          
            txtLeben.Text = "" + Leben;        
        }

        private void btnSpezial_Click(object sender, EventArgs e)
        {
             picEreignis.Image = Image.FromFile("special.png");
            Zug(Ereignisse.Spezial);
           
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            picEreignis.Image = Image.FromFile("shield.png");
            Zug(Ereignisse.Verteidigung);
                    
        }
        private void btnAngriff_Click(object sender, EventArgs e)
        {
            picEreignis.Image = Image.FromFile("sword.png");
            Zug(Ereignisse.Angriff);
            
        }
        public void duBistDran()
        {
            SetzeEreignisseEnabled(true);
        }

        private void SetzeEreignisseEnabled(bool enabled)
        {
            btnAngriff.Enabled = btnBlock.Enabled = btnSpezial.Enabled = enabled;
        }
    }
}
