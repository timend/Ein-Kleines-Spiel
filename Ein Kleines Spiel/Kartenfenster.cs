using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ein_Kleines_Spiel
{
    public partial class Kartenfenster : Form
    {

        int breite = 75;
        int hoehe = 40;

        public Kartenfenster()
        {
            InitializeComponent();
        }

        private void Kartenfenster_Load(object sender, EventArgs e)
        {
            int seed = new Random().Next(0, 10000);
            this.kartenansicht.karte = new Karte(breite, hoehe, seed);
            txtSeed.Text = Convert.ToString(seed);
        }

        private void useSeed_Click(object sender, EventArgs e)
        {
            int seed = Convert.ToInt32(txtSeed.Text);
            this.kartenansicht.karte = new Karte(breite, hoehe, seed);
            kartenansicht.Invalidate();
        }

        private void randomize_Click(object sender, EventArgs e)
        {
            int seed = new Random().Next(0, 10000);
            this.kartenansicht.karte = new Karte(breite, hoehe, seed);
            txtSeed.Text = Convert.ToString(seed);
            kartenansicht.Invalidate();
        }

        private void Kartenfenster_KeyDown(object sender, KeyEventArgs e)
        {
            Karte karte = kartenansicht.karte;
            if (e.KeyCode == Keys.Up)
            {
                karte.spielery--;
                karte.elemente[karte.spielerx, karte.spielery].typ = Kartenelement.Typ.Spieler;
                kartenansicht.Invalidate();
            }
        }

        private void kartenansicht_Load(object sender, EventArgs e)
        {

        }
    }
}
