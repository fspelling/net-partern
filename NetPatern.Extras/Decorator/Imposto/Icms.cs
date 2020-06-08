namespace NetPatern.Extras.Decorator
{
    public class Icms : Imposto
    {
        public Icms() : base() { }
        public Icms(Imposto imposto) : base(imposto) { }

        public override double Calcular(Orcamento orcamento) => orcamento.Valor* 0.01 + CalcularImpostoInner(orcamento);
    }
}
