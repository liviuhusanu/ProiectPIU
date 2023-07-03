using ProiectPIU;

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


namespace WindowsFormsApp1
{
    public partial class FormCart : Form
    {
        private List<Produs> listProdus = new List<Produs>();
        private string numeFisier = "Comanda.txt";
        decimal pretTotal = 0;

        public FormCart()
        {
            InitializeComponent();
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            Administrare_Fisier admin = new Administrare_Fisier(numeFisier);
            Produs[] produse = admin.GetProdus(File.ReadLines(numeFisier).Count());
            foreach (var produs in produse)
            {
                dataGridView1.Rows.Add(new object[] { produs.Id, produs.Nume, produs.Descriere, produs.Pret, produs.Cantitate, produs.Pret_total });
                pretTotal += produs.Pret_total;
                lblPretTotal.Text ="Pret total: " + pretTotal.ToString() + " lei";
            }
        }


    }
}
