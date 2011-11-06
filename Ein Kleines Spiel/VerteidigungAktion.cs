using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ein_Kleines_Spiel
{
    public class VerteidigungAktion : RundenAktion
    {
        public override int RundenKraft()
        {
            return 0;
        }

        public override int RundenSchild()
        {
            return charakter.Schild * 2;
        }
        public override String BildName()
        {
            return "shield.png";
        }
    }
}
