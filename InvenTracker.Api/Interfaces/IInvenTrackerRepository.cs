using InvenTracker.Api.Models;

namespace InvenTracker.Api.Interfaces
{
    public interface IInvenTrackerRepository
    {
            // Customer Orders

            /// <summary>
            /// Retrieve a list of all customer orders.
            /// </summary>
            Task<IEnumerable<CustomerOrder>> GetCustomerOrders();

            /// <summary>
            /// Retrieve details of a specific customer order.
            /// </summary>
            Task<CustomerOrder> GetCustomerOrderById(int orderId);

            /// <summary>
            /// Create a new customer order.
            /// </summary>
            Task CreateCustomerOrder(CustomerOrder order);

            /// <summary>
            /// Update an existing customer order.
            /// </summary>
            Task UpdateCustomerOrder(int orderId, CustomerOrder order);

            /// <summary>
            /// Delete a customer order.
            /// </summary>
            Task CancelCustomerOrder(int orderId);

            /// <summary>
            /// Get all orders and returns for a specific customer.
            /// </summary>
            Task<IEnumerable<Order>> GetOrderHistoryForCustomer(int customerId);

            /// <summary>
            /// Get all orders and returns for a specific customer within a specified date range.
            /// </summary>
            Task<IEnumerable<CustomerOrder>> GetOrderHistoryForCustomerUsingDate(int customerId, DateTime fromDate, DateTime toDate);

        #region WarehousOrders

        /// <summary>
        /// Retrieve a list of all warehouse orders.
        /// </summary>
        Task<IEnumerable<WarehouseOrder>> GetWarehouseOrders();

            /// <summary>
            /// Retrieve details of a specific warehouse order.
            /// </summary>
            Task<WarehouseOrder> GetWarehouseOrderById(int orderId);

            /// <summary>
            /// Create a new warehouse order.
            /// </summary>
            Task CreateWarehouseOrder(WarehouseOrder order);

            /// <summary>
            /// Update an existing warehouse order.
            /// </summary>
            Task UpdateWarehouseOrder(int orderId, WarehouseOrder order);

            /// <summary>
            /// Delete a warehouse order.
            /// </summary>
            Task CancelWarehouseOrder(int orderId);

        #endregion WarehousOrders

    }
}
