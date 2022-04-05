using System;

namespace Aula3VSC
{
    class Program
    {
        static void Main(string[] args)
        {
            float height;
            float weight;
            float imc;

            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Olá, " + name + "! Digite sua altura: ");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            weight = float.Parse(Console.ReadLine());

            imc = weight / (height * height);

            Console.WriteLine ("Seu IMC atualmente é " + imc);
        }
    }
}
