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


            //UC_2_LastNamecs UC2 = new UC_2_LastNamecs();
            //Console.WriteLine("Enter Last Name");
            //string value = Console.ReadLine();
            //bool match = UC2.ValidateLastName(value);

            //if (match)
            //{
                //Console.WriteLine("Pattern Matched");
            //}
            //else
                /Console.WriteLine("Pattern not Matched");

            //UC_3_Email UC3 = new UC_3_Email();
            //Console.WriteLine("Enter Your Email");
            //string value = Console.ReadLine();
            //bool match = UC3.ValidateEmail(value);

            //if (match)
            //{
                //Console.WriteLine("Patterns Matched");

            //}
            //else
                //Console.WriteLine("Pattern Not Matched");

            //UC_5_PasswardRule1 UC5 = new UC_5_PasswardRule1();
            //Console.WriteLine("Enter Your Passward");
            //string value = Console.ReadLine();
            //bool match = UC5.ValidateChar(value);

            //if (match)
            //{
                //Console.WriteLine("Pattern Matched ");
            //}
            //else
                //Console.WriteLine("Pattern not Matched");

            //UC_6_OneUpperCase UC6 = new UC_6_OneUpperCase();
            //Console.WriteLine("Enter Your Passwaed");
            //string value = Console.ReadLine();
            //bool match = UC6.ValidateUpper(value);

            //if (match)
            //{
                //Console.WriteLine("Pattern Matched");
            //}
            /else
                //Console.WriteLine("Pattern Not Matched");

            //UC_7_OneNumericNumber UC7 = new UC_7_OneNumericNumber();    
            //Console.WriteLine("Enter Your Passward");
            //string value =Console.ReadLine();
            //bool match = UC7.ValidateNumeric(value);

            //if (match)
            //{
                //Console.WriteLine("Pattern Matched");

            //}
            //else
            //{
                //Console.WriteLine("Pattern not Matched");
            //}

            UC_8_SpecialChar UC8 = new UC_8_SpecialChar();
            Console.WriteLine("Enter your Passward");
            string value = Console.ReadLine();
            bool match = UC8.ValidateChar(value);

            if (match)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
                Console.WriteLine("Pattern Not Matched");

        }
    }
}
