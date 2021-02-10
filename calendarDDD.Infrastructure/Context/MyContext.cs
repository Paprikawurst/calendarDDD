using System;
using System.Collections.Generic;
using calendarDDD.Domain.Entities.Entities;
using calendarDDD.Infrastructure.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace calendarDDD.Infrastructure.Context
{
    public class MyContext : Microsoft.EntityFrameworkCore.DbContext, IProductRepository
    {
        public MyContext(DbContextOptions<MyContext> options)
                : base(options)
        {
        }

        public DbSet<ProductEntity> ProductEntity { get; set; }
        public DbSet<UserEntity> UserEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>();
            modelBuilder.Entity<UserEntity>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
