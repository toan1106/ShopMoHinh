using ShopMoHinh.DataContext;
using ShopMoHinh.Models;
using ShopMoHinh.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMoHinh.UnitOfWork
{
    public class UnitOfWorkClass : IUnitOfWork
    {
        private ApplicationContext _context;

        public UnitOfWorkClass(ApplicationContext context)
        {
            _context = context;
            InitRepositories();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        private bool _disposed = false;

        public IGenericRepository<Order> OrderRepository { get; private set; }

        public IGenericRepository<OrderDetails> OrderDetailsRepository { get; private set; }
        public IGenericRepository<Product> ProductsRepository { get; private set; }

        private void InitRepositories()
        {
            OrderRepository = new GenericRepository<Order>(_context);
            OrderDetailsRepository = new GenericRepository<OrderDetails>(_context);
            ProductsRepository = new GenericRepository<Product>(_context);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
