using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsDDD.Domain.Entities.Entities;
using ProductsDDD.Domain.Models;
using ProductsDDD.Infrastructure.Contracts.Base;

namespace ProductsDDD.Infrastructure.Contracts
{
    public interface IProductRepository : IRepository<ProductAggregate, ProductEntity>
    {
    }
}
