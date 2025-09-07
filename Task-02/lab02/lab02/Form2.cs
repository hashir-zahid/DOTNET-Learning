using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    public partial class Form2: Form
    {
        DBconn db = new DBconn();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool success = db.login(username, password);
            if (success)
            {
                MessageBox.Show("User Exist");
            }
            else
            {
                MessageBox.Show("User Does Not Exist");
            }
        }
    }
}
