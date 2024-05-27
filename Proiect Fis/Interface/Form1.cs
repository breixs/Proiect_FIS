using Proiect_Fis.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Fis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnManagerSignIn_Click(object sender, EventArgs e)
        {
            ManagerOptionsForm managerForm = new ManagerOptionsForm();
            managerForm.Show();
        }

        private void btnContAngajat_Click(object sender, EventArgs e)
        {
            EmployeeOptionsForm employeeForm = new EmployeeOptionsForm();
            employeeForm.Show();
        }

        private void btnCatalogSist_Click(object sender, EventArgs e)
        {
            CatalogSistemeForm form=new CatalogSistemeForm();
            form.Show();
            VizualizareProduse();
        }

        private void btnCatalogPC_Click(object sender, EventArgs e)
        {
            // Cod pentru catalogul pieselor PC
            VizualizareProduse();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            // Cod pentru gestionarea cererilor de service
            DepunereCerereService();
        }

        private void btnClientSignIn_Click(object sender, EventArgs e)
        {
            ClientOptionsForm clientForm = new ClientOptionsForm();
            clientForm.Show();
        }

        private void VizualizareProduse()
        {
            MessageBox.Show("Produse vizualizate!");
        }

        private void DepunereCerereService()
        {
            MessageBox.Show("Cerere de service depusă!");
        }
    }
}
