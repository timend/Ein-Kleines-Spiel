using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ein_Kleines_Spiel
{
    public class KICharakter : Charakter
    {
        public KICharakter(int Kraft, int Schild, int Geschick, int Leben, string Rasse, string Name)
            : base(Kraft, Schild, Geschick, Leben, Rasse, Name)
        {
        }

        public override RundenAktion macheZug()
        {
            // KI hier einfügen
            return new AngriffAktion();
        }
    }
}
