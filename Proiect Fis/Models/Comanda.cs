using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_Fis.Models
{
    public class Comanda
    {
        [Key]
        public int ComandaId { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [ForeignKey("Produs")]
        public int ProdusId { get; set; }
        public Produs Produs { get; set; }
    }
}