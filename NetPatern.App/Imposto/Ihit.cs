using NetPatern.App.Strategy;

namespace NetPatern.App.Imposto
{
    public class Ihit : TemplateImpostoCondicional
    {
        protected override double RetornarValorCondicional(Orcamento orcamento) => orcamento.Valor * 0.13 + 100;

        protected override double RetornarValorDefault(Orcamento orcamento) => orcamento.Valor * orcamento.Itens.Count;

        protected override bool ValidarImposto(Orcamento orcamento)
        {
            var valid = false;

            foreach (var item in orcamento.Itens)
            {
                var itensQtd = orcamento.Itens.FindAll(p => p.Nome == item.Nome).Count;

                if (itensQtd > 1)
                {
                    valid = true;
                    break;
                }
            }

            return valid;
        }

    }
}
