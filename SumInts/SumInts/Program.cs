using System;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int quit = 999;
            int userNumber;

            while (quit == 999)
            {
                Console.WriteLine("Enter a number or use the number 999 to quit");
                userNumber = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
