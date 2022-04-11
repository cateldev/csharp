using System;

namespace Class8VS.src
{
    public class Gato
    {
        public string nome { get; set; }
        public string cor { get; set; }
        public int tamanho { get; set; }
    }
    public Gato()
    {

    }
    public Gato(string _nome, string _cor, int _tamanho)
    {
        Nome = _nome;
        Cor = _cor;
        Tamanho = _tamanho;
    }
    public void dormir ()
    {
        Console.WriteLine("ZzZZZzZzZ...")
    }
    public void comer(string comida)
    {
        Console.WriteLine($"Estou comendo{comida}");
    }
    public string rosnar(string rosno)
    {
        Console.WriteLine($"RRRRrrr{rosno}")
    }
}