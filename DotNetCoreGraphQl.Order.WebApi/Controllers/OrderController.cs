using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreGraphQl.Order.Providers;
using DotNetCoreGraphQl.Order.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreGraphQl.Order.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderProvider _orderProvider;
        public OrderController(IOrderProvider orderProvider ) {
            _orderProvider = orderProvider;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<OrderDetails> Get(int id)
        {
            return _orderProvider.GetOrderDetails(id);
        }

         
    }
}
