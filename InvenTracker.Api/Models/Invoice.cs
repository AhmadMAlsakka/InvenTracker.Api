using System;
using System.Collections.Generic;

namespace InvenTracker.Api.Models;

public partial class Invoice
{
    public int InvoiceId { get; set; }

    public int? OrderId { get; set; }

    public DateOnly InvoiceDate { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal Costs { get; set; }

    public decimal Profit { get; set; }

    public virtual Order? Order { get; set; }
}
