using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab_task_2.Models.Database
{
    public class Database
    {
        public Students Students { get; set; }
        public Departments Departments { get; set; }
        public Admins Admins { get; set; }
        
        public Database()
        {
            string connString = @"Server=.;Database=Lab2;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            Students = new Students(conn);
            Departments = new Departments(conn);
            Admins = new Admins(conn);
           

        }
    }
}