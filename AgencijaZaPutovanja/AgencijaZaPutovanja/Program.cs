using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgencijaZaPutovanja
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrijavaForma());

            

            // Poveži događaj za zatvaranje svih formi
            Application.AddMessageFilter(new FormCloseMessageFilter());

            // Kreiraj i pokreni glavnu formu
            Application.Run(new PrijavaForma());
        }
    }
}
