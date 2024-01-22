using InvenTracker.Api.Models;
using InvenTracker.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InvenTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public InvenTrackerRepository InvenTrackerRepository { get; }

        public OrdersController(InvenTrackerRepository invenTrackerRepository)
        {
            InvenTrackerRepository = invenTrackerRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<CustomerOrder>>> GetOrderHistoryForCustomerUsingDate(int customerID,DateTime startDate, DateTime endDate)
        {
            var CustomerOrders = await InvenTrackerRepository.GetOrderHistoryForCustomerUsingDate(customerID, startDate, endDate);
            return Ok(CustomerOrders.ToList());
        }


        public async Task<IActionResult> CancelOrder(int orderId)
        {
            return Ok("Order Cancelled");
        }
    }
}
