using System;

namespace Detail
{
    class Program
    {
        static void Main(string[]args)
        {
            UC_1_FirstName UC1 = new UC_1_FirstName();

            Console.WriteLine("Enter First name");
            string value = Console.ReadLine();
            bool match = UC1.FirstNameSpecified(value);

            if (match)
            {
                Console.WriteLine("Patterns Matched");

            }
            else
                Console.WriteLine("Patterns Not Matched");
        }
    }
}