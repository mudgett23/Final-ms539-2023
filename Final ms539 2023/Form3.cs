﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_ms539_2023
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //put in transferr from phone number on form 1
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
