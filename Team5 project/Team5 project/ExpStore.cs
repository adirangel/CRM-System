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
    public partial class ExpStore : Form
    {
        public ExpStore()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ExpStoreproduct1 ss = new ExpStoreproduct1();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Exp ss = new Exp();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           FindProduct ss = new FindProduct();
            ss.Show();
        }
    }
}
