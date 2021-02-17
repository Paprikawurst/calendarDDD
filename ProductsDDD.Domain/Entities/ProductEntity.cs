using System;
using ProductsDDD.Domain.Entities.Base;
using ProductsDDD.Domain.Shared.Enums;

namespace ProductsDDD.Domain.Entities.Entities
{
    public class ProductEntity : IEntity
    {
        public Guid Id { get; set; }
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
