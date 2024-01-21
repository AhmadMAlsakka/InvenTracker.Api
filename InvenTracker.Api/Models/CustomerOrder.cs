using System;
using System.Collections.Generic;

namespace InvenTracker.Api.Models;

public partial class CustomerOrder
{
    public int OrderId { get; set; }

    public int? UserId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime OrderDate { get; set; }

    public int Status { get; set; }

    public int? WarehouseId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<CustomerOrderItem> CustomerOrderItems { get; set; } = new List<CustomerOrderItem>();

    public virtual Invoice? Invoice { get; set; }

    public virtual User? User { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
