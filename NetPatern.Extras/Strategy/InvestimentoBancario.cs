namespace NetPatern.App.Strategy
{
    public class InvestimentoBancario
    {
        public double Valor { get; private set; }

        public InvestimentoBancario(double valor) => Valor = valor;
    }
}
