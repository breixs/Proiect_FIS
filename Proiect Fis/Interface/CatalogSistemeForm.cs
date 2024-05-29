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
        public int idMax;
        List<Produs> produse = new List<Produs>();
        ProduseCosForm Form = new ProduseCosForm();
        public CatalogSistemeForm()
        {
            InitializeComponent();
        }

        private void CatalogSistemeForm_Load(object sender, EventArgs e)
        {
            
            using (var context = new ApplicationDbContext())
            {
                idMax=context.Produse.Max(p => p.ProdusId);
                
            }

            
           for(int i=1;i<=idMax;i++)
           {
                produse.Add(new Produs(i));
           }

           if(produse.Count > 2)
            {
                produse[0].afisareProduse(listBox1, 1);
                produse[1].afisareProduse(listBox2, 2);
                produse[2].afisareProduse(listBox3, 3);
            }
                       
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
            Produs selectedProdus = produse[0];
            if (Form == null || Form.IsDisposed)
            {
                Form = new ProduseCosForm();
            }
            Form.AddProductToListBox(selectedProdus);
            Form.Show();
        }

        private void HideNseek2_Click(object sender, EventArgs e)
        {
            
            Produs selectedProdus = produse[1];
            if (Form == null || Form.IsDisposed)
            {
                Form = new ProduseCosForm();
            }
            Form.AddProductToListBox(selectedProdus);
            Form.Show();
        }

        private void HideNseek3_Click(object sender, EventArgs e)
        {
            Produs selectedProdus = produse[2];
            if (Form == null || Form.IsDisposed)
            {
                Form = new ProduseCosForm();
            }
            Form.AddProductToListBox(selectedProdus);     
            Form.Show();
        }
    }
}
