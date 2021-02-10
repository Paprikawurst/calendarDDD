using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calendarDDD.Domain.Entities.Entities;
using calendarDDD.Infrastructure.Context;
using calendarDDD.Infrastructure.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace calendarDDD.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        MyContext dbContext;

        public void UserServices(MyContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// This method returns the list of users
        public async Task<List<UserEntity>> GetUserAsync()
        {
            return await dbContext.UserEntity.ToListAsync();
        }

        /// This method add a new user to the MyContext and saves it
        public async Task<UserEntity> AddProductAsync(UserEntity user)
        {
            try
            {
                dbContext.UserEntity.Add(user);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return user;
        }
        /// This method update and existing user and saves the changes
        public async Task<UserEntity> UpdateUserAsync(UserEntity user)
        {
            try
            {
                var userExist = dbContext.UserEntity.FirstOrDefault(u => u.Id == user.Id);
                if (userExist != null)
                {
                    dbContext.Update(user);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return user;
        }

        /// This method removes an existing user from the MyContext and saves it
        public async Task DeleteUserAsync(UserEntity user)
        {
            try
            {
                dbContext.UserEntity.Remove(user);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
