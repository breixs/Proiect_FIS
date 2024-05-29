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
        public CatalogPiese()
        {
            InitializeComponent();
        }

        private void CatalogPiese_Load(object sender, EventArgs e)
        {
            List<Produs> piese = new List<Produs>();
            using (var context = new ApplicationDbContext())
            {
                idMax = context.Produse.Max(p => p.ProdusId);
                MessageBox.Show(idMax.ToString());
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


        }
    }
}
