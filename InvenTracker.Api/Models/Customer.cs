using System;
using System.Collections.Generic;

namespace InvenTracker.Api.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string MobilePhone { get; set; } = null!;

    public string? LandlinePhone { get; set; }

    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();
}
