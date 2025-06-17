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
    public partial class AdminForma : Form
    {
        public AdminForma()
        {
            InitializeComponent();
        }

        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            if (lstRezervacije.SelectedItems.Count > 0)
            {
                // Uzimanje selektovane stavke iz ListView-a
                ListViewItem selektovanaStavka = lstRezervacije.SelectedItems[0];

                // Parsiranje ID-ova korisnika i izleta iz kolona
                int idKorisnika = int.Parse(selektovanaStavka.SubItems[0].Text);
                int idIzleta = int.Parse(selektovanaStavka.SubItems[1].Text);

                // Pronalazak rezervacije za brisanje po ID-ovima
                var rezervacijaZaBrisanje = podaci.Rezervacije
                    .FirstOrDefault(r => r.IdKorisnika == idKorisnika && r.IDIzleta == idIzleta);

                if (rezervacijaZaBrisanje != null)
                {
                    // Uklanjanje rezervacije iz liste podataka
                    podaci.Rezervacije.Remove(rezervacijaZaBrisanje);
                    // Uklanjanje rezervacije iz ListView-a
                    lstRezervacije.Items.Remove(selektovanaStavka);
                    // Čuvanje promenjenih podataka
                    podaci.Sacuvaj();
                }
                else
                {
                    MessageBox.Show("Rezervacija nije pronađena.");
                }

                OsveziRezervacije();
            }
            else
            {
                MessageBox.Show("Molimo Vas da selektujete rezervaciju za brisanje.");
            }


        }

        private void AdminForma_Load(object sender, EventArgs e)
        {
            lstKorisnici.View = View.Details;
            lstKorisnici.Columns.Add("ID", 30);
            lstKorisnici.Columns.Add("Ime", 60);
            lstKorisnici.Columns.Add("Prezime", 60);
            lstKorisnici.Columns.Add("Korisnicko ime", 80);
            lstKorisnici.Columns.Add("Lozinka", 60);
            lstKorisnici.Columns.Add("Vrsta korisnika", 80);
            OsveziKorisnikeListView();

            lstIzleti.View = View.Details;
            lstIzleti.Columns.Add("ID", 50);
            lstIzleti.Columns.Add("Mesto", 100);
            lstIzleti.Columns.Add("Država", 100);
            lstIzleti.Columns.Add("Cena", 60);
            lstIzleti.Columns.Add("Popust", 60);
            lstIzleti.Columns.Add("Broj Dana", 60);
            lstIzleti.Columns.Add("Ukupno Mesta", 80);
            lstIzleti.Columns.Add("Datum", 100);
            OsveziIzlet();

            lstRezervacije.View = View.Details;
            lstRezervacije.Columns.Add("ID Korisnika", 100);
            lstRezervacije.Columns.Add("ID Izleta", 100);
            lstRezervacije.Columns.Add("Ukupna Cena", 100);
            lstRezervacije.Columns.Add("Broj Rezervisanih Mesta", 100);
            lstRezervacije.Columns.Add("Datum i Vreme", 150);
            OsveziRezervacije();
        }

        private void btnDodajKorisnika_Click_1(object sender, EventArgs e)
        {
            var noviKorisnik = new UnosKorisnikaForma();
            noviKorisnik.Show();
        }

        private void btnDodajIzlet_Click(object sender, EventArgs e)
        {
            var noviIzlet = new DodajNoviIzletForma();
            noviIzlet.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var novaRezervacija = new DodajNovuRezervacijuForma();
            novaRezervacija.Show();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            if (lstKorisnici.SelectedItems.Count > 0)
            {
                // Uzimanje selektovane stavke iz ListView-a
                ListViewItem selektovanaStavka = lstKorisnici.SelectedItems[0];
                // Parsiranje ID-a korisnika iz prve kolone
                int korisnikId = int.Parse(selektovanaStavka.SubItems[0].Text);
                // Pronalazak korisnika za brisanje po ID-u
                var korisnikZaBrisanje = podaci.Korisnici.FirstOrDefault(k => k.Id == korisnikId);

                if (korisnikZaBrisanje != null)
                {
                    // Uklanjanje korisnika iz liste podataka
                    podaci.Korisnici.Remove(korisnikZaBrisanje);
                    // Uklanjanje korisnika iz ListView-a
                    lstKorisnici.Items.Remove(selektovanaStavka);
                    // Čuvanje promenjenih podataka
                    podaci.Sacuvaj();
                }
                else
                {
                    MessageBox.Show("Korisnik nije pronađen.");
                }

                OsveziKorisnikeListView();
            }
            else
            {
                MessageBox.Show("Molimo Vas da selektujete korisnika za brisanje.");
            }

        }

        private void OsveziKorisnikeListView()
        {
            var podaci = new Podaci();
            podaci.Ucitaj();
            lstKorisnici.Items.Clear();
            // Iteracija kroz listu korisnika
            foreach (var korisnik in podaci.Korisnici)
            {
                // Kreiranje nove stavke sa podacima o korisniku
                ListViewItem item = new ListViewItem(korisnik.Id.ToString());
                item.SubItems.Add(korisnik.Ime);
                item.SubItems.Add(korisnik.Prezime);
                item.SubItems.Add(korisnik.KorisnickoIme);
                item.SubItems.Add(korisnik.Lozinka);
                item.SubItems.Add(korisnik.VrstaKorisnika.ToString());
                // Dodavanje stavke u ListView
                lstKorisnici.Items.Add(item);
            }
        }

        private void tabKorisnici_Click(object sender, EventArgs e)
        {

        }

        private void btnOsveziKorisnike_Click(object sender, EventArgs e)
        {
            OsveziKorisnikeListView();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (lstKorisnici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete korisnika iz liste.");
                return; 
            }
            var podaci = new Podaci();
            podaci.Ucitaj();

            
            // Uzimanje selektovane stavke iz ListView-a
            ListViewItem selektovanaStavka = lstKorisnici.SelectedItems[0];
            // Parsiranje ID-a korisnika iz prve kolone
            int korisnikId = int.Parse(selektovanaStavka.SubItems[0].Text);
            // Pronalazak korisnika za brisanje po ID-u
            var korisnikZaIzmenu = podaci.Korisnici.FirstOrDefault(k => k.Id == korisnikId);

            var unosKorisnikaForma = new UnosKorisnikaForma(korisnikZaIzmenu);

            unosKorisnikaForma.Show();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            if (lstIzleti.SelectedItems.Count > 0)
            {
                // Uzimanje selektovane stavke iz ListView-a
                ListViewItem selektovanaStavka = lstIzleti.SelectedItems[0];
                // Parsiranje ID-a korisnika iz prve kolone
                int izletId = int.Parse(selektovanaStavka.SubItems[0].Text);
                // Pronalazak korisnika za brisanje po ID-u
                var izletZaBrisanje = podaci.Izleti.FirstOrDefault(i => i.ID == izletId);

                if (izletZaBrisanje != null)
                {
                    // Uklanjanje korisnika iz liste podataka
                    podaci.Izleti.Remove(izletZaBrisanje);
                    // Uklanjanje korisnika iz ListView-a
                    lstIzleti.Items.Remove(selektovanaStavka);
                    // Čuvanje promenjenih podataka
                    podaci.Sacuvaj();
                }
                else
                {
                    MessageBox.Show("Izlet nije pronađen.");
                }
            }
            else
            {
                MessageBox.Show("Molimo Vas da selektujete izlet za brisanje.");
            }
        }
        private void OsveziIzlet()
        {
            var podaci = new Podaci();
            podaci.Ucitaj();  // Load data

            lstIzleti.Items.Clear();  // Clear existing items

            // Iterate through the list of trips
            foreach (var izlet in podaci.Izleti)
            {
                // Create a new ListViewItem with the trip data
                ListViewItem item = new ListViewItem(izlet.ID.ToString());
                item.SubItems.Add(izlet.Mesto);
                item.SubItems.Add(izlet.Drzava);
                item.SubItems.Add(izlet.Cena.ToString("C"));  // Format as currency
                item.SubItems.Add(izlet.Popust.ToString() + "%");  // Format as percentage
                item.SubItems.Add(izlet.BrDana.ToString());
                item.SubItems.Add(izlet.UkupnoMesta.ToString());
                item.SubItems.Add(izlet.Datum.ToString("dd.MM.yyyy"));  // Format date

                // Add the item to the ListView
                lstIzleti.Items.Add(item);
            }
        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            OsveziIzlet();
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            // Provera da li je nešto selektovano u ListView-u
            if (lstIzleti.SelectedItems.Count > 0)
            {
                ListViewItem selektovanaStavka = lstIzleti.SelectedItems[0];
                int izletId = int.Parse(selektovanaStavka.SubItems[0].Text);
                var izletZaIzmenu = podaci.Izleti.FirstOrDefault(i => i.ID == izletId);
                var noviIzletForma = new DodajNoviIzletForma(izletZaIzmenu);
                noviIzletForma.Show();
            }
            else
            {
                MessageBox.Show("Molimo Vas da izaberete izlet iz liste.");
            }

        }

        private void btnOsveziRezervacije_Click(object sender, EventArgs e)
        {
            OsveziRezervacije();
        }

        private void OsveziRezervacije()
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            lstRezervacije.Items.Clear();

            foreach (var rezervacija in podaci.Rezervacije)
            {
                ListViewItem item = new ListViewItem(rezervacija.IdKorisnika.ToString());
                item.SubItems.Add(rezervacija.IDIzleta.ToString());
                item.SubItems.Add(rezervacija.UkupnaCena.ToString("C"));  // Format as currency
                item.SubItems.Add(rezervacija.BrojRezervisanihMesta.ToString());
                item.SubItems.Add(rezervacija.DatumIVreme.ToString("dd.MM.yyyy HH:mm"));  // Format date and time

                lstRezervacije.Items.Add(item);
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            if (lstRezervacije.SelectedItems.Count > 0)
            {
                // Uzimanje selektovane stavke iz ListView-a
                ListViewItem selektovanaStavka = lstRezervacije.SelectedItems[0];

                // Parsiranje ID-ova korisnika i izleta iz kolona
                int idKorisnik = int.Parse(selektovanaStavka.SubItems[0].Text);
                int idIzlet = int.Parse(selektovanaStavka.SubItems[1].Text);

                // Pronalazak rezervacije za izmenu po ID-ovima
                var rezervacijaZaIzmenu = podaci.Rezervacije
                    .FirstOrDefault(r => r.IdKorisnika == idKorisnik && r.IDIzleta == idIzlet);

                if (rezervacijaZaIzmenu != null)
                {
                    // Otvoriti formu za izmenu rezervacije i proslediti rezervaciju
                    var novaRezForma = new DodajNovuRezervacijuForma(rezervacijaZaIzmenu);
                    novaRezForma.Show();
                }
                else
                {
                    MessageBox.Show("Rezervacija nije pronađena.");
                }
            }
            else 
            {
                MessageBox.Show("Molimo Vas da izaberite rezervaciju sa liste");
            }
    }
}
}
