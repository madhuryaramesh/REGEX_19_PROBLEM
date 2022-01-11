using System;

namespace REGEX_19_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC7
            UC5Password3 fName = new UC5Password3(); ;
            Console.WriteLine("ENTER YOUR PASSWORD 3 HERE : ");
            var check = Console.ReadLine();
            fName.Password3(check);
  
        }
    }
}
