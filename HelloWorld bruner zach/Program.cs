using System;

namespace HelloWorld_bruner_zach
{
    class Program


    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first Name?"); // Ask the user for first name
            string firstname = Console.ReadLine();         // Assigns user input to firstname
            Console.WriteLine("What is your last name?");  // Assigns the user last name
            string lastname = Console.ReadLine();          // Assigns the user input to lastname variable

            // 
            Console.WriteLine("Hello, " + firstname + " " +lastname + "!"); // Prints the user input 
        }
    }
}