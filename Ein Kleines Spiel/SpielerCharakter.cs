using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ein_Kleines_Spiel
{
    public class SpielerCharakter : Charakter
    {
        public Kampfsteuerung steuerung;

        public SpielerCharakter(int Kraft, int Schild, int Geschick, int Leben, string Rasse, string Name)
            : base(Kraft, Schild, Geschick, Leben, Rasse, Name)
        {
        }

        public override RundenAktion macheZug()
        {
            return steuerung.Runde();
        }
    }
}
