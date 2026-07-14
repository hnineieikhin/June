using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2026ConsoleApp5
{
    public class June2026AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder
                {
                    DataSource = "DESKTOP-B4L5P5O\\KHIN",
                    InitialCatalog = "June2026",
                    UserID = "sa",
                    Password = "sasa@123",
                    TrustServerCertificate = true
                };
                optionsBuilder.UseSqlServer(sb.ConnectionString);
            }
        }
        public DbSet<StaffEntity> Staffs { get; set; }
       
    }
}
