using Proiect_Fis.Data;
using Proiect_Fis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Fis.Interface
{
    public partial class CerereForm : Form
    {
        public CerereForm()
        {
            InitializeComponent();
        }

        private void trimiteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numeTB.Text) || string.IsNullOrWhiteSpace(parolaTB.Text) || string.IsNullOrWhiteSpace(descriereTB.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                CerereClient cerere = new CerereClient(numeTB.Text, parolaTB.Text, descriereTB.Text, dateTimePicker1.Text);
                using (var context = new ApplicationDbContext())
                {
                    var client = context.Clienti.FirstOrDefault(c => c.Nume == numeTB.Text && c.Parola == parolaTB.Text);

                    if (client == null)
                    {
                        MessageBox.Show("Acest cont nu exista!");
                    }
                    else
                    {
                        cerere.TrimiteCerere();
                    }
                }
            }   
        }
    }
}
