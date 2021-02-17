using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsDDD.Domain.Entities.Base;
using ProductsDDD.Domain.Entities.Entities;
using ProductsDDD.Domain.Models;
using ProductsDDD.Domain.Models.Contracts;

namespace ProductsDDD.Infrastructure.Contracts.Base
{
    public interface IRepository<TAggregate, TEntity> where TAggregate : IAggregate
        where TEntity : IEntity
    {
        Task<IEnumerable<TAggregate>> GetAllAsync();
        Task<TAggregate> GetAsync(Guid id);
        Task<TAggregate> AddAsync(TEntity product);
    }
}
