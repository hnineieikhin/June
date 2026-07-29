using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace June2026Database.AppDbContextModels;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<TblStaff> TblStaffs { get; set; }

    public virtual DbSet<TblStudent> TblStudents { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=June2026;User Id=sa;Password=sasa@123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F11110B33D6");

            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Tbl_Cust__A4AE64D86CDFE9BB");

            entity.ToTable("Tbl_Customer");

            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
        });

        modelBuilder.Entity<TblStaff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__Tbl_Staf__96D4AB173519E41C");

            entity.ToTable("Tbl_Staff");

            entity.Property(e => e.StaffName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblStudent>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Tbl_Stud__32C52B99CB352AC9");

            entity.ToTable("Tbl_Student");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FatherName).HasMaxLength(100);
            entity.Property(e => e.MobileNo).HasMaxLength(15);
            entity.Property(e => e.StudentName).HasMaxLength(100);
            entity.Property(e => e.StudentNo).HasMaxLength(20);
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Tbl_User__1788CC4C2DD3FC9E");

            entity.ToTable("Tbl_User");

            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
