using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trividi_Booking.Models
{
    public class BookingDetails
    {
        public int IdBooking { get; set; }
        public string RoomDetails { get; set; }
        public string Hotel { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? NumberOfRooms { get; set; }
        public int? TotalCosts { get; set; }
        public bool? Confirm { get; set; }
        public DateTime? CreateAt { get; set; }

        public BookingDetails(int id, string room,string hotel, DateTime? dateS,DateTime? dateE, int? numR,int? TotalCosts,bool? conf, DateTime? crAt, string fullname, string email, string phone){
            this.IdBooking = id;
            this.RoomDetails = room;
            this.Hotel = hotel;
            this.DateStart = dateS;
            this.DateEnd = dateE;
            this.Confirm = conf;
            this.NumberOfRooms = numR;
            this.TotalCosts = TotalCosts;
            this.CreateAt = crAt;
            this.FullName = fullname;
            this.Email = email;
            this.Phone = phone;
        }
    }
}