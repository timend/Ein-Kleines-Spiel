using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ein_Kleines_Spiel
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Spiel spiel = new Spiel();
            spiel.GanzesSpiel();
        }
    }
}
