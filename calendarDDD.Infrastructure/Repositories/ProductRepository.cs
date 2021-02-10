using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calendarDDD.Domain.Entities.Entities;
using calendarDDD.Infrastructure.Context;
using calendarDDD.Infrastructure.Interfaces;
using calendarDDD.Infrastructure.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace calendarDDD.Infrastructure.Repositories
{       
    //hieß vorher ProductServices
    public class ProductRepository : IProductRepository
    {
        private Context.MyContext _myContext;

        public ProductRepository(MyContext myContext)
        {
            this._myContext = myContext;
        }

        /// This method returns the list of product
        public async Task<List<ProductEntity>> GetProductAsync()
        {
            return await _myContext.ProductEntity.ToListAsync();
        }

        /// This method add a new product to the MyContext and saves it
        public async Task<ProductEntity> AddProductAsync(ProductEntity product)
        {
            try
            {
                _myContext.ProductEntity.Add(product);
                await _myContext.SaveChangesAsync();
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
                var productExist = _myContext.ProductEntity.FirstOrDefault(p => p.Id == product.Id);
                if (productExist != null)
                {
                    _myContext.Update(product);
                    await _myContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return product;
        }

        /// This method removes and existing product from the MyContext and saves it
        public async Task DeleteProductAsync(ProductEntity product)
        {
            try
            {
                _myContext.ProductEntity.Remove(product);
                await _myContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

