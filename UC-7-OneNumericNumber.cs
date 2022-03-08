using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Detail
{
    public class UC_7_OneNumericNumber
    {
        public static string NumericPattern = "^[A-Z]{1}[a-z]{1}[0-9]{6}$";

        public bool ValidateNumeric(string number)
        {
            return Regex.IsMatch(number, NumericPattern);
        }
    }
}
