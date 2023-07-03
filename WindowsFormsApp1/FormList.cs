using ProiectPIU;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class FormList : Form
    {
        private List<Produs> listProdus = new List<Produs>();
        private string numeFisier = "Produs.txt";

        public FormList()
        {
            InitializeComponent();
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            Administrare_Fisier admin = new Administrare_Fisier(numeFisier);
            Produs[] produse = admin.GetProdus(File.ReadLines(numeFisier).Count());
            foreach (var produs in produse)
            {
                dataGridView1.Rows.Add(new object[] { produs.Id, produs.Nume, produs.Descriere, produs.Pret, produs.Cantitate });
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listProdus.Clear();
            Administrare_Fisier admin = new Administrare_Fisier(numeFisier);

            foreach (DataGridViewRow selectedRow in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkboxCell = selectedRow.Cells["addColumn"] as DataGridViewCheckBoxCell;

                if (checkboxCell != null && Convert.ToBoolean(checkboxCell.Value) == true)
                {
                    Produs produs = new Produs();
                    produs.Id = Convert.ToInt32(selectedRow.Cells["idColumn"].Value);
                    produs.Nume = selectedRow.Cells["brandColumn"].Value.ToString();
                    produs.Descriere = selectedRow.Cells["categorieColumn"].Value.ToString();
                    produs.Pret = Convert.ToDecimal(selectedRow.Cells["pretColumn"].Value);


                    if (selectedRow.Cells["cantitateColumn"].Value == null || Convert.ToInt32(selectedRow.Cells["cantitateColumn"].Value) == 0)
                    {
                        MessageBox.Show("Introdu cantitatea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    produs.Cantitate = Convert.ToInt32(selectedRow.Cells["cantitateColumn"].Value);
                    produs.Pret_total = produs.Pret * produs.Cantitate;

                    Produs produsToRemove = listProdus.Find(p => p.Id == produs.Id && p.Nume == produs.Nume && p.Descriere == produs.Descriere && p.Pret == produs.Pret && p.Cantitate == produs.Cantitate);

                    if (produsToRemove == null)
                    {
                        listProdus.Add(produs);
                    }
                    else
                    {
                        listProdus.Remove(produsToRemove);
                    }
                }
            }

            foreach (Produs produs in listProdus)
            {
                admin.AddProdus(produs);
            }
            lblNumar.Text ="Produse adăugate: " + listProdus.Count.ToString();
            dataGridView1.ClearSelection();
        }
    }
}


