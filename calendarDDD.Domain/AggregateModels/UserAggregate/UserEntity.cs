using System;
using calendarDDD.Domain.Interfaces;

namespace calendarDDD.Domain.AggregateModels.UserAggregate
{
    public class UserEntity : IEntity, IAggregateRoot
    {
        public Guid Id { get; set; }
        public string PreName { get; set; }
        public string SurName { get; set; }
        public TeamEntity Team { get; set; }

    }
}
