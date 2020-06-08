namespace NetPatern.App.Strategy.Investimento
{
    public class Conservador : IInvestimento
    {
        public double Investir(InvestimentoBancario investimento) => investimento.Valor * 0.8;
    }
}
