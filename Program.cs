using System;

namespace Detail
{
    class Program
    {
        static void Main(string[]args)
        {
            //UC_1_FirstName UC1 = new UC_1_FirstName();

            //Console.WriteLine("Enter First name");
            //string value = Console.ReadLine();
            //bool match = UC1.FirstNameSpecified(value);

            //if (match)
            //{
                //Console.WriteLine("Patterns Matched");

            //}
            //else
                //Console.WriteLine("Patterns Not Matched");


            UC_2_LastNamecs UC2 = new UC_2_LastNamecs();
            Console.WriteLine("Enter Last Name");
            string value = Console.ReadLine();
            bool match = UC2.ValidateLastName(value);

            if (match)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
                Console.WriteLine("Pattern not Matched");
        }
    }
}
