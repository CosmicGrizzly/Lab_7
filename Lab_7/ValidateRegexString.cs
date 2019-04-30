using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_7
{
    class ValidateRegexString
    {
       public static bool ValidName(string y)
        {
            bool x = Regex.IsMatch(y, @"[A-Z][a-z]{1,29}");
            return x;
        }
        public static bool ValidEmail(string email)
        {
            bool v = Regex.IsMatch(email, @"[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}\.[a-zA-Z0-9]{2,3}");
            return v;
        }
        public static bool ValidPhone(string phone)
        {
            bool c = Regex.IsMatch(phone, @"[0-9]{1,3}[0-9]{1,3}[0-9]{1,4}");
            return c;
        }
        public static bool ValidDate(string date)
        {
            bool regexDate = Regex.IsMatch(date, @"(([0-3]{1})([0-9]{1})(/)([0-1]{1})([0-9]{1})(/)([0-9]){4})");
            return regexDate;
        }
    }
}
