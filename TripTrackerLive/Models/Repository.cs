using System;
using System.Collections.Generic;
using System.Linq;

namespace TripTracker.Backend.Models
{
    public class Repository
    {
        private List<Trip> MyTrips = new List<Trip>
        {
            new Trip {
                Id = 1,
                Name = "SLC Trip",
                StartDate = new DateTime(2019, 05, 01),
                EndDate = new DateTime(2019, 05, 19)

            },
            new Trip
            {
                Id = 2,
                Name = "Gray Maine Vacation",
                StartDate = new DateTime(2019, 06, 10),
                EndDate = new DateTime(2019, 06, 15)

            },
            new Trip
            {
                Id = 3,
                Name = "Get to Work",
                StartDate = new DateTime(2019, 06, 19),
                EndDate = new DateTime(2019, 06, 25)

            }
        };

        public List<Trip> Get()
        {
            return MyTrips;
        }

        public Trip Get(int id)
        {
            return MyTrips.First(t => t.Id == id);
        }

        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);

        }

        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == tripToUpdate.Id));
            Add(tripToUpdate);
        }

        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == id));
        }
    }
}
