using System;
using System.Collections.Generic;

namespace EventEase.Models
{
    public class EventModel
    {
        public int EventModelId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }

        public int? VenueId { get; set; }
        public Venue? Venue { get; set; }

        public ICollection<Booking>? Bookings { get; set; }
    }
}
