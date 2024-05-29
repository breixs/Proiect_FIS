using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
           
        }

        private void BtnPropunePromotie_Click(object sender, EventArgs e)
        {
            int idMax;
            Promotie promotie= new Promotie(1, 10);
            List<Produs> produse = new List<Produs>();

            using (var context = new ApplicationDbContext())
            {
                idMax = context.Produse.Max(p => p.ProdusId);
                MessageBox.Show(idMax.ToString());
            }

            for (int i = 1; i <= idMax; i++)
            {
                produse.Add(new Produs(i));
            }

            foreach(Produs produs in produse)
            {
                if(produs.ProdusId==1)
                {
                    produs.adaugarePromotie(1);
                }
            }
          
            MessageBox.Show("Promotie propusă!");
        }

        private void BtnStergePromotie_Click(object sender, EventArgs e)
        {
            var promotii = Promotie.VizualizeazaPromotii();
            if (promotii.Any())
            {
                Promotie.StergePromotie(promotii.First().PromotieId);
                MessageBox.Show("Promotie ștearsă!");
            }
            else
            {
                MessageBox.Show("Nu există promoții de șters!");
            }
        }

        private void BtnAdaugaProdus_Click(object sender, EventArgs e)
        {
            AdaugaProdus();
        }

        private void BtnAdaugaPiesa_Click(object sender, EventArgs e)
        {
            AdaugaPiesa();
        }


        private void AdaugaProdus()
        {
            Produs produsNou=new Produs(Convert.ToInt32(produsIdTb.Text), descriereTB.Text, float.Parse(pretTB.Text), float.Parse(scorTB.Text), numeTB.Text, categorieTB.Text);
            produsNou.adaugareNoua(produsNou);
            MessageBox.Show("produs adaugat");
        }

        private void AdaugaPiesa()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    //var produs = new Produs { Descriere = "Descriere Piesă", Pret = 50, Scor = 4.5f };
                    //context.Produse.Add(produs);
                    //context.SaveChanges();
                }
                MessageBox.Show("Piesă adăugată!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StergeAngajatBtn_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                int angajatId;
                bool isValid = Int32.TryParse(angajatIdTB.Text, out angajatId);
                if (isValid)
                {
                    var angajat = context.Angajati.FirstOrDefault(c => c.AngajatId == angajatId);
                    if (angajat != null)
                    {
                        Angajat.StergeAngajat(angajatId);
                        MessageBox.Show("Angajat sters cu succes");
                    }
                    else
                    {
                        MessageBox.Show("Angajatul nu a fost gasit");
                    }
                }
                else
                {
                    MessageBox.Show("ID-ul angajatului introdus nu este valid");
                }
            }
        }
    }
}
