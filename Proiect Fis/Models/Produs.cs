﻿using Proiect_Fis.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Fis.Models
{
    public class Produs
    {

        [Key]
        public int ProdusId { get; set; }
        public string Descriere { get; set; }
        public float Pret { get; set; }
        public float Scor { get; set; }
        public string Nume { get; set; }
        public string Categorie { get; set; }
        public int? promotie { get; set; }

        public Produs(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                this.ProdusId=context.Produse.Where(p => p.ProdusId==id).Select(p => p.ProdusId).FirstOrDefault();
                this.Descriere = context.Produse.Where(p => p.ProdusId == id).Select(p => p.Descriere).FirstOrDefault();
                this.Pret = context.Produse.Where(p => p.ProdusId == id).Select(p => p.Pret).FirstOrDefault();
                this.Scor = context.Produse.Where(p => p.ProdusId == id).Select(p => p.Scor).FirstOrDefault();
                this.Nume = context.Produse.Where(p => p.ProdusId == id).Select(p => p.Nume).FirstOrDefault();
                this.Categorie = context.Produse.Where(p => p.ProdusId == id).Select(p => p.Categorie).FirstOrDefault();
            }
        }

        public Produs(int produsId, string descriere, float pret, float scor, string nume, string categorie)
        {
            ProdusId = produsId;
            Descriere = descriere;
            Pret = pret;
            Scor = scor;
            Nume = nume;
            Categorie = categorie;
        }

        public Produs() { }
        public void afisareProduse(ListBox listbox, int id)
        {
            string nume, descriere, categorie;
            float pret, scor;

            if (this.hasPromotion())
            {
                this.Pret += 0.10f * this.Pret;
            }

            nume = this.Nume;
            descriere = this.Descriere;
            pret = this.Pret;
            scor = this.Scor;
            categorie = this.Categorie;
            List<string> itemDetails = new List<string>();

            itemDetails.Add($"Nume: {nume}");
            itemDetails.Add($"Categorie: {categorie}");
            itemDetails.Add($"Pret: {pret}");
            itemDetails.Add($"Scor: {descriere}");
            itemDetails.Add($"Descriere: {scor}");

            foreach (string detail in itemDetails)
            {
                listbox.Items.Add(detail);
            }
        }
        /*
        public static void AdaugaProdus(int produsId, string descriere, float pret, float scor, string nume, string categorie)
        {
            using (var context = new ApplicationDbContext())
            {
                var produs = new Produs(produsId, descriere, pret, scor, nume, categorie)
                {
                    Descriere = descriere,
                    Pret = pret,
                    Scor = scor,
                    Nume = nume,
                    Categorie = categorie
                };
                context.Produse.Add(produs);
                context.SaveChanges();
            }
        }
        */

        public void adaugareNoua(Produs produs)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Produse.Add(produs);
                context.SaveChanges();
            }
        }

        public void adaugarePromotie(int promotieId)
        {
            this.promotie = promotieId;
        }

        public bool hasPromotion()
        {
            if (this.promotie != null)
                return true;

            return false;
        }

    }
}