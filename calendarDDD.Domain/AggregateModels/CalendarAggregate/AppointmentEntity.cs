using System;
using calendarDDD.Domain.AggregateModels.UserAggregate;
using calendarDDD.Domain.Interfaces;
using calendarDDD.Domain.Shared;

namespace calendarDDD.Domain.AggregateModels.CalendarAggregate
{ 
    public class AppointmentEntity : IEntity
    {
        public Guid Id { get; set; }
        public AppointmentType Type  { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public UserEntity CreatorUser { get; set; }
    }
}