using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Ein_Kleines_Spiel
{
    abstract public class RundenAktion
    {
        public Charakter charakter;

        public abstract int RundenKraft();
        public abstract int RundenSchild();

        public void ausfuehren(RundenAktion GegnerAktion)
        {
            int MeinSchaden = GegnerAktion.RundenKraft() - RundenSchild();

            if (MeinSchaden < 0)
            {
                MeinSchaden = 0;
            }

            charakter.verringereLeben(MeinSchaden);
        }

        public abstract String BildName();
    }
}
