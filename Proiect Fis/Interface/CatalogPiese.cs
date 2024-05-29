using Proiect_Fis.Data;
using Proiect_Fis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Fis.Interface
{
    public partial class CatalogPiese : Form
    {
        public int idMax;
        List<Produs> piese = new List<Produs>();
        ProduseCosForm Form = new ProduseCosForm();
        public CatalogPiese()
        {
            InitializeComponent();
        }

        private void CatalogPiese_Load(object sender, EventArgs e)
        {         
            using (var context = new ApplicationDbContext())
            {
                idMax = context.Produse.Max(p => p.ProdusId);
               
            }

            for (int i = 1; i <= idMax; i++)
            {
                piese.Add(new Produs(i));
            }

            if (piese.Count > 5)
            {
                piese[3].afisareProduse(listBox1, 4);
                piese[4].afisareProduse(listBox2, 5);
                piese[5].afisareProduse(listBox3, 6);
            }

            if (Client.LoggedInUser != null)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produs selectedProdus = piese[3];
            if (Form == null || Form.IsDisposed)
            {
                Form = new ProduseCosForm();
            }
            Form.AddProductToListBox(selectedProdus);
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produs selectedProdus = piese[4];
            if (Form == null || Form.IsDisposed)
            {
                Form = new ProduseCosForm();
            }
            Form.AddProductToListBox(selectedProdus);
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Produs selectedProdus = piese[5];
            if (Form == null || Form.IsDisposed)
            {
                Form = new ProduseCosForm();
            }
            Form.AddProductToListBox(selectedProdus);
            Form.Show();
        }
    }
}