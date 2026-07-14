using June2026ConsoleApp2;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

DapperService service = new DapperService();
//service.Read();
//service.Create();
//service.Delete();
service.Update();

Console.ReadLine();

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