using System;

namespace EventEase.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int EventModelId { get; set; }
        public int VenueId { get; set; }
        public DateTime BookingDate { get; set; }

        public EventModel? Event { get; set; }
        public Venue? Venue { get; set; }
    }
}
