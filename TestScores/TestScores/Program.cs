using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            double average = 0;

            int[] score = new int[5];
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine("Please enter 5 students test scores");
                score[i] = Convert.ToInt32(Console.ReadLine());
                average = average + score[i] / 5;
            }
            Console.WriteLine("You're average is {0}", average);


        }
    }
}
