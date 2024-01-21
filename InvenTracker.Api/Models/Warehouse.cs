using System;
using System.Collections.Generic;

namespace InvenTracker.Api.Models;

public partial class Warehouse
{
    public int WarehouseId { get; set; }

    public string WarehouseName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public virtual ICollection<CustomerOrderItem> CustomerOrderItems { get; set; } = new List<CustomerOrderItem>();

    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();

    public virtual ICollection<WarehouseOrderItem> WarehouseOrderItems { get; set; } = new List<WarehouseOrderItem>();

    public virtual ICollection<WarehouseOrder> WarehouseOrders { get; set; } = new List<WarehouseOrder>();
}
