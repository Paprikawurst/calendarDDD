using System;
using ProductsDDD.Domain.Shared.Enums;

namespace ProductsDDD.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductType ProductType { get; set; }
    }
}
