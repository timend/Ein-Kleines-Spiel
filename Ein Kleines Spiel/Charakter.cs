using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ein_Kleines_Spiel
{
    abstract public class Charakter
    {                
        public int Kraft, Schild, Geschick, Leben;        
        public String Rasse, Name;

        public Charakter(int Kraft, int Schild, int Geschick, int Leben, string Rasse, string Name)
        {
            this.Kraft = Kraft;
            this.Schild = Schild;
            this.Geschick = Geschick;
            this.Leben = Leben;
            this.Rasse = Rasse;
            this.Name = Name;
        }

        public abstract RundenAktion macheZug();

        public void verringereLeben(int Schaden)
        {            
            Leben -= Schaden;
        }


        public bool istTot()
        {
            return Leben <= 0;
        }
    }
}
