using System;
using System.Collections.Generic;

namespace June2026Database.AppDbContextModels;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string? Position { get; set; }

    public string? Phone { get; set; }

    public decimal? Salary { get; set; }
}
