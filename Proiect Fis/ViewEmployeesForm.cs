using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Proiect_Fis.Data;

namespace Proiect_Fis
{
    public partial class ViewEmployeesForm : Form
    {
        public ViewEmployeesForm()
        {
            InitializeComponent();
        }

        private void DeleteEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using (var context = new ApplicationDbContext())
            {
                var angajati = context.Angajati.Select(a => new { a.AngajatId, a.Nume, a.Categorie }).ToList();
                dgvAngajati.DataSource = angajati;
            }
        }

        private void ȘtergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAngajati.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAngajati.SelectedRows[0].Index;
                int angajatId = (int)dgvAngajati.Rows[selectedRowIndex].Cells["AngajatId"].Value;

                using (var context = new ApplicationDbContext())
                {
                    var angajat = context.Angajati.FirstOrDefault(a => a.AngajatId == angajatId);
                    if (angajat != null)
                    {
                        context.Angajati.Remove(angajat);
                        context.SaveChanges();
                    }
                }

                MessageBox.Show("Angajat șters cu succes!");
                LoadEmployees();
            }
            else
            {
                MessageBox.Show("Te rog să selectezi un angajat.");
            }
        }
    }
}
