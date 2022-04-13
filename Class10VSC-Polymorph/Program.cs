using System;
using System.Collections.Generic;

namespace Class10VSC_Polymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the zoo!");

            List<Animals> animal = new List<Animals>(new Animals []
            {
                new Monkey("Monkey ","34 species ", "black"),
                new Tiger("Tiger ", "16 species ", "orange"),
                new Zebra("Zebra ","1 specie ","black n white")    
            });
            foreach (Animals animal in animals)
            {
                if (animal.name == "Monkey")
                {
                    Console.WriteLine($"{animal.nome} is {animal.color} and has {animal.species}");
                    animal.message("Uhuhuhu-hahaha");
                }
                else if (animal.name == "Tiger")
                {
                    Console.WriteLine($"{animal.name} is {animal.color} and has {animal.species}");
                    animal.Comunicar("Raawr");
                }
                else if (animal.name == "Zebra")
                {
                    Console.WriteLine($"{animal.name} is {animal.color} and has {animal.species}");
                    animal.Comunicar("Zebra Sound Here");
                }
            }
        }
    }
}
