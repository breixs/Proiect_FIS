using Proiect_Fis.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Proiect_Fis.Models
{
    public class Angajat
    {
        [Key]
        public int AngajatId { get; set; }
        public string Nume { get; set; }
        public string Categorie { get; set; }

        public static void AdaugaAngajat(string nume, string categorie)
        {
            using (var context = new ApplicationDbContext())
            {
                var angajat = new Angajat
                {
                    Nume = nume,
                    Categorie = categorie
                };

                context.Angajati.Add(angajat);
                context.SaveChanges();
            }
        }

        public static List<Angajat> VizualizeazaAngajati()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Angajati.ToList();
            }
        }

        public static void StergeAngajat(int angajatId)
        {
            using (var context = new ApplicationDbContext())
            {
                var angajat = context.Angajati.Find(angajatId);
                if (angajat != null)
                {
                    context.Angajati.Remove(angajat);
                    context.SaveChanges();
                }
            }
        }
    }
}