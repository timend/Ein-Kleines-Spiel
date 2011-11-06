using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ein_Kleines_Spiel
{
    public partial class Kampffenster : Form
    {
        SpielerCharakter spieler;
        Charakter gegner;

        public Kampffenster(SpielerCharakter spieler, Charakter gegner)
        {
            this.spieler = spieler;
            this.gegner = gegner;
            InitializeComponent();
        }

        private void Hauptfenster_Load(object sender, EventArgs e)
        {           
            ctnSpieler.charakter = spieler;
            ctnGegner.charakter = gegner;
        }


        public void SchreibeLogEintrag(String Eintrag)
        {
            txtLog.Text = txtLog.Text + Eintrag + Environment.NewLine ;
            txtLog.SelectionStart = txtLog.Text.Length - 1;
            txtLog.SelectionLength = 0;
            txtLog.ScrollToCaret();
        }       
    }
}
