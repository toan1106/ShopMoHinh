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
    public class OrderService : BaseService<Order, OrderDto>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<Order> _reponsitory => _unitOfWork.OrderRepository;

        public async Task SubmitAsync(string createBy, IEnumerable<OrderDetailsDto> orderDetails)
        {
            var orderDto = new OrderDto
            {
                CreatedAt = DateTime.Now,
                CreatedBy = createBy,
                Sku = Guid.NewGuid().ToString("n").Substring(0, 6)
            };

            var orderEntity = DtoToEntity(orderDto);

            _unitOfWork.OrderRepository.Add(orderEntity);

            foreach (var details in orderDetails)
            {
                details.Order = orderEntity;
                var config = new MapperConfiguration(cfg => cfg.CreateMap<OrderDetails, OrderDetailsDto>());
                var mapper = new Mapper(config);
                var detailsEntity = mapper.Map<OrderDetails>(details);
                _unitOfWork.OrderDetailsRepository.Add(detailsEntity);
            }

            await _unitOfWork.SaveAsync();
        }
    }
}
