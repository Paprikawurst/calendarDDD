using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsDDD.Application.Contracts;
using ProductsDDD.Domain.Entities.Entities;
using ProductsDDD.Domain.Models;
using ProductsDDD.Domain.Shared.Enums;
using ProductsDDD.Domain.Shared.Exceptions;
using ProductsDDD.Infrastructure.Contracts;
using ProductsDDD.Models;

namespace ProductsDDD.Application
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductModel> Add(ProductModel model)
        {
            var entity = CreateEntity(model.Description, model.Name, model.Price, model.ProductType);
            var aggregate = new ProductAggregate(entity);
            if (!aggregate.Validate(out var validations))
            {
                throw new ValidationException(validations);
            }
            aggregate = await _productRepository.AddAsync(entity);
            return ToModel(aggregate);
        }

        public async Task<List<ProductModel>> GetAllProducts()
        {
            var list = await _productRepository.GetAllAsync();
            return list.Select(ToModel).ToList();
        }

        private ProductModel ToModel(ProductAggregate aggregate)
        {
            return new ProductModel
            {
                Description = aggregate.Description,
                Id = aggregate.Id,
                Name = aggregate.Name,
                Price = aggregate.Price,
                ProductType = aggregate.ProductType
            };
        }

        private ProductEntity CreateEntity(string description, string name, double price, ProductType productType)
        {
            return new ProductEntity
            {
                Description = description,
                Id = Guid.NewGuid(),
                Name = name,
                Price = price,
                ProductType = productType,
            };
        }
    }

    //public class ProductService2 : IProductService
    //{

    //}
}