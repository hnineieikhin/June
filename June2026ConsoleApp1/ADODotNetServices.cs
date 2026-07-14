using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2026ConsoleApp1
{
    internal class ADODotNetServices
    {
        public void Read()
        {

            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = "DESKTOP-B4L5P5O\\KHIN";//Server name(local)
            sb.InitialCatalog = "June2026";//Database name
            sb.UserID = "sa";
            sb.Password = "sasa@123";
            sb.TrustServerCertificate = true;

            Console.WriteLine($"connection string: {sb.ConnectionString}");
            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            Console.WriteLine("Connection is opening");
            connection.Open();
            Console.WriteLine("Connection is opened");

            string query = @"SELECT *
            FROM [June2026].[dbo].[Tbl_Student]";

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adaper = new SqlDataAdapter(cmd);//carry command and execute
            DataTable dt = new DataTable();
            adaper.Fill(dt);


            Console.WriteLine("Connection is closing");

            connection.Close();
            Console.WriteLine("Connection is closed");
        }

        //    List<Student> lst = new List<Student>();

        //    foreach (DataRow item in dt.Rows)
        //    {
        //        Student student = new Student
        //        {
        //            StudentId = Convert.ToInt32(item["StudentId"]),
        //            StudentName = Convert.ToString(item["StudentName"]),
        //            FatherName = Convert.ToString(item["FatherName"]),
        //            StudentNo = Convert.ToString(item["StudentNo"]),
        //            Email = Convert.ToString(item["Email"]),
        //            // DateTime dtDob = Convert.ToDateTime(item["DateofBirth"]),
        //            DateOfBirth = Convert.ToDateTime(item["DateofBirth"]),
        //            MobileNo = Convert.ToString(item["MobileNo"])

        //        };
        //        lst.Add(student);

        //    }
        //    foreach (var item in lst)
        //    { 
        //        Console.WriteLine($"Id: {item.StudentId}, Name: {item.StudentName}");
        //    }
        //}



        public void Create()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = "DESKTOP-B4L5P5O\\KHIN";//Server name(local)
            sb.InitialCatalog = "June2026";//Database name
            sb.UserID = "sa";
            sb.Password = "sasa@123";
            sb.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open();
            string query = @"INSERT INTO [dbo].[Tbl_Student]
           ([StudentName]
           ,[FatherName]
           ,[StudentNo]
           ,[Email]
           ,[DateOfBirth]
           ,[MobileNo])
            VALUES
            ('John Smith', 'Robert Smith', 'S0001', 'john.smith@gmail.com', '2002-05-15', '09123456789'),
            ('Emma Johnson', 'David Johnson', 'S0002', 'emma.johnson@gmail.com', '2001-08-22', '09234567890'),
            ('Michael Brown', 'James Brown', 'S0003', 'michael.brown@gmail.com', '2003-01-10', '09345678901'),
            ('Sophia Davis', 'William Davis', 'S0004', 'sophia.davis@gmail.com', '2002-11-30', '09456789012'),
            ('Daniel Wilson', 'Thomas Wilson', 'S0005', 'daniel.wilson@gmail.com', '2001-07-18', '09567890123');
                                        ";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }





        //public void update()
        //{

        //    SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
        //    sb.DataSource = "DESKTOP-B4L5P5O\\KHIN";//Server name(local)
        //    sb.InitialCatalog = "June2026";//Database name
        //    sb.UserID = "sa";
        //    sb.Password = "sasa@123";
        //    sb.TrustServerCertificate = true;
        //    SqlConnection connection = new SqlConnection(sb.ConnectionString);
        //    connection.Open();

        //    string query = @"UPDATE [dbo].Tbl_Student
        //    SET Email = 'john.new@gmail.com',
        //    MobileNo = '09987654321'
        //    WHERE StudentNo = 'S0001';";

        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.ExecuteNonQuery();
        //    connection.Close();

        //}
        //public void Delete()
        //{
        //    SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
        //    sb.DataSource = "DESKTOP-B4L5P5O\\KHIN";//Server name(local)
        //    sb.InitialCatalog = "June2026";//Database name
        //    sb.UserID = "sa";
        //    sb.Password = "sasa@123";
        //    sb.TrustServerCertificate = true;
        //    SqlConnection connection = new SqlConnection(sb.ConnectionString);
        //    connection.Open();
        //    string query = @"DELETE FROM [dbo].Tbl_Student
        //    WHERE StudentNo = 'S0004';";
        //    SqlCommand cmd=new SqlCommand(query,connection);    
        //    int result=cmd.ExecuteNonQuery();
        //    connection.Close();

        //}

        public class Student
        {
            public int StudentId { get; set; }

            public string StudentName { get; set; }

            public string FatherName { get; set; }

            public string StudentNo { get; set; }

            public string Email { get; set; }

            public DateTime DateOfBirth { get; set; }

            public string MobileNo { get; set; }

        }

    }
}