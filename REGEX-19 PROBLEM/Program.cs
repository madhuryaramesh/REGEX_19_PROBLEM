using System;

namespace REGEX_19_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC4
            UC4Phone fName = new UC4Phone(); ;
            Console.WriteLine("ENTER YOUR PHONE NUMBER HERE : ");
            var check = Console.ReadLine();
            fName.PhoneNum(check);
  
        }
    }
}
