using System;
using System.Collections.Generic;

namespace InvenTracker.Api.Models;

public partial class ProductVariant
{
    public int VariantId { get; set; }

    public int? ProductId { get; set; }

    public string VariantName { get; set; } = null!;

    public decimal PriceAdjustment { get; set; }

    public int Quantity { get; set; }

    public int? UnitId { get; set; }

    public virtual ICollection<CustomerOrderItem> CustomerOrderItems { get; set; } = new List<CustomerOrderItem>();

    public virtual Product? Product { get; set; }

    public virtual Unit? Unit { get; set; }

    public virtual ICollection<WarehouseOrderItem> WarehouseOrderItems { get; set; } = new List<WarehouseOrderItem>();
}
