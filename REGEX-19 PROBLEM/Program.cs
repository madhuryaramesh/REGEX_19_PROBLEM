using System;

namespace REGEX_19_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC9
            UC9SampleEmail fName = new UC9SampleEmail(); ;
            Console.WriteLine("ENTER YOUR SAMPLE EMAIL HERE : ");
            var check = Console.ReadLine();
            fName.SampleEmail(check);
  
        }
    }
}
