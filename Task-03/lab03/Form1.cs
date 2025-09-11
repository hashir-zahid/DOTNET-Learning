using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public partial class Form1: Form
    {
        DBconn db = new DBconn();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string email = textBox3.Text;
            string position = textBox4.Text;
            string department = textBox5.Text;

            bool success = db.Signup(username, password, email, position, department);

            if (success)
            {
                MessageBox.Show("Successfully Added-------Hurray");
            }
            else
            {
                MessageBox.Show("Moye Moye");
            }
        }
    }
}
