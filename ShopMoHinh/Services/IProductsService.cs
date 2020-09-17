using ShopMoHinh.Dtos;
using ShopMoHinh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMoHinh.Services.BaseService
{
    public interface IProductsService : IBaseService<Product, ProductsDto>
    {
        Task SubmitAsync(string createBy, IEnumerable<ProductsDto> products);
    }
}
