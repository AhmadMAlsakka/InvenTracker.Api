using InvenTracker.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InvenTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        //Retrieve a list of all orders for a selected period of time
        public List<Order> GetOrdersforDate(DateTime startDate, DateTime endDate)
        {

        }
    }
}
