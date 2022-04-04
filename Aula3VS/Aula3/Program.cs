using System;

namespace Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome");
            string name = Console.ReadLine();

            Console.WriteLine("Entre com a sua idade");
            int age = Convert.ToInt32((string)Console.ReadLine());

            Console.WriteLine("Oi " + name + "\nQue legal que voce tem " + age + " anos de idade");

            Console.WriteLine("Qual seu filme favorito?");
            Console.ReadLine();
        }
    }
}
