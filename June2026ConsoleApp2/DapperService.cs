using June2026ConsoleApp2;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2026ConsoleApp2
{
    internal class DapperService
    {
        private readonly SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder
        {

            DataSource = "DESKTOP-B4L5P5O\\KHIN",
            InitialCatalog = "June2026",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true

        };
        public void Read()
        {

            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                List<Student> lst = db.Query<Student>("SELECT * FROM [dbo].[Tbl_Student];").ToList();
                foreach (var item in lst)
                {
                    Console.WriteLine($"Id:{item.StudentId}, Name: {item.StudentName}");
                }
                db.Close();
            }
        }

        public void Create()
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                db.Execute(@"INSERT INTO [dbo].[Tbl_Student]
                (
                [StudentName],
                [FatherName],
                [StudentNo],
                [Email],
                [DateOfBirth],
                [MobileNo]
                )
                VALUES
                ('Aung Aung', 'U Tun Tun', 'S00011', 'aungaung@gmail.com', '2002-05-15', '09123456789'),
                ('Su Su', 'U Hla Win', 'S00012', 'susu@gmail.com', '2001-08-20', '09987654321'),
                ('Mg Mg', 'U Kyaw Kyaw', 'S00013', 'mgmg@gmail.com', '2003-01-10', '09456789123');");
                db.Close();
            }
            ;
        }

        public void Update()
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                db.Execute(@"UPDATE [dbo].[Tbl_Student]
                            SET
                            StudentName = 'Aung Kyaw',
                            Email = 'aungkyaw@gmail.com'
                            WHERE StudentNo = 'S00013';");
                db.Close();

            }
            ;

        }

        public void Delete()
        {

            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                int result = db.Execute("Delete from Tbl_Student where StudentId=11");
                Console.WriteLine($"Rows affected: {result}");
                db.Close();
            }


        }




    }
}