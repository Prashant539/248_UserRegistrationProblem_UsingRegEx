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
        public static string REGEX_EMAIL = "^[a-z]{1,}[0-9]{0,}[@][a-z]{1,}[.][a-z]{1,3}[.]{0,}[a-z]{0,2}$";
        public static string REGEX_NUMBER = "^[1-9]{1}[0-9]{1}[ ][1-9]{1}[0-9]{9}$";
        public static string REGEX_PASSWORD = "^[a-zA-Z0-9]{8}$";
        public static string REGEX_PASSWORD2 = "^[A-Z]{1}[a-zA-Z0-9]{7}$";
        public static string REGEX_PASSWORD3 = "^[A-Z]{1,}[a-z]{6}[0-9]{1,}$";

        public bool validateFirstName(string fName)
        {
            return Regex.IsMatch(fName, REGEX_FIRST_NAME);
        }
        public bool validateLastName(string lName)
        {
            return Regex.IsMatch(lName, REGEX_LAST_NAME);
        }
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool validateNumber(string number)
        {
            return Regex.IsMatch(number, REGEX_NUMBER);
        }
        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
        public bool validatePassword2(string password2)
        {
            return Regex.IsMatch(password2, REGEX_PASSWORD2);
        }
        public bool validatePassword3(string password3)
        {
            return Regex.IsMatch(password3, REGEX_PASSWORD3);
        }
    }
}
