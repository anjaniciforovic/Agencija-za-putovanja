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
    public partial class DetaljniPrikazForma : Form
    {
        private Rezervacija rezervacija;

        public DetaljniPrikazForma(Rezervacija rezervacija)
        {
            InitializeComponent();
            this.rezervacija = rezervacija;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetaljniPrikazForma_Load(object sender, EventArgs e)
        {
            lstRezervacije.View = View.Details;
            lstRezervacije.Columns.Add("Mesto", 100);
            lstRezervacije.Columns.Add("Država", 100);
            lstRezervacije.Columns.Add("Cena", 80);
            lstRezervacije.Columns.Add("Popust", 80);
            lstRezervacije.Columns.Add("Broj Dana", 80);
            lstRezervacije.Columns.Add("Ukupno Mesta", 100);
            lstRezervacije.Columns.Add("Datum", 120);
            lstRezervacije.Columns.Add("Broj Rezervisanih Mesta", 150);
            lstRezervacije.Columns.Add("Ukupna Cena", 100);
            PrikaziDetaljeRezervacije();
        }
        

        private void PrikaziDetaljeRezervacije()
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            // Pronađi izlet na osnovu ID-a iz rezervacije
            var izlet = podaci.Izleti.FirstOrDefault(i => i.ID == rezervacija.IDIzleta);
            if (izlet != null)
            {
                ListViewItem item = new ListViewItem(izlet.Mesto);
                item.SubItems.Add(izlet.Drzava);
                item.SubItems.Add(izlet.Cena.ToString("C"));
                item.SubItems.Add(izlet.Popust.ToString() + "%");
                item.SubItems.Add(izlet.BrDana.ToString());
                item.SubItems.Add(izlet.UkupnoMesta.ToString());
                item.SubItems.Add(izlet.Datum.ToString("dd.MM.yyyy"));
                item.SubItems.Add(rezervacija.BrojRezervisanihMesta.ToString());
                item.SubItems.Add(rezervacija.UkupnaCena.ToString() + "eur");

                lstRezervacije.Items.Add(item);
            }
        }
    }
}

