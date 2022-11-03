using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trividi_Booking.Models
{
    public class HotelDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? NumberOfStars { get; set; }
        public bool Status { get; set; }
        public string City { get; set; }
        public string Category { get; set; }

        public HotelDetail(int iD, string name, string description, string image, string phone, string address, int? numberOfStars, bool status, string city, string category)
        {
            ID = iD;
            Name = name;
            Description = description;
            Image = image;
            Phone = phone;
            Address = address;
            NumberOfStars = numberOfStars;
            Status = status;
            City = city;
            Category = category;
        }
    }
}