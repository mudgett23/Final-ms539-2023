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
        public Form1(string Name="", string Phone ="")
        {
            InitializeComponent();
            textBox1.Text = Name;
            maskedTextBox1.Text = Phone;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.Clear();
            MessageBox.Show("Not a Valid Phone Number");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2(textBox1.Text);
            //f2.Show();
           // this.Hide();
            //put in if statement for each box to have messagebox pop up saying it can't be left blank/
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // Form3 F3 = new Form3();
           // F3.Show();
            //this.Hide();
            //see if buttons can be merged depending on what radiobutton is used
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(textBox1.Text,maskedTextBox1.Text);
            f2.Show();
            this.Hide();
            //put in if statement for each box to have messagebox pop up saying it can't be left blank/
            //add a jump from employee to form 2 when next button is hit
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            this.Hide();
            //see if buttons can be merged depending on what radiobutton is used
            //add a jump from client to form 3 when next button is hit
        }
    }
}
