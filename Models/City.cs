using System;
using System.Collections.Generic;

#nullable disable

namespace Trividi_Booking.Models
{
    public partial class City
    {
        public City()
        {
            Hotels = new HashSet<Hotel>();
        }

        public int IdCity { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
