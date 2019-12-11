using System;

namespace EnterLowercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter;

            Console.WriteLine("Enter a lower case letter");
            letter = Console.ReadLine();

            if (letter = string.ToLower)
            {
                Console.WriteLine("OK");
            }

            else if (letter = string.ToUppper)
            {
                Console.WriteLine("No, you need to enter a lowercase letter not a uppercase");
            }
        }
    }
}