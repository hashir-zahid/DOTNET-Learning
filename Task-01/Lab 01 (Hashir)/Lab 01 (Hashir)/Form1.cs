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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            MessageBox.Show("You Entered " + input);
        }
        
        private void updatelabel()
        {
            FontStyle style = FontStyle.Regular;

            if (checkBox1.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (checkBox2.Checked)
            {
                style |= FontStyle.Underline;
            }
            if (checkBox3.Checked)
            {
                style |= FontStyle.Italic;
            }

            label1.Font = new Font(label1.Font, style);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updatelabel();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            updatelabel();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            updatelabel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
