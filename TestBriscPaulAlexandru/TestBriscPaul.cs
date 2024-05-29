using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proiect_Fis.Models;
using System.Collections.Generic;
using System;
using System.Windows;
using System.Windows.Forms;


namespace Proiect_Fis.Tests
{
    [TestClass]
    public class ProdusTests
    {
        [TestMethod]
        public void TestProdusConstructor()
        {
            var produs = new Produs(1, "description", 100.0f, 4.5f, "name", "category");
            Assert.AreEqual(1, produs.ProdusId);
            Assert.AreEqual("description", produs.Descriere);
            Assert.AreEqual(100.0f, produs.Pret);
            Assert.AreEqual(4.5f, produs.Scor);
            Assert.AreEqual("name", produs.Nume);
            Assert.AreEqual("category", produs.Categorie);
        }

        [TestMethod]
        public void TestAdaugarePromotie()
        {
            var produs = new Produs();
            produs.adaugarePromotie(10);
            Assert.AreEqual(10, produs.promotie);
        }

        [TestMethod]
        public void TestHasPromotion()
        {
            var produs = new Produs();
            Assert.IsFalse(produs.hasPromotion());
            produs.adaugarePromotie(10);
            Assert.IsTrue(produs.hasPromotion());
        }

        [TestMethod]
        public void TestAfisareProduse()
        {
            var produs = new Produs(1, "description", 100.0f, 4.5f, "name", "category");
            var listbox = new System.Windows.Forms.ListBox();
            produs.afisareProduse(listbox, 1);
            Assert.AreEqual(5, listbox.Items.Count);
        }

        [TestMethod]
        public void TestProdusConstructorWithNoArguments()
        {
            var produs = new Produs();
            Assert.AreEqual(0, produs.ProdusId);
            Assert.IsNull(produs.Descriere);
            Assert.AreEqual(0.0f, produs.Pret);
            Assert.AreEqual(0.0f, produs.Scor);
            Assert.IsNull(produs.Nume);
            Assert.IsNull(produs.Categorie);
        }

        [TestMethod]
        public void TestProdusPromotie()
        {
            var produs = new Produs();
            Assert.IsNull(produs.promotie);
            produs.adaugarePromotie(10);
            Assert.AreEqual(10, produs.promotie);
        }

        [TestMethod]
        public void TestProdusPretWithoutPromotion()
        {
            var produs = new Produs(1, "description", 100.0f, 4.5f, "name", "category");
            Assert.AreEqual(100.0f, produs.Pret);
        }
    }
}
