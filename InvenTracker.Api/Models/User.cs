using System;
using System.Collections.Generic;

namespace InvenTracker.Api.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Role { get; set; } = null!;

    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();

    public virtual ICollection<WarehouseOrder> WarehouseOrders { get; set; } = new List<WarehouseOrder>();
}
