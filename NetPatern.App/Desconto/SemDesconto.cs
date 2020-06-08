using NetPatern.App.Strategy;

namespace NetPatern.App.Desconto
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento) => 0;
    }
}
