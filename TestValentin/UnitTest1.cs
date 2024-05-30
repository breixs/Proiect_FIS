using NUnit.Framework;
using Proiect_Fis;
using Proiect_Fis.Models;
using Proiect_Fis.Data;
using System.Linq;

namespace TestValentin
{
    [TestFixture]
    public class ManagerOptionsFormTests
    {
        private ManagerOptionsForm _managerOptionsForm;
        private ApplicationDbContext _context;

        [SetUp]
        public void Setup()
        {
            _managerOptionsForm = new ManagerOptionsForm();
            _context = new ApplicationDbContext();
        }

        [Test]
        public void BtnAdaugaAngajat_Click_ShouldAddEmployee()
        {
            var initialCount = _context.Angajati.Count();
            _managerOptionsForm.AngajatNume = "Test Angajat";
            _managerOptionsForm.AngajatCategorie = "Test Categorie";

            _managerOptionsForm.BtnAdaugaAngajat_Click(null, null);

            NUnit.Framework.Assert.AreEqual(initialCount + 1, _context.Angajati.Count());
        }

        [Test]
        public void BtnVizualizareAngajati_Click_ShouldDisplayEmployees()
        {
            _managerOptionsForm.BtnVizualizareAngajati_Click(null, null);
            NUnit.Framework.Assert.IsTrue(_managerOptionsForm.EmployeeFormVisible);
        }

        [Test]
        public void BtnPropunePromotie_Click_ShouldAddPromotion()
        {
            var initialCount = _context.Promotii.Count();

            _managerOptionsForm.BtnPropunePromotie_Click(null, null);

            NUnit.Framework.Assert.AreEqual(initialCount + 1, _context.Promotii.Count());
        }

        [Test]
        public void BtnStergePromotie_Click_ShouldDeletePromotion()
        {
            _managerOptionsForm.BtnPropunePromotie_Click(null, null);
            var initialCount = _context.Promotii.Count();

            _managerOptionsForm.BtnStergePromotie_Click(null, null);

            NUnit.Framework.Assert.AreEqual(initialCount - 1, _context.Promotii.Count());
        }

        [Test]
        public void BtnAdaugaProdus_Click_ShouldAddProduct()
        {
            var initialCount = _context.Produse.Count();
            _managerOptionsForm.ProdusNume = "Test Produs";
            _managerOptionsForm.ProdusDescriere = "Test Descriere";
            _managerOptionsForm.ProdusPret = 100.0f;
            _managerOptionsForm.ProdusScor = 4.5f;
            _managerOptionsForm.ProdusCategorie = "Test Categorie";

            _managerOptionsForm.BtnAdaugaProdus_Click(null, null);

            NUnit.Framework.Assert.AreEqual(initialCount + 1, _context.Produse.Count());
        }
    }
}
