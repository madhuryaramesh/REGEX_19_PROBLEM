using System;

namespace REGEX_19_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC2
            UC2LastName fName = new UC2LastName(); ;
            Console.WriteLine("ENTER YOUR FIRST NAME HERE : ");
            var check = Console.ReadLine();
            fName.FName(check);
            
            Console.WriteLine("ENTER YOUR LAST NAME HERE : ");
            var check2 = Console.ReadLine();
            fName.LName(check);
            // Console.WriteLine(check);
        }
    }
}
