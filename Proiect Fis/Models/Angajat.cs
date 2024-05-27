using System.ComponentModel.DataAnnotations;

namespace Proiect_Fis.Models
{
    public class Angajat
    {
        [Key]
        public int AngajatId { get; set; }
        public string Nume { get; set; }
        public string Categorie { get; set; }
    }
}
