using InvenTracker.Api.Models;

namespace InvenTracker.Api.Repository
{
    public partial class InvenTrackerRepository
    {
        public InvenTrackerRepository(InventrackerContext context)
        {
            Context = context;
        }

        public InventrackerContext Context { get; }

        public async Task CancelCustomerOrder(int orderId)
		{

		}

		public Task CancelWarehouseOrder(int orderId)
		{
			throw new NotImplementedException();
		}

		public Task CreateCustomerOrder(CustomerOrder order)
		{
			throw new NotImplementedException();
		}

		public Task CreateWarehouseOrder(WarehouseOrder order)
		{
			throw new NotImplementedException();
		}

		public Task<CustomerOrder> GetCustomerOrderById(int orderId)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<CustomerOrder>> GetCustomerOrders()
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Order>> GetOrderHistoryForCustomer(int customerId)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<CustomerOrder>> GetOrderHistoryForCustomerUsingDate(int customerId, DateTime fromDate, DateTime toDate)
		{
			throw new NotImplementedException();
		}

		public Task<WarehouseOrder> GetWarehouseOrderById(int orderId)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<WarehouseOrder>> GetWarehouseOrders()
		{
			throw new NotImplementedException();
		}

		public Task UpdateCustomerOrder(int orderId, CustomerOrder order)
		{
			throw new NotImplementedException();
		}

		public Task UpdateWarehouseOrder(int orderId, WarehouseOrder order)
		{
			throw new NotImplementedException();
		}
	}
}
