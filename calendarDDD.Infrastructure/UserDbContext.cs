using calendarDDD.Domain.AggregateModels.UserAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace calendarDDD.Infrastructure
{
    //Constructor
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
                : base(options)
        {

        }

        //Public properties
        public DbSet<UserEntity> UserEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasData(GetUsers());
            base.OnModelCreating(modelBuilder);
        }

        //Private methods
        private List<UserEntity> GetUsers()
        {
            return new List<UserEntity>
    {
        new UserEntity { Id = Guid.NewGuid(), PreName = "Hans", SurName = "Müller"},
        new UserEntity { Id = Guid.NewGuid(), PreName = "Maria", SurName = "Schmidt"},
        new UserEntity { Id = Guid.NewGuid(), PreName = "Peter", SurName = "Fischer"},
    };
        }
    }
}
