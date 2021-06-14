using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab_task_2.Models.Database
{
    public class Admins
    {
        SqlConnection conn;

        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        public string Get(string username, string password )
        {
            Admin p = null;
            string q = null;
           
            string query = $"select * from Admin Where Username='{username}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              
              q = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return q;
        }
    }
}