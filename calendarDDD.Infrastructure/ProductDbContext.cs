using calendarDDD.Domain.AggregateModels.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace calendarDDD.Infrastructure
{
    public class ProductDbContext : DbContext, IProductRepository
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
                : base(options)
        {
        }

        public DbSet<ProductEntity> ProductEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }
        private List<ProductEntity> GetProducts()
        {
            return new List<ProductEntity>
    {
        new ProductEntity { Id = Guid.NewGuid(), Name = "Laptop", Price = 20.02, Quantity = 10, Description ="This is a best gaming laptop"},
        new ProductEntity { Id = Guid.NewGuid(), Name = "Microsoft Office", Price = 20.99, Quantity = 50, Description ="This is a Office Application"},
        new ProductEntity { Id = Guid.NewGuid(), Name = "Lazer Mouse", Price = 12.02, Quantity = 20, Description ="The mouse that works on all surface"},
        new ProductEntity { Id = Guid.NewGuid(), Name = "USB Storage", Price = 5.00, Quantity = 20, Description ="To store 256GB of data"}
    };
        }
    }
}
