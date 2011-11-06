using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Ein_Kleines_Spiel
{
    public partial class Form1 : Form
    {
        enum Ereignis {Angriff, Verteidigung, Spezial, Unbekannt};
        Ereignis Ereigniss1, Ereigniss2;
        enum Rasse { Mensch, Steingolem, Elf, Oger, Feuerteufel, Blitzelement};
        Rasse Rasse1, Rasse2;
        int Kraft1, Schild1, Geschick1, Leben1, Kraft2, Schild2, Geschick2, Leben2;
        enum Spieler {Spieler2, Spieler1};
        Spieler gewonnen;

        public Form1()
        {
            InitializeComponent();
            Ereigniss1 = Ereignis.Unbekannt;
            Ereigniss2 = Ereignis.Unbekannt;
            txtAngriff1.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick1.Text = Convert.ToString(Geschick1); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben1.Text = Convert.ToString(Leben1); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung1.Text = Convert.ToString(Schild1); txtRüstung2.Text = Convert.ToString(Schild2);
            
            btnSpezial2.Enabled = btnBlock2.Enabled = btnAngriff2.Enabled = false;
            gewonnen = Spieler.Spieler1;
        }            

        private void btnAngriff1_Click(object sender, EventArgs e)
        {
            Ereigniss1 = Ereignis.Angriff;
            btnSpezial2.Enabled = btnBlock2.Enabled = btnAngriff2.Enabled = true;
            btnSpezial1.Enabled = btnBlock1.Enabled = btnAngriff1.Enabled = false;
            txtEreigniss1.Text = "Angriff";
            if (gewonnen == Spieler.Spieler2)
            {
                rundenEnde();
            }
        }

        private void btnSpezial1_Click(object sender, EventArgs e)
        {
            Ereigniss1 = Ereignis.Spezial;
            btnSpezial2.Enabled = btnBlock2.Enabled = btnAngriff2.Enabled = true;
            btnSpezial1.Enabled = btnBlock1.Enabled = btnAngriff1.Enabled = false;
            txtEreigniss1.Text = "Spezial";
            if (gewonnen == Spieler.Spieler2)
            {
                rundenEnde();
            }
        }

        private void btnBlock1_Click(object sender, EventArgs e)
        {
            Ereigniss1 = Ereignis.Verteidigung;
            btnSpezial2.Enabled = btnBlock2.Enabled = btnAngriff2.Enabled = true;
            btnSpezial1.Enabled = btnBlock1.Enabled = btnAngriff1.Enabled = false;
            txtEreigniss1.Text = "Block";
            if (gewonnen == Spieler.Spieler2)
            {
                rundenEnde();
            }
        }

        private void btnAngriff2_Click(object sender, EventArgs e)
        {
            Ereigniss2 = Ereignis.Angriff;
            if (gewonnen == Spieler.Spieler1)
            {
                rundenEnde();
            }
        }

        private void btnSpezial2_Click(object sender, EventArgs e)
        {
            Ereigniss2 = Ereignis.Spezial;
            if (gewonnen == Spieler.Spieler1)
            {
                rundenEnde();
            }
        }

        private void btnBlock2_Click(object sender, EventArgs e)
        {
            Ereigniss2 = Ereignis.Verteidigung;
            if (gewonnen == Spieler.Spieler1)
            {
                rundenEnde();
            }
        }

        private void rundenEnde()
        {
            int RKraft1 = 0, RKraft2 = 0, RSchild2 = 3, RSchild1 = 3, RLeben1, RLeben2;

            if (Ereigniss1 == Ereignis.Angriff)
            {
                RKraft1 = Kraft1;
                RSchild1 = Schild1;
            }

            if (Ereigniss1 == Ereignis.Verteidigung)
            {
                RKraft1 = 0;
                RSchild1 = Schild1 * 2;
            }

            if (Ereigniss1 == Ereignis.Spezial)
            {
                Random r = new Random();
                int Zufall = r.Next(100);
                RSchild1 = Schild1 / 2;
                if (Zufall < Geschick1)
                {
                    RKraft1 = Kraft1 * 2;
                }
            }

            if (Ereigniss2 == Ereignis.Angriff)
            {
                RKraft2 = Kraft2;
                RSchild2 = Schild2;
            }

            if (Ereigniss2 == Ereignis.Verteidigung)
            {
                RKraft2 = 0;
                RSchild2 = Schild2 * 2;
            }

            if (Ereigniss2 == Ereignis.Spezial)
            {
                Random r = new Random();
                int Zufall = r.Next(100);
                RSchild2 = Schild2 / 2;
                if (Zufall < Geschick2)
                {
                    RKraft2 = Kraft2 * 2;
                }
            }
            RLeben1 = Leben1 - (RKraft2 - RSchild1);
            RLeben2 = Leben2 - (RKraft1 - RSchild2);
            if (RLeben1 < 0)
            {
                txtLog.Text = "SPIELER 1 HAT VERLOREN" + Environment.NewLine + Environment.NewLine + txtLog.Text;
            }
            if (RLeben2 < 0)
            {
                txtLog.Text = "SPIELER 2 HAT VERLOREN" + Environment.NewLine + Environment.NewLine + txtLog.Text;
            }
            if (RSchild1 < RKraft2)
            {
                Leben1 = Leben1 - (RKraft2 - RSchild1);
                txtLog.Text = txtLog.Text + "Spieler 1 verliert " + (RKraft2 - RSchild1) + " Leben." + Environment.NewLine;
            }

            else
            {
                txtLog.Text = txtLog.Text + "Spieler 1 nimmt keinen Schaden" + Environment.NewLine;
            }

            if (RSchild2 < RKraft1)
            {
                Leben2 = Leben2 - (RKraft1 - RSchild2);
                txtLog.Text = txtLog.Text + "Spieler 2 verliert " + (RKraft1 - RSchild2) + " Leben." + Environment.NewLine;
            }

            else
            {
                txtLog.Text = txtLog.Text + "Spieler 2 nimmt keinen Schaden" + Environment.NewLine;
            }

            txtLog.SelectionStart = txtLog.Text.Length - 1;
            txtLog.SelectionLength = 0;
            txtLog.ScrollToCaret();

            txtLeben1.Text = "" + Leben1;
            txtLeben2.Text = "" + Leben2;

            if (RKraft1 - RSchild2 < RKraft2 - RSchild1)
            {
                gewonnen = Spieler.Spieler2;
                // Spieler 1 hat mehr Schaden gemacht und den Zug gewonnen
                // deshalb muss er beim nächsten Zug anfangen
                SetzeSpieler1Enabled(false);
                SetzeSpieler2Enabled(true);
            }
            if (RKraft1 - RSchild2 > RKraft2 - RSchild1)
            {
                SetzeSpieler1Enabled(true);
                SetzeSpieler2Enabled(false);
                gewonnen = Spieler.Spieler1;
            }
            if (RKraft1 - RSchild2 == RKraft2 - RSchild1)
            {
                Random r = new Random();
                int Zufall = r.Next(100);
                if (Zufall < 50)
                {
                    SetzeSpieler1Enabled(true);
                    SetzeSpieler2Enabled(false);
                    gewonnen = Spieler.Spieler1;
                }
                else
                {
                    SetzeSpieler1Enabled(false);
                    SetzeSpieler2Enabled(true);
                    gewonnen = Spieler.Spieler1;
                }
            }
            
        }

        private void SetzeSpieler1Enabled(bool enabled)
        {
            btnAngriff1.Enabled = btnBlock1.Enabled = btnSpezial1.Enabled = enabled;
        }

        private void SetzeSpieler2Enabled(bool enabled)
        {
            btnAngriff2.Enabled = btnBlock2.Enabled = btnSpezial2.Enabled = enabled;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Leben1 = 60;
            Kraft1 = 6;
            Schild1 = 2;
            Geschick1 = 15;
            Rasse1 = Rasse.Oger;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
            txtAngriff1.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick1.Text = Convert.ToString(Geschick1); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben1.Text = Convert.ToString(Leben1); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung1.Text = Convert.ToString(Schild1); txtRüstung2.Text = Convert.ToString(Schild2);
            txtRasse1.Text = "Oger";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Leben1 = 75;
            Kraft1 = 7;
            Schild1 = 4;
            Geschick1 = 0;
            Rasse1 = Rasse.Steingolem;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
            txtAngriff1.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick1.Text = Convert.ToString(Geschick1); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben1.Text = Convert.ToString(Leben1); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung1.Text = Convert.ToString(Schild1); txtRüstung2.Text = Convert.ToString(Schild2);
            txtRasse1.Text = "Steingolem";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Leben1 = 60;
            Kraft1 = 5;
            Schild1 = 5;
            Geschick1 = 45;
            Rasse1 = Rasse.Elf;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
            txtAngriff1.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick1.Text = Convert.ToString(Geschick1); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben1.Text = Convert.ToString(Leben1); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung1.Text = Convert.ToString(Schild1); txtRüstung2.Text = Convert.ToString(Schild2);
            txtRasse1.Text = "Elf";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leben1 = 30;
            Kraft1= 9;
            Schild1 = 0;
            Geschick1 = 80;
            Rasse1 = Rasse.Blitzelement;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
            txtAngriff1.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick1.Text = Convert.ToString(Geschick1); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben1.Text = Convert.ToString(Leben1); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung1.Text = Convert.ToString(Schild1); txtRüstung2.Text = Convert.ToString(Schild2);
            txtRasse1.Text = "Blitz-Element";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Leben1 = 60;
            Kraft1 = 6;
            Geschick1 = 30;
            Schild1 = 3;
            Rasse1 = Rasse.Mensch;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
            txtAngriff1.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick1.Text = Convert.ToString(Geschick1); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben1.Text = Convert.ToString(Leben1); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung1.Text = Convert.ToString(Schild1); txtRüstung2.Text = Convert.ToString(Schild2);
            txtRasse1.Text = "Mensch";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leben1 = 40;
            Kraft1 = 8;
            Geschick1 = 70;
            Schild1 = 2;
            Rasse1 = Rasse.Feuerteufel;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = false;
txtAngriff1.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick1.Text = Convert.ToString(Geschick1); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben1.Text = Convert.ToString(Leben1); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung1.Text = Convert.ToString(Schild1); txtRüstung2.Text = Convert.ToString(Schild2);
            txtRasse1.Text = "Feuerteuel";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Leben2 = 60;
            Kraft2 = 6;
            Schild2 = 2;
            Geschick2 = 15;
            Rasse2 = Rasse.Oger;
            button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = false;
txtAngriff1.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick1.Text = Convert.ToString(Geschick1); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben1.Text = Convert.ToString(Leben1); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung1.Text = Convert.ToString(Schild1); txtRüstung2.Text = Convert.ToString(Schild2);
            txtRasse2.Text = "Oger";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Leben2 = 75;
            Kraft2 = 7;
            Schild2 = 4;
            Geschick2 = 0;
            Rasse2 = Rasse.Steingolem;
            button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = false;
txtAngriff1.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick1.Text = Convert.ToString(Geschick1); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben1.Text = Convert.ToString(Leben1); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung1.Text = Convert.ToString(Schild1); txtRüstung2.Text = Convert.ToString(Schild2);
            txtRasse2.Text = "Steingolem";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Leben2 = 60;
            Kraft2 = 5;
            Schild2 = 5;
            Geschick2 = 45;
            Rasse2 = Rasse.Elf;
            button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = false;
            txtAngriff1.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick1.Text = Convert.ToString(Geschick1); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben1.Text = Convert.ToString(Leben1); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung1.Text = Convert.ToString(Schild1); txtRüstung2.Text = Convert.ToString(Schild2);
            txtRasse2.Text = "Elf";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Leben2 = 40;
            Kraft2 = 8;
            Geschick2 = 70;
            Schild2 = 2;
            Rasse2 = Rasse.Feuerteufel;
            button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = false;
txtAngriff1.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick1.Text = Convert.ToString(Geschick1); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben1.Text = Convert.ToString(Leben1); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung1.Text = Convert.ToString(Schild1); txtRüstung2.Text = Convert.ToString(Schild2);
            txtRasse2.Text = "Feuerteufel";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Leben2 = 60;
            Kraft2 = 6;
            Geschick2 = 30;
            Schild2 = 3;
            Rasse2 = Rasse.Mensch;
            button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = false;
txtAngriff1.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick1.Text = Convert.ToString(Geschick1); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben1.Text = Convert.ToString(Leben1); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung1.Text = Convert.ToString(Schild1); txtRüstung2.Text = Convert.ToString(Schild2);
            txtRasse2.Text = "Mensch";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Leben2 = 30;
            Kraft2 = 9;
            Schild2 = 0;
            Geschick2 = 80;
            Rasse2 = Rasse.Blitzelement;
            button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = false;
txtAngriff2.Text = Convert.ToString(Kraft1); txtAngriff2.Text = Convert.ToString(Kraft2);
            txtGeschick2.Text = Convert.ToString(Geschick2); txtGeschick2.Text = Convert.ToString(Geschick2);
            txtLeben2.Text = Convert.ToString(Leben2); txtLeben2.Text = Convert.ToString(Leben2);
            txtRüstung2.Text = Convert.ToString(Schild2); txtRüstung2.Text = Convert.ToString(Schild2);
            txtRasse2.Text = "Blitz-Element";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
