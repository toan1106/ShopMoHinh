using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopMoHinh.Dtos;
using ShopMoHinh.Services.BaseService;

namespace ShopMoHinh.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailsService _orderDetailsService;

        public OrderDetailsController(IOrderDetailsService orderDetailsService)
        {
            _orderDetailsService = orderDetailsService;
        }

        [HttpPost]
        [Route("Post")]
        public async Task Post(string createBy, [FromBody] IDictionary<string, IEnumerable<OrderDetailsDto>> dic)
        {
            var orderDetailsList = dic["OrderDetails"];
            await _orderDetailsService.SubmitAsync(createBy, orderDetailsList);
        }
    }
}
