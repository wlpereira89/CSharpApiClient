﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void BtnPassagens_Click(object sender, EventArgs e)
        {
            Passagens _f = new Passagens();
            _f.Show();
            this.Hide();
        }
    }
}