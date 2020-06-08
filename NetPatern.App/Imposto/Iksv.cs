using NetPatern.App.Strategy;
using System.Linq;

namespace NetPatern.App.Imposto
{
    public class Iksv : TemplateImpostoCondicional
    {
        protected override double RetornarValorCondicional(Orcamento orcamento) => orcamento.Valor * 0.10;

        protected override double RetornarValorDefault(Orcamento orcamento) => orcamento.Valor * 0.6;

        protected override bool ValidarImposto(Orcamento orcamento) =>
            orcamento.Valor >= 500 && orcamento.Itens.Where(i => i.Valor >= 100).FirstOrDefault() != null;
    }
}
