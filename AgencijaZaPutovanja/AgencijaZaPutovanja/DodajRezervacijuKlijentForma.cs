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
    public partial class DodajRezervacijuKlijentForma : Form
    {
        private int korisnikId;
        private decimal cenaPoOsobi;
        private decimal popust;
        public DodajRezervacijuKlijentForma(int korisnikId)
        {
            InitializeComponent();
            this.korisnikId = korisnikId;
            nudBrojPutnika.ValueChanged += nudBrojPutnika_ValueChanged;
        }

        

        private void DodajRezervacijuKlijentForma_Load(object sender, EventArgs e)
        {
            lstIzleti.View = View.Details;
            lstIzleti.Columns.Add("Mesto", 100);
            lstIzleti.Columns.Add("Država", 100);
            lstIzleti.Columns.Add("Cena", 60);
            lstIzleti.Columns.Add("Popust", 60);
            lstIzleti.Columns.Add("Broj Dana", 60);
            lstIzleti.Columns.Add("Ukupno Mesta", 80);
            lstIzleti.Columns.Add("Datum", 100);
            OsveziIzlet();
            PopuniComboBox();
        }

        private void OsveziIzlet()
        {
            var podaci = new Podaci();
            podaci.Ucitaj();  

            lstIzleti.Items.Clear(); 
            foreach (var izlet in podaci.Izleti)
            {
                
                ListViewItem item = new ListViewItem(izlet.Mesto);
                item.SubItems.Add(izlet.Drzava);
                item.SubItems.Add(izlet.Cena.ToString() + "eur");  
                item.SubItems.Add(izlet.Popust.ToString() + "%");  
                item.SubItems.Add(izlet.BrDana.ToString());
                item.SubItems.Add(izlet.UkupnoMesta.ToString());
                item.SubItems.Add(izlet.Datum.ToString("dd.MM.yyyy"));  
                item.Tag = izlet.ID;
                
                lstIzleti.Items.Add(item);
            }
        }

        private void lstIzleti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIzleti.SelectedItems.Count > 0)
            {
                ListViewItem selectedTrip = lstIzleti.SelectedItems[0];
                var podaci = new Podaci();
                podaci.Ucitaj();
                int izletId = (int)selectedTrip.Tag;
                var izlet = podaci.Izleti.FirstOrDefault(i => i.ID == izletId);

                if (izlet != null)
                {
                    cenaPoOsobi = izlet.Cena;
                    popust = izlet.Popust;
                    IzracunajCenu();
                }
            }
            


        }
        private void nudBrojPutnika_ValueChanged(object sender, EventArgs e)
        {
            IzracunajCenu();
        }

        private void btnRezervisiIzlet_Click_1(object sender, EventArgs e)
        {
            if (lstIzleti.SelectedItems.Count > 0 && nudBrojPutnika.Value > 0)
            {
                ListViewItem selectedTrip = lstIzleti.SelectedItems[0];
                int izletId = (int)selectedTrip.Tag;

                var podaci = new Podaci();
                podaci.Ucitaj();

                var izlet = podaci.Izleti.FirstOrDefault(i => i.ID == izletId);
                if (izlet != null)
                {

                    int brojPutnika = (int)nudBrojPutnika.Value;
                    decimal popust = izlet.Popust;
                    decimal ukupnaCena = (brojPutnika * izlet.Cena);
                    if (popust > 0)
                    {
                        ukupnaCena = ukupnaCena * (1 - popust / 100);
                    }

                    Rezervacija novaRezervacija = new Rezervacija
                    {
                        IdKorisnika = korisnikId,
                        IDIzleta = izlet.ID,
                        BrojRezervisanihMesta = brojPutnika,
                        UkupnaCena = ukupnaCena,
                        DatumIVreme = DateTime.Now
                    };

                    podaci.Rezervacije.Add(novaRezervacija);
                    podaci.Sacuvaj();

                    MessageBox.Show("Rezervacija uspešno dodata!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Izlet nije pronađen.");
                }
            }
            else
            {
                MessageBox.Show("Molimo Vas da izaberete izlet i unesete broj putnika.");
            }
        }
        private void IzracunajCenu()
        {
            if (lstIzleti.SelectedItems.Count > 0)
            {
                ListViewItem selectedTrip = lstIzleti.SelectedItems[0];
                var podaci = new Podaci();
                podaci.Ucitaj();

                int izletId = (int)selectedTrip.Tag;
                var izlet = podaci.Izleti.FirstOrDefault(i => i.ID == izletId);

                if (izlet != null)
                {
                    int brojPutnika = (int)nudBrojPutnika.Value;
                    decimal ukupnaCena = brojPutnika * izlet.Cena;

                    if (izlet.Popust > 0)
                    {
                        ukupnaCena = ukupnaCena * (1 - popust / 100);
                    }
                    txtCena.Text = ukupnaCena.ToString("0.00") + " eur";
                }
            }
        }

        private void PopuniComboBox()
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            // Koristi HashSet da bi eliminisao duplikate
            HashSet<string> drzave = new HashSet<string>();

            foreach (var izlet in podaci.Izleti)
            {
                drzave.Add(izlet.Drzava);
            }

            // Dodaj države u ComboBox
            cmbDrzava.Items.Clear();
            foreach (var drzava in drzave)
            {
                cmbDrzava.Items.Add(drzava);
            }
        }

        // Ažuriraj ListView na osnovu selektovane države
        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            string izabranaDrzava = cmbDrzava.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(izabranaDrzava))
            {
                OsveziIzlete(izabranaDrzava);
            }
        }

        // Osveži ListView da prikaže samo izlete u selektovanoj državi
        private void OsveziIzlete(string drzava)
        {
            var podaci = new Podaci();
            podaci.Ucitaj();

            lstIzleti.Items.Clear();

            foreach (var izlet in podaci.Izleti.Where(i => i.Drzava == drzava))
            {
                ListViewItem item = new ListViewItem(izlet.Mesto);
                item.SubItems.Add(izlet.Drzava);
                item.SubItems.Add(izlet.Cena.ToString() + "eur");
                item.SubItems.Add(izlet.Popust.ToString() + "%");
                item.SubItems.Add(izlet.BrDana.ToString());
                item.SubItems.Add(izlet.UkupnoMesta.ToString());
                item.SubItems.Add(izlet.Datum.ToString("dd.MM.yyyy"));
                item.Tag = izlet.ID;
                lstIzleti.Items.Add(item);
            }
        }
    }
}
