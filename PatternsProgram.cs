using System;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[]args)
        {
            Patterns patterns = new Patterns();

            Console.WriteLine("Enter the Phone Number");
            string value = Console.ReadLine();
            bool match = patterns.ValidatePinCode(value);

            if (match)
            {
                Console.WriteLine("Patterns matched");

            }
            else
                Console.WriteLine("Pattens Not Matched");
        }
    }
}