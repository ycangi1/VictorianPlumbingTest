using System;
using VictorainPlumbing.Domain;

namespace VictorianPlumbingTest.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Product> Product { get; }
        IGenericRepository<Order> Order { get; }
        IGenericRepository<ProductOrder> ProductOrder { get; }
        int SaveChanges();
    }
}
