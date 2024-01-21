using System;
using System.Collections.Generic;

namespace InvenTracker.Api.Models;

public partial class WarehouseOrderItem
{
    public int OrderItemId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? VariantId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public int? UnitId { get; set; }

    public int? WarehouseId { get; set; }

    public virtual WarehouseOrder? Order { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Unit? Unit { get; set; }

    public virtual ProductVariant? Variant { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
