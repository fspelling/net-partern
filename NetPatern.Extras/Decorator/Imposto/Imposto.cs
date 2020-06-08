namespace NetPatern.Extras.Decorator
{
    public abstract class Imposto
    {
        protected Imposto _impostoInner;

        protected Imposto() => _impostoInner = null;
        protected Imposto(Imposto impostoInner) => _impostoInner = impostoInner;

        public abstract double Calcular(Orcamento orcamento);

        protected double CalcularImpostoInner(Orcamento orcamento)
        {
            if (_impostoInner == null) return 0;
            return _impostoInner.Calcular(orcamento);
        }
    }
}
