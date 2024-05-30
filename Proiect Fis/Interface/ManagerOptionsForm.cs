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
        public string AngajatNume { get; set; }
        public string AngajatCategorie { get; set; }
        public bool EmployeeFormVisible { get; set; }
        public string ProdusNume { get; set; }
        public string ProdusDescriere { get; set; }
        public float ProdusPret { get; set; }
        public float ProdusScor { get; set; }
        public string ProdusCategorie { get; set; }
        public ManagerOptionsForm()
        {
            InitializeComponent();
        }

        public void ManagerOptionsForm_Load(object sender, EventArgs e)
        {
           
        }

        public void BtnAdaugaAngajat_Click(object sender, EventArgs e)
        {
            var addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
        }

        public void BtnVizualizareAngajati_Click(object sender, EventArgs e)
        {
            var viewEmployeesForm = new ViewEmployeesForm();
            viewEmployeesForm.ShowDialog();
        }

        public void BtnStergeAngajat_Click(object sender, EventArgs e)
        {
           
        }

        public void BtnPropunePromotie_Click(object sender, EventArgs e)
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

        public void BtnStergePromotie_Click(object sender, EventArgs e)
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

        public void BtnAdaugaProdus_Click(object sender, EventArgs e)
        {
            AdaugaProdus();
        }

        public void BtnAdaugaPiesa_Click(object sender, EventArgs e)
        {
            AdaugaPiesa();
        }


        public void AdaugaProdus()
        {
            Produs produsNou=new Produs(Convert.ToInt32(produsIdTb.Text), descriereTB.Text, float.Parse(pretTB.Text), float.Parse(scorTB.Text), numeTB.Text, categorieTB.Text);
            produsNou.adaugareNoua(produsNou);
            MessageBox.Show("produs adaugat");
        }

        public void AdaugaPiesa()
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

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void StergeAngajatBtn_Click(object sender, EventArgs e)
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
