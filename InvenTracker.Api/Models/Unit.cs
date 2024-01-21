using System;
using System.Collections.Generic;

namespace InvenTracker.Api.Models;

public partial class Unit
{
    public int UnitId { get; set; }

    public string UnitName { get; set; } = null!;

    public virtual ICollection<CustomerOrderItem> CustomerOrderItems { get; set; } = new List<CustomerOrderItem>();

    public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<WarehouseOrderItem> WarehouseOrderItems { get; set; } = new List<WarehouseOrderItem>();
}
