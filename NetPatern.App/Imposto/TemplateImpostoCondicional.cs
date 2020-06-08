using NetPatern.App.Strategy;
using ImpostoClass = NetPatern.App.Strategy.Imposto;

namespace NetPatern.App.Imposto
{
    public abstract class TemplateImpostoCondicional : ImpostoClass.Imposto
    {
        protected TemplateImpostoCondicional() => _impostoInner = null;
        protected TemplateImpostoCondicional(ImpostoClass.Imposto impostoInner) => _impostoInner = impostoInner;

        public override double Calcular(Orcamento orcamento)
        {
            if (ValidarImposto(orcamento))
                return RetornarValorCondicional(orcamento) + CalcularImpostoInner(orcamento);

            return RetornarValorDefault(orcamento) + CalcularImpostoInner(orcamento);
        }

        protected abstract bool ValidarImposto(Orcamento orcamento);
        protected abstract double RetornarValorCondicional(Orcamento orcamento);
        protected abstract double RetornarValorDefault(Orcamento orcamento);
    }
}
