using System;
using calendarDDD.Domain.Entities.Base;

namespace calendarDDD.Domain.Entities.Entities
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
