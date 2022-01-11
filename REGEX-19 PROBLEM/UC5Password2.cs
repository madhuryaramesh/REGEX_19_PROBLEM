using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX_19_PROBLEM
{
    class UC5Password2
    {
        public static string Password2Regex = "^[A-Z]{1}[A-Z a-z]{7,}$";
        public void Password2(string password2)
        {
            bool check = Regex.IsMatch(password2, Password2Regex);
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
