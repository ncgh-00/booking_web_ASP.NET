using System;
using System.Collections.Generic;

#nullable disable

namespace Trividi_Booking.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            Accounts = new HashSet<Account>();
            RoomDetails = new HashSet<RoomDetail>();
        }

        public int IdHotel { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? NumberOfStars { get; set; }
        public bool Status { get; set; }
        public int IdCity { get; set; }
        public int? IdCategory { get; set; }

        public virtual HotelCategory IdCategoryNavigation { get; set; }
        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<RoomDetail> RoomDetails { get; set; }
    }
}
