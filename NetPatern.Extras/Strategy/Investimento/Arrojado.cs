using System;

namespace NetPatern.App.Strategy.Investimento
{
    public class Arrojado : IInvestimento
    {
        public double Investir(InvestimentoBancario investimento)
        {
            double investimentoCalc;
            var random = new Random();

            if (random.Next(101) <= 20)
                investimentoCalc = investimento.Valor * 0.05;
            else if (random.Next(101) <= 50)
                investimentoCalc = investimento.Valor * 0.03;
            else
                investimentoCalc = investimento.Valor * 0.06;

            return investimentoCalc;
        }
    }
}
