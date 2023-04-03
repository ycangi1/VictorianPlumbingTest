using System;
using VictorainPlumbing.Domain;
using VictorianPlumbingTest.Repository.Context;

namespace VictorianPlumbingTest.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly VictorianPlumbingContext _context;
        public IGenericRepository<Product> Product { get; }
        public IGenericRepository<Order> Order { get; }
        public IGenericRepository<ProductOrder> ProductOrder { get; }

        public UnitOfWork(VictorianPlumbingContext context)
        {
            _context = context;
            Product = new GenericRepository<Product>(context);
            Order = new GenericRepository<Order>(context);
            ProductOrder = new GenericRepository<ProductOrder>(context);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}