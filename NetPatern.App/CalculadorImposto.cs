using ImpostoClass = NetPatern.App.Strategy.Imposto;
using System;

namespace NetPatern.App.Strategy
{
    public class CalculadorImposto
    {
        public void CalcularImposto(Orcamento orcamento, ImpostoClass.Imposto imposto)
        {
            var valorCalc = imposto.Calcular(orcamento);
            Console.WriteLine(valorCalc);
        }
    }
}
