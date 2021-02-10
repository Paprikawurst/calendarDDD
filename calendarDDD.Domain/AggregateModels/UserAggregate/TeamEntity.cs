using calendarDDD.Domain.Interfaces;
using calendarDDD.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace calendarDDD.Domain.AggregateModels.UserAggregate
{
    public class TeamEntity : IEntity
    {
        public Guid Id { get; set; }

        public TeamType Type { get; set; }

    }
}
