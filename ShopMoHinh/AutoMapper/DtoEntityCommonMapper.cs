using AutoMapper;
using ShopMoHinh.Dtos;
using ShopMoHinh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMoHinh.AutoMapper
{
    public class DtoEntityCommonMapper : Profile
    {
        public DtoEntityCommonMapper()
        {
            #region Enity(model) To Dto(ViewModel)

            CreateMap<Order, OrderDto>();
            CreateMap<OrderDetails, OrderDetailsDto>();
            #endregion

            #region Dto(ViewModel) to Entity(Model)

            CreateMap<OrderDto, Order>();
            CreateMap<OrderDetailsDto, OrderDetails>();
            #endregion
        }
    }
}
