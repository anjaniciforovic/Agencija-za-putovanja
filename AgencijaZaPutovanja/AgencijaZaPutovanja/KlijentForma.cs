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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgencijaZaPutovanja
{
    public partial class KlijentForma : Form
    {
        private Korisnik klijent;

        public KlijentForma(Korisnik klijent)
        {
            this.klijent = klijent;
            InitializeComponent();
        }

        private void btnDodajNovuRez_Click(object sender, EventArgs e)
        {
            var dodajNovuRez = new DodajRezervacijuKlijentForma(klijent.Id);
            dodajNovuRez.Show();
        }

        private void btnVidiDetalje_Click(object sender, EventArgs e)
        {
            if (lstVaseRezervacije.SelectedItems.Count > 0)
            {
                ListViewItem selektovanaStavka = lstVaseRezervacije.SelectedItems[0];
                var rezervacija = (Rezervacija)selektovanaStavka.Tag;

                var detaljanPrikaz = new DetaljniPrikazForma(rezervacija);
                detaljanPrikaz.Show();
            }
            else
            {
                MessageBox.Show("Molimo Vas da selektujete rezervaciju za prikaz detalja.");
            }
        }

        private void lnkIstorija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var istorija = new IstorijaForma(klijent);
            istorija.Show();
        }

        private void KlijentForma_Load(object sender, EventArgs e)
        {
            lstVaseRezervacije.View = View.Details;
            lstVaseRezervacije.Columns.Add("Mesto", 100);
            lstVaseRezervacije.Columns.Add("Drzava", 100);
            lstVaseRezervacije.Columns.Add("Cena", 80);
            lstVaseRezervacije.Columns.Add("Popust", 80);
            lstVaseRezervacije.Columns.Add("Broj dana", 80);
            lstVaseRezervacije.Columns.Add("Ukupno mesta", 100);
            lstVaseRezervacije.Columns.Add("Datum", 120);

            PrikaziRezervacije();


        }

        private void PrikaziRezervacije()
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            lstVaseRezervacije.Items.Clear();
            DateTime danasnjiDatum = DateTime.Today;

            foreach (var rezervacija in podaci.Rezervacije)
            {
                if (rezervacija.IdKorisnika != klijent.Id)
                    continue;
               

                var izlet = podaci.Izleti.First(i => i.ID == rezervacija.IDIzleta);

                // Proverite da li je datum izleta danasnji ili u budućnosti
                if (izlet.Datum < danasnjiDatum)
                    continue;


                ListViewItem item = new ListViewItem(izlet.Mesto);
                item.SubItems.Add(izlet.Drzava);
                item.SubItems.Add(izlet.Cena.ToString());
                item.SubItems.Add(izlet.Popust.ToString());
                item.SubItems.Add(izlet.BrDana.ToString());
                item.SubItems.Add(rezervacija.BrojRezervisanihMesta.ToString());
                item.SubItems.Add(izlet.Datum.ToString());
                item.Tag = rezervacija;
                lstVaseRezervacije.Items.Add(item);
            }
        }

        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            if (lstVaseRezervacije.SelectedItems.Count > 0)
            {
                ListViewItem selektovanaStavka = lstVaseRezervacije.SelectedItems[0];

                var rezervacijaZaBrisanje = (Rezervacija)selektovanaStavka.Tag;
                if (rezervacijaZaBrisanje != null)
                {
                    var rezervacija = podaci.Rezervacije.FirstOrDefault(r =>
                r.IdKorisnika == rezervacijaZaBrisanje.IdKorisnika &&
                r.IDIzleta == rezervacijaZaBrisanje.IDIzleta);
                    if (rezervacija != null)
                    {
                        podaci.Rezervacije.Remove(rezervacija);
                        lstVaseRezervacije.Items.Remove(selektovanaStavka);
                        podaci.Sacuvaj();
                    }
                    else
                    {
                        MessageBox.Show("Rezervacija nije pronađena.");
                    }
                }
                else
                {
                    MessageBox.Show("Rezervacija nije pronađena.");
                }

            }
            else
            {
                MessageBox.Show("Molimo Vas da selektujete rezervaciju za brisanje.");
            }
        }

        private void lstVaseRezervacije_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (lstVaseRezervacije.SelectedItems.Count > 0)
            {
                // Uzimanje selektovane rezervacije
                ListViewItem selektovanaRezervacija = lstVaseRezervacije.SelectedItems[0];

                // Pretpostavljamo da se ID korisnika i ID izleta drže u "Tag" ili u nekoj od kolona
                var rezervacija = (Rezervacija)selektovanaRezervacija.Tag;
                int idIzleta = rezervacija.IDIzleta;
                int idKorisnika = klijent.Id; // ID trenutno prijavljenog korisnika
                
                var podaci = new Podaci();
                podaci.Ucitaj();

                // Pronalazak rezervacije na osnovu IdKorisnika i IdIzleta
                var rezervacijaZaIzmenu = podaci.Rezervacije.FirstOrDefault(r => r.IdKorisnika == idKorisnika && r.IDIzleta == idIzleta);

                if (rezervacijaZaIzmenu != null)
                {
                    // Otvaranje forme za promenu rezervacije i prosleđivanje trenutne rezervacije
                    var promenaRezervacijeForma = new NovaRezervacijaForma(rezervacijaZaIzmenu);
                    promenaRezervacijeForma.ShowDialog();

                    // Osvježavanje prikaza rezervacija nakon izmene
                    PrikaziRezervacije();
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da izaberete rezervaciju za ažuriranje.");
            }

        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            PrikaziRezervacije();
        }
    }
}
