using System;
using System.Collections.Generic;

#nullable disable

namespace Trividi_Booking.Models
{
    public partial class Booking
    {
        public int IdBooking { get; set; }
        public int? IdRoomDetails { get; set; }
        public int Uid { get; set; }
        public int? StaffId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? NumberOfRooms { get; set; }
        public int? TotalCosts { get; set; }
        public bool? Confirm { get; set; }
        public DateTime? CreateAt { get; set; }

        public virtual RoomDetail IdRoomDetailsNavigation { get; set; }
        public virtual Account Staff { get; set; }
        public virtual Account UidNavigation { get; set; }
    }
}
