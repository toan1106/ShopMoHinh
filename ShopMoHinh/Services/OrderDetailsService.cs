using AutoMapper;
using ShopMoHinh.Dtos;
using ShopMoHinh.Models;
using ShopMoHinh.Repositories;
using ShopMoHinh.Services.BaseService;
using ShopMoHinh.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMoHinh.Services
{
    public class OrderDetailsService : BaseService<OrderDetails, OrderDetailsDto>, IOrderDetailsService
    {
        public OrderDetailsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<OrderDetails> _reponsitory => _unitOfWork.OrderDetailsRepository;

        public async Task SubmitAsync(string createBy, IEnumerable<OrderDetailsDto> orderDetails)
        {
            var orderDto = new OrderDto
            {
                CreatedAt = DateTime.Now,
                CreatedBy = createBy,
                Sku = Guid.NewGuid().ToString("n").Substring(0, 6)
            };
            var config = new MapperConfiguration(cfg => cfg.CreateMap<OrderDto, Order>());
            var mapper = config.CreateMapper();
            var orderEntity = mapper.Map<Order>(orderDto);
            //_unitOfWork.OrderRepository.Add(orderEntity);
            var productDto = new ProductsDto
            {
                Create = DateTime.Now,
            };
            var config2 = new MapperConfiguration(cfg => cfg.CreateMap<ProductsDto, Product>());
            var mapper2 = config2.CreateMapper();
            var productEntity = mapper2.Map<Product>(productDto);
            foreach (var details in orderDetails)
            {
                details.Order = orderEntity;
                details.CreateAt = DateTime.Now;
                details.Product = productEntity;
                _unitOfWork.OrderDetailsRepository.Add(DtoToEntity(details));
            }
            await _unitOfWork.SaveAsync();
        }
    }
}
