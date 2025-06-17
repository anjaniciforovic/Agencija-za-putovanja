using AgencijaZaPutovanja.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgencijaZaPutovanja
{
   
    public partial class NovaRezervacijaForma : Form
{
        private Rezervacija trenutnaRezervacija;
        private decimal cenaPoOsobi;
        private decimal popust;

        public NovaRezervacijaForma(Rezervacija rezervacija)
    {
            InitializeComponent();
            trenutnaRezervacija = rezervacija;

            numBrojacPutnika.Value = trenutnaRezervacija.BrojRezervisanihMesta;
        }
       
        private void NovaRezervacija_Load(object sender, EventArgs e)
        {
            var podaci = new Podaci();
            podaci.Ucitaj();
            var izlet = podaci.Izleti.FirstOrDefault(i => i.ID == trenutnaRezervacija.IDIzleta);
            if (izlet != null)
            {
                cenaPoOsobi = izlet.Cena;
                popust = izlet.Popust;
                IzracunajCenu(); // Prikaz cene pri učitavanju forme
            }
            
        }
        


        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            // Pronalazak postojeće rezervacije u listi
            var rezervacijaZaIzmenu = podaci.Rezervacije.FirstOrDefault(r =>
                r.IdKorisnika == trenutnaRezervacija.IdKorisnika &&
                r.IDIzleta == trenutnaRezervacija.IDIzleta);

            if (rezervacijaZaIzmenu != null)
            {
                // Ažuriranje broja rezervisanih mesta
                rezervacijaZaIzmenu.BrojRezervisanihMesta = (int)numBrojacPutnika.Value;
                // Ažuriraj cenu na osnovu broja putnika i popusta
                rezervacijaZaIzmenu.UkupnaCena = IzracunajCenu();
                // Sačuvaj promene u XML
                podaci.Sacuvaj();

                MessageBox.Show("Rezervacija uspešno ažurirana!");
            }
            else
            {
                MessageBox.Show("Rezervacija nije pronađena!");
            }

            this.Close();
        }
        private void numBrojacPutnika_ValueChanged(object sender, EventArgs e)
        {
            IzracunajCenu();
        }
        private decimal IzracunajCenu()
        {


            // Dobij trenutni broj putnika
            int brojPutnika = (int)numBrojacPutnika.Value;

            // Izračunaj ukupnu cenu bez popusta
            decimal ukupnaCena = brojPutnika * cenaPoOsobi;

            // Primeni popust ako postoji
            if (popust > 0)
            {
                ukupnaCena = ukupnaCena * (1 - popust / 100);
            }

            // Prikaži cenu u tekstualnom polju
            txtCena.Text = ukupnaCena.ToString("0.00") + " eur";

            // Vrati izračunatu cenu za kasnije ažuriranje rezervacije
            return ukupnaCena;
        }
    }

       


}

