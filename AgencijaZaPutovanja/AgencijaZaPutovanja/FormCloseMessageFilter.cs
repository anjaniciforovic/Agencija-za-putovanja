using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgencijaZaPutovanja
{
    public class FormCloseMessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            // Proveri da li je poruka tipa WM_CLOSE (zatvaranje forme)
            if (m.Msg == 0x0010)
            {
                // Ako nema više otvorenih formi, zatvori aplikaciju
                if (Application.OpenForms.Count == 1)
                {
                    Application.Exit();
                }
            }
            return false;
        }
    }
}
