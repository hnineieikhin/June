using System;
using System.Collections.Generic;

namespace June2026Database.AppDbContextModels;

public partial class TblStudent
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string? FatherName { get; set; }

    public string? StudentNo { get; set; }

    public string? Email { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? MobileNo { get; set; }
}
