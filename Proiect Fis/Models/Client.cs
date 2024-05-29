using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Proiect_Fis.Data;
using Proiect_Fis.Interface;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Proiect_Fis.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Nume { get; set; }
        public string Parola { get; set; }

        public static Client LoggedInUser {get; private set; }
        public Client(int id)
        {
            using (var context = new ApplicationDbContext())
            {       
                this.Nume = context.Clienti.Where(p => p.ClientId == id).Select(p => p.Nume).FirstOrDefault();
                this.Parola = context.Clienti.Where(p => p.ClientId == id).Select(p => p.Parola).FirstOrDefault();             
            }
        }

        public Client(string Nume, string Parola)
        {
            this.Nume = Nume;
            this.Parola = Parola;
        }

        public Client() { }
    
        public void CreareCont(Client client)
        {
            using (var context = new ApplicationDbContext())
            {                           
                context.Clienti.Add(client);
                context.SaveChanges();
                MessageBox.Show("Cont creat cu succes");
            }
        }
    
        public void Login()
        {
            using (var context = new ApplicationDbContext())
            {

                var client = context.Clienti.FirstOrDefault(c => c.Nume == this.Nume && c.Parola == this.Parola);

                if (client != null)
                {
                    MessageBox.Show("Autentificat!");
                    LoggedInUser = client;
                }
                else
                {
                    MessageBox.Show("Utilizatorul nu a fost gasit!");
                    LoggedInUser = null;
                }
            }
        }

        public void Logout()
        {
            if (LoggedInUser != null)
            {
                LoggedInUser = null;
                MessageBox.Show("Delogat!");
            }
            else
            {
                MessageBox.Show("Niciun utilizator logat!");
            }
        }

        public bool IsUserLoggedIn()
        {
            return LoggedInUser != null;
        }

        /*public void Cumpara(int produsId, bool preAsamblat)
        {
            using (var context = new ApplicationDbContext())
            {
                var articol = context.Produse.FirstOrDefault(a => a.ProdusId == produsId);
                if (articol != null)
                {
                    float pretFinal = articol.Pret;
                    if (preAsamblat)
                    {
                        pretFinal += 100;
                    }
                }
                else
                {
                    MessageBox.Show("Articolul nu a fost găsit!");
                }
            }
        }*/
    }
}
