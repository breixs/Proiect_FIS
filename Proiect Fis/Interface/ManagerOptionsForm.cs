using System;
using System.Linq;
using System.Windows.Forms;
using Proiect_Fis.Data;
using Proiect_Fis.Models;

namespace Proiect_Fis
{
    public partial class ManagerOptionsForm : Form
    {
        public ManagerOptionsForm()
        {
            InitializeComponent();
        }

        private void ManagerOptionsForm_Load(object sender, EventArgs e)
        {
            // Poți să adaugi aici încărcarea inițială a datelor dacă este necesar
        }

        private void BtnAdaugaAngajat_Click(object sender, EventArgs e)
        {
            var addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
        }

        private void BtnVizualizareAngajati_Click(object sender, EventArgs e)
        {
            var viewEmployeesForm = new ViewEmployeesForm();
            viewEmployeesForm.ShowDialog();
        }

        private void BtnStergeAngajat_Click(object sender, EventArgs e)
        {
            // Funcționalitatea de ștergere a fost mutată în `ViewEmployeesForm`.
        }

        private void BtnPropunePromotie_Click(object sender, EventArgs e)
        {
            PropunePromotie();
        }

        private void BtnStergePromotie_Click(object sender, EventArgs e)
        {
            StergePromotie();
        }

        private void BtnAdaugaProdus_Click(object sender, EventArgs e)
        {
            AdaugaProdus();
        }

        private void BtnAdaugaPiesa_Click(object sender, EventArgs e)
        {
            AdaugaPiesa();
        }

        // Metodele Managerului

        private void PropunePromotie()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var promotie = new Promotie { Discount = 10 };
                    context.Promotii.Add(promotie);
                    context.SaveChanges();
                }
                MessageBox.Show("Promoție propusă!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }
        }

        private void StergePromotie()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var promotie = context.Promotii.FirstOrDefault();
                    if (promotie != null)
                    {
                        context.Promotii.Remove(promotie);
                        context.SaveChanges();
                    }
                }
                MessageBox.Show("Promoție ștearsă!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }
        }

        private void AdaugaProdus()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var produs = new Produs { Descriere = "Descriere Produs", Pret = 100, Scor = 5, Nume="Memorie Kingston FURY Beast 16GB DDR4" };
                    context.Produse.Add(produs);
                    context.SaveChanges();
                }
                MessageBox.Show("Produs adăugat!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }
        }

        private void AdaugaPiesa()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var produs = new Produs { Descriere = "Descriere Piesă", Pret = 50, Scor = 4.5f};
                    context.Produse.Add(produs);
                    context.SaveChanges();
                }
                MessageBox.Show("Piesă adăugată!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }
        }
    }
}
