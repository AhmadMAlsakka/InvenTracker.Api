using System;
using System.Collections.Generic;

namespace InvenTracker.Api.Models;

public partial class WarehouseOrder
{
    public int OrderId { get; set; }

    public int? UserId { get; set; }

    public int? VendorId { get; set; }

    public DateTime OrderDate { get; set; }

    public int Status { get; set; }

    public int? WarehouseId { get; set; }

    public virtual User? User { get; set; }

    public virtual Vendor? Vendor { get; set; }

    public virtual Warehouse? Warehouse { get; set; }

    public virtual ICollection<WarehouseOrderItem> WarehouseOrderItems { get; set; } = new List<WarehouseOrderItem>();
}
