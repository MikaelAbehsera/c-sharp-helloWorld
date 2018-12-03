using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";
            //Print full name
            Console.WriteLine("Name: " + firstName + " " + lastName);
            //Ask for new name
            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();
            //Print the new name
            Console.WriteLine("New name: " + firstName + " " + lastName);

            Console.ReadLine();
        }
    }
}