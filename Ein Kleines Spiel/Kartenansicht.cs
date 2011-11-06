using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ein_Kleines_Spiel
{
    public partial class Kartenansicht : UserControl
    {
        public Karte karte;
        private bool keystrokeProcessed;
        public Spiel spiel;

        

        public Kartenansicht()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.Selectable, true);
        }

        private void Kartenansicht_Paint(object sender, PaintEventArgs e)
        {
            if (karte != null)
            {
                for (int x = 0; x < karte.breite; x++)
                {
                    for (int y = 0; y < karte.hoehe; y++)
                    {
                        int bildIndex = (int)karte.elemente[x, y].typ;
                        elementBilder.Draw(e.Graphics, new Point(x * 20, y * 20), bildIndex);
                    }
                }
            }
        }

        private void Kartenansicht_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            keystrokeProcessed = true;
            switch (keyData)
            {
                case Keys.Down:
                    bewegespieler(0, 1);
                    return true;
                case Keys.Up:
                    bewegespieler(0, -1);
                    return true;
                case Keys.Left:
                    bewegespieler(-1, 0);
                    return true;
                case Keys.Right:
                    bewegespieler(1, 0);
                    return true;
            }
         
            return base.ProcessDialogKey(keyData);
        }

        public void bewegespieler(int deltaX, int deltaY)
        {
            int zielX = karte.spielerx + deltaX;
            int zielY = karte.spielery + deltaY;

            if (zielX < 0 || zielX >= karte.breite || zielY < 0 || zielY >= karte.hoehe)
            {
                return;
            }

            if (karte.elemente[zielX, zielY].typ != Kartenelement.Typ.Ebene)
            {
                if (karte.elemente[zielX, zielY].typ != Kartenelement.Typ.Schatztruhe)
                {
                    return;
                }
            }

            karte.elemente[karte.spielerx, karte.spielery].typ = Kartenelement.Typ.Ebene;
            karte.spielerx = zielX;
            karte.spielery = zielY;
            karte.elemente[karte.spielerx, karte.spielery].typ = Kartenelement.Typ.Spieler;

            Random random = new Random();

            if (random.Next(10) == 1)
            {
                spiel.Kampf(new KICharakter(10, 10, 40, 30, "TestGegner", "Der Böse"));
            }

            this.Invalidate();
        }

        private void Kartenansicht_Load(object sender, EventArgs e)
        {

        }
    }
}
