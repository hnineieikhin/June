using System;
using System.Collections.Generic;

namespace June2026Database.AppDbContextModels;

public partial class TblStaff
{
    public int StaffId { get; set; }

    public string StaffName { get; set; } = null!;
}
