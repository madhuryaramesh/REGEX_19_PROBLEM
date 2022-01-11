using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX_19_PROBLEM
{
    class UC3Email
    {
        public static string EMailRegex = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$";
        public void EmailId(string emailid)
        {
            bool check = Regex.IsMatch(emailid, EMailRegex);
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
