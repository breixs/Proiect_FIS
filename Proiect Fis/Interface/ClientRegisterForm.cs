﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_Fis.Models;

namespace Proiect_Fis.Interface
{
    public partial class ClientRegisterForm : Form
    {
        public ClientRegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client.CreareCont(RegisterNume.Text,RegisterParola.Text);
        }
    }
}