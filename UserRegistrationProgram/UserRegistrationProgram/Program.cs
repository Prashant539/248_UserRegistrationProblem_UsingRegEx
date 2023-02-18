﻿using System;
namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistration validation = new UserRegistration();
            Console.WriteLine("User Registration Using RegEx!\n");
            Console.WriteLine("Enter First Name : ");
            string fName = Console.ReadLine();
            bool validFirstName = validation.validateFirstName(fName);
            Console.WriteLine("First Name Valid : " + validFirstName);
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("Enter Last Name : ");
            string lName = Console.ReadLine();
            bool validLastName = validation.validateLastName(lName);
            Console.WriteLine("Last Name Valid : " + validLastName);
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();
            bool validEmail = validation.validateEmail(email);
            Console.WriteLine("Email Valid : " + validEmail);
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("Enter Mobile Number : ");
            string number = Console.ReadLine();
            bool validNumber = validation.validateNumber(number);
            Console.WriteLine("Mobile Number Valid : " + validNumber);
            Console.WriteLine("______________________________________________________________________");
        }
    }
}
