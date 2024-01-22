using InvenTracker.Api.Models;
using Microsoft.EntityFrameworkCore;
using static InvenTracker.Api.Enum.InvenTrackerEnums;

namespace InvenTracker.Api.Repository
{
    public partial class InvenTrackerRepository
    {
        public InvenTrackerRepository(InvenTrackerContext invenTrackerContext)
        {
            this.dbContext = invenTrackerContext;
        }

        public InvenTrackerContext dbContext { get; }

        public async Task CancelOrder(int orderId)
		{
			
               var order = await dbContext.CustomerOrders.FirstOrDefaultAsync(x=> x.CustomerId == orderId);
            if (order != null)
            {
                order.Status = (int)OrderStatus.Canceled;
                await dbContext.SaveChangesAsync();
            }
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

		public async Task<IEnumerable<CustomerOrder>> GetCustomerOrders()
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<CustomerOrder>> GetOrderHistoryForCustomer(int customerId)
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
