using System;
using System.Collections.Generic;

namespace June2026Database.AppDbContextModels;

public partial class TblCustomer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }
}
