namespace NetPatern.App.Strategy.Imposto
{
    public class Iccc : Imposto
    {
        public Iccc(): base() { }
        public Iccc(Imposto imposto) : base(imposto) { }

        public override double Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
                return 0.05 * orcamento.Valor + CalcularImpostoInner(orcamento);
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                return 0.07 * orcamento.Valor + CalcularImpostoInner(orcamento);
            else
                return 0.08 * orcamento.Valor + 30.0 + CalcularImpostoInner(orcamento);
        }
    }
}
