using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
          
            int userInput;
            int low = 1;
            int high = 100;
            int rndNumber = rnd.Next(low, high);
            int quit = 0;
            int guesses = 0;

            while (quit != 999)
            {
                Console.WriteLine("Enter a number that is between 1 - 100");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (rndNumber > userInput)
                {
                    Console.WriteLine("The number is to low");
                    low = rndNumber;
                    ++guesses;
                }
                else if (rndNumber < userInput)
                {
                    Console.WriteLine("That number is to high");
                    high = rndNumber;
                    ++guesses;
                }
                else if (rndNumber == userInput)
                {
                    Console.WriteLine("The computer guessed the right number");
                    Console.WriteLine("It took the computer {0} times to guess the right number", guesses);
                }
            }
        }
    }
}
