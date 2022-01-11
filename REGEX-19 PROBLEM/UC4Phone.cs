using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX_19_PROBLEM
{
    class UC4Phone
    {
        public static string MobileNoRegex = "^[0-9]{1,3}[ ][6789][0-9]{9}$";
        public void PhoneNum(string phone)
        {
            bool check = Regex.IsMatch(phone,MobileNoRegex);
            if (check == true)
            {
                Console.WriteLine("VALID");
            }
            else
            {
                Console.WriteLine("INVALID");
            }

        }

    }
}
