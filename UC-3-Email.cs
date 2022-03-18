using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Detail
{
    public class UC_3_Email
    {
        public static string EmailPattern = @"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

        public bool ValidateEmail(string EmailID)
        {
            return Regex.IsMatch(EmailID, EmailPattern);
        }
    }
}
