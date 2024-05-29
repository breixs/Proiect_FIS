using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Fis.Models
{
    [NotMapped]
    public class CerereClient : Client
    {
        private string descriere;
        private string data;

        public CerereClient(string Nume, string Parola, string descriere, string data) : base(Nume, Parola)
        {
            this.descriere = descriere;
            this.data = data;
        }

        public CerereClient() { }

        public void TrimiteCerere()
        {
            MessageBox.Show("Cerere Trimisa !"+"\nNume: "+ this.Nume + "\nParola: "+ this.Parola+"\n"+"Descriere: "+ this.descriere+"\nData: "+ this.data);
        }
    }
}
