using System;

namespace ageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: declare variables to store firstName, date of birth, and age.
            string firstName;
            DateTime birthDate;
            TimeSpan age;

            // TODO: Assign values to the variables from the users input
            Console.WriteLine("Enter your First Name");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your date of birth using this format m/dd/yyyy");
            birthDate = DateTime.Parse(Console.ReadLine()); //TODO: Use the Parse method to convert string to date formart

            // TODO: minus date of birth from current date to find the actually age of the user
            age = DateTime.Today - birthDate; 

            /*TODO:
            We welcomed the user by passing their name and telling them when they were born,
            To get the actually age of the user, we couldn't use TimeSpans because years don't
            have a constant number of days. Meaning that we're only able to get the total number
            of days in the interval, so we divided days by 365.255 and then round them down.
             */
            Console.WriteLine($"Hi {firstName} you were born on {birthDate}");
            Console.WriteLine("And you are {0} years old.", Math.Floor(age.Days/365.255));
            Console.WriteLine("Thank you.");
        }
    }
}
