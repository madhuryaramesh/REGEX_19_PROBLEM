using System;

namespace REGEX_19_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC5
            UC5Password2 fName = new UC5Password2(); ;
            Console.WriteLine("ENTER YOUR PASSWORD 2 HERE : ");
            var check = Console.ReadLine();
            fName.Password2(check);
  
        }
    }
}
