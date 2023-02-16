using System;
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
        }
    }
}
