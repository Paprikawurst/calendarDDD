using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductsDDD.Domain.Entities.Entities;
using ProductsDDD.Domain.Models;
using ProductsDDD.Infrastructure.Context;
using ProductsDDD.Infrastructure.Contracts;
using ProductsDDD.Infrastructure.Contracts.Base;

namespace ProductsDDD.Infrastructure.Repositories
{       
    //hieß vorher ProductServices
    public class ProductRepository : IProductRepository
    {
        private MyContext _myContext;

        public ProductRepository(MyContext myContext)
        {
            this._myContext = myContext;
        }

        /// This method returns the list of product
        public async Task<IEnumerable<ProductAggregate>> GetAllAsync()
        {
            var list = await _myContext.ProductEntity.ToListAsync();
            return list.Select(CreateAggregate);
        }

        private async Task<ProductEntity> GetProductEntityAsync(Guid id)
        {
            var item = await _myContext.ProductEntity.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }
        public async Task<ProductAggregate> GetAsync(Guid id)
        {
            var item = await GetProductEntityAsync(id);
            if (item == null) return null;
            return CreateAggregate(item);
        }

        private ProductAggregate CreateAggregate(ProductEntity entity)
        {
            return new ProductAggregate(entity);
        }

        /// This method add a new product to the MyContext and saves it
        public async Task<ProductAggregate> AddAsync(ProductEntity product)
        {
            try
            {
                _myContext.ProductEntity.Add(product);
                await _myContext.SaveChangesAsync();
                return CreateAggregate(product);
            }
            catch (Exception)
            {
                throw;
            }
            return CreateAggregate(product);
        }
        public async Task DeleteAsync(ProductAggregate product)
        {
            try
            {
                var entity = await this.GetProductEntityAsync(product.Id);
                _myContext.ProductEntity.Remove(entity);
                await _myContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// This method update and existing product and saves the changes
        //public async Task<ProductEntity> UpdateProductAsync(ProductEntity product)
        //{
        //    try
        //    {
        //        var productExist = _myContext.ProductEntity.FirstOrDefault(p => p.Id == product.Id);
        //        if (productExist != null)
        //        {
        //            _myContext.Update(product);
        //            await _myContext.SaveChangesAsync();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return product;
        //}
    }
}

