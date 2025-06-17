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
    enum NovaRezervacija
    {
        Kreiranje,
        Izmena
    }
    public partial class DodajNovuRezervacijuForma : Form
    {
        private NovaRezervacija mod;
        public DodajNovuRezervacijuForma()
        {
            this.mod = NovaRezervacija.Kreiranje;
            InitializeComponent();
        }
        public DodajNovuRezervacijuForma(Rezervacija rezervacija)
        {
            this.mod = NovaRezervacija.Izmena;
            InitializeComponent();
            txtIdKorisnika.Text = rezervacija.IdKorisnika.ToString();
            txtIdIzleta.Text = rezervacija.IDIzleta.ToString();
            txtBrRezMesta.Text = rezervacija.BrojRezervisanihMesta.ToString();
            txtUkupnaCena.Text = rezervacija.UkupnaCena.ToString();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            int idKorisnika;
            if (!int.TryParse(txtIdKorisnika.Text, out idKorisnika))
            {
                MessageBox.Show("ID mora biti broj");
                return;
            }
            int idIzleta;
            if (!int.TryParse(txtIdIzleta.Text, out idIzleta))
            {
                MessageBox.Show("ID mora biti broj");
                return;
            }
            int ukupnaCena;
            if (!int.TryParse(txtUkupnaCena.Text, out ukupnaCena))
            {
                return;
            }
            int brRezMesta;
            if (!int.TryParse(txtBrRezMesta.Text, out brRezMesta))
            {
                return;
            }
            DateTime datumRezervacije = DateTime.Now;

            Rezervacija novaRezervacija = new Rezervacija(idKorisnika, idIzleta, ukupnaCena, brRezMesta, datumRezervacije);

            var podaci = new Podaci();
            podaci.Ucitaj();

            if (this.mod == NovaRezervacija.Kreiranje)
            {
                novaRezervacija = new Rezervacija(idKorisnika, idIzleta, ukupnaCena, brRezMesta, datumRezervacije);

                // Dodavanje novog korisnika u listu korisnika
                podaci.Rezervacije.Add(novaRezervacija);
                MessageBox.Show("Nova rezervacija je uspešno dodata.");
            }
            else
            {
                var postojecaRezervacija = podaci.Rezervacije.First(r => r.IdKorisnika == idKorisnika);
                postojecaRezervacija.UkupnaCena = ukupnaCena;
                postojecaRezervacija.BrojRezervisanihMesta = brRezMesta;
                postojecaRezervacija.IDIzleta = idIzleta;
                
                MessageBox.Show("Nova rezervacija je uspešno izmenjena.");
            }

            // Čuvanje podataka u XML
            podaci.Sacuvaj();



            MessageBox.Show("Nova rezervacija je uspešno dodata.");
            this.Close();


        }

        private void DodajNovuRezervacijuForma_Load(object sender, EventArgs e)
        {

        }
    }
}
