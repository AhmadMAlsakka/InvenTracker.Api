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

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Product? Product { get; set; }
}
