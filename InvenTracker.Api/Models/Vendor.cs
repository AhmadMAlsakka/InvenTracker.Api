using System;
using System.Collections.Generic;

namespace InvenTracker.Api.Models;

public partial class Vendor
{
    public int VendorId { get; set; }

    public string VendorName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string MobilePhone { get; set; } = null!;

    public string? LandlinePhone { get; set; }

    public virtual ICollection<WarehouseOrder> WarehouseOrders { get; set; } = new List<WarehouseOrder>();
}
