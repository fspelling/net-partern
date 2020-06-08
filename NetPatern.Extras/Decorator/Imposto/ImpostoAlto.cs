namespace NetPatern.Extras.Decorator
{
    public class ImpostoAlto : Imposto
    {
        public ImpostoAlto() : base() { }
        public ImpostoAlto(Imposto imposto) : base(imposto) { }

        public override double Calcular(Orcamento orcamento) => orcamento.Valor * 0.20 + CalcularImpostoInner(orcamento);
    }
}
