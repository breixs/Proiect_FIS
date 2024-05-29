using Proiect_Fis.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Proiect_Fis.Models
{
    public class Promotie
    {
        [Key]
        public int PromotieId { get; set; }
        public float Discount { get; set; }
        public List<Produs> ProduseIncluse { get; set; }

        public static void AdaugaPromotie(float discount)
        {
            using (var context = new ApplicationDbContext())
            {
                var promotie = new Promotie { Discount = discount };
                context.Promotii.Add(promotie);
                context.SaveChanges();
            }
        }

        public static List<Promotie> VizualizeazaPromotii()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Promotii.Include(p => p.ProduseIncluse).ToList();
            }
        }

        public static void StergePromotie(int promotieId)
        {
            using (var context = new ApplicationDbContext())
            {
                var promotie = context.Promotii.Find(promotieId);
                if (promotie != null)
                {
                    context.Promotii.Remove(promotie);
                    context.SaveChanges();
                }
            }
        }
    }
}
