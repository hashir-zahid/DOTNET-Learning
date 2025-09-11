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
    public partial class Form3: Form
    {
        DBconn db = new DBconn();
        DataTable EmpTable;

        public Form3()
        {
            InitializeComponent();
        }

        public void populate()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("All");
            comboBox1.Items.Add("EmployeeID");
            comboBox1.Items.Add("Username");
            comboBox1.Items.Add("Email");
            comboBox1.Items.Add("Position");
            comboBox1.Items.Add("Department");

            comboBox1.SelectedIndex = 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.getEmployees();
            populate();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            EmpTable = db.getEmployees();
            if (EmpTable == null)
            {
                return;
            }

            string sc = comboBox1.SelectedItem.ToString();
            if (sc == "All")
            {
                dataGridView1.DataSource = EmpTable;
                return;
            }

            DataTable ftable = new DataTable();
            ftable.Columns.Add(sc);

            foreach (DataRow row in EmpTable.Rows)
            {
                ftable.Rows.Add(row[sc]);
            }

            dataGridView1.DataSource = ftable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }
    }
}
