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
    public partial class IstorijaForma : Form
    {
        private Korisnik klijent;
        
        public IstorijaForma(Korisnik klijent)
        {
            this.klijent = klijent;
            InitializeComponent();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IstorijaForma_Load(object sender, EventArgs e)
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
                if (izlet.Datum > danasnjiDatum)
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
    }
}
