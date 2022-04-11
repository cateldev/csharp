using System;

namespace Class8VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Gato garfield = new Gato("Garfield", "Laranja", 8);
            Gato tomas = new Gato("Tomas","Cinza", 5);
            Gato frajola = new Gato();

            Console.WriteLine($"Gato 1 é o {garfield.Nome} de cor {garfield.Cor} e tem o tamanho de {garfield.Tamanho} metros");
            Console.WriteLine($"Gato 2 é o {tomas.Nome} de cor {tomas.Cor} e tem o tamanho de {tomas.Tamanho} metros");
            Console.WriteLine($"Gato 3 é o {frajola.Nome} de cor {frajola.Cor} e tem o tamanho de {frajola.Tamanho} metros");
        }
    }
}
