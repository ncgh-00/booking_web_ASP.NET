using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trividi_Booking.Models
{
    public class Statistic
    {
        public int numberBooking { get; set; }
        public int sumTotal { get; set; }

        public int sumTotalToday { get; set; }
        public int numberBookingToday { get; set; }

        public Statistic(int numberBooking,int sumTotal,int sumTotalToday,int numberBookingToday){
            this.numberBooking = numberBooking;
            this.sumTotal = sumTotal;
            this.sumTotalToday = sumTotalToday;
            this.numberBookingToday = numberBookingToday;
        }
    }
}