using System;
using System.Linq;
using System.Windows.Forms;
using Proiect_Fis.Data;
using Proiect_Fis.Interface;
using Proiect_Fis.Models;

namespace Proiect_Fis
{
    public partial class ClientOptionsForm : Form
    {
        public ClientOptionsForm()
        {
            InitializeComponent();
        }

        private void btnCreareCont_Click(object sender, EventArgs e)
        {
            //CreareCont();
            ClientRegisterForm Form = new ClientRegisterForm();
            Form.Show();
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            //Autentificare();
            ClientLogInForm Form = new ClientLogInForm();
            Form.Show();
        }

        private void btnVizualizareProduse_Click(object sender, EventArgs e)
        {
            CatalogSistemeForm form = new CatalogSistemeForm();
            form.Show();
        }

        private void btnDepunereComanda_Click(object sender, EventArgs e)
        {
            DepunereComanda();
        }

        private void btnDepunereCerereService_Click(object sender, EventArgs e)
        {
            DepunereCerereService();
        }

        // Metodele Clientului
        /*private void CreareCont()
        {
            using (var context = new ApplicationDbContext())
            {
                var client = new Client { Nume = "Nume Client", ContCreat = true };
                context.Clienti.Add(client);
                context.SaveChanges();
            }
            MessageBox.Show("Cont creat!");
        }

        private void Autentificare()
        {
            using (var context = new ApplicationDbContext())
            {
                var client = context.Clienti.FirstOrDefault(c => c.Nume == "Nume Client"); // Exemplu de autentificare
                if (client != null && client.ContCreat)
                {
                    MessageBox.Show("Autentificat!");
                }
                else
                {
                    MessageBox.Show("Autentificare eșuată!");
                }
            }
        }*/

        private void VizualizareProduse()
        {
            using (var context = new ApplicationDbContext())
            {
                var produse = context.Produse.ToList();
                // Afișează produsele (poți folosi un control de tip DataGridView pentru a afișa lista de produse)
            }
            MessageBox.Show("Produse vizualizate!");
        }

        private void DepunereComanda()
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
            MessageBox.Show("Comandă depusă!");
        }

        private void DepunereCerereService()
        {
            // Implementarea cererii de service
            MessageBox.Show("Cerere de service depusă!");
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            var clientLogout = new Client();           
            clientLogout.Logout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogPiese form = new CatalogPiese();
            form.Show();
        }
    }
}
