using System;

namespace Aula3VSC
{
    class Program
    {
        //Calcular o IMC de uma persona.
        
        static void Main(string[] args)
        {
            float height;
            float weight;
            double imc;

            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Olá, " + name + "! Digite sua altura: ");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            weight = float.Parse(Console.ReadLine());

            imc = weight / (height * height);

            if (imc <= 18.5){
                Console.WriteLine ("Seu IMC atualmente é " + imc +". Você está abaixo do peso.");
            }
            else if (imc < 25){
                Console.WriteLine ("Seu IMC atualmente é " + imc +". Você está com peso normal.");
            }
             else if (imc < 30){
                Console.WriteLine ("Seu IMC atualmente é " + imc +". Você está sobrepeso.");
            }
            else if(imc <= 30){
                Console.WriteLine ("Seu IMC atualmente é " + imc +". Você está obeso.");
            }
        }
    }
}
