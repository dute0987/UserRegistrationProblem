using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Detail
{
    public class UC_6_OneUpperCase
    {
        public static string UpperPattern = "^[A-Z]{1}[a-z]{7}$";

        public bool ValidateUpper(string Passward)
        {
            return Regex.IsMatch(Passward, UpperPattern);
        }

    }
}
