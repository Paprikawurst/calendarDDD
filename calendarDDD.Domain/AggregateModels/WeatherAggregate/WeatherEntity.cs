using calendarDDD.Domain.Interfaces;
using System;

namespace calendarDDD.Domain.AggregateModels.WeatherAggregate
{
    public class WeatherEntity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Description { get; set; }
    }
}
