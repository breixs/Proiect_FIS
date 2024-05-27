using System;
using System.Linq;
using System.Windows.Forms;
using Proiect_Fis.Data;
using Proiect_Fis.Models;

namespace Proiect_Fis
{
    public partial class EmployeeOptionsForm : Form
    {
        public EmployeeOptionsForm()
        {
            InitializeComponent();
        }

        private void btnCreeazaComanda_Click(object sender, EventArgs e)
        {
            CreeazaComanda();
        }

        private void btnSchimbaStatusComanda_Click(object sender, EventArgs e)
        {
            SchimbaStatusComanda();
        }

        // Metodele Angajatului
        private void CreeazaComanda()
        {
            using (var context = new ApplicationDbContext())
            {
                var comanda = new Comanda
                {
                    Data = DateTime.Now,
                    Status = "Nou",
                    ClientId = 1, // Exemplu de ClientId
                    ProdusId = 1  // Exemplu de ProdusId
                };
                context.Comenzi.Add(comanda);
                context.SaveChanges();
            }
            MessageBox.Show("Comandă creată!");
        }

        private void SchimbaStatusComanda()
        {
            using (var context = new ApplicationDbContext())
            {
                var comanda = context.Comenzi.FirstOrDefault(c => c.ComandaId == 1); // Exemplu de ComandaId
                if (comanda != null)
                {
                    comanda.Status = "In Proces";
                    context.SaveChanges();
                }
            }
            MessageBox.Show("Statusul comenzii schimbat!");
        }
    }
}
