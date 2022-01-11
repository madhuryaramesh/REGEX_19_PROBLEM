using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX_19_PROBLEM
{
    class UC8Password4
    {
        public static string Password4Regex = "^[A-Z]{1}[A-Z a-z]{7,}[!*@#$%^&+=]?[0-9]{1,}$";
        public void Password4(string password4)
        {
            bool check = Regex.IsMatch(password4, Password4Regex);
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
