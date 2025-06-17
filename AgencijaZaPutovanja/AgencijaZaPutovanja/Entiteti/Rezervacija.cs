using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaPutovanja.Entiteti
{
    public class Rezervacija
    {
        private int idKorisnika;
        private int idIzleta;
        private decimal ukupnaCena;
        private int brojRezervisanihMesta;
        private DateTime datumIVreme;

        public int IdKorisnika
        {
            get { return idKorisnika; }
            set { idKorisnika = value; }
        }

        public int IDIzleta
        {
            get { return idIzleta; }
            set { idIzleta = value; }
        }

        public decimal UkupnaCena
        {
            get { return ukupnaCena; }
            set { ukupnaCena = value; }
        }

        public int BrojRezervisanihMesta
        {
            get { return brojRezervisanihMesta; }
            set { brojRezervisanihMesta = value; }
        }

        public DateTime DatumIVreme
        {
            get { return datumIVreme; }
            set { datumIVreme = value; }
        }

        public Rezervacija()
        {
            
        }

        // Konstruktor klase
        public Rezervacija(int idKorisnika, int idIzleta, decimal ukupnaCena, int brojRezervisanihMesta, DateTime datumIVreme)
        {
            this.idKorisnika = idKorisnika;
            this.idIzleta = idIzleta;
            this.ukupnaCena = ukupnaCena;
            this.brojRezervisanihMesta = brojRezervisanihMesta;
            this.datumIVreme = datumIVreme; 
        }

        // Opcionalna metoda za prikaz informacija o rezervaciji
        public override string ToString()
        {
            return $"ID Korisnika: {idKorisnika}\nID Izleta: {idIzleta}\nUkupna Cena: {ukupnaCena:C}\nBroj Rezervisanih Mesta: {brojRezervisanihMesta}\nDatum i Vreme: {datumIVreme:dd.MM.yyyy HH:mm:ss}";
        }

       
    }
}

