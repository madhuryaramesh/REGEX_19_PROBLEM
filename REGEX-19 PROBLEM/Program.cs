using System;

namespace REGEX_19_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC3
            UC3Email fName = new UC3Email(); ;
            Console.WriteLine("ENTER YOUR EMAIL ID HERE : ");
            var check = Console.ReadLine();
            fName.EmailId(check);
            
            
        }
    }
}
