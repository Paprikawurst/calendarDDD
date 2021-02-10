using System;
using calendarDDD.Domain.Entities.Base;
using calendarDDD.Domain.Shared;

namespace calendarDDD.Domain.Entities.Entities
{
    public class TeamEntity : IEntity
    {
        public Guid Id { get; set; }

        public TeamType Type { get; set; }

    }
}
