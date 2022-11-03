using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trividi_Booking.Models
{
    public class Chart
    {
        public DateTime? date;

        public int numberBook {get;set;}

        public double? total {get;set;}

        public Chart(DateTime? date, int numberBook , double? total){
            this.date = date;
            this.numberBook = numberBook;
            this.total = total;
        }
    }
}