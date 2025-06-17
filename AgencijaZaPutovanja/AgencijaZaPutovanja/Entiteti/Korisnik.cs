using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaPutovanja.Entiteti
{
    public enum VrstaKorisnika
    {
        Admin,
        Klijent
    }

    public class Korisnik 
    {
        private int id;
        private string ime;
        private string prezime;
        private string korisnickoIme;
        private string lozinka;
        private VrstaKorisnika vrstaKorisnika;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string KorisnickoIme
        {
            get { return korisnickoIme; }
            set { korisnickoIme = value; }
        }

        public string Lozinka
        {
            get { return lozinka; }
            set { lozinka = value; }
        }

        public VrstaKorisnika VrstaKorisnika
        {
            get { return vrstaKorisnika; }
            set { vrstaKorisnika = value; }
        }

        // Konstruktor klase
        public Korisnik()
        {
                
        }

        public Korisnik(int id, string ime, string prezime, string korisnickoIme, string lozinka, VrstaKorisnika vrstaKorisnika)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.vrstaKorisnika = vrstaKorisnika;
        }

        // Opcionalna metoda za prikaz informacija o korisniku
        public override string ToString()
        {
            return $"ID: {id}\nIme: {ime}\nPrezime: {prezime}\nKorisničko Ime: {korisnickoIme}\nVrsta Korisnika: {vrstaKorisnika}";
        }
    }

}

