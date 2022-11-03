using System;
using System.Collections.Generic;

#nullable disable

namespace Trividi_Booking.Models
{
    public partial class HotelCategory
    {
        public HotelCategory()
        {
            Hotels = new HashSet<Hotel>();
        }

        public int IdCategory { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
