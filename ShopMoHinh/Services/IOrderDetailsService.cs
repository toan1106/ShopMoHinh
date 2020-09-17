using ShopMoHinh.Dtos;
using ShopMoHinh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMoHinh.Services.BaseService
{
    public interface IOrderDetailsService : IBaseService<OrderDetails, OrderDetailsDto>
    {
        Task SubmitAsync(string createBy, IEnumerable<OrderDetailsDto> orderDetails);
    }
}
