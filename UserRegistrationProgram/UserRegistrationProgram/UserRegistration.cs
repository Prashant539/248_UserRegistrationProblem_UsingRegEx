using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class UserRegistration
    {
        public static string REGEX_FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public bool validateFirstName(string fName)
        {
            return Regex.IsMatch(fName, REGEX_FIRST_NAME);
        }
    }
}
