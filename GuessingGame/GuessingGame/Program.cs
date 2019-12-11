using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 100);
            int userNumber;
            int quit = 0;
            int guesses = 0;

            while (quit != 999)
            {
                Console.WriteLine("Pick a number that is between 1 - 100");
                userNumber = Convert.ToInt32(Console.ReadLine());              

                if (userNumber > rndNumber)
                {
                    Console.WriteLine("You're to high, choose again");
                    ++guesses;
                }
                else if (userNumber < rndNumber)
                {
                    Console.WriteLine("You're to low, choose again");
                    ++guesses;
                }
                else if (userNumber == rndNumber)
                {
                    Console.WriteLine("Congrats, you got the right number");
                    Console.WriteLine("It took you {0} tries to get the correct number", guesses);
                }
                
            }
        }
    }
}
