using System;
using System.Windows.Forms;
using Proiect_Fis.Data;
using Proiect_Fis.Models;

namespace Proiect_Fis
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            // Popularea ComboBox cu categoriile disponibile
            cmbCategorie.Items.Add("Manager");
            cmbCategorie.Items.Add("Angajat Senior");
            cmbCategorie.Items.Add("Angajat");
        }

        private void BtnSalveaza_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text;
            string categorie = cmbCategorie.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(categorie))
            {
                MessageBox.Show("Te rog să completezi toate câmpurile.");
                return;
            }

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var angajat = new Angajat { Nume = nume, Categorie = categorie };
                    context.Angajati.Add(angajat);
                    context.SaveChanges();
                }

                MessageBox.Show("Angajat adăugat cu succes!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }
        }

        private void BtnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
