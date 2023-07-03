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
using ProiectPIU;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormHome : Form
    {
        private FormStart form;
        private string numeFisier = "Client.txt";

        public FormHome()
        {
            InitializeComponent();
        }

        private void ClearTextBox()
        {
            textBoxNumeClient.Text = string.Empty;
            textBoxAdresaClient.Text = string.Empty;
            textBoxTelefonClient.Text = string.Empty;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            bool hasError = false;

            if (string.IsNullOrEmpty(textBoxNumeClient.Text) || textBoxNumeClient.Text.Split(' ').Length < 2)
            {
                hasError = true;
                errorProvider1.SetError(textBoxNumeClient, "Introdu numele");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrEmpty(textBoxAdresaClient.Text) || textBoxNumeClient.Text.Split(' ').Length < 2)
            {
                hasError = true;
                errorProvider2.SetError(textBoxAdresaClient, "Introdu adresa");
            }
            else
            {
                errorProvider2.Clear();
            }

            if (!int.TryParse(textBoxTelefonClient.Text, out int telefon) || textBoxTelefonClient.TextLength <= 9 || textBoxTelefonClient.TextLength >= 11)
            {
                hasError = true;
                errorProvider3.SetError(textBoxTelefonClient, "Introdu numarul corect: 07XXXXXXXX");
            }
            else
            {
                errorProvider3.Clear();
            }

            if (hasError == false)
            {
                Client c1 = new Client();
                c1.Nume = textBoxNumeClient.Text;
                c1.Adresa = textBoxAdresaClient.Text;
                c1.Telefon = textBoxTelefonClient.Text;

                Administrare_Fisier adminFisier = new Administrare_Fisier(numeFisier);
                adminFisier.AddClient(c1);


                FormStart formStart = new FormStart();
                formStart.Nume = textBoxNumeClient.Text;
                formStart.Adresa = textBoxAdresaClient.Text;
                formStart.Telefon = textBoxTelefonClient.Text;

                ClearTextBox();
            }
        }
    }
}
