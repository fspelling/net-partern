using NetPatern.App.Strategy;
using System.Linq;

namespace NetPatern.App.Desconto
{
    public class DescontoVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            var lapis = orcamento.Itens.FirstOrDefault(i => i.Nome.ToUpper() == "LAPIS");
            var caneta = orcamento.Itens.FirstOrDefault(i => i.Nome.ToUpper() == "CANETA");

            if (orcamento.Itens.Contains(lapis) && orcamento.Itens.Contains(caneta))
                return orcamento.Valor * 0.05;

            return Proximo.Descontar(orcamento);
        }
    }
}