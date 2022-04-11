using System;

namespace Class8VSC
{
    class Program
    {
        static void Main(string[] args)
        {
            pokemon pikachu = new pokemon ("Pikachu", "Yellow", "460");

        Console.WriteLine($"The pokemon is{pikachu.name} his color is {pikachu.color} and its powerlevel is {pikachu.power}");

        }
    }
}
