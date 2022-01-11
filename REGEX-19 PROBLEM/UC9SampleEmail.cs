using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX_19_PROBLEM
{
    class UC9SampleEmail
    {
        public static string SampleEmailsRegex = @"^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public void SampleEmail(string sampemail)
        {
            bool check = Regex.IsMatch(sampemail, SampleEmailsRegex);
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
