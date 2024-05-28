using Proiect_Fis.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Fis.Models
{
    public class Produs
    {

        [Key]
        public int ProdusId { get; set; }
        public string Descriere { get; set; }
        public float Pret { get; set; }
        public float Scor { get; set; }
        public string Nume { get; set; }
        public string Categorie { get; set; }

        public Produs(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                this.ProdusId=context.Produse.Where(p => p.ProdusId==id).Select(p => p.ProdusId).FirstOrDefault();
                this.Descriere = context.Produse.Where(p => p.ProdusId == id).Select(p => p.Descriere).FirstOrDefault();
                this.Pret = context.Produse.Where(p => p.ProdusId == id).Select(p => p.Pret).FirstOrDefault();
                this.Scor = context.Produse.Where(p => p.ProdusId == id).Select(p => p.Scor).FirstOrDefault();
                this.Nume = context.Produse.Where(p => p.ProdusId == id).Select(p => p.Nume).FirstOrDefault();
                this.Categorie = context.Produse.Where(p => p.ProdusId == id).Select(p => p.Categorie).FirstOrDefault();
            }
        }

        public Produs(int produsId, string descriere, float pret, float scor, string nume, string categorie)
        {
            ProdusId = produsId;
            Descriere = descriere;
            Pret = pret;
            Scor = scor;
            Nume = nume;
            Categorie = categorie;
        }

        public static void afisareProduse(Produs produs, ListBox listbox, int id)
        {
            string nume, descriere, categorie;
            float pret, scor;

            nume = produs.Nume;
            descriere = produs.Descriere;
            pret = produs.Pret;
            scor = produs.Scor;
            categorie = produs.Categorie;
            List<string> itemDetails = new List<string>();

            itemDetails.Add($"Nume: {nume}");
            itemDetails.Add($"Categorie: {categorie}");
            itemDetails.Add($"Pret: {pret}");
            itemDetails.Add($"Scor: {descriere}");
            itemDetails.Add($"Descriere: {scor}");

            foreach (string detail in itemDetails)
            {
                listbox.Items.Add(detail);
            }
        }

        public static void AdaugaProdus(int produsId, string descriere, float pret, float scor, string nume, string categorie)
        {
            using (var context = new ApplicationDbContext())
            {
                var produs = new Produs(produsId, descriere, pret, scor, nume, categorie)
                {
                    Descriere = descriere,
                    Pret = pret,
                    Scor = scor,
                    Nume = nume
                };
                context.Produse.Add(produs);
                context.SaveChanges();
            }
        }
    }
}