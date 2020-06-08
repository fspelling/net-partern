namespace NetPatern.App.Strategy.Imposto
{
    public class Iss : Imposto
    {
        public Iss() : base() { }
        public Iss(Imposto imposto) : base(imposto) { }

        public override double Calcular(Orcamento orcamento) => orcamento.Valor * 0.06 + CalcularImpostoInner(orcamento);
    }
}
