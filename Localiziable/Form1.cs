﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Localiziable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Meldungen.ErfolgSpeichern;
            //textBoxAnr.Text = "falsche  Meldungen";
            //textBoxDatum.Text = DateTime.Now.ToString();
        }
    }
}
