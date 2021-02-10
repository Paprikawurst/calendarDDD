using System;
using System.Collections.Generic;
using calendarDDD.Domain.AggregateModels.WeatherAggregate;
using calendarDDD.Domain.Shared;

namespace calendarDDD.Infrastructure
{
    public class WeatherRepository : IWeatherRepository
    {

        public List<WeatherEntity> GetWeatherList()
        {

            //TODO: hardcode lösung durch DB ersetzen
            DateTime currDate = DateTime.Now;

            List<WeatherEntity> weatherEntities = new List<WeatherEntity>
            {
                new WeatherEntity { Date = currDate.AddDays(-1), TemperatureC = 30, Description = WeatherType.Hot.ToString() },
                new WeatherEntity { Date = currDate.AddDays(-2), TemperatureC = 10, Description = WeatherType.Cool.ToString() },
                new WeatherEntity { Date = currDate.AddDays(-3), TemperatureC = -20, Description = WeatherType.Cold.ToString() }
            };

            return weatherEntities;
        }
    }
}
