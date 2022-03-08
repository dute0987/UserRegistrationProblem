using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class Patterns
    {
        public static string Regex_Pattern = "^[+][0-9]{2}[' '][7-9]{1}[0-9]{5}[0-9]{4}$";

        public bool ValidatePinCode(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, Regex_Pattern);
        }
    }
}
