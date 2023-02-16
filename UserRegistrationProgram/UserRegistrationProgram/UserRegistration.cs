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
        public static string REGEX_LAST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public bool validateFirstName(string fName)
        {
            return Regex.IsMatch(fName, REGEX_FIRST_NAME);
        }
        public bool validateLastName(string lName)
        {
            return Regex.IsMatch(lName, REGEX_LAST_NAME);
        }
    }
}
