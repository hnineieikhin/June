using System;
using System.Collections.Generic;

namespace June2026Database.AppDbContextModels;

public partial class MenuItem
{
    public int MenuItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public string Category { get; set; } = null!;

    public decimal Price { get; set; }

    public int StockQty { get; set; }
}
