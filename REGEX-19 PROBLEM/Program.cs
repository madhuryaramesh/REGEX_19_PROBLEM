using System;

namespace REGEX_19_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            UC1Name fName = new UC1Name(); ;
            Console.WriteLine("ENTER YOUR FIRST NAME HERE : ");
            var check = Console.ReadLine();
            fName.FName(check);
           // Console.WriteLine(check);
        }
    }
}
