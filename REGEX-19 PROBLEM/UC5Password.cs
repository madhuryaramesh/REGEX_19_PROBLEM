using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX_19_PROBLEM
{
    class UC5Password
    {
        public static string PasswordRegex = "^[A-Z a-z]{8,}$";
        public void Password(string password)
        {
            bool check = Regex.IsMatch(password, PasswordRegex);
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
