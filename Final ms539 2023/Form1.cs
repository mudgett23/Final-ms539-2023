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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1 = new TextBox();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.Clear();
            MessageBox.Show("Not a Valid Phone Number");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //put in if statment for each box to have messagebox pop up saying it can't be left blank//
        }
    }
}
