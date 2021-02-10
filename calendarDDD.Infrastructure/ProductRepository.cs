using calendarDDD.Domain.AggregateModels.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calendarDDD.Infrastructure
{       
    //hieß vorher ProductServices
    public class ProductRepository : IProductRepository
    {
        private ProductDbContext dbContext;

        public ProductRepository(ProductDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// This method returns the list of product
        public async Task<List<ProductEntity>> GetProductAsync()
        {
            return await dbContext.ProductEntity.ToListAsync();
        }

        /// This method add a new product to the DbContext and saves it
        public async Task<ProductEntity> AddProductAsync(ProductEntity product)
        {
            try
            {
                dbContext.ProductEntity.Add(product);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return product;
        }

        /// This method update and existing product and saves the changes
        public async Task<ProductEntity> UpdateProductAsync(ProductEntity product)
        {
            try
            {
                var productExist = dbContext.ProductEntity.FirstOrDefault(p => p.Id == product.Id);
                if (productExist != null)
                {
                    dbContext.Update(product);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return product;
        }

        /// This method removes and existing product from the DbContext and saves it
        public async Task DeleteProductAsync(ProductEntity product)
        {
            try
            {
                dbContext.ProductEntity.Remove(product);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

