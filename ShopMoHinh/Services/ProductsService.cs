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
    public class ProductsService : BaseService<Product, ProductsDto>, IProductsService
    {
        public ProductsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<Product> _reponsitory => _unitOfWork.ProductsRepository;

        public async Task SubmitAsync(string createBy, IEnumerable<ProductsDto> products)
        {

            foreach (var details in products)
            {
                details.Create = DateTime.Now;
                _unitOfWork.ProductsRepository.Add(DtoToEntity(details));
            }

            await _unitOfWork.SaveAsync();
        }
    }
}
