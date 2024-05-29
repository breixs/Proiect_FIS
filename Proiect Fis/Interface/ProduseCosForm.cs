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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proiect_Fis.Interface
{
    public partial class ProduseCosForm : Form
    {
        public ProduseCosForm()
        {
            InitializeComponent();
        }
        
        public void AddProductToListBox(Produs produs)
        {
            var existingItem = listBox1.Items.Cast<string>().FirstOrDefault(i => i.StartsWith(produs.Nume));

            if (existingItem != null)
            {
                var parts = existingItem.Split(':');
                var quantity = int.Parse(parts[1]) + 1;
                listBox1.Items.Remove(existingItem);
                listBox1.Items.Add(produs.Nume + " - Quantity: " + quantity);
            }
            else
            {
                listBox1.Items.Add(produs.Nume + " - Quantity: 1");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem as string;
            if (selectedItem != null)
            {
                var parts = selectedItem.Split(':');
                var quantity = int.Parse(parts[1].Trim());

                if (quantity > 1)
                {
                    quantity--;
                    listBox1.Items.Remove(selectedItem);
                    listBox1.Items.Add(parts[0] + ": " + quantity);
                }
                else
                {              
                    listBox1.Items.Remove(selectedItem);
                }
            }
        }
    }
}
