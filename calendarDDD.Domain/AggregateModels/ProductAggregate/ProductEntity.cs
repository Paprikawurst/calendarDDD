using calendarDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace calendarDDD.Domain.AggregateModels.ProductAggregate
{
    public class ProductEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
