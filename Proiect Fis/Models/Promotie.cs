using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proiect_Fis.Models
{
    public class Promotie
    {
        [Key]
        public int PromotieId { get; set; }
        public float Discount { get; set; }
        public List<Produs> ProduseIncluse { get; set; }
    }
}