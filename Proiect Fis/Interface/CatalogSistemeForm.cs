using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_Fis.Data;
using Proiect_Fis.Models;

namespace Proiect_Fis.Interface
{
    public partial class CatalogSistemeForm : Form
    {
        public CatalogSistemeForm()
        {
            InitializeComponent();
        }

        private void ChangeLabel(Label labelNume, Label labelDescriere, int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var numeProdus = context.Produse
                           .Where(p => p.ProdusId == id)
                           .Select(p => p.Nume)
                           .FirstOrDefault();
                labelNume.Text = numeProdus;

                var descriereProdus = context.Produse.Where(p => p.ProdusId == id).Select(p => p.Descriere).FirstOrDefault();
                labelDescriere.Text= descriereProdus;   
            }
        }

        private void ChangeList(ListBox listbox, int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var specificatiiProdus = context.Produse
                           .Where(p => p.ProdusId == id)
                           .Select(p => new { p.Nume, p.Pret, p.Scor, p.Descriere})
                           .ToList();
                listbox.Items.Clear(); // Clear existing items if necessary

                foreach (var item in specificatiiProdus)
                {
                    List<string> itemDetails = new List<string>();

                    itemDetails.Add($"Nume: {item.Nume}");
                    itemDetails.Add($"Pret: {item.Pret}");
                    itemDetails.Add($"Scor: {item.Scor}");
                    itemDetails.Add($"Descriere: {item.Descriere}");

                    foreach (string detail in itemDetails)
                    {
                        listbox.Items.Add(detail);
                    }
                }
            }
        }

        private void CatalogSistemeForm_Load(object sender, EventArgs e)
        {
            //ChangeLabel(ProdusNumeLabel1, ProdusDescriereLabel1, 1);
            //ChangeLabel(ProdusNumeLabel2, ProdusDescriereLabel2, 2);
            ChangeList(listBox1, 1);
            ChangeList(listBox2, 2);
            ChangeList(listBox3, 3);
        }
    }
}
