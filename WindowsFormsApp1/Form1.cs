using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

using ProiectPIU;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Administrare_Fisier adminProdus;
        Administrare_Fisier adminProdus1;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produs p3 = new Produs(textBox1.Text);
            string numeFisier = "Produs.txt";
            Administrare_Fisier adminProdus = new Administrare_Fisier(numeFisier);
            adminProdus.AddProdus(p3);

            //Produs[] getprod = adminProdus.GetProdus(File.ReadAllLines("Produs.txt").Length);
            
            //Comanda c4 = new Comanda(textBox3.Text, getprod, c3);
            //string numeFisier = "Comanda.txt";
            //Administrare_Fisier adminProdus = new Administrare_Fisier(numeFisier);
            //adminProdus.AddComanda(c4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client c3 = new Client(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Comanda c4 = new Comanda(textBox3.Text);
            string numeFisier = "Comanda.txt";
            Administrare_Fisier adminProdus = new Administrare_Fisier(numeFisier);
            adminProdus.AddComanda(c4);
        }
    }
}
