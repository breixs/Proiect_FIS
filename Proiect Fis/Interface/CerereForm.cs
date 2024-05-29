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
            CerereClient cerere = new CerereClient(numeTB.Text, parolaTB.Text, descriereTB.Text, dateTimePicker1.Text);
            cerere.TrimiteCerere();
        }
    }
}
