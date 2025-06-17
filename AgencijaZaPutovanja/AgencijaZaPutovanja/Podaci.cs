using AgencijaZaPutovanja.Entiteti;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace AgencijaZaPutovanja
{
    public class Podaci
    {
        public Podaci()
        {
            Korisnici = new List<Korisnik>();
            Izleti = new List<Izlet>();
            Rezervacije = new List<Rezervacija>();
        }

        public List<Korisnik> Korisnici { get; set; }
        public List<Izlet> Izleti { get; set; }
        public List<Rezervacija> Rezervacije { get; set; }
        public void Ucitaj()
        {
            var xmlSerializer = new XmlSerializer(typeof(Podaci));
            using (var reader = new StreamReader("podaci.xml"))
            {
                var ucitaniPodaci = (Podaci)xmlSerializer.Deserialize(reader);
                this.Korisnici = ucitaniPodaci.Korisnici;
                this.Izleti = ucitaniPodaci.Izleti;
                this.Rezervacije = ucitaniPodaci.Rezervacije;
            }
        }
        public void Sacuvaj()
        {

            var xmlSerializer = new XmlSerializer(typeof(Podaci));

            var stringWriter = new StringWriter();
            string xml;
            using (var writer = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Indent = true }))
            {
                xmlSerializer.Serialize(writer, this);
                xml = stringWriter.ToString();
            };

            File.WriteAllText("podaci.xml", xml);



        }
    }
}
