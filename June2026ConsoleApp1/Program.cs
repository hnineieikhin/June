
using June2026ConsoleApp1;
using Microsoft.Data.SqlClient;
using System.Data;

ADODotNetServices service = new ADODotNetServices();
service.Read();
service.Create();
//service.delete();
//service.update();

Console.ReadLine();




