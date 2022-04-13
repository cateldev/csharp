namespace Matheus_Catel.Desktop.Coding.GENERATION.EXERCICES.CODES.Class10VSC.src
{
    namespace zoologico.src
    {
        public class cachorro : animal
        {
            public string Nome {get; set;}
            public string Cor {get; set;}
            public string Classificacao {get; set;}

            public gato(){}

            public gato (string nome, string cor, string classificacao)
            {
                Nome = nome;
                Cor = cor;
                Classificacao = classificacao;
            }
            public override void comunicar (string comunicacao)
            {
                Console.WriteLine ($"{Nome} está faltando: {comunicacao}");
            }
        }
    }
}