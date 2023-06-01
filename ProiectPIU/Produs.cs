using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPIU
{
    public class Produs
    {
        private const int ID = 0;
        private const int NUME = 1;
        private const int DESCRIERE = 2;
        private const int PRET = 3;
        private const int CANTITATE = 4;
        private const int PRET_TOTAL = 5;

        private char SEPARATOR_FISIER = ';';
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public decimal Pret { get; set; }
        public int Cantitate { get; set; }
        public decimal Pret_total { get; set; }
        public int Id { get; set; }
        public Produs() { }
        public Produs(string nume, string descriere, decimal pret, int cantitate)
        {
            Id = File.ReadAllLines("Produs.txt").Length + 1;
            Nume = nume;
            Descriere = descriere;
            Pret = pret;
            Pret_total = pret * cantitate;
            Cantitate = cantitate;
        }

        //Constructor pentru lucru cu fisier
        public Produs(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_FISIER);
            Id = Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Descriere = dateFisier[DESCRIERE];
            Pret = Convert.ToInt32(dateFisier[PRET]);
            Cantitate = Convert.ToInt32(dateFisier[CANTITATE]);
            Pret_total = Convert.ToInt32(dateFisier[PRET_TOTAL]);
        }

        public override string ToString()
        {
            return $"\nProdus: {Nume} - {Descriere}\nPret: {Pret} lei\n" +
                   $"Pret Total: {Pret_total} lei\nCantitate: {Cantitate}\n";
        }

        public string ConversieLaSir_PentruFisier()
        {
            string FileObject = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}", SEPARATOR_FISIER,
                (Id.ToString() ?? "Necunoscut"),
                (Nume ?? "Necunoscut"),
                (Descriere ?? "Necunoscut"),
                (Pret.ToString() ?? "Necunoscut"),
                (Pret_total.ToString() ?? "Necunoscut"),
                (Cantitate.ToString() ?? "Necunoscut"));
            return FileObject;
        }
    }
}
