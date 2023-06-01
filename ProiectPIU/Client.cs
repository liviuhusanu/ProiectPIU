using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPIU
{
    public class Client
    {
        private const int NUME = 0;
        private const int ADRESA = 1;
        private const int TELEFON = 2;

        private char SEPARATOR_FISIER = ';';
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }

        public Client() { }

        public Client(string nume, string adresa, string telefon)
        {
            Nume = nume;
            Adresa = adresa;
            Telefon = telefon;
        }

        public Client(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_FISIER);
            Nume = dateFisier[NUME];
            Adresa = dateFisier[ADRESA];
            Telefon = dateFisier[TELEFON];
        }

        public override string ToString()
        {
            return $"Nume: {Nume}\nAdresa: {Adresa}\n" +
                   $"Telefon: {Telefon}\n";
        }

        public string ConversieLaSir_PentruFisier()
        {
            string FileObject = string.Format("{1}{0}{2}{0}{3}", SEPARATOR_FISIER,
                (Nume ?? "Necunoscut"),
                (Adresa ?? "Necunoscut"),
                (Telefon.ToString() ?? "Necunoscut"));
            return FileObject;
        }
    }
}
