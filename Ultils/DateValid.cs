using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trividi_Booking.Ultils
{
    public class DateValid
    {
        public static int duration(string dateS, string dateN)
        {
            DateTime now = DateTime.ParseExact(dateS, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime late = DateTime.ParseExact(dateN, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan interval = late.Subtract(now);
            return interval.Days;
        }
        public static int durationDateTime(DateTime dateS, DateTime dateN)
        {
            TimeSpan interval = dateN.Subtract(dateS);
            return interval.Days;
        }

        public static bool isLogicDate(string date)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(duration(now.ToString("yyyy-MM-dd"), date));
            if (duration(now.ToString("yyyy-MM-dd"), date) > 0)
            {
                return true;
            }
            return false;
        }
    }
}