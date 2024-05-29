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

        public Promotie(int promotieId, float discount)
        {
            PromotieId = promotieId;
            Discount = discount;
        }

        public void AdaugaPromotie(Promotie promotie)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Promotii.Add(promotie);
                context.SaveChanges();
            }
        }

        public static List<Promotie> VizualizeazaPromotii()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Promotii.ToList();
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

        public void LinkPromotie(Produs produs)
        {
            produs.adaugarePromotie(PromotieId);
        }

    }
}
