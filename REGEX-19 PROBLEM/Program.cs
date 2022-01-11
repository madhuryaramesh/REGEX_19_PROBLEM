using System;

namespace REGEX_19_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC5
            UC5Password fName = new UC5Password(); ;
            Console.WriteLine("ENTER YOUR PASSWORD HERE : ");
            var check = Console.ReadLine();
            fName.Password(check);
  
        }
    }
}
