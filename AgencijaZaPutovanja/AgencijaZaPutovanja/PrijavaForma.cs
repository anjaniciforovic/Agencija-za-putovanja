using AgencijaZaPutovanja.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgencijaZaPutovanja
{
    public partial class PrijavaForma : Form
    {
        public PrijavaForma()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            foreach (var korisnik in podaci.Korisnici) 
            {
                if (korisnik.KorisnickoIme == txtKorisnickoIme.Text && korisnik.Lozinka == txtLozinka.Text)
                {
                    if (korisnik.VrstaKorisnika == VrstaKorisnika.Klijent)
                    {
                        var klijentForma = new KlijentForma(korisnik);
                        klijentForma.Show();
                    }
                    else
                    {
                        var adminForma = new AdminForma();
                        adminForma.Show();
                    }
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Pogresna lozinka ili korisnicko ime");
        }

        private void PrijavaForma_Load(object sender, EventArgs e)
        {
            
            

        }
    }
}
