using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_Fis.Data;
using Proiect_Fis.Models;

namespace Proiect_Fis.Interface
{
    public partial class ClientRegisterForm : Form
    {
        public ClientRegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clientCreareCont = new Client(RegisterNume.Text, RegisterParola.Text);
            using (var context = new ApplicationDbContext())
            {
                var client = context.Clienti.FirstOrDefault(c => c.Nume == RegisterNume.Text && c.Parola == RegisterParola.Text);

                if (client == null)
                {
                    clientCreareCont.CreareCont(clientCreareCont);
                }
                else
                {
                    MessageBox.Show("Exista deja acest cont!");
                }
            }               
            
        }
    }
}
