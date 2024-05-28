using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Proiect_Fis.Models;

namespace Proiect_Fis.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer<ApplicationDbContext>(null);
        }
        
        public DbSet<Angajat> Angajati { get; set; }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }
        public DbSet<Client> Clienti { get; set; }
        public DbSet<Promotie> Promotii { get; set; }
    }
}
