﻿using Proiect_Fis.Models;
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
        float totalFinalCost = 0;
        public void AddProductToListBox(Produs produs)
        {
            var existingItem = listBox1.Items.Cast<string>().FirstOrDefault(i => i.StartsWith(produs.ProdusId.ToString()));

            if (existingItem != null)
            {             
                var parts = existingItem.Split('-');
                var quantity = int.Parse(parts[2].Split(':')[1].Trim()) + 1;
                var totalCost = quantity * produs.Pret;

                listBox1.Items.Remove(existingItem);
                listBox1.Items.Add(produs.ProdusId + " - " + produs.Nume + " - Quantity: " + quantity + " - Price: " + produs.Pret + " - Total Cost of that Piece: " + totalCost);
                if (produs.Categorie == "Componenta")
                {
                    totalFinalCost += produs.Pret;
                }
                else
                {
                    totalFinalCost += produs.Pret + 100;
                }
                
                label2.Text = "Total Cost: " + totalFinalCost;
            }
            else
            {
                listBox1.Items.Add(produs.ProdusId + " - " + produs.Nume + " - Quantity: 1 - Price: " + produs.Pret + " - Total Cost: " + produs.Pret);
                
                if (produs.Categorie == "Componenta")
                {
                    totalFinalCost += produs.Pret;
                }
                else
                {
                    totalFinalCost += produs.Pret + 100;
                }
                label2.Text = "Total Cost: " + totalFinalCost;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comanda a fost plasata!");
        }



        public void RemoveProductFromListBox(Produs produs)
        {
            var existingItem = listBox1.Items.Cast<string>().FirstOrDefault(i => i.StartsWith(produs.ProdusId.ToString()));

            if (existingItem != null)
            {
                var parts = existingItem.Split('-');
                var quantity = int.Parse(parts[2].Split(':')[1].Trim()) - 1;
                var totalCost = quantity * produs.Pret;

                listBox1.Items.Remove(existingItem);

                if (quantity > 0)
                {
                    listBox1.Items.Add(produs.ProdusId + " - " + produs.Nume + " - Quantity: " + quantity + " - Price: " + produs.Pret + " - Total Cost of that Piece: " + totalCost);
                }

                if (produs.Categorie == "Componenta")
                {
                    totalFinalCost -= produs.Pret;
                }

                else
                {
                    totalFinalCost -= produs.Pret + 100;
                }

                if (quantity != 0)
                    label2.Text = "Total Cost: " + totalFinalCost;
                else
                    label2.Text = "Total Cost: 0";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {          
            if (listBox1.SelectedItem != null)
            {
                var parts = listBox1.SelectedItem.ToString().Split('-');
                var produsId = int.Parse(parts[0].Trim());
                var produsNume = parts[1].Trim();
                var produsPret = float.Parse(parts[3].Split(':')[1].Trim());

                Produs produs = new Produs()
                {
                    ProdusId = produsId,
                    Nume = produsNume,
                    Pret = produsPret
                };
                RemoveProductFromListBox(produs);
            }
        }
    }
}
