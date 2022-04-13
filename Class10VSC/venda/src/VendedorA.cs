namespace venda.src
{
    public class VendedorA : Bonus
    {
        public string Nome { get; set; }
        public double Venda { get; set; }
        public double Bonus { get; set; }
        public double TotalReceber { get; set; }
        public string Cargo { get; set; }

        public VendedorA(string nome, double venda, string cargo)
        {
            Nome = nome;
            Venda = venda;
            Bonus = CalculaBonus(venda);
            TotalReceber = TotalReceber;
            Cargo = cargo;
        }

        public override double CalculaBonus (double venda)
        {
            return venda * 0.05;
        }
    }

}