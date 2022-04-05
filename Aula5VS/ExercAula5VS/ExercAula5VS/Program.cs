using System;

namespace ExercAula5VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você concluiu o curso? (sim ou não):");
            string condicaoCursoConcluido = Console.ReadLine();

            Console.WriteLine("Quantos cursos você concluiu?");
            int condicaoQuantidadeCurso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você pagou todo o curso? (sim ou não)");
            string condicaoQuitacao = Console.ReadLine();

            Console.WriteLine("Você devolveu os livros da biblioteca? (sim ou não");
            string condicaoBiblioteca = Console.ReadLine();

            if (condicaoCursoConcluido == "sim" &&
                condicaoQuantidadeCurso >= 25 &&
                condicaoQuitacao == "sim" &&
                condicaoBiblioteca == "sim")
            {
                Console.WriteLine("Pode colar grau");
            }
            else
            {
                Console.WriteLine("Não pode colar grau");
            }
        }
    }
}
