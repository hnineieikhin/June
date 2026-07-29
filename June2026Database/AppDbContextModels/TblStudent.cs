using System;
using System.Collections.Generic;

namespace June2026Database.AppDbContextModels;

public partial class TblStudent
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string FatherName { get; set; } = null!;

    public string StudentNo { get; set; } = null!;

    public string? Email { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? MobileNo { get; set; }
}
