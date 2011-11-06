using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ein_Kleines_Spiel
{
    public class Spiel
    {
        SpielerCharakter Spieler;

        public void GanzesSpiel()
        {
            NeuerCharakter neuerCharakter = new NeuerCharakter();
            neuerCharakter.ShowDialog();
            Spieler = neuerCharakter.charakter;

            Kartenfenster kartenfenster = new Kartenfenster();
            kartenfenster.kartenansicht.spiel = this;
            kartenfenster.ShowDialog();
        }

        public void Kampf(Charakter Gegner)
        {
            Kampffenster kampffenster = new Kampffenster(Spieler, Gegner);
            kampffenster.ShowDialog();

            Spieler.steuerung = kampffenster.ctnSpieler;            

            while (!Spieler.istTot() && !Gegner.istTot())
            {
                RundenAktion spielerAktion = Spieler.macheZug();
                RundenAktion gegnerAktion = Gegner.macheZug();

                spielerAktion.ausfuehren(gegnerAktion);
                gegnerAktion.ausfuehren(spielerAktion);
            }
        }
    }
}
