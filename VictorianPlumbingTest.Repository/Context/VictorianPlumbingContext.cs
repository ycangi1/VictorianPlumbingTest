using Microsoft.EntityFrameworkCore;
using VictorainPlumbing.Domain;

namespace VictorianPlumbingTest.Repository.Context
{
  public  class VictorianPlumbingContext : DbContext
    {
        public VictorianPlumbingContext()
        {
        }

        public VictorianPlumbingContext(DbContextOptions<VictorianPlumbingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name);
                modelBuilder.Entity<ProductOrder>().HasKey(ba => new { ba.OrderId, ba.ProductId });

            }
        }
    }
}