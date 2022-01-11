using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX_19_PROBLEM
{
    class UC5Password3
    {
        public static string Password3Regex = "^[A-Z]{1}[A-Z a-z]{7,}[0-9]{1,}$";
        public void Password3(string password3)
        {
            bool check = Regex.IsMatch(password3, Password3Regex);
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
