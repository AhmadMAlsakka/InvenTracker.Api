namespace InvenTracker.Api.Enum
{
    public static class InvenTrackerEnums
    {
        // Enum for Order Status
        public enum OrderStatus
        {
            Unpaid = 0,
            Pending = 1,
            Paid = 2,
            Shipped = 3,
            Canceled = -1
        }

        // Enum for Order Type (Customer or Warehouse)
        public enum OrderType
        {
            CustomerOrder = 0,
            WarehouseOrder = 1
        }

        // Enum for Payment Status
        public enum PaymentStatus
        {
            Unpaid = 0,
            Pending = 1,
            Paid = 2,
            Failed = -1
        }
    }
}
