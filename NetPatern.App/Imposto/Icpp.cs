using NetPatern.App.Strategy;

namespace NetPatern.App.Imposto
{
    public class Icpp : TemplateImpostoCondicional
    {
        protected override double RetornarValorCondicional(Orcamento orcamento) => orcamento.Valor * 0.7;

        protected override double RetornarValorDefault(Orcamento orcamento) => orcamento.Valor * 0.5;

        protected override bool ValidarImposto(Orcamento orcamento) => orcamento.Valor >= 500;
    }
}
