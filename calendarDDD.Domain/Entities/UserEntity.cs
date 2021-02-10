using System;
using calendarDDD.Domain.Entities.Base;

namespace calendarDDD.Domain.Entities.Entities
{
    public class UserEntity : IEntity
    {
        public Guid Id { get; set; }
        public string PreName { get; set; }
        public string SurName { get; set; }
        public TeamEntity Team { get; set; }

    }
}
