using Proiect_Fis.Data;
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
    public partial class CatalogSistemeForm : Form
    {

        public CatalogSistemeForm()
        {
            InitializeComponent();
        }

        private void ChangeLabel(Label label, int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var nume = context.Produse
                             .Where(a => a.ProdusId == id)
                             .Select(a => a.Nume)
                             .FirstOrDefault();
                label.Text = nume;

            }
        }

        private void CatalogSistemeForm_Load(object sender, EventArgs e)
        {
            ChangeLabel(Produs1NameLabel, 1);
        }
    }
}
