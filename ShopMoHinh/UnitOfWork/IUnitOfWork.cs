using ShopMoHinh.Models;
using ShopMoHinh.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMoHinh.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Order> OrderRepository { get; }
        IGenericRepository<OrderDetails> OrderDetailsRepository { get; }
        IGenericRepository<Product> ProductsRepository { get; }
        Task SaveAsync();
    }
}
