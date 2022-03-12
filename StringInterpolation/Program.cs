using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string userLastName = Console.ReadLine();
            Console.WriteLine($"Privet, {userFirstName} {userLastName}!"); //string interpolation
            //wdConsole.WriteLine("Привет," + userFirstName + " " + userLastName + "!"); //string concantention 
        }
    }
}
