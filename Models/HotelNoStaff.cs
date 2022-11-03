using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trividi_Booking.Models
{
    public class HotelNoStaff
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? UID { get; set; }


        public HotelNoStaff(int iD, string name, int? uid)
        {
            ID = iD;
            Name = name;
            UID = uid;
        }
    }
}