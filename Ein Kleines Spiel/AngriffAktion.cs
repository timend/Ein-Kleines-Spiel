using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ein_Kleines_Spiel
{
    class AngriffAktion : RundenAktion
    {
        public AngriffAktion(Charakter charakter)
            : base(charakter)
        {
            
        }

        public override int RundenKraft()
        {
            return charakter.Kraft;
        }

        public override int RundenSchild()
        {
            return charakter.Schild;

        }


        public override String BildName()
        {
            return "sword.png";
        }
    }
}
