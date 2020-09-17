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
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productRepository;

        public ProductsController(IProductsService productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost]
        [Route("Post")]

        public async Task Post(string createBy, [FromBody] IDictionary<string, IEnumerable<ProductsDto>> dic)
        {
            var products = dic["Product"];
            await _productRepository.SubmitAsync(createBy, products);
        }
    }
}
