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

            string query = @"SELECT TOP (1000) [StudentId]
      ,[StudentName]
      ,[FatherName]
      ,[StudentNo]
      ,[Email]
      ,[DateOfBirth]
      ,[MobileNo]
  FROM [June2026].[dbo].[Tbl_Student]
";

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adaper = new SqlDataAdapter(cmd);//carry command and execute
            DataTable dt = new DataTable();
            adaper.Fill(dt);


            Console.WriteLine("Connection is closing");

            connection.Close();
            Console.WriteLine("Connection is closed");

            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["StudentId"]);
                Console.WriteLine(item["StudentName"]);
                DateTime dtDob = Convert.ToDateTime(item["DateofBirth"]);
                Console.WriteLine(dtDob.ToString("dd-MMM-yy"));

            }


        }
        public  void Create()
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
('John Smith', 'Robert Smith', 'STU001', 'john.smith@gmail.com', '2002-05-15', '09123456789'),
('Emma Johnson', 'David Johnson', 'STU002', 'emma.johnson@gmail.com', '2001-08-22', '09234567890'),
('Michael Brown', 'James Brown', 'STU003', 'michael.brown@gmail.com', '2003-01-10', '09345678901'),
('Sophia Davis', 'William Davis', 'STU004', 'sophia.davis@gmail.com', '2002-11-30', '09456789012'),
('Daniel Wilson', 'Thomas Wilson', 'STU005', 'daniel.wilson@gmail.com', '2001-07-18', '09567890123');
                                        ";
            SqlCommand cmd = new SqlCommand(query,connection );
            cmd.ExecuteNonQuery();
            connection.Close() ;
        }





        public void update()
        {

            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = "DESKTOP-B4L5P5O\\KHIN";//Server name(local)
            sb.InitialCatalog = "June2026";//Database name
            sb.UserID = "sa";
            sb.Password = "sasa@123";
            sb.TrustServerCertificate = true;
            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open();

            string query = @"UPDATE [dbo].Tbl_Student
        SET Email = 'john.new@gmail.com',
            MobileNo = '09987654321'
WHERE StudentNo = 'S0001';";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public void Delete()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = "DESKTOP-B4L5P5O\\KHIN";//Server name(local)
            sb.InitialCatalog = "June2026";//Database name
            sb.UserID = "sa";
            sb.Password = "sasa@123";
            sb.TrustServerCertificate = true;
            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open();
            string query = @"DELETE FROM [dbo].Tbl_Student
            WHERE StudentNo = 'S0005';";
            SqlCommand cmd=new SqlCommand(query,connection);    
            cmd.ExecuteNonQuery();
            connection.Close();

        }
                     
}}
