using System.Text.RegularExpressions;

namespace Trividi_Booking.Ultils
{
    public class Validation
    {
        public static bool ValidMobileNumber(string inputMobileNumber)
        {
            string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

            Regex re = new Regex(strRegex);

            if (re.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }

        public static bool ValidEmail(string mail)
        {
            string strRegex = "^[a-zA-z]+\\w*([.-_]\\w+)*\\@[a-zA-Z]+\\w*([.-_]\\w+)*(\\.\\w+)+$";

            Regex re = new Regex(strRegex);

            if (re.IsMatch(mail))
                return (true);
            else
                return (false);
        }
    }
}
