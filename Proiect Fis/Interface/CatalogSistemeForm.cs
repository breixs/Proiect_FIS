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
    public partial class CatalogSistemeForm : Form
    {
        public CatalogSistemeForm()
        {
            InitializeComponent();
        }

        private void CatalogSistemeForm_Load(object sender, EventArgs e)
        {        
            List<Produs> produse = new List<Produs>
            {
                new Produs(1),
                new Produs(2),
                new Produs(3),
                new Produs(4),
                new Produs(5),
            };




            Produs.afisareProduse(produse[0],listBox1, 1);
            Produs.afisareProduse(produse[1], listBox2, 2);
            Produs.afisareProduse(produse[2], listBox3, 3);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = produse;
         
            if(Client.LoggedInUser != null)
            {
                HideNseek.Visible = true;
                HideNseek2.Visible = true;
                HideNseek3.Visible = true;
            }
            else
            {
                HideNseek.Visible = false;
                HideNseek2.Visible = false;
                HideNseek3.Visible = false;
            }
        }

        private void HideNseek_Click(object sender, EventArgs e)
        {
            ProduseCos Form = new ProduseCos();
            Form.Show();
        }

        private void HideNseek2_Click(object sender, EventArgs e)
        {
            ProduseCos Form = new ProduseCos();
            Form.Show();
        }

        private void HideNseek3_Click(object sender, EventArgs e)
        {
            ProduseCos Form = new ProduseCos();
            Form.Show();
        }
    }
}
