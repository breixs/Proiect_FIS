using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proiect_Fis.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Nume { get; set; }
        public bool ContCreat { get; set; }
    }
}
