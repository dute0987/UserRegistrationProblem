using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Detail
{
    public class UC_2_LastNamecs
    {
        public static string LastPattern = "^[A-Z]{1}[a-z]{3}$";

        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, LastPattern);
        }
    }
}
