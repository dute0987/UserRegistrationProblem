using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Detail
{
     public class UC_1_FirstName
     {
        public static string FirstName = "^[A-Z]{1}[a-z]{5}$";

        public bool FirstNameSpecified(string firstname)
        {
            return Regex.IsMatch(firstname, FirstName);
        }
     }
}
