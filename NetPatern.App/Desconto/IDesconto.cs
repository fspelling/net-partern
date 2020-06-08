using NetPatern.App.Strategy;

namespace NetPatern.App.Desconto
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }
        double Descontar(Orcamento orcamento);
    }
}
