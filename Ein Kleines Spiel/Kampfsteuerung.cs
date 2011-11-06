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
    public partial class Kampfsteuerung : UserControl
    {
        public Charakter charakter;
        public RundenAktion aktion;

        public Kampfsteuerung()
        {
            InitializeComponent();
        }

        public void zeigeCharakterAn()
        {
            labName.Text = charakter.Name;
            txtAngriff.Text  = charakter.Kraft + "";
            txtGeschick.Text = charakter.Geschick + "";
            txtLeben.Text = charakter.Leben + "";
            txtRasse.Text = charakter.Rasse + "";
            txtRüstung.Text = charakter.Schild + "";
        }

        public void zeigeAktionAn(RundenAktion aktion)
        {
            if (aktion == null)
            {
                picEreignis.Image = Image.FromFile("none.png");
            }
            else
            {
                picEreignis.Image = Image.FromFile(aktion.BildName());
            }
        }

        private void Spieler_Load(object sender, EventArgs e)
        {
            SetzeEreignisseEnabled(true);            
        }

        public RundenAktion Runde()
        {
            aktion = null;

            zeigeCharakterAn();
            zeigeAktionAn(null);
            SetzeEreignisseEnabled(true);

            do
            {
                Application.DoEvents();
            } 
            while (aktion != null);

            zeigeAktionAn(aktion);
            return aktion;
        }

          
    
        private void btnSpezial_Click(object sender, EventArgs e)
        {
            aktion = new SpezialAktion();           
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            aktion = new VerteidigungAktion();                    
        }
        private void btnAngriff_Click(object sender, EventArgs e)
        {
            aktion = new AngriffAktion();
        }        

        private void SetzeEreignisseEnabled(bool enabled)
        {
            btnAngriff.Enabled = btnBlock.Enabled = btnSpezial.Enabled = enabled;
        }
    }
}
