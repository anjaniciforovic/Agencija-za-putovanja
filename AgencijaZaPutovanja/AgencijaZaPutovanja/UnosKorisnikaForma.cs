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
    enum UnosKorisnikaMod
    {
        Kreiranje,
        Izmena
    }

    public partial class UnosKorisnikaForma : Form
    {
        private UnosKorisnikaMod mod;

        public UnosKorisnikaForma()
        {
            this.mod = UnosKorisnikaMod.Kreiranje;

            InitializeComponent();
        }

        public UnosKorisnikaForma(Korisnik korisnik )
        {
            this.mod = UnosKorisnikaMod.Izmena;

            InitializeComponent();

            txtId.Text = korisnik.Id.ToString();
            txtKorisnickoIme.Text = korisnik.KorisnickoIme;
            txtLozinka.Text = korisnik.Lozinka;
            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodajKorisnikaForma_Load(object sender, EventArgs e)
        {
            cmbVrstaKorisnika.DataSource = Enum.GetValues(typeof(VrstaKorisnika));

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("ID mora biti broj");
                return;
            }
            VrstaKorisnika vrstaKorisnika;
            if (cmbVrstaKorisnika.SelectedItem == null)
            {
                MessageBox.Show("Molimo Vas da izaberete vrstu korisnika.");
                return;
            }
            else
            {
                // Čitanje izabrane vrednosti iz ComboBox-a
                vrstaKorisnika = (VrstaKorisnika)cmbVrstaKorisnika.SelectedItem;


            }

            var podaci = new Podaci();
            podaci.Ucitaj();

            if (this.mod == UnosKorisnikaMod.Kreiranje)
            {
                // Kreiranje novog korisnika
                Korisnik noviKorisnik = new Korisnik(id, ime, prezime, korisnickoIme, lozinka, vrstaKorisnika);

                // Dodavanje novog korisnika u listu korisnika
                podaci.Korisnici.Add(noviKorisnik);
            }
            else
            {
                var postojeciKorisnik = podaci.Korisnici.First(k => k.Id == id);
                postojeciKorisnik.KorisnickoIme = korisnickoIme;
                postojeciKorisnik.Lozinka = lozinka;
                postojeciKorisnik.Ime = ime;
                postojeciKorisnik.Prezime = prezime;
                postojeciKorisnik.VrstaKorisnika = vrstaKorisnika;
            }

            // Čuvanje podataka u XML
            podaci.Sacuvaj(); 



            MessageBox.Show("Novi korisnik je uspešno dodat, ili izmenjen.");
            this.Close();
        }

        private void cmbVrstaKorisnika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
