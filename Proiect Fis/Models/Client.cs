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
        public bool? LoggedIn { get; set; }

        public static Client LoggedInUser { get; private set; }
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

        public static void CreareCont(string nume, string parola)
        {
            using (var context = new ApplicationDbContext())
            {
                var cont = new Client(nume, parola)
                {
                    Nume = nume,
                    Parola = parola
                };
                context.Clienti.Add(cont);
                context.SaveChanges();
            }
        }
        
        public static void Login(string nume, string parola)
        {
            using (var context = new ApplicationDbContext())
            {
                //var user = context.Clienti.FirstOrDefault(c => c.Nume == nume);
                //var password = context.Clienti.FirstOrDefault(c => c.Parola == parola);
                var client = context.Clienti.FirstOrDefault(c => c.Nume == nume && c.Parola == parola);

                if (client != null)
                {
                    MessageBox.Show("Autentificat!");
                    LoggedInUser = client;              
                }   
                else
                {
                    MessageBox.Show("Eroare in pula mea!");
                    LoggedInUser = null;
                }
            } 
        }

       

    }
}
