using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaPutovanja.Entiteti
{
    public class Izlet
    {
        private int id;
        private string mesto;
        private string drzava;
        private int cena;
        private int popust;
        private int brDana;
        private int ukupnoMesta;
        private DateTime datum;


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Mesto
        {
            get { return mesto; }
            set { mesto = value; }
        }

        public string Drzava
        {
            get { return drzava; }
            set { drzava = value; }
        }

        public int Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        public int Popust
        {
            get { return popust; }
            set { popust = value; }
        }

        public int BrDana
        {
            get { return brDana; }
            set { brDana = value; }
        }

        public int UkupnoMesta
        {
            get { return ukupnoMesta; }
            set { ukupnoMesta = value; }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public Izlet()
        {
            
        }


        // Konstruktor klase
        public Izlet(int id, string mesto, string drzava, int cena, int popust, int brDana, int ukupnoMesta, DateTime datum)
        {
            this.id = id;
            this.mesto = mesto;
            this.drzava = drzava;
            this.cena = cena;
            this.popust = popust;
            this.brDana = brDana;
            this.ukupnoMesta = ukupnoMesta;
            this.datum = datum;
        }

        // Opcionalna metoda za prikaz informacija o izletu
        public override string ToString()
        {
            return $"Izlet ID: {id}\nMesto: {mesto}\nDržava: {drzava}\nCena: {cena} RSD\nPopust: {popust}%\nBroj Dana: {brDana}\nUkupno Mesta: {ukupnoMesta}\nDatum: {datum:dd.MM.yyyy}";
        }

        
        
    }

}

