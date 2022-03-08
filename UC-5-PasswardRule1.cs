using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Detail
{
    public class UC_5_PasswardRule1
    {
        public static string Rule1Pattern = "^[a-z]{8}$";

        public bool ValidateChar(string Passward)
        {
            return Regex.IsMatch(Passward, Rule1Pattern);
        }
    }
}
