using System;

namespace ProductsDDD.Domain.Entities.Base
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
