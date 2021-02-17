using Microsoft.EntityFrameworkCore;
using ProductsDDD.Domain.Entities.Entities;
using ProductsDDD.Infrastructure.Contracts;

namespace ProductsDDD.Infrastructure.Context
{
    public class MyContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
                : base(options)
        {
        }

        public DbSet<ProductEntity> ProductEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
