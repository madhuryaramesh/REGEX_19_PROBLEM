using System;

namespace REGEX_19_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC8
            UC8Password4 fName = new UC8Password4(); ;
            Console.WriteLine("ENTER YOUR PASSWORD 3 HERE : ");
            var check = Console.ReadLine();
            fName.Password4(check);
  
        }
    }
}
