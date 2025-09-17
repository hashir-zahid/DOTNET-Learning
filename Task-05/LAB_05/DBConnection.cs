using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LAB_05
{
    public class DBConnection
    {
        private  string connectionstring =
            "Data Source=DESKTOP-SDI7IH1\\SQLEXPRESS; " +
            "Initial Catalog=APweb ; " +
            "Integrated Security=True";

        public bool SignUP(string username, string password, int access, int status)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string query = "INSERT INTO users(username,password,access,status) VALUES(@username,@password,@access,@status)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@access", access);
                        cmd.Parameters.AddWithValue("@status", status);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error !!!!!" + e.Message);
                return false;
            }
        }

        public bool Login(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string query = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        conn.Open();
                        int result = Convert.ToInt32(cmd.ExecuteScalar());
                        return result > 0;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error !!!!!" + e.Message);
                return false;
            }
        }

        public DataTable LoadUser()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string query = "SELECT  id,username,password,access,status FROM users";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error !!!!!" + e.Message);
                return null;
            }
        }
    }
}