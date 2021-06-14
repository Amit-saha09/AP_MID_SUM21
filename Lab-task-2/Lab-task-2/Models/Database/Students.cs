using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab_task_2.Models.Database
{
    public class Students
    {
        SqlConnection conn;

        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Student p)
        {
            //string query = String.Format("Insert into Products values ('{0}','{1}',{2},{3})", p.Name, p.Description, p.Price, p.Qty);
            string query = "Insert into Students values(@name,@dob,@credit,@cgpa,@deptid)";
            SqlCommand cmd = new SqlCommand(query, conn);
            float cgpaa = Convert.ToSingle(p.CGPA);
            cmd.Parameters.AddWithValue("@name", p.Name);
            cmd.Parameters.AddWithValue("@dob", p.Dob.ToString());
            cmd.Parameters.AddWithValue("@credit", p.Credit);
            cmd.Parameters.AddWithValue("@cgpa", cgpaa);
            cmd.Parameters.AddWithValue("@deptid", p.Deptid);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            string query = "select * from Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student p = new Student();

                p.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                p.Name = reader.GetString(reader.GetOrdinal("Name"));
                p.Dob = reader.GetString(reader.GetOrdinal("Dob"));
                p.Credit = reader.GetInt32(reader.GetOrdinal("Credit"));
                p.CGPA = reader.GetDouble(reader.GetOrdinal("Cgpa"));
                p.Deptid = reader.GetInt32(reader.GetOrdinal("Deptid"));


                students.Add(p);
            }
            conn.Close();
            return students;
        }
        public Student Get(int id)
        {
            Student p = null;
            string query = $"select * from Students Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                p = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Dob = reader.GetString(reader.GetOrdinal("Dob")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("Cgpa")),
                    Deptid = reader.GetInt32(reader.GetOrdinal("Deptid")),
                };
            }
            conn.Close();
            return p;
        }
        public void Update(Student p)
        {
            float cgpaa = Convert.ToSingle(p.CGPA);
            string query = $"Update Students Set Name='{p.Name}', Dob='{p.Dob}' ,Credit={p.Credit}, Cgpa={cgpaa}, Deptid={p.Deptid} Where Id = {p.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(int p)
        {
            string query = $"Delete from Students Where Id={p}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}