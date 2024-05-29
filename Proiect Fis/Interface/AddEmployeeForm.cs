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
            if (string.IsNullOrWhiteSpace(txtNume.Text) || string.IsNullOrWhiteSpace(cmbCategorie.Text))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii.");
                return;
            }

            Angajat.AdaugaAngajat(txtNume.Text, cmbCategorie.Text);

            MessageBox.Show("Angajat adăugat cu succes!");


            txtNume.Clear();
            cmbCategorie.SelectedIndex = -1;
        }

        private void BtnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
