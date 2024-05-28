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
            //using (var context = new ApplicationDbContext())
            ///{
              //  var numeProdus = context.Produse
              //             .Where(p => p.ProdusId == id)
              //             .Select(p => p.Nume)
              //             .FirstOrDefault();
               // labelNume.Text = numeProdus;

                //var descriereProdus = context.Produse.Where(p => p.ProdusId == id).Select(p => p.Descriere).FirstOrDefault();
                //labelDescriere.Text= descriereProdus;   
            //}
        }
        private void CatalogSistemeForm_Load(object sender, EventArgs e)
        {
            List<Produs> produse = new List<Produs>();
            produse.Add(new Produs(1));
            produse.Add(new Produs(2));
            produse.Add(new Produs(3));
            Produs.afisareProduse(produse[0],listBox1, 1);
            Produs.afisareProduse(produse[1], listBox2, 2);
            Produs.afisareProduse(produse[2], listBox3, 3);

            //ChangeList(listBox1, 1);
            //ChangeList(listBox2, 2);
            //ChangeList(listBox3, 3);
        }
    }
}
