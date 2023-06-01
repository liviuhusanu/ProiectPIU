using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPIU
{
    public class Comanda
    {
        private const int ID = 0;
        private const int DATACOMANZII = 1;
        private const int PRODUSECOMANDATE = 2;
        private const int TOTALCOMANDA = 3;
        private const int CLIENT = 4;

        private char SEPARATOR_FISIER = ';';
        public int Id { get; set; }
        public DateTime DataComenzii { get; set; }
        public List<Produs> ProduseComandate { get; set; }
        public decimal TotalComanda { get; set; }
        public Client client { get; set; }

        public Comanda() { }

        public Comanda(DateTime dataComenzii, List<Produs> produseComandate, Client client)
        {
            Id = File.ReadAllLines("Comanda.txt").Length + 1;
            DataComenzii = dataComenzii;
            ProduseComandate = produseComandate;
            foreach (Produs produs in produseComandate)
            {
                TotalComanda += produs.Pret_total;
            }
            this.client = client;
        }

        public Comanda(string linieFisier)
        {   

            var dateFisier = linieFisier.Split(SEPARATOR_FISIER);
            Id = Convert.ToInt32(dateFisier[ID]);
            DataComenzii = Convert.ToDateTime(dateFisier[DATACOMANZII]);
            string ProduseComandate = dateFisier[PRODUSECOMANDATE];
            TotalComanda = Convert.ToInt32(dateFisier[TOTALCOMANDA]);
            //string client = dateFisier[CLIENT];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Produs produs in ProduseComandate)
            {
                sb.Append(produs.ToString());
            }

            return $"ID: {Id}\nPret Total: {TotalComanda} lei\nClient: {client.Nume}\nData: {DataComenzii}\n{sb}\n";
        }

        public string ConversieLaSir_PentruFisier()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Produs produs in ProduseComandate)
            {
                sb.Append(produs.ConversieLaSir_PentruFisier());
            }
            string FileObject = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}", SEPARATOR_FISIER,
                (Id.ToString() ?? "Necunoscut"),
                (DataComenzii.ToString("dd.MM.yyyy") ?? "Necunoscut"),
                (sb.ToString() ?? "Necunoscut"),
                (TotalComanda.ToString() ?? "Necunoscut"),
                (client.Nume ?? "Necunoscut"));
            return FileObject;
        }
    }
}
