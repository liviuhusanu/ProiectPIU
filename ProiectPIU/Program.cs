using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPIU
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crearea unui produs
            Produs p = new Produs("Adidasi Nike", "Adidasi de alergare pentru barbati", 250, 2);

            //Crearea unui client
            Client q = new Client("Alex Dumbrava", "Calea Iesilor 23", "077878");
            //Console.WriteLine(q.ToString());

            //Produs p1 = new Produs("Adidasi Adidas", "Adidasi sport pentru alergat", 200, 3);

            //Crearea unei liste de produse
            List<Produs> listaProduse = new List<Produs>();
            //listaProduse.Add(p1);
            listaProduse.Add(p);

            //Crearea unei comenzi
            Comanda a = new Comanda(new DateTime(2016, 01, 22), listaProduse, q);
            Console.WriteLine(a.ToString());

            //Scrierea intr-un fisier text a unui produs
            string numeFisier = "Produs.txt";
            string numeFisier1 = "Comanda.txt";

            //Produs produs = new Produs();
            Administrare_Fisier adminProdus = new Administrare_Fisier(numeFisier);
            adminProdus.AddProdus(p);

            //Scrierea intr-un fisier text a unei comenzi
            Administrare_Fisier adminComanda = new Administrare_Fisier(numeFisier1);
            adminComanda.AddComanda(a);

            //Preluarea datelor din fisier
            Produs[] getprod = adminProdus.GetProdus(File.ReadAllLines(numeFisier).Length);
            foreach (Produs produs in getprod)
            {
                Console.WriteLine(produs.ToString());
            }

            //Citirea datelor de la tastatura si cautarea dupa criterii
            Produs d1 = new Produs();
            Console.WriteLine("Introduceti modelul: ");
            d1.Nume = Console.ReadLine();
            Console.WriteLine("Introduceti pretul: ");
            d1.Pret = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduceti descrierea: ");
            //d1.Descriere = Console.ReadLine();

            //Console.WriteLine("Pret: ");
            //d1.Pret = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Cantitatea: ");
            //d1.Cantitate = Convert.ToInt32(Console.ReadLine());

            //d1.Pret_total = d1.Pret * d1.Cantitate;

            var CautProduse = adminProdus.Search(produs =>
            (produs.Nume == d1.Nume) &&
            (produs.Pret == d1.Pret));
            foreach (Produs produs in CautProduse)
            {
                Console.WriteLine(produs);
            }
        }
    }
}