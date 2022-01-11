using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX_19_PROBLEM
{
    class UC2LastName
    {
        public static string FirstNameREGEX = "^[A-Z]{1}[a-z]{2,}$";
        public static string LastNameREGEX = "^[A-Z]{1}[a-z]{2,}$";
        public void FName(string firstna)
        {
            bool check = Regex.IsMatch(firstna, FirstNameREGEX);
            if (check == true)
            {
                Console.WriteLine("VALID");
            }
            else
            {
                Console.WriteLine("INVALID");
            }

        }


        public void LName(string lastna)
        {
            bool check = Regex.IsMatch(lastna,LastNameREGEX);
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
