using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ein_Kleines_Spiel
{
    public class Karte
    {
        public Kartenelement[,] elemente;
        public int breite, hoehe, seed;

        public int spielerx, spielery;


        public Karte(int breite, int hoehe, int seed)
        {
            elemente = new Kartenelement[breite, hoehe];

            Random random = new Random(seed);

            this.breite = breite;
            this.hoehe = hoehe;
            this.seed = seed;

            for (int x = 0; x < breite; x++)
            {
                for (int y = 0; y < hoehe; y++)
                {
                    elemente[x, y] = new Kartenelement();
                    elemente[x, y].typ = Kartenelement.Typ.Ebene;
                }
            }

            erzeugeFluss(random, 0.05);

            int waende = random.Next(2, 8);

            for (int i = 0; i < waende; i++)
            {
                erzeugeWand(random, 0.25);
            }
            int schaetze = random.Next(breite * hoehe / 38, breite * hoehe / 35);

            for (int i = 0; i < schaetze; i++)
            {
                int x = random.Next(breite);
                int y = random.Next(hoehe);
                elemente[x, y].typ = Kartenelement.Typ.Schatztruhe;
            }
            int haus = random.Next(breite * hoehe / 50, breite * hoehe / 45);
            for (int i = 0; i < haus; i++)
            {
                int x = random.Next(breite - 3);
                int y = random.Next(hoehe - 3);
                bool platzfrei = istplatzfrei(x, y);

                if (platzfrei == true)
                {
                    elemente[x, y].typ = Kartenelement.Typ.Haus;
                    elemente[x + 1, y].typ = Kartenelement.Typ.Haus;
                    elemente[x + 2, y].typ = Kartenelement.Typ.Haus;
                    elemente[x, y + 1].typ = Kartenelement.Typ.Haus;
                    elemente[x + 1, y + 1].typ = Kartenelement.Typ.Haus;
                    elemente[x + 2, y + 1].typ = Kartenelement.Typ.Haus;
                    elemente[x, y + 2].typ = Kartenelement.Typ.Haus;
                    elemente[x + 1, y + 2].typ = Kartenelement.Typ.Haus;
                    elemente[x + 2, y + 2].typ = Kartenelement.Typ.Haus;
                }
            }

            int lx = random.Next(0, breite);
            int ly = random.Next(0, hoehe);
            
            while (elemente[lx, ly].typ != Kartenelement.Typ.Ebene)
            {
                lx = random.Next(0, breite);
                ly = random.Next(0, hoehe);
            }

            elemente[lx, ly].typ = Kartenelement.Typ.Spieler;
            spielerx = lx;
            spielery = ly;
        }

        public bool istplatzfrei(int startx, int starty)
        {
            for (int x = startx - 1; x < startx + 4; x++)
            {
                for (int y = starty - 1; y < starty + 4; y++)
                {
                    if (0 <= x && x < breite && 0 <= y && y < hoehe)
                    {
                        if (elemente[x, y].typ == Kartenelement.Typ.Haus)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public void erzeugeFluss(Random random, double verzweigung)
        {
            int startX = random.Next(breite);
            int startY = random.Next(hoehe);

            erzeugeFluss(startX, startY, random, verzweigung);
        }

        public void erzeugeFluss(int startX, int startY, Random random, double verzweigung)
        {
            // Fluss startet an beliebigem Punkt der Karte
            // Fluss fließt in eine bestimmte Richtung
            // Fluss enthält keine Lücken (d.h. eine Seite gemeinsam mit anderem Flusselement)     
            int richtungX = 0;
            int richtungY = 0;

            while (richtungX == 0 && richtungY == 0)
            {
                richtungX = random.Next(-10, 10);
                richtungY = random.Next(-10, 10);
            }

            int x = startX;
            int y = startY;

            while (0 <= x && x < breite && 0 <= y && y < hoehe)
            {
                elemente[x, y].typ = Kartenelement.Typ.Fluss;

                int schrittX = 0, schrittY = 0;

                if (richtungX >= 0)
                {
                    int rechts = random.Next(10);

                    if (richtungX > rechts)
                    {
                        schrittX = 1;
                    }
                }
                else
                {
                    int links = random.Next(10);

                    if (Math.Abs(richtungX) > links)
                    {
                        schrittX = -1;
                    }
                }

                if (richtungY >= 0)
                {
                    int unten = random.Next(10);

                    if (richtungY > unten)
                    {
                        schrittY = 1;
                    }
                }
                else
                {
                    int oben = random.Next(10);

                    if (Math.Abs(richtungY) > oben)
                    {
                        schrittY = -1;
                    }
                }


                if (schrittX != 0 && schrittY != 0)
                {
                    if (random.Next(2) == 0)
                    {
                        schrittX = 0;
                    }
                    else
                    {
                        schrittY = 0;
                    }
                }

                x += schrittX;
                y += schrittY;

                if (verzweigung > random.NextDouble())
                {
                    erzeugeFluss(x, y, random, 0);
                }
            }

        }

        public void erzeugeWand(Random random, double richtungsWechsel)
        {
            int startX = random.Next(breite);
            int startY = random.Next(hoehe);

            erzeugeWand(startX, startY, random, richtungsWechsel);
        }

        public void erzeugeWand(int startX, int startY, Random random, double richtungsWechsel)
        {    
            bool horizontaleRichtung = random.Next(2) == 0;
            bool positiveRichtung = random.Next(2) == 0;

            int schrittX = 0, schrittY = 0;

            if (horizontaleRichtung)
            {
                if (positiveRichtung)
                {
                    schrittX = 1;
                    schrittY = 0;
                }
                else
                {
                    schrittX = -1;
                    schrittY = 0;
                }
            }
            else
            {
                if (positiveRichtung)
                {
                    schrittY = 1;
                    schrittX = 0;
                }
                else
                {
                    schrittY = -1;
                    schrittX = 0;
                }
            }

            int laenge = random.Next(15, 20);

            int x = startX;
            int y = startY;
            int bisherigeLaenge = 0;
            int stueckLaenge = 0;

            while (0 <= x && x < breite && 0 <= y && y < hoehe && bisherigeLaenge < laenge)
            {
                if (elemente[x, y].typ == Kartenelement.Typ.Wand)
                {
                    return;
                }

                elemente[x, y].typ = Kartenelement.Typ.Wand;
                x += schrittX;
                y += schrittY;

                if (stueckLaenge > 2 && richtungsWechsel > random.NextDouble())
                {
                    stueckLaenge = 0;
                    horizontaleRichtung = !horizontaleRichtung;
                    positiveRichtung = random.Next(2) == 0;

                    if (horizontaleRichtung)
                    {
                        if (positiveRichtung)
                        {
                            schrittX = 1;
                            schrittY = 0;
                        }
                        else
                        {
                            schrittX = -1;
                            schrittY = 0;
                        }
                    }
                    else
                    {
                        if (positiveRichtung)
                        {
                            schrittY = 1;
                            schrittX = 0;
                        }
                        else
                        {
                            schrittY = -1;
                            schrittX = 0;
                        }
                    }    
                }

                bisherigeLaenge++;
                stueckLaenge++;
            }
        }
    }
}
