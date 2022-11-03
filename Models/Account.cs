using System;
using System.Collections.Generic;

#nullable disable

namespace Trividi_Booking.Models
{
    public partial class Account
    {
        public Account()
        {
            BookingStaffs = new HashSet<Booking>();
            BookingUidNavigations = new HashSet<Booking>();
        }

        public int Uid { get; set; }
        public int? IdHotel { get; set; }
        public int? RoleId { get; set; }
        public string Username { get; set; }
        public string HashPassword { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? Status { get; set; }

        public virtual Hotel IdHotelNavigation { get; set; }
        public virtual ICollection<Booking> BookingStaffs { get; set; }
        public virtual ICollection<Booking> BookingUidNavigations { get; set; }
    }
}
