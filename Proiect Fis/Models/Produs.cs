using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Fis.Models
{
    public class Produs
    {
        [Key]
        public int ProdusId { get; set; }
        public string Descriere { get; set; }
        public float Pret { get; set; }
        public float Scor { get; set; }
    }
}