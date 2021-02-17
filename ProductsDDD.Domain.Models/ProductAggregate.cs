using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProductsDDD.Domain.Entities.Entities;
using ProductsDDD.Domain.Models.Contracts;
using ProductsDDD.Domain.Shared.Enums;

namespace ProductsDDD.Domain.Models
{
    public class ProductAggregate : IAggregate
    {
        private readonly ProductEntity _entity;
        private int _quantity;

        public ProductAggregate(ProductEntity entity)
        {
            _entity = entity;
        }
        public Guid Id => _entity.Id;
        public string Description => _entity.Description;
        public string Name => _entity.Name;
        public double Price => _entity.Price;
        public ProductType ProductType => _entity.ProductType;

        public bool Validate(out List<ValidationResult> validationInfos)
        {
            var list = new List<ValidationResult>();
            if (Id == Guid.Empty)
            {
                list.Add(new ValidationResult("ID is not set", new[] {nameof(Id)}));
            }

            if (string.IsNullOrWhiteSpace(Name))
            {
                list.Add(new ValidationResult("Name is empty", new[] { nameof(Name) }));
            }
            else if (Name.Length > 10)
            {
                list.Add(new ValidationResult("Name must be 10 or less characters", new[] { nameof(Name) }));
            }

            if (Price <= 0)
            {
                list.Add(new ValidationResult("Price must be greater than 0", new[] { nameof(Price) }));
            }

            validationInfos = list;
            return validationInfos.Count <= 0;
        }
    }
}
