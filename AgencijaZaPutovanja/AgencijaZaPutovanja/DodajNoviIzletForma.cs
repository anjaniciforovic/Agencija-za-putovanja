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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AgencijaZaPutovanja
{
    enum NoviIzletMod
    {
        Kreiranje,
        Izmena
    }
    public partial class DodajNoviIzletForma : Form
    {
        private NoviIzletMod mod;
        public DodajNoviIzletForma()
        {
            this.mod =  NoviIzletMod.Kreiranje;
            InitializeComponent();
        }
        public DodajNoviIzletForma(Izlet izlet)
        {
            this.mod = NoviIzletMod.Izmena;
            InitializeComponent();
            txtId.Text = izlet.ID.ToString();
            txtMesto.Text = izlet.Mesto;
            txtDrzava.Text = izlet.Drzava;
            txtCena.Text = izlet.Cena.ToString();
            txtPopust.Text = izlet.Popust.ToString();
            txtBrDana.Text = izlet.BrDana.ToString();
            txtUkMesta.Text = izlet.UkupnoMesta.ToString();
            datDatum.Value = izlet.Datum;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DodajNoviIzletForma_Load(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string mesto = txtMesto.Text;
            string drzava = txtDrzava.Text;
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("ID mora biti broj");
                return;
            }
            int cena;
            if (!int.TryParse(txtCena.Text, out cena))
            {
                return;
            }
            int popust;
            if (!int.TryParse(txtPopust.Text, out popust))
            {
                 return;
            }
            int brDana;
            if (!int.TryParse(txtBrDana.Text, out brDana))
            {
                return;
            }
            int ukupnoMesta;
            if (!int.TryParse(txtUkMesta.Text, out ukupnoMesta))
            {
                return;
            }
            DateTime datum = datDatum.Value;

           
            var podaci = new Podaci();
            podaci.Ucitaj();

            if (this.mod == NoviIzletMod.Kreiranje)
            {
                // kreiranje novog izleta
                Izlet noviIzlet = new Izlet(id, mesto, drzava, cena, popust, brDana, ukupnoMesta, datum);

                // Dodavanje novog korisnika u listu korisnika
                podaci.Izleti.Add(noviIzlet);
                MessageBox.Show("Novi izlet je uspešno dodat.");
            }
            else
            {
                var postojeciIzlet = podaci.Izleti.First(i => i.ID == id);
                postojeciIzlet.Mesto = mesto;
                postojeciIzlet.Drzava = drzava;
                postojeciIzlet.Cena = cena;
                postojeciIzlet.Popust = popust;
                postojeciIzlet.BrDana = brDana;
                postojeciIzlet.UkupnoMesta = ukupnoMesta;
                postojeciIzlet.Datum = datum;
                MessageBox.Show("Novi izlet je uspešno izmenjen.");
            }

            

            // Čuvanje podataka u XML
            podaci.Sacuvaj();



            
            this.Close();
        }

       
        
    }
}
