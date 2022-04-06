using System;

namespace Exercice_1_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score, stars;
            score = 0; stars = 0;

            Console.WriteLine("How was your score?");
            score = Convert.ToInt32(Console.ReadLine());

            if ((score >= 0) && (score <= 25))
            {
                stars = 0;
               
            }
            else if ((score >= 26) && (score <= 50))
            {
                stars = 1;
                
            }
            else if ((score >= 51) && (score <= 75))
            {
                stars = 2;
               
            }
            else
            {
                stars = 3;
            }
            Console.WriteLine($"You got {stars} stars");

        }
    }
}
