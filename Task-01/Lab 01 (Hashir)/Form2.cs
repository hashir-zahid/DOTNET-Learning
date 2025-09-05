using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_01__Hashir_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ".";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 0;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text += 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += 6;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text += 7;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text += 8;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text += 9;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            try
            {
                string expression = richTextBox1.Text;
                DataTable table = new DataTable();
                var result = table.Compute(expression, "");

                richTextBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = "Error";
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text += "-";
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text += "*";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text += "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 20);
        }
    }
}
