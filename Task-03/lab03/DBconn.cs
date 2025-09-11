using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    class DBconn
    {
        private string connectionString = "Data Source = DESKTOP-SDI7IH1\\SQLEXPRESS;Initial Catalog=Hashir;Integrated Security=True";
        public bool Signup(string username, string password, string email, string position, string department)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Employees(username, password, email, position, department)  " +
                        "VALUES(@username, @password, @email, @position, @department)";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@position", position);
                    command.Parameters.AddWithValue("@department", department);

                    conn.Open();

                    int result = command.ExecuteNonQuery();

                    conn.Close();

                    return result > 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                return false;
            }

        }
        public bool login(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "select * from Employees where username=@username AND password=@password";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    conn.Open();

                    int result = Convert.ToInt32(command.ExecuteScalar());

                    conn.Close();

                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                return false;
            }
        }

        public DataTable getEmployees()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("getEmployees", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        sda.Fill(dt);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            return dt;
        }

        public bool update(string username, string password, string email, string position, string department)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {


                    SqlCommand command = new SqlCommand("UpdateEmployees", conn);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@position", position);
                    command.Parameters.AddWithValue("@department", department);

                    conn.Open();

                    int result = command.ExecuteNonQuery();

                    conn.Close();

                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
