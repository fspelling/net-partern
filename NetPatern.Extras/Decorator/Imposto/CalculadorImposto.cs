using System;

namespace NetPatern.Extras.Decorator
{
    public class CalculadorImposto
    {
        public void CalcularImposto(Orcamento orcamento, Imposto imposto)
        {
            var valorCalc = imposto.Calcular(orcamento);
            Console.WriteLine(valorCalc);
        }
    }
}
