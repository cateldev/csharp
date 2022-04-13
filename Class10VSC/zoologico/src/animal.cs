    namespace zoologico.src
    {
        public class animal
        {
            public string Nome {get; set;}
            public string Cor {get; set;}
            public string Classificacao {get; set;}

            public animal(){}

            public animal (string nome, string cor, string classificacao)
            {
                Nome = nome;
                Cor = cor;
                Classificacao = classificacao;
            }
            public virtual void comunicar (string comunicacao)
            {
                Console.WriteLine ($"{Nome} está faltando: {comunicacao}");
            }
            
        }
    }
}