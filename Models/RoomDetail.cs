using System;
using System.Collections.Generic;

#nullable disable

namespace Trividi_Booking.Models
{
    public partial class RoomDetail
    {
        public RoomDetail()
        {
            Bookings = new HashSet<Booking>();
        }

        public int IdRoomDetails { get; set; }
        public int IdHotel { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int? Discount { get; set; }
        public bool Status { get; set; }

        public virtual Hotel IdHotelNavigation { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
