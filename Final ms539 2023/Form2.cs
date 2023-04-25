using System;
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
    public partial class Form2 : Form
    {
        public Form2(string fromF1)
        {
            InitializeComponent();
            textBox1.Text = fromF1;
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
                     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.Clear();
            MessageBox.Show("Not a Valid Phone Number");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Please Enter Valid Date ");
            MessageBox.Show("Date Format is MM/DD/YYYY");
        }
    }
}
