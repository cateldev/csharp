using System;

namespace Aula6VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Tabuada. \nInsira qual número você quer calcular: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= 10; x++)
            {
                int result = number * x;
                Console.WriteLine($"{number} x {x} = {result}");
            }

        }
    }
}

