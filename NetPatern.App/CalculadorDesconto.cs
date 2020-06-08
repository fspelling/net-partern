using NetPatern.App.Desconto;
using NetPatern.App.Strategy;

namespace NetPatern.App
{
    public class CalculadorDesconto
    {
        public double Calcular(Orcamento orcamento)
        {
            var descontoCincoItens = new DescontoCincoItens();
            var descontoQuinhentosReais = new DescontoQuinhentosReais();
            var descontoVendaCasada = new DescontoVendaCasada();
            var semDesconto = new SemDesconto();

            descontoCincoItens.Proximo = descontoQuinhentosReais;
            descontoQuinhentosReais.Proximo = descontoVendaCasada;
            descontoVendaCasada.Proximo = semDesconto;

            var descontoResult = descontoCincoItens.Descontar(orcamento);

            return descontoResult;
        }
    }
}
