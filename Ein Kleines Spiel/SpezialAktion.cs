using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ein_Kleines_Spiel
{
    public class SpezialAktion : RundenAktion
    {
        public override int RundenKraft()
        {
            Random r = new Random();
            int Zufall = r.Next(100);
            if (Zufall < charakter.Geschick)
            {
                return charakter.Kraft * 2;
            }

            return 0;
        }

        public override int RundenSchild()
        {
            return charakter.Schild / 2;
        }
        public override String BildName()
        {
            return "special.png";
        }
    }
}
