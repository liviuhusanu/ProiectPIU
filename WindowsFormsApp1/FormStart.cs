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
using System.Reflection.Emit;

namespace WindowsFormsApp1
{
    public partial class FormStart : Form
    {
        private Form activeForm;
        private string numeFisier = "Comanda.txt";
        private string numeFisier1 = "Client.txt";
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }

        public FormStart()
        {
            InitializeComponent();
            lblClientNume.Text = Nume;
            lblClientAdresa.Text = Adresa;
            lblClientTelefon.Text = Telefon;
            lblClientNume.BringToFront();
            lblClientAdresa.BringToFront();
            lblClientTelefon.BringToFront();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) 
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            File.WriteAllText(numeFisier, string.Empty);
            File.WriteAllText(numeFisier1, string.Empty);
            OpenChildForm(new FormHome(), sender);
            lblTitle.Text = "";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormList(), sender);
            lblTitle.Text = "Produse";
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCart(), sender);
            lblTitle.Text = "Coș";
        }
    }
}
