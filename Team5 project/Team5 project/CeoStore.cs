﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_project
{
    public partial class CeoStore : Form
    {
        public CeoStore()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CeoAddWorker mm = new CeoAddWorker();
            mm.Show();
        }

        private void DeleteWorker_Click(object sender, EventArgs e)
        {
            this.Hide();
            CeoDeleteWorker mm = new CeoDeleteWorker();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CeoControlPage mm = new CeoControlPage();
            mm.Show();
        }
    }
}