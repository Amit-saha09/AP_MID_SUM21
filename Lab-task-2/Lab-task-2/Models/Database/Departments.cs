using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab_task_2.Models.Database
{
    public class Departments
    {
        SqlConnection conn;

        public Departments(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Department p)
        {
            //string query = String.Format("Insert into Products values ('{0}','{1}',{2},{3})", p.Name, p.Description, p.Price, p.Qty);
            string query = "Insert into Departments values(@name)";
            SqlCommand cmd = new SqlCommand(query, conn);
           
            cmd.Parameters.AddWithValue("@name", p.Name);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Department> GetAll()
        {
            List<Department> departments = new List<Department>();
            string query = "select * from Departments";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Department p = new Department();

                p.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                p.Name = reader.GetString(reader.GetOrdinal("Name"));
               


                departments.Add(p);
            }
            conn.Close();
            return departments;
        }
        public Department Get(int id)
        {
            Department p = null;
            string query = $"select * from Departments Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                p = new Department()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                   
                };
            }
            conn.Close();
            return p;
        }
        public void Update(Department p)
        {
            
            string query = $"Update Departments Set Name='{p.Name}' Where Id = {p.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(int p)
        {
            string query = $"Delete from Departments Where Id={p}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}