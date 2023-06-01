using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPIU
{
    public class Administrare_Fisier
    {
        private string numeFisier = "Produs.txt";
        private string numeFisier1 = "Comanda.txt";
        public Administrare_Fisier(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddProdus(Produs produs)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(produs.ConversieLaSir_PentruFisier());
            }
        }

        public void AddComanda(Comanda comanda)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier1, true))
            {
                streamWriterFisierText.WriteLine(comanda.ConversieLaSir_PentruFisier());
            }
        }

        public Produs[] GetProdus(int nrProdus)
        {
            Produs[] produs = new Produs[nrProdus];
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                int contor = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    try
                    {
                        produs[contor++] = new Produs(linieFisier);
                    }
                    catch (Exception e)
                    {
                        contor--;
                        Console.WriteLine("Error: {0}", e.Message);
                    }

                }
            }
            return produs;
        }

        public IEnumerable<Produs> Search(Func<Produs, bool> predicate)
        {
            {
                Produs[] produse = GetProdus(File.ReadAllLines(numeFisier).Length);
                foreach (Produs produs in produse)
                {
                    if (predicate(produs))
                    {
                        yield return produs;
                    }
                }

            }
        }
    }
}
