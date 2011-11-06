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
    public partial class NeuerCharakter : Form
    {
        public Kampffenster hauptfenster;
        public SpielerCharakter charakter;

        public NeuerCharakter()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        public void erstelleCharakter(int Leben, int Kraft, int Schild, int Geschick, String Rasse)
        {
            charakter = new SpielerCharakter(Kraft, Schild, Geschick, Leben, Rasse, txtName.Text);
            Close();
        }

        private void btnOger_Click(object sender, EventArgs e)
        {
            erstelleCharakter(60, 6, 2, 15, "Oger");            
        }

        private void btnSteingolem_Click(object sender, EventArgs e)
        {
            erstelleCharakter(75, 7, 4, 0, "Steingolem");
            
        }

        private void btnElf_Click(object sender, EventArgs e)
        {
            erstelleCharakter(60, 5, 5, 45, "Elf");            
        }

        private void btnFeuerteufel_Click(object sender, EventArgs e)
        {
            erstelleCharakter(40, 8, 70, 2, "Feuerteufel");            
        }

        private void btnMensch_Click(object sender, EventArgs e)
        {
            erstelleCharakter(60, 6, 30, 3, "Mensch");            
        }

        private void btnBlitzelement_Click(object sender, EventArgs e)
        {
            erstelleCharakter(30, 9, 0, 80, "Blitzelement");            
        }
    }
}
