using NetPatern.App.Strategy;

namespace NetPatern.App.Desconto
{
    public class DescontoQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500)
                return orcamento.Valor * 0.4;

            return Proximo.Descontar(orcamento);
        }
    }
}
